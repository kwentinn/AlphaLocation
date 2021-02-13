using AlphaLocation.Cqrs;
using AlphaLocation.Queries.GetAllCustomers;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace AlphaLocation.Controllers
{
	[ApiController]
	[Route("api/[controller]")]
	public class CustomerController : ControllerBase
	{
		private readonly IMediatorWrapper mediator;

		public CustomerController(IMediatorWrapper mediator)
		{
			this.mediator = mediator;
		}

		[HttpGet]
		public async Task<IEnumerable<CustomerDto>> Get()
		{
			return await this.mediator.GetResultAsync(new GetAllCustomersQuery());
		}
	}
}
