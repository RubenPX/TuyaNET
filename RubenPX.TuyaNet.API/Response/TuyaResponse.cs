using RubenPX.TuyaNet.API.ResponteInterfaces;

namespace RubenPX.TuyaNet.API.ResponseObjects;

public class TuyaResponse(bool success, string t, string tid, string? msg) : ITuyaResponse {
    public bool success { get; } = success;
    public string t { get; } = t;
    public string tid { get; } = tid;
    public string? msg { get; } = msg;
}

public class TuyaResponse<T>(bool success, string t, string tid, string? msg, T? result) : ITuyaResponse<T> {
    public bool success { get; } = success;
    public string t { get; } = t;
    public string tid { get; } = tid;
    public string? msg { get; } = msg;
    public T? result { get; } = result;
}