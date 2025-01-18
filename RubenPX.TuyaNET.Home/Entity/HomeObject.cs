namespace RubenPX.TuyaNET.Home.Request.AddHome;

public interface IHomeObject {
    /// <summary>The name of a home.</summary>
    string name { get; }

    /// <summary>The geographical location of a home.</summary>
    string? geo_name { get; }

    /// <summary>The longitude of a home.</summary>
    double? lon { get; }

    /// <summary>The latitude of a home.</summary>
    double? lat { get; }
}

public class HomeObject(string name, double? lon = null, double? lat = null, string? geoName = null) : IHomeObject {
    public string name { get; set; } = name;
    public string? geo_name { get; set; } = geoName;
    public double? lon  { get; set; } = lon;
    public double? lat { get; set; } = lat;
}