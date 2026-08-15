using Day43_NUnitTest.Services;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace Day43_NUnitTest.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CalculatorController : ControllerBase
    {
        private readonly CalculatorService _calculatorService;

        public CalculatorController(CalculatorService calculatorService)
        {
            _calculatorService = calculatorService;
        }


        [HttpGet]
        public IActionResult Add(int a, int b)
        {
            var result = _calculatorService.Add(a, b);
            Console.WriteLine(result);
            return Ok(result);
        }
    }
}
