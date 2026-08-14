using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace Day42_JWTToken.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class DataController : ControllerBase
    {
        [Authorize]
        [HttpGet("Get-data")]
        public IActionResult Get()
        {
            return Ok("Success");
        }
    }
}
