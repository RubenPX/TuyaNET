using RubenPX.TuyaNet.API.Response;
using RubenPX.TuyaNet.API.Utils;

namespace RubenPX.TuyaNet.API;

public interface ITuyaTokenResult {
    /// <summary>The access token.</summary>
    string access_token { get; }
    
    /// <summary>The validity period in seconds.</summary>
    int expire_time { get; }
    
    /// <summary>The refresh token.</summary>
    string refresh_token { get; }
    
    /// <summary>Tuya user ID.</summary>
    string uid { get; }
}

public class TuyaTokenResult(string accessToken, int expireTime, string refreshToken, string uid) : ITuyaTokenResult {
    public string uid { get; } = uid;
    public string access_token { get; } = accessToken;
    public string refresh_token { get; } = refreshToken;
    public int expire_time { get; } = expireTime;
}

public interface IGetaTokenRequest {
    /// <summary>
    /// The authorization type. Valid values: <br />
    /// - 1: Simple mode. <br />
    /// - 2: OAuth 2.0 mode.
    /// </summary>
    public string grant_type { get; }
    
    /// <summary>
    /// The authorization code. This parameter is supported only when grant_type is 2.
    /// </summary>
    string? code { get; }

    /// <summary>
    /// The terminal ID.
    /// </summary>
    string? terminal_id { get; }

    /// <summary>
    /// The unique identifier of a user authenticated by Identity and Access Management
    /// (IAM). The IAM integration is supported only when grant_type is 1.
    /// </summary>
    string? target_uid { get; }
}

public class GetaTokenRequest(string grant_type) : IGetaTokenRequest {
    public string grant_type { get; set; } = grant_type;
    public string? code { get; set; }
    public string? terminal_id { get; set; }
    public string? target_uid { get; set; }
}

public partial class TuyaApi {
    /// <summary>
    /// <a href="https://developer.tuya.com/en/docs/cloud/6c1636a9bd?id=Ka7kjumkoa53v">
    ///     <c>GET: /v1.0/token</c>
    /// </a>
    /// Get tuya token
    /// </summary>
    public async Task<ITuyaResponse<ITuyaTokenResult>> GetaToken(IGetaTokenRequest reqData, bool runWithoutToken = true) =>
        await SendRequestAsync<ITuyaTokenResult>(HttpMethod.Get, $"/v1.0/token", new Dictionary<string, string?>() {
            { "grant_type", reqData.grant_type },
            { "code", reqData.code },
            { "terminal_id", reqData.terminal_id },
            { "target_uid", reqData.target_uid },
        }, null, runWithoutToken);
}