using System;

namespace AlphaLocation.Customers.Infra.Entities
{
    public class CustomerEntity
    {
        public string Id { get; set; }
        public string Firstname { get; set; }
        public string Lastname { get; set; }
        public int Gender { get; set; }
        public DateTime Birthdate { get; set; }
    }
}
