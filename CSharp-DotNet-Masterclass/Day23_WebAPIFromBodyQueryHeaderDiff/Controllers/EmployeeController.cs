using Day23_WebAPIFromBodyQueryHeaderDiff.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Http.HttpResults;
using Microsoft.AspNetCore.Mvc;
using System.Text.Json;

namespace Day23_WebAPIFromBodyQueryHeaderDiff.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class EmployeeController : ControllerBase
    {
        public EmployeeController() { }

        [HttpGet("GetEmployeeByQuery")]
        public IActionResult GetEmployeeByQuery([FromQuery] int id, [FromQuery] string employeeName)
        {
            Console.WriteLine("----------------------GetEmployeeByQuery Called with Id : " + id);
            string result = "Id " + id + "  Employee Name  " + employeeName;
            return Ok(result);
        }

        [HttpGet("GetEmployeeByHeader")]
        public IActionResult GetEmployeeByHeader([FromHeader] string company)
        {
            var result = company;
            return Ok(result);
        }

        [HttpPost("CreateEmployee")]
        public IActionResult CreateEmployee([FromBody] CreateEmployeeRequest createEmployeeRequest)
        {
            Console.WriteLine("----------------------CreateEmployee Method with employee name " + createEmployeeRequest.EmployeeName);
            string response = JsonSerializer.Serialize(createEmployeeRequest);
            Console.WriteLine("__________Serilaised Object : " + response);
            return CreatedAtAction(nameof(CreateEmployee),createEmployeeRequest);
        }
    }
}
