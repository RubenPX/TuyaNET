namespace RubenPX.TuyaNet.API.Response;

/// 
/// TUYA RESPONSE WITHOUT BODY
/// 

public interface ITuyaResponse {
    bool success { get; }
    string t { get; }
    string tid { get; }
    string? msg { get; }
}

public class TuyaResponse(bool success, string t, string tid, string? msg) : ITuyaResponse {
    public bool success { get; } = success;
    public string t { get; } = t;
    public string tid { get; } = tid;
    public string? msg { get; } = msg;
}

/// 
/// TUYA RESPONSE WITH BODY
/// 

public interface ITuyaResponse<T> {
    bool success { get; }
    string t { get; }
    string tid { get; }
    string? msg { get; }
    T? result { get; }
}

public class TuyaResponse<T>(bool success, string t, string tid, string? msg, T? result) : ITuyaResponse<T> {
    public bool success { get; } = success;
    public string t { get; } = t;
    public string tid { get; } = tid;
    public string? msg { get; } = msg;
    public T? result { get; } = result;
}