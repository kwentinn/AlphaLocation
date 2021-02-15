using AlphaLocation.Cqrs.Base.Commands;
using System.Threading.Tasks;

namespace AlphaLocation.Commands.CreateCustomer
{
    public class CreateCustomerCommand : ICommand
    {
        public string Gender { get; set; }
        public string Firstname { get; set; }
        public string Lastname { get; set; }
        public string Comment { get; set; }
    }

    public class CreateCustomerCommandHandler : CommandHandler<CreateCustomerCommand>
    {
        public override Task HandleAsync(CreateCustomerCommand command)
        {
            throw new System.NotImplementedException();
        }
    }
}
