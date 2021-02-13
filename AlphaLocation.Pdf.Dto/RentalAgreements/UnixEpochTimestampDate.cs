using System;

namespace AlphaLocation.Document.Shared.RentalAgreements
{
	public class UnixEpochTimestampDate
	{
		public long Value { get; set; }

		public DateTime UtcDate => this.GetUtcDate();

		private DateTime GetUtcDate()
		{
			DateTime epoch = new DateTime(1970, 1, 1);
			return epoch.AddSeconds(this.Value).Date;
		}
	}
}
