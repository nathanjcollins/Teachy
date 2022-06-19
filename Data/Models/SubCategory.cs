using Microsoft.EntityFrameworkCore;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Teachy.Data.Models
{
	[Index(nameof(Name), nameof(CategoryId), IsUnique = true)]
	public class SubCategory
	{
		[Key]
		public int Id { get; set; }

		public string Name { get; set; } = null!;

		[ForeignKey("Category")]
		public int CategoryId { get; set; }
		public virtual Category Category { get; set; } = null!;
	}
}
