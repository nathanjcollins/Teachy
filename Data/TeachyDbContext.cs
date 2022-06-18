using Microsoft.EntityFrameworkCore;
using System.Globalization;
using Teachy.Data.Enums;
using Teachy.Data.Models;

namespace Teachy.Data
{
    public class TeachyDbContext : DbContext
    {
        public DbSet<UserProfile> UserProfiles { get; set; } = null!;
        public DbSet<Class> Classes { get; set; } = null!;
        public DbSet<ClassMember> ClassMembers { get; set; } = null!;
        public DbSet<Resource> Resources { get; set; } = null!;
        public DbSet<Author> Authors { get; set; } = null!;
        public DbSet<Country> Countries { get; set; } = null!;

        public TeachyDbContext(DbContextOptions<TeachyDbContext> options) : base(options)
        { }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            modelBuilder.Entity<ResourceType>()
                .HasData(Enum.GetValues(typeof(ResourceTypeEnum))
                    .OfType<ResourceTypeEnum>()
                    .Select(x => new ResourceType() { Id = x, Name = x.ToString() })
                    .ToArray());

            var cultureList = new List<string>();
            var cultures = CultureInfo.GetCultures(CultureTypes.AllCultures & ~CultureTypes.NeutralCultures);

            foreach (var culture in cultures)
			{
                var region = new RegionInfo(culture.LCID);

                if (!(cultureList.Contains(region.EnglishName)))
                {
                    cultureList.Add(region.EnglishName);
                }
            }

            cultureList.Sort();
            modelBuilder.Entity<Country>()
                .HasData(cultureList.Select((val, index) => new Country { Id = index + 1, Name = val }));
        }
    }
}
