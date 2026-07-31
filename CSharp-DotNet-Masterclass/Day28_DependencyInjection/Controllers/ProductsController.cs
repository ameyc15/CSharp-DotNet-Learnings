using Day28_DependencyInjection.Services;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace Day28_DependencyInjection.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ProductsController : ControllerBase
    {
        private readonly IProductService _productService;
        public ProductsController(IProductService productService)
        {
            _productService = productService;   
        }
        [HttpGet("get-all-products")]
        public IActionResult GetAllProducts()
        {
            //lets use product service method using dependency injection
            List<string> result = _productService.GetAllProducts();
            Console.WriteLine("Get All Products called with by object with Hascode : " + _productService.GetHashCode());
            return Ok(result);
        }
    }
}
