namespace coreCodeFirstRelationships.Models
{
    public class Book
    {
        public int BookId { get; set; }
        public string? Title { get; set; }
        public double Price { get; set; }
        //Navigation Property
        public Author? author { get; set; }
    }
}
