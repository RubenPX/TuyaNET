using RubenPX.TuyaNet.API.Response;
using RubenPX.TuyaNET.Home.Request.AddHome;

namespace RubenPX.TuyaNET.Home;

public interface IDeleteHome {
    string home_id { get; }
}

public class DeleteHome(string uuid) : IDeleteHome {
    public string home_id { get; set; } = uuid;
}

public partial class HomeManagement {
    /// <summary>
    /// <a href="https://developer.tuya.com/en/docs/cloud/b3014bea96?id=Kawfjdqri4xgi">
    ///     <c>POST: /v1.0/home/create-home</c>
    /// </a>
    /// Add a home and rooms for a specified user.
    /// </summary>
    public async Task<ITuyaResponse<bool>> DeleteHome(IDeleteHome reqData) =>
        await api.SendRequestAsync<bool>(HttpMethod.Post, "/v1.0/home/create-home", reqData);
    
}