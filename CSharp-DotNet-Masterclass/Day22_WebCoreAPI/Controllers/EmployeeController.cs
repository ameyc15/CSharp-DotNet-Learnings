using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace Day22_WebCoreAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class EmployeeController : ControllerBase
    {
        public string EmployeeName = "Amey Chaudhary";

        public string EmmployeeCity = "Pune";

        public EmployeeController()
        {

        }

        [HttpGet("GetEmployeeName")]
        public string GetEmployeeName() 
        {
            return EmployeeName;
        }

        [HttpGet("GetCityName")]
        public string GetEmployeeCity() 
        {
            return EmmployeeCity;
        }
    }
}
