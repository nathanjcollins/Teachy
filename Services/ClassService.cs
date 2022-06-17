using Microsoft.EntityFrameworkCore;
using Teachy.Data;
using Teachy.Data.Models;

namespace Teachy.Services
{
    public class ClassService
    {
        private readonly TeachyDbContext _dbContext;

        public ClassService(TeachyDbContext dbContext)
        {
            _dbContext = dbContext;
        }

        public async Task<Class> AddNewAsync(string name, int ownerId)
        {
            var newClass = new Class
            {
                Name = name,
                OwnerId = ownerId
            };

            _dbContext.Update(newClass);

            await _dbContext.SaveChangesAsync();

            return newClass;
        }

        public async Task<List<Class>> GetClassesByUserIdAsync(int userId)
        {
            return await _dbContext.Classes
                .Include(x => x.ClassMembers)
                .Where(x => x.OwnerId == userId || x.ClassMembers.Any(y => y.MemberId == userId))
                .ToListAsync();
        }

        public async Task<Class?> GetByIdAsync(int id)
        {
            return await _dbContext.Classes
                .Include(x => x.ClassMembers)
                    .ThenInclude(x => x.Member)
                .SingleOrDefaultAsync(x => x.Id == id);
        }
    }
}
