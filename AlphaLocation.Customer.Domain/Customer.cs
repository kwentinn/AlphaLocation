namespace AlphaLocation.Customers.Domain
{
    public class Customer
    {
        public CustomerId Id { get; }
        public Gender Gender { get; }
        public Name Firstname { get; }
        public Name Lastname { get; }
        public Birthdate Birthdate { get; }
        public string Comment { get; }

        #region Constructors & factories

        private Customer(CustomerId id, Gender gender, Name firstname, Name lastname, Birthdate birthdate, string comment)
        {
            this.Id = id;
            this.Gender = gender;
            this.Firstname = firstname;
            this.Lastname = lastname;
            this.Birthdate = birthdate;
            this.Comment = comment;
        }

        /// <summary>
        /// Registers a new customer
        /// </summary>
        /// <param name="gender"></param>
        /// <param name="firstname"></param>
        /// <param name="lastname"></param>
        /// <param name="birthdate"></param>
        /// <param name="comment"></param>
        /// <returns></returns>
        public static Customer Register(Gender gender, Name firstname, Name lastname, Birthdate birthdate, string comment)
        {
            return new Customer(CustomerId.Unset, gender, firstname, lastname, birthdate, comment);
        }

        /// <summary>
        /// Rehydrate a customer from the persistence layer.
        /// </summary>
        /// <param name="id"></param>
        /// <param name="gender"></param>
        /// <param name="firstname"></param>
        /// <param name="lastname"></param>
        /// <param name="birthdate"></param>
        /// <param name="comment"></param>
        /// <returns></returns>
        public static Customer Rehydrate(CustomerId id, Gender gender, Name firstname, Name lastname, Birthdate birthdate, string comment)
        {
            return new Customer(id, gender, firstname, lastname, birthdate, comment);
        }
        
        #endregion
    }
}
