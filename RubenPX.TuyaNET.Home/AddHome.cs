using RubenPX.TuyaNet.API.Response;
using RubenPX.TuyaNET.Home.Request.AddHome;

namespace RubenPX.TuyaNET.Home;

public interface IAddHome {
    string uuid { get; set; }
    HomeObject Home { get; set; }
    List<string>? rooms { get; set; }
}

public class AddHome(string uuid, HomeObject home, List<string>? rooms = null) : IAddHome {
    public string uuid { get; set; } = uuid;
    public HomeObject Home { get; set; } = home;
    public List<string>? rooms { get; set; } = rooms;
}

public partial class HomeManagement {
    /// <summary>
    /// <a href="https://developer.tuya.com/en/docs/cloud/b3014bea96?id=Kawfjdqri4xgi">
    ///     <c>POST: /v1.0/home/create-home</c>
    /// </a>
    /// Add a home and rooms for a specified user.
    /// </summary>
    public async Task<ITuyaResponse<long>> AddHome(AddHome reqData) =>
        await api.SendRequestAsync<long>(HttpMethod.Post, "/v1.0/home/create-home", reqData);
    
}