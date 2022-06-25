using Microsoft.EntityFrameworkCore;
using Teachy.Data;
using Teachy.Data.Models;
using Teachy.Pages.Resources.Models;

namespace Teachy.Services;

public class ResourceService
{
    private readonly TeachyDbContext _dbContext;
    private readonly AuthorService _authorService;
    private readonly CategoryService _categoryService;
    private readonly TagService _tagService;

    public ResourceService(TeachyDbContext dbContext, TagService tagService, AuthorService authorService, CategoryService categoryService)
    {
        _dbContext = dbContext;
        _tagService = tagService;
        _authorService = authorService;
        _categoryService = categoryService;
    }
    
    public async Task<List<Resource>> GetAllResourcesAsync()
    {
        return await _dbContext.Resources
            .Include(x => x.Author)
            .Include(x => x.SubCategory)
                .ThenInclude(x => x.Category)
            .Include(x => x.ResourceTags)
                .ThenInclude(x => x.Tag)
            .ToListAsync();
    }

    public async Task<Resource> GetByIdAsync(int id)
    {
        return await _dbContext.Resources
            .Include(x => x.Author)
            .Include(x => x.SubCategory)
                .ThenInclude(x => x.Category)
            .Include(x => x.ResourceTags)
                .ThenInclude(x => x.Tag)
            .SingleAsync(x => x.Id == id);
    }

    public async Task<Resource> AddNewAsync(ResourceViewModel model)
    {
        var category = await _categoryService.AddIfDoesNotExistAsync(model.CategoryName);
        var subCategory = await _categoryService.AddSubCategoryIfDoesNotExistAsync(model.SubCategoryName, category.Id);
        var tagIds = (await _tagService.AddIfDoesNotExistAsync(model.Tags)).Select(x => x.Id).ToList();
        var author = await _authorService.UpdateAsync(model.Author);

        var resource = new Resource
        {
            Name = model.Name,
            SubCategoryId = subCategory.Id,
            AuthorId = author.Id,
            Uri = model.Uri,
            ResourceTypeId = model.ResourceType,
            Id = model.Id ?? 0
        };

        _dbContext.Resources.Update(resource);
        await _dbContext.SaveChangesAsync();
        await _tagService.UpdateResourceTagsAsync(resource.Id, tagIds);
        
        return await GetByIdAsync(resource.Id);
    }
}