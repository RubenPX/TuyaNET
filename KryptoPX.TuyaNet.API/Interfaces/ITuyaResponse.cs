namespace KryptoPX.TuyaNet.API.Interfaces;

public interface ITuyaResponse<T> {
    bool success { get; }
    string t { get; }
    string tid { get; }
    string? msg { get; }
    T? result { get; }
}