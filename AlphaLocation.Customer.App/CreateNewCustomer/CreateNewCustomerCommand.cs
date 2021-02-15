using AlphaLocation.Cqrs.Base.Commands;
using AlphaLocation.Customers.Domain;
using System;

namespace AlphaLocation.Customers.App.CreateNewCustomer
{
    public class CreateNewCustomerCommand : ICommand
    {
        public Gender Gender { get; set; }
        public string Firstname { get; set; }
        public string Lastname { get; set; }
        public DateTime Birthdate { get; set; }
    }
}
