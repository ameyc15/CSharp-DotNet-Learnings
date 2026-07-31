using Day28_DependencyInjection.Managers;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace Day28_DependencyInjection.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class EmployeeController : ControllerBase
    {
        private readonly EmployeeManager _employeeManager;

        public EmployeeController(EmployeeManager employeeManager)
        {
            _employeeManager = employeeManager;
        }

        [HttpGet("GetEmployeeInformation")]
        public IActionResult GetData()
        {
            Console.WriteLine("Get Data Called " + _employeeManager.GetHashCode());
            _employeeManager.CreateEmployee();
            return Ok();
        }

        [HttpPut("Add-Employee")]
        public IActionResult CreateEmployee()
        {
            Console.WriteLine("Created Employee " + _employeeManager.GetHashCode());
            _employeeManager.CreateEmployee();
            return Ok();
        }

    }
}
