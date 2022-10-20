using FluentValidation;

namespace InternetShopAPI.Models;

public class Product
{
    public int Id { get; set; }
    public string Name { get; set; }
    public Category Category { get; set; }
    public string? Atribute { get; set; }
    public uint Quantity { get; set; }
}

public class ProductValidator : AbstractValidator<Product>
{
    public ProductValidator()
    {
        RuleFor(p => p.Name).NotEmpty();
        RuleFor(p => p.Category);
        RuleFor(p => p.Atribute).Length(5,50);
        /*RuleFor(p => p.Quantity).InclusiveBetween(1, 500);*/
    }
}