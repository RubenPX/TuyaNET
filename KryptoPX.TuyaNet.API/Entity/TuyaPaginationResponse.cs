﻿using KryptoPX.TuyaNet.API.Interfaces;

namespace KryptoPX.TuyaNet.Core.Entity;

public class TuyaPaginationResponse<T>(string message, string currentRowKey, string deviceId, bool hasNext, List<T> data) : ITuyaPaginationResponse<T> {
    public string Message { get; } = message;
    public string current_row_key { get; } = currentRowKey;
    public string device_id { get; } = deviceId;
    public bool has_next { get; } = hasNext;
    public List<T> data { get; } = data;
}