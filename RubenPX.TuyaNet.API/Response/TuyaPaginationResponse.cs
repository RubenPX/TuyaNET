namespace RubenPX.TuyaNet.API.Response;

public interface ITuyaPaginationResponse<T> {
    public string Message { get; }
    public string current_row_key { get; }
    public string device_id { get; }
    public bool has_next { get; }
    public List<T> data { get; }
}

public class TuyaPaginationResponse<T>(string message, string currentRowKey, string deviceId, bool hasNext, List<T> data) : ITuyaPaginationResponse<T> {
    public string Message { get; } = message;
    public string current_row_key { get; } = currentRowKey;
    public string device_id { get; } = deviceId;
    public bool has_next { get; } = hasNext;
    public List<T> data { get; } = data;
}