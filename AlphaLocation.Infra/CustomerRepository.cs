using AlphaLocation.Customers.Domain;
using System.Linq;
using System.Threading.Tasks;

namespace AlphaLocation.Customers.Infra
{
    public class CustomerRepository : ICustomerRepository
    {
        private readonly IStore store;

        public CustomerRepository(IStore store)
        {
            this.store = store;
        }

        public async Task<Customer> GetById(CustomerId customerId)
        {
            CustomerInfra customerInfra = this.store.Customers
                .Find(c => c.Id == customerId.Value)
                .Single();

            return await Task.FromResult(new Customer
            (
                CustomerId.From(customerInfra.Id),
                (Gender)customerInfra.Gender,
                Name.From(customerInfra.Firstname),
                Name.From(customerInfra.Lastname),
                Birthdate.From(customerInfra.Birthdate)
            ));
        }

        public async Task SaveAsync(Customer customer)
        {
            await this.store.Customers.InsertOneAsync(new CustomerInfra
            {
                Id = customer.Id.Value,
                Firstname = customer.Firstname.Value,
                Lastname = customer.Lastname.Value,
                Gender = (int)customer.Gender,
                Birthdate = customer.Birthdate.Value
            });
        }
    }
}
