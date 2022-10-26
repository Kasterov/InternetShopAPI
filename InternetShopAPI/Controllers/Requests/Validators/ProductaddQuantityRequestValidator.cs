using FluentValidation;

namespace InternetShopAPI.Controllers.Requests.Validators;

public class ProductaddQuantityRequestValidator : AbstractValidator<ProductaddQuantityRequest>
{
    public ProductaddQuantityRequestValidator()
    {
        RuleFor(x => x.Quantity)
            .GreaterThan(0).
            WithMessage("Quantity have to be grater than 0!");
    }
}
