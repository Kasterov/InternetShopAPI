using InternetShopAPI.Controllers.Requests;
using InternetShopAPI.Controllers.Responces;
using InternetShopAPI.Models.Requests;
using InternetShopAPI.Services;
using Microsoft.AspNetCore.Mvc;
using InternetShopAPI.Models;
using FluentValidation;
using FluentValidation.Results;
using InternetShopAPI.Controllers.Requests.Validators;

namespace InternetShopAPI.Controllers;

[ApiController]
[Route("/api/[controller]")]
public class ShopController : ControllerBase
{
    private readonly IProductService _productService;
    public ShopController(IProductService productService)
    {
        _productService = productService;
    } 

    [HttpPost("products")]
    public async Task<IActionResult> AddProduct(
        [FromBody] ProductCreateRequest request, 
        [FromServices] IValidator<ProductCreateRequest> _validator)
    {
        await _validator.ValidateAndThrowAsync(request);

        await _productService.AddProduct(request);
        return Ok(new ApiResponce("Products is added!"));
    }

    [HttpDelete("products/{id}")]
    public async Task<IActionResult> DeleteProduct([FromRoute] int id)
    {
        await _productService.DeleteProduct(id);
        return Ok(new ApiResponce("Poducts is deleted!"));
    }

    [HttpPost("product/{id}/attribute")]
    public async Task<IActionResult> AddProductAtribute(
        [FromRoute] int id,
        [FromBody] ProductAddAtributeRequest request,
        [FromServices] IValidator<ProductAddAtributeRequest> _validator)
    {
        await _validator.ValidateAndThrowAsync(request);

        await _productService.AddProductAtribute(id, request.Atribute);
        return Ok(new ApiResponce("Attribute is added!"));
    }

    [HttpPatch("product/{id}/attribute")]
    public async Task<IActionResult> ChangeProductAtribute(
        [FromRoute] int id,
        [FromBody] ProductAddAtributeRequest request,
        [FromServices] IValidator<ProductAddAtributeRequest> _validator)
    {
        await _validator.ValidateAndThrowAsync(request);

        await _productService.ChangeProductAtribute(id, request.Atribute);
        return Ok(new ApiResponce("Attribute is changed!"));
    }

    [HttpPost("products/{id}/quantity")]
    public async Task<IActionResult> AddQuantityProduct(
        [FromRoute] int id,
        [FromBody] ProductaddQuantityRequest request,
        [FromServices] IValidator<ProductaddQuantityRequest> _validator)
    {
        await _validator.ValidateAndThrowAsync(request);
        await _productService.AddQuantityProduct(id, request.Quantity);
        return Ok(new ApiResponce("Quantity of product is changed!"));
    }

    [HttpGet("products")]
    public async Task<IActionResult> GetProductsByCategory([FromQuery] Category category)
    {
        var products = await _productService.GetProductsByCategory(category);
        return Ok(products);
    }

    [HttpGet("products/{id}")]
    public async Task<IActionResult> GetProductById([FromRoute] int id)
    {
        var product = await _productService.GetProductById(id);
        return Ok(product);
    }
}