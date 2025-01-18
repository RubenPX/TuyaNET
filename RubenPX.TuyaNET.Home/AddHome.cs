using RubenPX.TuyaNet.API;

namespace RubenPX.TuyaNET.Home;

public partial class HomeManagement {
    private TuyaApi api;
    
    public async Task<ITuyaResponse> AddHome(AddHome request) {
        return await api.SendRequestAsync(HttpMethod.Post, "/v1.0/home/create-home", request);
    }
}