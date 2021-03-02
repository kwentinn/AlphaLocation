using AlphaLocation.Cqrs.Base.Queries;
using AlphaLocation.Customers.Infra.Stores;
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
                    Gender = (Queries.GetAllCustomers.Gender)c.Gender
                })
                .ToList());
        }
    }
}
