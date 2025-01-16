namespace KryptoPX.TuyaNet.API.Interfaces;

public interface ITuyaTokenResult {
    string access_token { get; }
    int expire_time { get; }
    string refresh_token { get; }
    string uid { get; }
}