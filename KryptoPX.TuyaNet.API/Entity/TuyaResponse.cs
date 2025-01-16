using KryptoPX.TuyaNet.API.Interfaces;

namespace KryptoPX.TuyaNet.Core.Entity;

public class TuyaResponse<T>() : ITuyaResponse<T> {
    public bool success { get; init; }
    public string t { get; init; }
    public string tid { get; init; }
    public string? msg { get; init; }
    public T? result { get; init; }
}