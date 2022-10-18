using InternetShopAPI.Controllers.Requests;
using InternetShopAPI.Controllers.Responces;
using InternetShopAPI.Models.Requests;
using InternetShopAPI.Services;
using Microsoft.AspNetCore.Mvc;

namespace InternetShopAPI.Controllers
{
    [ApiController]
    [Route("/api/[controller]")]
    public class ShopController : ControllerBase
    {
        private readonly IProductService _productService;

        public ShopController(IProductService productService)
        {
            _productService = productService;
        } 

        [HttpPost("Products/")]
        public IActionResult AddProduct([FromBody] ProductCreateRequest request)
        {
            _productService.AddProduct(request);
            return Ok(new ApiResponce("Products is added!"));
        }

        [HttpDelete("Products/{id}")]
        public IActionResult DeleteProduct([FromRoute] int id)
        {
            _productService.DeleteProduct(id);
            return Ok(new ApiResponce("Poducts is deleted!"));
        }

        [HttpPost("Product/{id}/Attribute")]
        public IActionResult AddProductAtribute([FromRoute] int id, string atribute)
        {
            _productService.AddProductAtribute(id, atribute);
            return Ok(new ApiResponce("Attribute is added!"));
        }

        [HttpPatch("Product/{id}/Attribute")]
        public IActionResult ChangeProductAtribute([FromRoute] int id, string atribute)
        {
            _productService.ChangeProductAtribute(id, atribute);
            return Ok(new ApiResponce("Attribute is changed!"));
        }

        [HttpPost("Products/{id}/Quantity")]
        public IActionResult AddQuantityProduct([FromRoute] int id, uint quantity)
        {
            _productService.AddQuantityProduct(id, quantity);
            return Ok(new ApiResponce("Quantity of product is changed!"));
        }
    }
}