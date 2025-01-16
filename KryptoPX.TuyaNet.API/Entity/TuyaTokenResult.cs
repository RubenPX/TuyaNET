using KryptoPX.TuyaNet.API.Interfaces;

namespace KryptoPX.TuyaNet.Core.Entity;

public class TuyaTokenResult(string accessToken, int expireTime, string refreshToken, string uid) : ITuyaTokenResult {
    public string uid { get; } = uid;
    public string access_token { get; } = accessToken;
    public string refresh_token { get; } = refreshToken;
    public int expire_time { get; } = expireTime;
}