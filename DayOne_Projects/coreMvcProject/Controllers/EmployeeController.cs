using coreMvcProject.Models;
using Microsoft.AspNetCore.Mvc;

namespace coreMvcProject.Controllers
{
    public class EmployeeController : Controller
    {
        public List<Employee> employees = new List<Employee>()
        {
            new Employee() { Id = 1, Name = "King Kochhar", Age = 23},
            new Employee() { Id = 2, Name = "Sarah Bowling", Age = 32},
            new Employee() { Id = 3, Name = "Shreya Sharma", Age = 41},
            new Employee() { Id = 4, Name = "Kartik Sharma", Age = 33},
            new Employee() { Id = 5, Name = "John Smith", Age = 40}
        };

        public IActionResult Index()
        {
            ViewBag.Message = "Employee List";
            ViewBag.EmployeeCount = employees.Count();
            ViewBag.EmployeeList = employees;
            return View();
        }

        public IActionResult Index1()
        {
            ViewData["Message"] = "Employee List";
            ViewData["EmployeeCount"] = employees.Count();
            ViewData["EmployeeList"] = employees;
            return View();
        }

        public IActionResult Index2()
        {
            TempData["Message"] = "Employee List";
            TempData["EmployeeCount"] = employees.Count();
            TempData["EmployeeList"] = employees;
            return View();
        }

        public IActionResult Details()
        {
            if (TempData["EmployeeCount"] != null)
            {
                return RedirectToAction("Details1");
            }
            return View();
        }
        public IActionResult Details1()
        {
            if(TempData.ContainsKey("EmployeeCount"))
            {
                // Peek Method will read the data and preserve the key for next request.
                ViewData["count"] = TempData.Peek("EmployeeCount");
                return View();
            }
            return RedirectToAction();
        }
    }
}
