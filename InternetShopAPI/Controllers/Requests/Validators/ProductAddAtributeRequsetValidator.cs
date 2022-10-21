using FluentValidation;
using InternetShopAPI.Models.Requests;

namespace InternetShopAPI.Controllers.Requests.Validators
{
    public class ProductAddAtributeRequsetValidator : AbstractValidator<ProductAddAtributeRequest>
    {
        public ProductAddAtributeRequsetValidator()
        {
            RuleFor(x => x.Atribute).MinimumLength(5).WithMessage("Minimum length of atribute is 5!");
        }
    }
}
