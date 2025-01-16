namespace KryptoPX.TuyaNet.API.Interfaces;

public interface ITuyaResponse<T> {
    bool success { get; set; }
    string t { get; set; }
    string tid { get; set; }
    string? msg { get; set; }
    T? result { get; set; }
}