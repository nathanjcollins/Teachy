using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Teachy.Data.Models
{
    public class ClassStudent
    {
        [Key]
        public int Id { get; set; }

        [ForeignKey("Class")]
        public int ClassId { get; set; }
        public virtual Class Class { get; set; } = null!;

        [ForeignKey("UserProfile")]
        public int StudentId { get; set; }
        public virtual UserProfile Student { get; set; } = null!;
    }
}
