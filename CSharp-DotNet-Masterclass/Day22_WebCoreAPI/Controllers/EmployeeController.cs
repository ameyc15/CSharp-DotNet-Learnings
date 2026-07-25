using Day22_WebCoreAPI.Services;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace Day22_WebCoreAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class EmployeeController : ControllerBase
    {
        public EmployeeService employeeService = new EmployeeService();

       

        public EmployeeController()
        {

        }

        [HttpGet("GetEmployeeName")]
        public string GetEmployeeName() 
        {
            return employeeService.GetEmployeeData();
             
        }

        //[HttpGet("GetCityName")]
        //public string GetEmployeeCity() 
        //{
        //    return EmmployeeCity;
        //}
    }
}
