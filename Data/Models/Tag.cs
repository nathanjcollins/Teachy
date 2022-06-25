using System.ComponentModel.DataAnnotations;

namespace Teachy.Data.Models;

public class Tag
{
    [Key]
    public int Id { get; set; }

    public string Name { get; set; } = null!;
    
    public ICollection<ResourceTag>? ResourceTags { get; set; }
}