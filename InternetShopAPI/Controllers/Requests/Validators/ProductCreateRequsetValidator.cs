using FluentValidation;

namespace InternetShopAPI.Controllers.Requests.Validators;

public class ProductValidator : AbstractValidator<ProductCreateRequest>
{
    public ProductValidator()
    {
        RuleFor(p => p.Name).NotEmpty();
        RuleFor(p => p.Category).NotNull();
        RuleFor(p => p.Quantity).GreaterThan(0);
    }
}
