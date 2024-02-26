using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Http;

namespace coreMiddlewaresProject.Controllers
{
    [Route("/login")]
    public class LoginController : Controller
    {
        [Route("")]
        [Route("index")]
        public IActionResult Index()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Login(string username, string password)
        {
            if(username != null && password != null && 
                username.Equals("bhawna") && password.Equals("123"))
            {
                HttpContext.Session.SetString("username", username);
                return View("Welcome");
            }
            ViewBag.error = "Invalid Credentials";
            return View();
        }
    }
}
