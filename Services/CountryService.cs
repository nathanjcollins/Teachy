using Microsoft.EntityFrameworkCore;
using Teachy.Data;
using Teachy.Data.Models;

namespace Teachy.Services
{
	public class CountryService
	{
		private readonly TeachyDbContext _dbContext;

		public CountryService(TeachyDbContext dbContext)
		{
			_dbContext = dbContext;
		}

		public async Task<List<Country>> GetAllAsync()
		{
			return await _dbContext.Countries.ToListAsync();
		}
	}
}
