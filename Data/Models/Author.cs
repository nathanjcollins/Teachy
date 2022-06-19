using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Teachy.Data.Models
{
    public class Author
    {
        [Key]
        public int Id { get; set; }

        public string FirstName { get; set; } = null!;

        public string LastName { get; set; } = null!;

        [Column(TypeName = "Date")]
        public DateTime? DateOfBirth { get; set; }

        [ForeignKey("Country")]
        public int? CountryOfOriginId { get; set; }
        public virtual Country? CountryOfOrigin { get; set; }
    }
}
