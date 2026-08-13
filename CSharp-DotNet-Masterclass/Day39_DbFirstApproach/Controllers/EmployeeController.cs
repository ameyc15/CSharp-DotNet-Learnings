using Day39_DbFirstApproach.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace Day39_DbFirstApproach.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class EmployeeController : ControllerBase
    {
        // 1. sql server using me need to create database , create table and insert values 
        // 2. Install Ef Packages into our project
        // 3. Generate Models from Database
        // 4. connectionstring in appsetting.json
        // 5. endpoint fill out and test

        private readonly CompanyDbContext _context;
        public EmployeeController(CompanyDbContext context)
        {
            _context = context;
        }

        [HttpGet("get-all")]
        public IActionResult Get()
        {
            var employess = _context.Employees.ToList();
            return Ok(employess);
        }


    }
}
