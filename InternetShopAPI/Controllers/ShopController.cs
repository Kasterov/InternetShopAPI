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

        [HttpPost("Products/AddProduct")]
        public IActionResult AddProduct([FromBody] ProductCreateRequest request)
        {
            _productService.AddProduct(request);
            return Ok(new ApiResponce("Everything is ok"));
        }


        [HttpPost("Product/{id}/Attribute")]
        public IActionResult AddProductAtribute([FromRoute] int id, string atribute)
        {
            _productService.AddProductAtribute(id, atribute);
            return Ok(new ApiResponce("Everything is ok"));
        }

        [HttpPost("Products/{id}/Quantity")]
        public IActionResult AddQuantityProduct([FromRoute] int id, uint quantity)
        {
            _productService.AddQuantityProduct(id, quantity);
            return Ok(new ApiResponce("Everything is ok"));
        }
    }
}