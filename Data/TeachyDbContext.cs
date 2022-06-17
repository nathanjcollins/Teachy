using Microsoft.EntityFrameworkCore;
using Teachy.Data.Models;

namespace Teachy.Data
{
    public class TeachyDbContext : DbContext
    {
        public DbSet<UserProfile> UserProfiles { get; set; } = null!;
        public DbSet<Class> Classes { get; set; } = null!;
        public DbSet<ClassMember> ClassMembers { get; set; } = null!;

        public TeachyDbContext(DbContextOptions<TeachyDbContext> options) : base(options)
        { }
    }
}
