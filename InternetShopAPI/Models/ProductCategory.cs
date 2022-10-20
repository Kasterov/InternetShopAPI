using System.Text.Json.Serialization;

namespace InternetShopAPI.Models;

[JsonConverter(typeof(JsonStringEnumConverter))]
public enum Category
{
    Home,
    Work,
    Garden,
    Car,
    Sport,
    Count = 5
}
