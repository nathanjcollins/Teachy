using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Teachy.Data.Models
{
    public class Class
    {
        [Key]
        public int Id { get; set; }

        public string Name { get; set; } = null!;

        [ForeignKey("UserProfile")]
        public int OwnerId { get; set; }
        public virtual UserProfile Owner { get; set; } = null!;

        public ICollection<ClassStudent> ClassStudents { get; set; } = null!;
    }
}
