using Microsoft.EntityFrameworkCore;
using System.ComponentModel.DataAnnotations;

namespace Teachy.Data.Models
{
	[Index(nameof(Name), IsUnique = true)]
	public class Category
	{
		[Key]
		public int Id { get; set; }

		public string Name { get; set; } = null!;

		public ICollection<SubCategory> SubCategories { get; set; } = null!;
	}
}
