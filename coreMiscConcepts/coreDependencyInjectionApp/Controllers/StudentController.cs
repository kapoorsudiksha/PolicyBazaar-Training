using coreDependencyInjectionApp.Models;
using coreDependencyInjectionApp.Repository;
using Microsoft.AspNetCore.Mvc;

namespace coreDependencyInjectionApp.Controllers
{
    public class StudentController : Controller
    {
        private readonly IStudentRepository _studentRepository;
        private readonly SomeOtherService? _someOtherService = null;
        public StudentController(IStudentRepository studentRepository, SomeOtherService someOtherService)
        {
            _studentRepository = studentRepository;
            _someOtherService = someOtherService;
        }
        public JsonResult Index()
        {
            List<Student> students = _studentRepository.GetAllStudents();
            _someOtherService?.SomeMethod();
            return Json(students);
        }

        public JsonResult Details(int id) 
        {
            Student student = _studentRepository.GetStudentById(id);
            _someOtherService?.SomeMethod();
            return Json(student);
        }
    }
}
