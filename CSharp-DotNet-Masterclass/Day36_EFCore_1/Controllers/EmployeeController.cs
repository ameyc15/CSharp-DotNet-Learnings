using Day36_EFCore_1.Models;
using Day36_EFCore_1.Services;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace Day36_EFCore_1.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class EmployeeController : ControllerBase
    {
        private readonly EmployeeService _employeeService;
        public EmployeeController(EmployeeService employeeService) 
        {
            _employeeService = employeeService;
        }
        // Get : api/employee/all
        [HttpGet("get-all-employees")]
        public  async Task<IActionResult> GetAllEmployees()
        {
            var employees = await _employeeService.GetAllEmployeesAsync();
            return Ok(employees);
        }

        [HttpGet("get-employee-by-id")]
        public async Task<IActionResult> GetEmployeeById(int id)
        {
            var employee = await _employeeService.GetEmployeeByIdAsync(id);
            if(employee == null)
            {
                return NotFound();
            }
            return Ok(employee);
        }

        [HttpPost("create-employee")]
        public async Task<IActionResult> CreateEmployee(Employee employee)
        {
            await _employeeService.AddEmployeeAsync(employee);
            return Created(nameof(CreateEmployee),employee);
        }

        [HttpDelete("delete-employee")]
        public async Task<IActionResult> DeleteEmployee(int id)
        {
            await _employeeService.DeleteEmployeeById(id);

            return Ok();
        }

        [HttpPut("update-employee")]
        public async Task<IActionResult> UpdateEmployee(Employee employee)
        {
            _employeeService.UpdateEmployeeAsync(employee);
            return Ok(employee);
        }
    }
}
