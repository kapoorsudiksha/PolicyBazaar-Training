using System.ComponentModel.DataAnnotations.Schema;

namespace coreCodeFirstRelationships.Models
{
    public class AuthorBiography
    {
        public int AuthorBiographyId { get; set; }
        public string? Biography { get; set; }
        public DateTime DateOfBirth { get; set; }
        public string? PlaceOfBirth { get; set; }
        /*[ForeignKey("Author")]*/
        public int AuthorId { get; set; }
        public Author? Author { get; set; }
    }
}
