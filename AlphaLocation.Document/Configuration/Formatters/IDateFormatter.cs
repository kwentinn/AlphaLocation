using AlphaLocation.Document.Shared.RentalAgreements;

namespace AlphaLocation.Document.Configuration.Formatters
{
	public interface IDateFormatter
	{
		string Format(UnixEpochTimestampDate timestamp);
	}
}