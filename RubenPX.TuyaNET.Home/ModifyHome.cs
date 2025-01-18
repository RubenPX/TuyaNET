using RubenPX.TuyaNet.API.Response;
using RubenPX.TuyaNET.Home.Request.AddHome;

namespace RubenPX.TuyaNET.Home;

public interface IModifyHome : IHomeObject {
    string home_id { get; }
}

public class ModifyHome(string name, string home_id, double? lon = null, double? lat = null, string? geoName = null) : HomeObject(name, lon, lat, geoName), IModifyHome {
    public string home_id { get; } = home_id;
}

public partial class HomeManagement {
    /// <summary>
    /// <a href="https://developer.tuya.com/en/docs/cloud/334c5cfcdb?id=Kawfje8vm4n40">
    ///     <c>PUT: /v1.0/homes/{home_id}</c>
    /// </a>
    /// Based on the home ID, query the basic information about the specified home.
    /// </summary>
    public async Task<ITuyaResponse<bool>> ModifyHome(IModifyHome reqData) =>
        await api.SendRequestAsync<bool>(HttpMethod.Get, $"/v1.0/homes/{reqData.home_id}", reqData);
}