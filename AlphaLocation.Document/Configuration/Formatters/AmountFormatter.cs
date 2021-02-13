using AlphaLocation.Document.Shared.RentalAgreements;

namespace AlphaLocation.Document.Configuration.Formatters
{
	public class AmountFormatter : IAmountFormatter
	{
		private readonly IDocumentConfiguration documentConfiguration;
		public AmountFormatter(IDocumentConfiguration documentConfiguration)
		{
			this.documentConfiguration = documentConfiguration;
		}
		public string FormatAmount(Amount amount)
		{
			return amount.Value.ToString(documentConfiguration.AmountFormat);
		}
	}
}
