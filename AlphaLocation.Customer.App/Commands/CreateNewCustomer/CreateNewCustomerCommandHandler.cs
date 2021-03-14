using AlphaLocation.Cqrs.Base.Commands;
using AlphaLocation.Customers.Domain;
using System;
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
            Customer customer = Customer.Register 
            (
                command.Gender,
                Name.From(command.Firstname),
                Name.From(command.Lastname),
                GetBirthdate(command),
                command.Comment
            );
            await this.customerRepository.SaveAsync(customer);
        }

        private static Birthdate GetBirthdate(CreateNewCustomerCommand command)
        {
            return command.Birthdate.HasValue ? Birthdate.From(command.Birthdate) : null;
        }
    }
}
