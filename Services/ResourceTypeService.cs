using Teachy.Data.Enums;
using Teachy.Data.Models;

namespace Teachy.Services
{
	public class ResourceTypeService
	{
		public List<ResourceType> GetAll()
		{
			return Enum.GetValues(typeof(ResourceTypeEnum))
				.OfType<ResourceTypeEnum>()
				.Select(x => new ResourceType() { Id = x, Name = x.ToString() })
				.ToList();
		}
	}
}
