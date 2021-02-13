using AlphaLocation.Document.Shared.RentalAgreements;

namespace AlphaLocation.Document.Configuration.Formatters
{
	public class DateFormatter : IDateFormatter
	{
		private readonly IDocumentConfiguration documentConfiguration;
		public DateFormatter(IDocumentConfiguration documentConfiguration)
		{
			this.documentConfiguration = documentConfiguration;
		}
		public string Format(UnixEpochTimestampDate timestamp)
		{
			return timestamp.UtcDate.ToString(this.documentConfiguration.DateFormat);
		}
	}
}
