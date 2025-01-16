using KryptoPX.TuyaNet.API.Interfaces;

namespace KryptoPX.TuyaNet.Core.Entity;

public class TuyaResponse<T>() : ITuyaResponse<T> {
    public bool success { get; set; }
    public string t { get; set; }
    public string tid { get; set; }
    public string? msg { get; set; }
    public T? result { get; set; }
}