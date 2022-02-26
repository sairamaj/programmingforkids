using Web.Shared.Model;

namespace Web.Server.Repository
{
	public interface IDataRepository
	{
		IAsyncEnumerable<Resource> GetResources(string name);
	}
}
