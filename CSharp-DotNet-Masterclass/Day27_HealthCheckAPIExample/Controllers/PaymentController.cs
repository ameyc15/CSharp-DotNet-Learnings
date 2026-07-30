using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace Day27_HealthCheckAPIExample.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class PaymentController : ControllerBase
    {
        // dummy api in payment service
        [HttpGet("ProcessPayment")]
        public IActionResult ProcessPayment()
        { 
            // do payment
            return Ok("Payment successful");
        }
    }
}
