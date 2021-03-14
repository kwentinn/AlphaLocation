using AlphaLocation.Customers.Domain;
using AlphaLocation.Customers.Infra.Entities;
using AlphaLocation.Customers.Infra.Stores;
using System;
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

        public async Task<Customer> GetByIdAsync(CustomerId customerId)
        {
            CustomerEntity entity = GetEntityById(customerId);
            return await Task.FromResult(Customer.Rehydrate
            (
                CustomerId.From(entity.Id),
                entity.Gender,
                Name.From(entity.Firstname),
                Name.From(entity.Lastname),
                Birthdate.From(entity.Birthdate),
                entity.Comment
            ));
        }

        private CustomerEntity GetEntityById(CustomerId customerId)
        {
            return this.store.Customers
                .Find(c => c.Id == customerId.Value)
                .Single();
        }

        public async Task SaveAsync(Customer customer)
        {
            await this.store.Customers.InsertOneAsync(new CustomerEntity
            {
                Id = customer.Id.Value,
                Firstname = customer.Firstname.Value,
                Lastname = customer.Lastname.Value,
                Gender = customer.Gender,
                Birthdate = GetBirthdate(customer),
                Comment = customer.Comment
            });
        }

        private static DateTime? GetBirthdate(Customer customer)
        {
            if (customer.Birthdate == null)
            {
                return null;
            }
            return customer.Birthdate.Value;
        }
    }
}
