namespace coreDependencyInjectionApp.Repository
{
    public class SomeOtherService
    {
        private readonly IStudentRepository? _studentRepository = null;
        
        public SomeOtherService(IStudentRepository studentRepository)
        {
            _studentRepository = studentRepository;
            
        }

        public void SomeMethod()
        {
            // Some Code Methods
        }
    }
}
