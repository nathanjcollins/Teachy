using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Teachy.Data.Enums;

namespace Teachy.Data.Models
{
    public class ResourceType
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public ResourceTypeEnum Id { get; set; }

        public string Name { get; set; } = null!;
    }
}
