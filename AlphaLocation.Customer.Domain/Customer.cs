namespace AlphaLocation.Customers.Domain
{
    public class Customer
    {
        public CustomerId Id { get; }
        public Gender Gender { get; }
        public Name Firstname { get; }
        public Name Lastname { get; }
        public Birthdate Birthdate { get; }

        public Customer(CustomerId id, Gender gender, Name firstname, Name lastname, Birthdate birthdate)
        {
            this.Id = id;
            this.Gender = gender;
            this.Firstname = firstname;
            this.Lastname = lastname;
            this.Birthdate = birthdate;
        }
    }
}
