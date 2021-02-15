using AlphaLocation.Cqrs.Base.Queries;
using AlphaLocation.Customers.Infra;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AlphaLocation.Queries.GetAllCustomers
{
	public class GetAllCustomersQueryHandler : QueryHandler<GetAllCustomersQuery, IEnumerable<CustomerDto>>
	{
        private readonly IStore store;

        public GetAllCustomersQueryHandler(IStore store)
        {
            this.store = store;
        }

		public async override Task<IEnumerable<CustomerDto>> HandleAsync(GetAllCustomersQuery query)
		{
			return await Task.FromResult(this.store.Customers
				.AsQueryable()
				.ToList()
				.Select(c => new CustomerDto
				{
					Firstname = c.Firstname,
					Lastname = c.Lastname,
					Gender = (Gender)c.Gender
				})
				.ToList());
		}

		//private static IEnumerable<CustomerDto> GetCustomers()
		//{
		//	yield return new CustomerDto
		//	{
		//		Firstname = "José",
		//		Lastname = "Galiéni",
		//		Gender = Gender.Male
		//	};
		//	yield return new CustomerDto
		//	{
		//		Firstname = "Jules",
		//		Lastname = "Patrimoni",
		//		Gender = Gender.Male
		//	};
		//	yield return new CustomerDto
		//	{
		//		Firstname = "Jean-Pierre",
		//		Lastname = "Castaldi",
		//		Gender = Gender.Male
		//	};
		//	yield return new CustomerDto
		//	{
		//		Firstname = "Jacqueline",
		//		Lastname = "Imbert",
		//		Gender = Gender.Female
		//	};
		//	yield return new CustomerDto
		//	{
		//		Firstname = "Dominique",
		//		Lastname = "Dimanche",
		//		Gender = Gender.Female
		//	};
		//}

	}
}
