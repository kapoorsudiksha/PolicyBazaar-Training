using coreCodeFirstApproachProject.Models;
using Microsoft.AspNetCore.Mvc;

namespace coreCodeFirstApproachProject.Controllers
{
    public class EmployeeController : Controller
    {
        ApplicationDbContext context;
        public EmployeeController()
        {
            context = new ApplicationDbContext();
        }
        public IActionResult Index()
        {
            var employees = context.Employees.ToList();
            return View(employees);
        }

        public IActionResult Details(int id)
        {
            var employee = context.Employees.Find(id);
            return View(employee);
        }

        public IActionResult Create()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Create(Employee employee)
        {
            context.Employees.Add(employee);
            context.SaveChanges();
            return RedirectToAction("Index");
        }

        public IActionResult Edit(int id)
        {
            var employee = context.Employees.Find(id);
            return View(employee);
        }

        [HttpPost]
        public IActionResult Edit(Employee employee)
        {
            context.Employees.Update(employee);
            context.SaveChanges();
            return RedirectToAction("Index");   
        }

        public IActionResult Delete(int id)
        {
            var employee = context.Employees.Find(id);
            return View(employee);

        }

        [HttpPost]
        public IActionResult Delete(int id, Employee emp)
        {
            var employee = context.Employees.Find(id);
            if(employee != null)
            {
                context.Employees.Remove(employee);
                context.SaveChanges();
                return RedirectToAction("Index");
            }
            return RedirectToAction("Index");
        }
    }
}
