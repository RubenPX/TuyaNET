namespace KryptoPX.TuyaNet.Core.Interfaces;

public interface ITuyaPaginationResponse<T> {
    string Message { get; set; }
    string current_row_key { get; set; }
    string device_id { get; set; }
    bool has_next { get; set; }
    List<T> data { get; set; }
}