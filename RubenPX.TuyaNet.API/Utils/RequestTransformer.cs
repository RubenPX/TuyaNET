using System.Web;

namespace RubenPX.TuyaNet.API.Utils;

public class RequestTransformer {
    public static string GenerateUrlParameters(Dictionary<string, string?>? parameters) {
        if (parameters == null) return "";
        var query = HttpUtility.ParseQueryString(string.Empty);
        foreach (var param in parameters) {
            if (string.IsNullOrEmpty(param.Value)) continue;
            query[param.Key] = param.Value;
        }
        return $"?{query.ToString()}";
    }
}