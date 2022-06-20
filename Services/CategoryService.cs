using Microsoft.EntityFrameworkCore;
using Teachy.Data;
using Teachy.Data.Models;

namespace Teachy.Services
{
	public class CategoryService
	{
		private readonly TeachyDbContext _dbContext;

		public CategoryService(TeachyDbContext dbContext)
		{
			_dbContext = dbContext;
		}

		public async Task<List<Category>> GetAllAsync()
		{
			return await _dbContext.Categories
				.Include(x => x.SubCategories)
				.ToListAsync();
		}
	}
}
