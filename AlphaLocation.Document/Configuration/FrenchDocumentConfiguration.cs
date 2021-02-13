namespace AlphaLocation.Document.Configuration
{
	public class FrenchDocumentConfiguration : IDocumentConfiguration
	{
		public string DateFormat => "dd/MM/yyyy";
		public string AmountFormat => "F2";
	}
}
