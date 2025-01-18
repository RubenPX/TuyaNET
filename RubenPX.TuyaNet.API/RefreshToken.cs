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
    /// <a href="https://developer.tuya.com/en/docs/cloud/80bb968f1d?id=Ka7kjv3j8jgvr">
    ///     <c>GET: /v1.0/token/{refresh_token}</c> <br />
    /// </a>
    /// Each OAuth token is valid for two hours. After expiration, you need to use refresh_token to replace the previous token
    /// </summary>
    public async Task<ITuyaResponse<ITuyaTokenResult>> RefreshToken(IRefreshTokenRequest reqData, bool runWithoutToken = true) =>
        await SendRequestAsync<ITuyaTokenResult>(HttpMethod.Get, $"/v1.0/token?{reqData.refresh_token}", runWithoutToken);
}