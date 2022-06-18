using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Teachy.Data.Models
{
    public class Author
    {
        [Key]
        public int Id { get; set; }

        public string Name { get; set; } = null!;

        public DateTime? DateOfBirth { get; set; }

        [ForeignKey("Country")]
        public int? CountryOfOriginId { get; set; }
        public virtual Country? CountryOfOrigin { get; set; }
    }
}
