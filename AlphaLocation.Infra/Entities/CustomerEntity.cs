using System;

namespace AlphaLocation.Customers.Infra.Entities
{
    public class CustomerEntity
    {
        public string Id { get; set; }
        public string Firstname { get; set; }
        public string Lastname { get; set; }
        public Domain.Gender Gender { get; set; }
        public DateTime? Birthdate { get; set; }
        public string Comment { get; set; }
    }
}
