using System.Security.Cryptography;
using System.Text;
using System.Text.Json;
using RubenPX.TuyaNet.API.Response;

namespace RubenPX.TuyaNet.API;

public partial class TuyaApi(string clientId, string secret, string baseURL = "https://openapi.tuyaeu.com") {
    private ITuyaTokenResult? tokenData = null;

    public async Task<string> getAccessToken() {
        tokenData ??= await GetInternalTuyaToken("token null");
        var expirationTime = DateTime.UtcNow.AddSeconds(tokenData!.expire_time);
        if (DateTime.UtcNow >= expirationTime) tokenData = await GetInternalTuyaToken("token expired");
        return tokenData!.access_token;
    }

    public async Task<ITuyaResponse> SendRequestAsync(HttpMethod httpMethod, string url, object? body = null, bool runWithoutToken = false) {
        return await SendRequestAsync<object>(httpMethod, url, body, runWithoutToken) as ITuyaResponse;
    }

    public async Task<ITuyaResponse<T>> SendRequestAsync<T>(HttpMethod httpMethod, string url, object? body = null, bool runWithoutToken = false) {
        string fullUrl = $"{baseURL}{url}";
        string timestamp = GetTime().ToString();
        
        string token = runWithoutToken ? "" : await getAccessToken();
        
        // @RubenPX: PTM casi una tarde entera para descifrar esto y hacer que funcione...
        // Aplicamos la especificación requerida por tuya : https://developer.tuya.com/en/docs/iot/api-request?id=Ka4a8uuo1j4t4
        string jsonRequest = body != null ? JsonSerializer.Serialize(body) : "";
        string stringToSign = StringToSign(httpMethod.ToString().ToUpperInvariant(), url, jsonRequest);
        string str = clientId + token + timestamp + stringToSign;
        string sign = CalcSign(str);
        
        // Prepare request
        HttpRequestMessage request = new HttpRequestMessage(httpMethod, fullUrl);
        if (body != null) request.Content = new StringContent(jsonRequest, Encoding.UTF8, "application/json");
        request.Headers.Add("client_id", clientId);
        request.Headers.Add("sign", sign);
        request.Headers.Add("t", timestamp);
        if (!string.IsNullOrWhiteSpace(token)) request.Headers.Add("access_token", token);
        request.Headers.Add("sign_method", "HMAC-SHA256");
        
        // Send request
        using HttpClient client = new HttpClient();
        HttpResponseMessage response = await client.SendAsync(request);
        string responseJson = await response.Content.ReadAsStringAsync();
        return JsonSerializer.Deserialize<TuyaResponse<T>>(responseJson)!;
    }
    
    private async Task<ITuyaTokenResult?> GetInternalTuyaToken(string reason) {
        var response = await GetaToken(new("1"));
        if (!string.IsNullOrWhiteSpace(response.msg)) {
#if DEBUG
            Console.WriteLine($"GetInternalTuyaToken: Failed | {reason} | {response.msg}");
#endif
            throw new HttpRequestException($"Failed to get Tuya Token: {response.msg}");
        }
#if DEBUG
        Console.WriteLine($"GetInternalTuyaToken: OK | {reason}");
#endif
        return response.result!;
    }
    
    private static long GetTime() {
        return DateTimeOffset.UtcNow.ToUnixTimeMilliseconds();
    }

    private string CalcSign(string str) {
        using var hmacsha256 = new HMACSHA256(Encoding.UTF8.GetBytes(secret));
        var hash = hmacsha256.ComputeHash(Encoding.UTF8.GetBytes(str));
        return BitConverter.ToString(hash).Replace("-", "").ToUpper();
    }

    private static string StringToSign(string method, string url, string body) {
        var sha256 = Sha256Hash(body);
        return $"{method}\n{sha256}\n\n{url}";
    }

    private static string Sha256Hash(string input) {
        using var sha256 = SHA256.Create();
        var hash = sha256.ComputeHash(Encoding.UTF8.GetBytes(input));
        return BitConverter.ToString(hash).Replace("-", "").ToLower();
    }
}