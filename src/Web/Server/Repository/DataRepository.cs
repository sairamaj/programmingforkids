using Web.Shared.Model;

namespace Web.Server.Repository
{
	public class DataRepository : IDataRepository
	{
		public DataRepository()
		{
		}

		public async IAsyncEnumerable<Resource> GetResources(string name)
		{
			for (var i = 0; i < 4; i++)
			{
				yield return new Resource
				{
					Order = i + 1,
					Title = $"resouce_{i}",
					Info = $"This is resource: {i}" 
				};
			}
		}
	}
}
