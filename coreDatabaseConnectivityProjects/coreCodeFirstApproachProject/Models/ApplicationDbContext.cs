using Microsoft.EntityFrameworkCore;

namespace coreCodeFirstApproachProject.Models
{
    public class ApplicationDbContext: DbContext
    {
        public DbSet<Employee> Employees { get; set; }
        public DbSet<Author> Authors { get; set; }
        public DbSet<Book> Books { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("Server=DESKTOP-EI4423A;Database=Sampledb;Integrated Security=true;TrustServerCertificate=True");
        }
    }
}
