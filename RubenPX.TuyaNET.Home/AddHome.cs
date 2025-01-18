using RubenPX.TuyaNet.API.Response;
using RubenPX.TuyaNET.Home.Request.AddHome;

namespace RubenPX.TuyaNET.Home;

public partial class HomeManagement {
    public async Task<ITuyaResponse?> AddHome(AddHome request) {
        return await api.SendRequestAsync(HttpMethod.Post, "/v1.0/home/create-home", request);
    }
}