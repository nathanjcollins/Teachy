using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Teachy.Data.Enums;

namespace Teachy.Data.Models
{
    public class Resource
    {
        [Key]
        public int Id { get; set; }

        public string Name { get; set; } = null!;

		[ForeignKey("SubCategory")]
        public int SubCategoryId { get; set; }
        public virtual SubCategory SubCategory { get; set; } = null!;

        [ForeignKey("ResourceType")]
        public ResourceTypeEnum ResourceTypeId { get; set; }
        public virtual ResourceType ResourceType { get; set; } = null!;

        public string? Uri { get; set; }

        public byte[]? FileContent { get; set; }

        [ForeignKey("Author")]
        public int AuthorId { get; set; }
        public virtual Author Author { get; set; } = null!;
    }
}
