using System.ComponentModel.DataAnnotations;

namespace Teachy.Data.Models
{
    public class UserProfile
    {
        [Key]
        public int Id { get; set; }

        public string Auth0Id { get; set; } = null!;

        public string FirstName { get; set; } = null!;

        public string LastName { get; set; } = null!;

        public ICollection<ClassStudent> ClassStudents { get; set; } = null!;
    }
}
