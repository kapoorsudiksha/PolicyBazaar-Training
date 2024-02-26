using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace coreCodeFirstRelationships.Models
{
    [Table("StudentMaster")]
    public class Student
    {
        [Key]
        [Column(Order = 0)]
        public int StudentDetailId { get; set; }
        [Column("StudentName", Order = 2)]
        [Required(ErrorMessage = "Name is Required.")]
        [MaxLength(100)]
        public string? Name { get; set; }
        [Column(Order = 1)]
        [MinLength(1), MaxLength(40)]
        public double Age { get; set; }
        [Column("DoB", TypeName = "DateTime2")]
        public DateTime DateofBirth { get; set; }
        [NotMapped]
        [StringLength(100)]
        public string? Description { get; set; }
    }
}
