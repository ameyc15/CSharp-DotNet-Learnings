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
            // Serialization : Is a process to convert the c# object to data format which is transferable over the http req 
            // like json or XML
            string response = JsonSerializer.Serialize(createEmployeeRequest);
            Console.WriteLine("__________Serilaised Object : " + response);
            return CreatedAtAction(nameof(CreateEmployee), createEmployeeRequest);
        }
        [HttpGet("GetEmployeeById)/{id}")]
        public IActionResult GetEmployeeById([FromRoute] int id)
        {
            Console.WriteLine("GetEmplpoyeeById called with Id " + id);
            return Ok();
        }
        [HttpPost("CreateEmployees")]
        public IActionResult CreateEmployees([FromForm] int id, [FromForm] int age)
        {
            Console.WriteLine("create Employee called with Id and Age" + id + age);
            return Ok();
        }


    }
       

}

