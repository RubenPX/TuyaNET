namespace KryptoPX.Tuya.Home.Entity.AddHome;

public class AddHome(string uuid, HomeObject home, List<string>? rooms = null) {
    public string uuid { get; set; } = uuid;
    public HomeObject Home { get; set; } = home;
    public List<string>? rooms { get; set; } = rooms;
}