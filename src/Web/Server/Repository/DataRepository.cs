using Web.Shared.Model;

namespace Web.Server.Repository
{
	public class DataRepository : IDataRepository
	{
		private readonly IWebHostEnvironment environment;

		public DataRepository(IWebHostEnvironment environment)
		{
			this.environment = environment ?? throw new ArgumentNullException(nameof(environment));
		}

		public async IAsyncEnumerable<Resource> GetResources(string name)
		{
            var homePageResources = Path.Combine(this.environment.WebRootPath, "Resources", name);
            foreach (var file in Directory.GetFiles(homePageResources, "*.MD"))
            {
                var title = Path.GetFileNameWithoutExtension(file);
                var orderInfo = title.Split('_').First();
                title = title.Substring(orderInfo.Length + 1);
                yield return new Resource
                {
                    Order = System.Convert.ToInt32(orderInfo),
                    Title = title,
                    Info = await File.ReadAllTextAsync(file)
                };
            }
        }
	}
}
