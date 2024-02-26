using Microsoft.AspNetCore.Mvc;
using coreWebSecurityApp.Models;
using coreWebSecurityApp.Security;


namespace coreWebSecurityApp.Controllers
{
    public class AccountController : Controller
    {
        private SecurityManager securityManager = new SecurityManager();
        public IActionResult Index()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Login(string username, string password)
        {
            AcccountModel model = new AcccountModel();
            if(string.IsNullOrEmpty(username) || string.IsNullOrEmpty(password) || model.login(username, password) == null)
            {
                ViewBag.Error = "Invalid Credentials";
                return View("Index");
            }
            else
            {
                securityManager.SignIn(this.HttpContext, model.find(username));
                return RedirectToAction("Welcome");
            }
                
        }

        public IActionResult Welcome() 
        {
            return View();
        }

        public IActionResult AccessDenied()
        {
            return View();
        }

        public IActionResult SignOut()
        {
            securityManager.SignOut(this.HttpContext);
            return RedirectToAction("Index");
        }
    }
}
