using coreDependencyInjectionApp.Models;

namespace coreDependencyInjectionApp.Repository
{
    public class StudentRepository : IStudentRepository
    {
        // When a new instance of this repository is created 
        // we need to log the date and time into a text file.
        public StudentRepository() 
        {
            string filePath = @"D:\\logs\\studentLog.txt";
            string contentToWrite = "Student Repository Object Created: " + DateTime.Now.ToString();
            using(StreamWriter writer = new StreamWriter(filePath, true))
            {
                writer.WriteLine(contentToWrite);
            }
        }


        public List<Student> GetAllStudents()
        {
            return getStudents();
        }

        public Student GetStudentById(int studentId)
        {
            return getStudents().FirstOrDefault(s => s.StudentId == studentId) ?? new Student();
        }

        public List<Student> getStudents()
        {
            return new List<Student>()
            {
                new Student() { StudentId = 1, Name = "Gautam", Gender = "Male" },
                new Student() { StudentId = 2, Name = "Shreya", Gender = "Female" },
                new Student() { StudentId = 3, Name = "Bharat", Gender = "Male" },
                new Student() { StudentId = 4, Name = "Smith", Gender = "Male" },
                new Student() { StudentId = 5, Name = "Roger", Gender = "Male" }
            };
        }
    }
}
