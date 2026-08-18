using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace Day47_StoredProcedure.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class EmployeeController : ControllerBase
    {
        private readonly EmployeeRepository _repo;

        public EmployeeController(EmployeeRepository repo)
        {
            _repo = repo;
        }


        [HttpPost]
        public IActionResult AddEmployee([FromBody]Employee employee)
        {
            _repo.AddEmployee(employee);
            return Created(nameof(AddEmployee), employee);
        }

        
    }
}
