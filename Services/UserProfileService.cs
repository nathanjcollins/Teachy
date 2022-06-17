using Microsoft.EntityFrameworkCore;
using Teachy.Data;
using Teachy.Data.Models;

namespace Teachy.Services
{
    public class UserProfileService
    {
        private readonly TeachyDbContext _dbContext;

        public UserProfileService(TeachyDbContext dbContext)
        {
            _dbContext = dbContext;
        }

        public async Task<UserProfile?> GetByAuth0IdAsync(string auth0Id)
        {
            return await _dbContext.UserProfiles.SingleOrDefaultAsync(x => x.Auth0Id == auth0Id);
        }

        public async Task<UserProfile> UpdateAsync(UserProfile userProfile)
        {
            _dbContext.Update(userProfile);

            await _dbContext.SaveChangesAsync();

            return userProfile;
        }
    }
}
