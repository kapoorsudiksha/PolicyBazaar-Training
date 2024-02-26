using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace coreWebIdentityProviderApp.Controllers
{
    public class DemoController : Controller
    {
        [AllowAnonymous]
        public IActionResult Index()
        {
            return View();
        }
        [Authorize(Policy = "RequireAdminRole")]
        public IActionResult Details()
        {
            return View();
        }

        [Authorize(Roles = "Employee")]
        public IActionResult Message()
        {
            return View();
        }
    }
}
