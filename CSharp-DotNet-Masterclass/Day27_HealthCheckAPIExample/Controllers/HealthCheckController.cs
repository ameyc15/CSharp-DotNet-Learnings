using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace Day27_HealthCheckAPIExample.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class HealthCheckController : ControllerBase
    {
        [HttpGet("Health/Check")]
        public IActionResult HealthCheck()
        {
            // check health status of server
            return Ok("Health Good");
        }
    }
}
