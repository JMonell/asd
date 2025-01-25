using System.Text.Json.Serialization;

namespace BlazorApi2.Models;

public class NumberModel{
    [JsonPropertyName("valid")]
    public bool Valid { get; set; }

    [JsonPropertyName("local_format")]
    public string? Local_Format { get; set; }

    [JsonPropertyName("country_prefix")]
    public string? Country_Prefix { get; set; }

    [JsonPropertyName("carrier")]
    public string? Carrier { get; set; }

    [JsonPropertyName("line_type")]
    public string? Line_Type { get; set; }

    [JsonPropertyName("country_name")]
    public string? Country_Name { get; set; }
}

public class FavoriteNumberModel{

    public NumberModel _NumberModel { get; set; }
    public bool _IsFavorite { get; set; }
}