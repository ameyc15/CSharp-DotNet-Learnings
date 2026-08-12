using Day38_EF_SampleApplication.Models;
using Day38_EF_SampleApplication.Repository;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace Day38_EF_SampleApplication.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class EmployeeController : ControllerBase
    {
        private readonly IEmployeeRepository _employeeRepository;

        public EmployeeController(IEmployeeRepository employeeRepository)
        {
            _employeeRepository = employeeRepository;
        }

        [HttpGet("GetEmployees")]
        public IActionResult GetEmployees()
        {
            var employees = _employeeRepository.GetAll();
            return Ok(employees);
        }

        [HttpGet("GetEmployeeById")]
        public IActionResult GetEmployee(int id) 
        {
            var employee = _employeeRepository.GetById(id);
            if(employee == null)
            {
                return NotFound("Employee with id not found");
            }
            return Ok(employee);
        }

        [HttpPost("AddEmployee")]
        public IActionResult AddEmployee(Employee emp)
        {
            _employeeRepository.Add(emp);
            return Ok(emp);
        }
    }
}
