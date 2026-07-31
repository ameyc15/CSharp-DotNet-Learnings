using Day28_DependencyInjection.Managers;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace Day28_DependencyInjection.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class UserController : ControllerBase
    {
        private readonly UserManager _userManager;

        public UserController(UserManager userManager)
        {
            _userManager = userManager;
        }

        [HttpGet("Add-User")]
        public IActionResult CreateUser()
        {
            UserManager m1 = new UserManager(); // unneccessary heap memory allocation 
            m1.CreateUser();
            m1.RemoveUser();
            return Ok();
        }

        // using dependency injection 
        [HttpGet("Remove-User")]
        public IActionResult RemoveUser()
        {
            _userManager.RemoveUser();
            Console.WriteLine("Object Created Successfully with HashCode " + _userManager.GetHashCode());
            // will return same HashCode since we have registered UserManager as Singleton in program.cs 
            // if scoped different HashCode gets returnred everytime
            return Ok();
        }



    }
}
