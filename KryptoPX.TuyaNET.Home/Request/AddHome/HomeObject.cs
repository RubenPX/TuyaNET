namespace KryptoPX.Tuya.Home.Entity.AddHome;

public class HomeObject(string name, double lon, double lat, string? geoName = null) {
    /// <summary>The name of a home.</summary>
    public string name { get; set; } = name;

    /// <summary>The geographical location of a home.</summary>
    string? geo_name { get; set; } = geoName;

    /// <summary>The longitude of a home.</summary>
    public double? lon  { get; set; } = lon;

    /// <summary>The latitude of a home.</summary>
    public double? lat { get; set; } = lat;
}