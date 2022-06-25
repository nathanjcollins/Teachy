using Teachy.Data.Enums;
using Teachy.Data.Models;

namespace Teachy.Pages.Resources.Models;

public class ResourceViewModel
{
    public int? Id { get; set; }

    public string Name { get; set; } = null!;
    
    public ResourceTypeEnum ResourceType { get; set; }
    
    public string? Uri { get; set; }

    public string CategoryName { get; set; } = null!;
    
    public string SubCategoryName { get; set; } = null!;

    public Author Author { get; set; } = null!;
    
    public List<string> Tags { get; set; } = null!;
}