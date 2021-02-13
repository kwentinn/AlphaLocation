using AlphaLocation.Document.Shared.RentalAgreements;

namespace AlphaLocation.Document.Configuration.Formatters
{
	public interface IAmountFormatter
	{
		string FormatAmount(Amount amount);
	}
}
