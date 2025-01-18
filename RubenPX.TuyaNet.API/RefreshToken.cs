using RubenPX.TuyaNet.API.Response;

namespace RubenPX.TuyaNet.API;

public interface IRefreshTokenRequest {
    /// <summary>Refresh Token</summary>
    string refresh_token { get; }
}

public class RefreshTokenRequest(string refresh_token) : IRefreshTokenRequest {
    public string refresh_token { get; } = refresh_token;
}

public partial class TuyaApi {
    /// <summary>
    /// Each OAuth token is valid for two hours. After expiration, you need to use refresh_token to replace the previous token <br />
    /// <c>GET: /v1.0/token/{refresh_token}</c> <br />
    /// https://developer.tuya.com/en/docs/cloud/80bb968f1d?id=Ka7kjv3j8jgvr
    /// </summary>
    public async Task<ITuyaResponse<ITuyaTokenResult>> RefreshToken(IRefreshTokenRequest reqParams, bool runWithoutToken = true) {
        return await SendRequestAsync<ITuyaTokenResult>(HttpMethod.Get, $"/v1.0/token?{reqParams.refresh_token}", runWithoutToken);
    }
}