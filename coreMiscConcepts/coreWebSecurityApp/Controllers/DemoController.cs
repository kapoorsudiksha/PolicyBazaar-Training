using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace coreWebSecurityApp.Controllers
{
    public class DemoController : Controller
    {
        [AllowAnonymous]
        public IActionResult Index()
        {
            return View();
        }

        [Authorize(Roles = "superadmin")]
        public IActionResult Index1()
        {
            return View();
        }

        [Authorize(Roles = "superadmin, admin")]
        public IActionResult Index2()
        {
            return View();
        }

        [Authorize(Roles = "superadmin, admin, employee")]
        public IActionResult Index3()
        {
            return View();
        }
    }
}
