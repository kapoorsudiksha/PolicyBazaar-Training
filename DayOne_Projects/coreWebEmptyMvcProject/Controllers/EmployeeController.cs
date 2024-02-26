using Microsoft.AspNetCore.Mvc;

namespace coreWebEmptyMvcProject.Controllers
{
    public class EmployeeController : Controller
    {
        public ViewResult Index()
        {
            return View();
        }
        public ViewResult Dashboard()
        {
            return View("EmployeeDashboard");
        }
    }
}
