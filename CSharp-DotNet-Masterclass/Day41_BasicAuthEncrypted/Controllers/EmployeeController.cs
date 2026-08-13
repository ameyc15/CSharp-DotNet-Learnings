using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace Day41_BasicAuthEncrypted.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class EmployeeController : ControllerBase
    {
        [HttpGet("getemployee")]
        public IActionResult Get()
        {
            if (!BasicAutherisationHelper.IsAutherised(Request))
            {
                return Unauthorized("Please enter valid credentials");
            }

            return Ok(new
            {
                Name = "Amey",
                Address = "Pune"
            });
        }
    }
}
