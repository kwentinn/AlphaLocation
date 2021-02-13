using AlphaLocation.Cqrs.Base.Queries;
using System.Collections.Generic;

namespace AlphaLocation.Queries.GetAllCustomers
{
	public class GetAllCustomersQuery : IQuery<IEnumerable<CustomerDto>>
	{
	}
}
