using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Teachy.Data.Models;

public class ResourceTag
{
    [Key]
    public int Id { get; set; }

    [ForeignKey("Resource")]
    public int ResourceId { get; set; }
    public virtual Resource Resource { get; set; } = null!;
    
    [ForeignKey("Tag")]
    public int TagId { get; set; }
    public virtual Tag Tag { get; set; } = null!;
}