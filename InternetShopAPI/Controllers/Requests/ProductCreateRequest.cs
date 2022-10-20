using FluentValidation;
using InternetShopAPI.Models;

namespace InternetShopAPI.Controllers.Requests;

public sealed record ProductCreateRequest(
    string Name,
    Category Category,
    ushort Quantity,
    string? Atribute
    );

public class ProductValidator : AbstractValidator<ProductCreateRequest>
{
    public ProductValidator()
    {
        RuleFor(p => p.Name).NotEmpty();
        RuleFor(p => p.Category).IsInEnum();
        RuleFor(p => p.Atribute).NotNull();
        RuleFor(p => p.Quantity).Must();
    }
}   