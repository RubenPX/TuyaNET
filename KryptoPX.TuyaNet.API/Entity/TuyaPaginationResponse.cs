using KryptoPX.TuyaNet.API.Interfaces;

namespace KryptoPX.TuyaNet.Core.Entity;

public class TuyaPaginationResponse<T>() : ITuyaPaginationResponse<T> {
    public string Message { get; set; }
    public string current_row_key { get; set; }
    public string device_id { get; set; }
    public bool has_next { get; set; }
    public List<T> data { get; set; }
}