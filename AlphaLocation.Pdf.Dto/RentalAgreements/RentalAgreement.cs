namespace AlphaLocation.Document.Shared.RentalAgreements
{
	public class RentalAgreement : ITemplateModel
	{
		public string RentalAgreementId { get; set; }
		public RentalClient RentalClient { get; set; }
		public Landlord Landlord { get; set; }
		public UnixEpochTimestampDate GenerationDate { get; set; }
		public Rental Rental { get; set; }
		public string TemplatePath => @"Templates\RentalAgreement.cshtml";
	}

	public class Rental
	{
		public Period Period { get; set; }
		public Amount PricePerNight { get; set; }
		public Amount JourneyTaxPricePerPerson { get; set; }
		public int NumberOfPeople { get; set; }
	}
}
