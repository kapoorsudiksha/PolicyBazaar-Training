using coreDependencyInjectionApp.Models;

namespace coreDependencyInjectionApp.Repository
{
    public interface IStudentRepository
    {
        List<Student> GetAllStudents();
        Student GetStudentById(int studentId);

    }
}
