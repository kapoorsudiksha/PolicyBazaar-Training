using Microsoft.EntityFrameworkCore;

namespace coreCodeFirstRelationships.Models
{
    public class ApplicationDBContext: DbContext
    {
        public DbSet<Author> Authors { get; set; }
        public DbSet<Book> Books { get; set; }
        public DbSet<AuthorBiography> authorBiographies { get; set; }
        public DbSet<Category> Categories { get; set; }
        public DbSet<Student> Students { get; set; }
        public DbSet<UserDetail> UserDetails { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("Server=DESKTOP-EI4423A;Database=coredb;Integrated Security=true;TrustServerCertificate=True");
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Author>().HasData(
                new Author { AuthorId = 1, FirstName = "King",LastName = "Kochhar" },
                new Author { AuthorId = 2, FirstName = "Shreya", LastName = "Sharma" },
                new Author { AuthorId = 3, FirstName = "Sarah", LastName = "Bowling" },
                new Author { AuthorId = 4, FirstName = "Gautam", LastName = "Bhalla" }
            );

            /* modelBuilder.Entity<AuthorBiography>().HasData(
                     new AuthorBiography 
                      { 
                         AuthorBiographyId = 1, 
                         Biography = "Some Details Here" , 
                         DateOfBirth = DateTime.Now, 
                         PlaceOfBirth = "Delhi", 
                         AuthorId = 1 
                     },
                     new AuthorBiography
                     { 
                         AuthorBiographyId = 2, 
                         Biography = "Some Details Here", 
                         DateOfBirth = DateTime.Now, 
                         PlaceOfBirth = "Mumbai", 
                         AuthorId = 2 
                     },
                     new AuthorBiography
                     { 
                         AuthorBiographyId = 3, 
                         Biography = "Some Details Here", 
                         DateOfBirth = DateTime.Now, 
                         PlaceOfBirth = "Chennai", 
                         AuthorId = 3 
                     },
                     new AuthorBiography
                     { 
                         AuthorBiographyId = 4, 
                         Biography = "Some Details Here", 
                         DateOfBirth = DateTime.Now, 
                         PlaceOfBirth = "Hyderabad", 
                         AuthorId = 4 
                     }
                 );*/

            // Configure Primary Key
            /*modelBuilder.Entity<User>()
                .HasKey(u => u.UId);*/

            // Configure Composite Key
            /*modelBuilder.Entity<User>()
                .HasKey(u => new { u.UId, u.RegdId });*/

        }

    }
}
