using System;

namespace AlphaLocation.Queries.GetAllCustomers
{
	public class CustomerDto
	{
		public string Firstname { get; set; }
		public string Lastname { get; set; }
		public Gender Gender { get; set; }
		public DateTime Birthdate { get; set; }
	}
}
