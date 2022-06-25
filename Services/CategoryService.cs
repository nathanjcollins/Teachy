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

		public async Task<List<Category>> GetTop10Async()
		{
			var categoryIds = await _dbContext.Resources
				.Include(x => x.SubCategory)
				.ThenInclude(x => x.Category)
				.GroupBy(x => x.SubCategory.CategoryId)
				.Select(x => new { CategoryId = x.Key, Count = x.Count() })
				.OrderByDescending(x => x.Count)
				.Take(10)
				.Select(x => x.CategoryId)
				.ToListAsync();

			return await _dbContext.Categories.Where(x => categoryIds.Contains(x.Id)).ToListAsync();
		}

		public async Task<Category> AddIfDoesNotExistAsync(string name)
		{
			var category = await _dbContext.Categories
				.FirstOrDefaultAsync(x => x.Name == name);

			if (category is null)
			{
				category = new Category
				{
					Name = name
				};

				_dbContext.Categories.Update(category);
				await _dbContext.SaveChangesAsync();
			}

			return category;
		}

		public async Task<SubCategory> AddSubCategoryIfDoesNotExistAsync(string name, int categoryId)
		{
			var subCategory = await _dbContext.SubCategories
				.SingleOrDefaultAsync(x => x.Name == name && x.CategoryId == categoryId);

			if (subCategory is null)
			{
				subCategory = new SubCategory
				{
					Name = name,
					CategoryId = categoryId
				};
				
				_dbContext.SubCategories.Update(subCategory);
				await _dbContext.SaveChangesAsync();
			}

			return subCategory;
		}
	}
}
