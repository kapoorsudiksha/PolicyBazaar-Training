using coreCodeFirstRelationships.Models;
using Microsoft.EntityFrameworkCore;

namespace coreDependencyInjectionProject.Models
{
    public class ApplicationDBContext: DbContext
    {
        public DbSet<Student> Students { get; set; }
        public DbSet<Author> Authors { get; set; }
        public DbSet<Book> Books { get; set; }  
        public ApplicationDBContext() { }
        public ApplicationDBContext(DbContextOptions<ApplicationDBContext> options): base(options) { }
    }
}
