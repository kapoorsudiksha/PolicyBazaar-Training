namespace coreCodeFirstRelationships.Models
{
    public class Author
    {
        public int AuthorId { get; set; }
        public string? FirstName { get; set; }
        public string? LastName { get; set; }
        // Navigational Property
        public ICollection<Book>? Books { get; set; }
        public AuthorBiography? Biography { get; set; }
    }
}
