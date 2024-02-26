using coreDependencyInjectionProject.Models;
using Microsoft.AspNetCore.Mvc;

namespace coreDependencyInjectionProject.Controllers
{
    public class StudentController : Controller
    {
        private ApplicationDBContext context;
        public StudentController(ApplicationDBContext _context)
        {
            context = _context;
        }
        public IActionResult Index()
        {
            var students = context.Students.ToList();
            return View(students);
        }
    }
}
