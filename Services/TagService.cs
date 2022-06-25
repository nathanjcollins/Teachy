using Microsoft.EntityFrameworkCore;
using Teachy.Data;
using Teachy.Data.Models;

namespace Teachy.Services;

public class TagService
{
    private readonly TeachyDbContext _dbContext;

    public TagService(TeachyDbContext dbContext)
    {
        _dbContext = dbContext;
    }

    public async Task<List<Tag>> GetAllAsync()
    {
        return await _dbContext.Tags.ToListAsync();
    }

    public async Task<List<Tag>> GetTop10Async()
    {
        var tagIds = await _dbContext.ResourceTags
            .GroupBy(x => x.TagId)
            .Select(x => new { TagId = x.Key, Count = x.Count() })
            .OrderByDescending(x => x.Count)
            .Take(10)
            .Select(x => x.TagId)
            .ToListAsync();
        
        return _dbContext.Tags.Where(x => tagIds.Contains(x.Id)).ToList();
    }
    
    public async Task<List<Tag>> AddIfDoesNotExistAsync(List<string> tagNames)
    {
        var existingTags = await _dbContext.Tags.ToListAsync();
        var tags = new List<Tag>();
        foreach (var tag in tagNames)
        {
            var existingTag = existingTags.FirstOrDefault(t => t.Name == tag);
            
            existingTag ??= new Tag { Name = tag };
            tags.Add(existingTag);
        }

        await _dbContext.Tags.AddRangeAsync(tags.Where(x => x.Id == 0));
        await _dbContext.SaveChangesAsync();
        return tags;
    }
    
    public async Task<List<ResourceTag>> UpdateResourceTagsAsync(int resourceId, List<int> tagIds)
    {
        var resourceTags = await _dbContext.ResourceTags.Where(x => x.ResourceId == resourceId).ToListAsync();
        var tagsToAdd = tagIds.Except(resourceTags.Select(x => x.TagId));
        var tagsToRemove = resourceTags.Select(x => x.TagId).Except(tagIds);
        
        foreach (var tagId in tagsToAdd)
        {
            _dbContext.ResourceTags.Add(new ResourceTag { ResourceId = resourceId, TagId = tagId });
        }
        
        foreach (var tagId in tagsToRemove)
        {
            var resourceTag = resourceTags.Single(x => x.TagId == tagId);
            _dbContext.ResourceTags.Remove(resourceTag);
        }
        
        await _dbContext.SaveChangesAsync();
        return await _dbContext.ResourceTags.Where(x => x.ResourceId == resourceId).ToListAsync();
    }
}