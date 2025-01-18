using RubenPX.TuyaNet.API.Response;
using RubenPX.TuyaNET.Home.Request.AddHome;

namespace RubenPX.TuyaNET.Home;

public interface ISearchforHome {
    /// <summary>The home ID.</summary>
    string home_id { get; }
}

public class SearchforHome(string home_id) : ISearchforHome {
    public string home_id { get; } = home_id;
}

public interface ISearchforHomeResult : IHomeObject {
    /// <summary>The home ID.</summary>
    string home_id { get; }
}

public class SearchforHomeResult(string name, string home_id, double? lon = null, double? lat = null, string? geoName = null) : HomeObject(name, lon, lat, geoName), ISearchforHomeResult {
    public string home_id { get; } = home_id;
}

public partial class HomeManagement {
    /// <summary>
    /// <a href="https://developer.tuya.com/en/docs/cloud/0dbe66fef6?id=Kawfjdzu0dava">
    ///     <c>GET: /v1.0/homes/{home_id}</c>
    /// </a>
    /// Based on the home ID, query the basic information about the specified home.
    /// </summary>
    public async Task<ITuyaResponse<ISearchforHomeResult>> SearchforHome(ISearchforHome reqData) =>
        await api.SendRequestAsync<ISearchforHomeResult>(HttpMethod.Get, $"/v1.0/homes/{reqData.home_id}");
    
}