using InternetShopAPI.Models;

namespace InternetShopAPI.Controllers.Requests;

public sealed record ProductCreateRequest(
    int Id,
    string Name,
    Category Category,
    string? Atribute
    );
