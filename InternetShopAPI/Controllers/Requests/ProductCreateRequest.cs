using InternetShopAPI.Models;

namespace InternetShopAPI.Controllers.Requests;

public sealed record ProductCreateRequest(
    string Name,
    Category Category,
    int Quantity,
    string? Atribute);