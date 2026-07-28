using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Immutable;
using System.Globalization;
using System.Xml.Linq;

namespace Day24_WebAPIPracticeExamples.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ExampleController : ControllerBase
    {
        //    - **Exercise 1**
        //- GET method with API name maxElement
        //- Takes number1 & number2 as query params
        //- Return the max number in response
        [HttpGet("MaxElement")]
        public IActionResult MaxElement([FromQuery]int numOne, int numTwo)
        {
            int result = int.Max(numOne, numTwo);
            return Ok(result);
        }

        //    - **Exercise 2**
        //- GET method with API name sortArray
        //- Take array in query param
        //- Return the sorted array in response

        [HttpGet("SortArray")]
        public IActionResult SortArray([FromQuery]int[] numbers)
        {
            Array.Sort(numbers);
            return Ok(numbers);
        }
    }
}
