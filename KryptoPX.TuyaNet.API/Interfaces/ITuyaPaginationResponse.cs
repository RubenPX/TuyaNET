namespace KryptoPX.TuyaNet.API.Interfaces;

public interface ITuyaPaginationResponse<T> {
    string Message { get; }
    string current_row_key { get; }
    string device_id { get; }
    bool has_next { get; }
    List<T> data { get; }
}