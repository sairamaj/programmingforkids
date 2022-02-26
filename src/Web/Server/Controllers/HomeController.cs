using Microsoft.AspNetCore.Mvc;
using Web.Server.Repository;
using Web.Shared;
using Web.Shared.Model;

namespace Web.Server.Controllers
{
	[ApiController]
	[Route("[controller]")]
	public class HomeController : ControllerBase
	{
		private readonly IDataRepository dataRepository;

		public HomeController(IDataRepository dataRepository)
		{
			this.dataRepository = dataRepository ?? throw new ArgumentNullException(nameof(dataRepository));
		}

        [HttpGet]
        [Route("resources/{name}")]
        public IAsyncEnumerable<Resource> GetResources(string name)
        {
			return this.dataRepository.GetResources(name);
        }
    }
}