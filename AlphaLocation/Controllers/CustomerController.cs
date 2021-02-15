using AlphaLocation.Cqrs;
using AlphaLocation.Customers.App.CreateNewCustomer;
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

		[HttpPost]
		public async Task<IActionResult> Create([FromBody] CustomerDto customer)
        {
			await this.mediator.DispatchAsync(new CreateNewCustomerCommand()
			{
				Firstname = customer.Firstname,
				Lastname = customer.Lastname,
				Birthdate = customer.Birthdate
			});
			return this.Ok();
		}
	}
}
