using KryptoPX.TuyaNet.Core.Interfaces;

namespace KryptoPX.TuyaNet.Core.Entity;

public class TuyaTokenResult : ITuyaTokenResult {
    public string access_token { get; init; }
    public int expire_time { get; init; }
    public string refresh_token { get; init; }
    public string uid { get; init; }
}