using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace Day44_CustomMiddleware.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ValuesController : ControllerBase
    {
        [HttpGet]
        public IActionResult Get()
        {
            return Ok("hello from api");
        }
    }
}
