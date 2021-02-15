using System.Threading.Tasks;

namespace AlphaLocation.Customers.Domain
{
    public interface ICustomerRepository
    {
        Task SaveAsync(Customer customer);
    }
}
