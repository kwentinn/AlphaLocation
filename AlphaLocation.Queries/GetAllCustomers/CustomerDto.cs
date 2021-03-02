using System;

namespace AlphaLocation.Queries.GetAllCustomers
{
	public class CustomerDto
	{
		public string Firstname { get; set; }
		public string Lastname { get; set; }
		public Gender Gender { get; set; }
		public SimpleDateDto Birthdate { get; set; }
        public string Comment { get; set; }
    }

	public class SimpleDateDto
    {
		public int Year { get; set; }
		public int Month { get; set; }
		public int Day { get; set; }

		public DateTime ToDateTime() => new DateTime(this.Year, this.Month, this.Day);
    }
}
