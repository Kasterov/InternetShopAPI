namespace InternetShopAPI.Models.Requests;

public sealed record ProductAddAtributeRequest(
    int Id,
    string Atribute
    );