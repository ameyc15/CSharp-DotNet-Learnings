using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace Day40_BasicAuthentication.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class EmployeeController : ControllerBase
    {
        [HttpGet("getemployees")]
        public IActionResult GetEmployees()
        {
            return Ok(new
            {
                User = "Amey",
                Salary = 100
            });
        }
    }
}
