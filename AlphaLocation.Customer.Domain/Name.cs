using AlphaLocation.Customers.Domain.Exceptions;
using ValueOf;

namespace AlphaLocation.Customers.Domain
{
    public class Name : ValueOf<string, Name>
    {
        protected override void Validate()
        {
            if (string.IsNullOrWhiteSpace(this.Value))
            {
                throw new InvalidNameException();
            }
        }
    }
}
