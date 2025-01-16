namespace KryptoPX.TuyaNet.Core.Interfaces;

public interface ITuyaTokenResult {
    string access_token { get; init; }
    int expire_time { get; init; }
    string refresh_token { get; init; }
    string uid { get; init; }
}