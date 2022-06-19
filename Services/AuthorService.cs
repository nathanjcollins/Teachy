using Microsoft.EntityFrameworkCore;
using Teachy.Data;
using Teachy.Data.Models;

namespace Teachy.Services
{
	public class AuthorService
	{
		private readonly TeachyDbContext _dbContext;

		public AuthorService(TeachyDbContext dbContext)
		{
			_dbContext = dbContext;
		}

		public async Task<List<Author>> GetAllAsync()
		{
			return await _dbContext.Authors.ToListAsync();
		}
	}
}
