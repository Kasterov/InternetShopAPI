using InternetShopAPI.Controllers.Requests;
using InternetShopAPI.Controllers.Responces;
using InternetShopAPI.Services;
using Microsoft.AspNetCore.Mvc;

namespace InternetShopAPI.Controllers
{
    [ApiController]
    [Route("[/api/[controller]")]
    public class ShopController : ControllerBase
    {
        private readonly IProductService _productService;

        public ShopController(IProductService productService)
        {
            _productService = productService;
        } 

        [HttpGet("api/Products/")]
        public IActionResult AddProduct([FromBody] ProductCreateRequest request)
        {
            _productService.addProduct(request);
            return Ok(new ApiResponce($"All products:"));
        }
    }
}