using InternetShopAPI.Models;

namespace InternetShopAPI.Controllers.Requests;

public sealed record ProductCreateRequest(
    string Name,
    Category Category,
    string? Atribute
    );
