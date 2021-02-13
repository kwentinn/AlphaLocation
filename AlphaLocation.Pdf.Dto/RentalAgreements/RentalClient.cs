namespace AlphaLocation.Document.Shared.RentalAgreements
{
	public class RentalClient
	{
		public Gender Gender { get; set; }
		public string Firstname { get; set; }
		public string Lastname { get; set; }
		public Address Address { get; set; }
		public BirthInfo BirthInfo { get; set; }
	}
}
