using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Teachy.Data.Models
{
    public class ClassMember
    {
        [Key]
        public int Id { get; set; }

        [ForeignKey("Class")]
        public int ClassId { get; set; }
        public virtual Class Class { get; set; } = null!;

        [ForeignKey("UserProfile")]
        public int MemberId { get; set; }
        public virtual UserProfile Member { get; set; } = null!;
    }
}
