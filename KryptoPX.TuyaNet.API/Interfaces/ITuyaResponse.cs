namespace KryptoPX.TuyaNet.API.Interfaces;

public interface ITuyaResponse<T> {
    bool success { get; init; }
    string t { get; init; }
    string tid { get; init; }
    string? msg { get; init; }
    T? result { get; init; }
}