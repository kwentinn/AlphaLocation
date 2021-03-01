using AlphaLocation.Cqrs.Base.Commands;
using AlphaLocation.Customers.Domain;
using System.Threading.Tasks;

namespace AlphaLocation.Customers.App.Commands.CreateNewCustomer
{
    public class CreateNewCustomerCommandHandler : CommandHandler<CreateNewCustomerCommand>
    {
        private readonly ICustomerRepository customerRepository;

        public CreateNewCustomerCommandHandler(ICustomerRepository customerRepository)
        {
            this.customerRepository = customerRepository;
        }

        public override async Task HandleAsync(CreateNewCustomerCommand command)
        {
            Customer customer = new Customer(
                CustomerId.Unset,
                command.Gender,
                Name.From(command.Firstname),
                Name.From(command.Lastname),
                Birthdate.From(command.Birthdate));
            await this.customerRepository.SaveAsync(customer);
        }
    }
}
