using System.ComponentModel.DataAnnotations;

namespace Teachy.Data.Models
{
    public class Country
    {
        [Key]
        public int Id { get; set; }

        public string Name { get; set; } = null!;
    }
}
