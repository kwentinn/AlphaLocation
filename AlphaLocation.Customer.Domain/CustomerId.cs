using ValueOf;

namespace AlphaLocation.Customers.Domain
{
    public class CustomerId : ValueOf<string, CustomerId>
    {
        public static CustomerId Unset => From(null);
    }
}