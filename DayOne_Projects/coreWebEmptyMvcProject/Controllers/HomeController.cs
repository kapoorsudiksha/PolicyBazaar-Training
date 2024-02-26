using Microsoft.AspNetCore.Mvc;

namespace coreWebEmptyMvcProject.Controllers
{
    public class HomeController : Controller
    {
        // Action Method
        public ViewResult Index()
        {
            return View();
        }
        public ViewResult Message()
        {
            return View();
        }
        public ViewResult Details()
        {
            return View();
        }
    }
}
