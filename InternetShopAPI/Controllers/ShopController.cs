using InternetShopAPI.Controllers.Requests;
using InternetShopAPI.Controllers.Responces;
using InternetShopAPI.Services;
using Microsoft.AspNetCore.Mvc;
using InternetShopAPI.Models;

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

    [HttpPost("products/addProduct")]
    public IActionResult AddProduct([FromBody] ProductCreateRequest request)
    {
        _productService.AddProduct(request);
        return Ok(new ApiResponce("Products is added!"));
    }

    [HttpDelete("products/{id}/deleteProduct")]
    public IActionResult DeleteProduct([FromRoute] int id)
    {
        _productService.DeleteProduct(id);
        return Ok(new ApiResponce("Poducts is deleted!"));
    }

    [HttpPost("product/{id}/attribute/addProductAtribute")]
    public IActionResult AddProductAtribute([FromRoute] int id, string atribute)
    {
        _productService.AddProductAtribute(id, atribute);
        return Ok(new ApiResponce("Attribute is added!"));
    }

    [HttpPatch("product/{id}/attribute/changeProductAtribute")]
    public IActionResult ChangeProductAtribute([FromRoute] int id, string atribute)
    {
        _productService.ChangeProductAtribute(id, atribute);
        return Ok(new ApiResponce("Attribute is changed!"));
    }

    [HttpPost("products/{id}/quantity/addQuantityProduct")]
    public IActionResult AddQuantityProduct([FromRoute] int id, uint quantity)
    {
        _productService.AddQuantityProduct(id, quantity);
        return Ok(new ApiResponce("Quantity of product is changed!"));
    }

    [HttpGet("products/category/getProductsByCategory")]
    public IActionResult GetProductsByCategory(Category category)
    {
        var products = _productService.GetProductsByCategory(category);
        return Ok(products);
    }

    [HttpGet("products/{id}/getProductById")]
    public IActionResult GetProductById([FromRoute] int id)
    {
        var product = _productService.GetProductById(id);
        return Ok(product);
    }
}