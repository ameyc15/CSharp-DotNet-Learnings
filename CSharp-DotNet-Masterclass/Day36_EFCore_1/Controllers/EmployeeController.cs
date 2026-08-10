using Day36_EFCore_1.Services;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace Day36_EFCore_1.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class EmployeeController : ControllerBase
    {
        private readonly EmployeeService employeeService;
        public EmployeeController() 
        {

        }
        // Get : api/employee/all
        [HttpGet("get-all-employees")]
        public  async Task<IActionResult> GetAllEmployees()
        {
            return Ok();
        }

        [HttpGet("get-employee-by-id")]
        public async Task<IActionResult> GetEmployeeById()
        {
            return Ok();
        }

        [HttpPost("create-employee")]
        public async Task<IActionResult> CreateEmployee()
        {
            return Ok();
        }
    }
}
