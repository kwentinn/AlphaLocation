using System;

namespace AlphaLocation.Document.Shared.RentalAgreements
{
	public class Period
	{
		public UnixEpochTimestampDate Start { get; set; }
		public UnixEpochTimestampDate End { get; set; }
		public int NumberOfNights => this.GetNumberOfNights();

		private int GetNumberOfNights()
		{
			return Convert.ToInt32((this.End.UtcDate.Date - this.Start.UtcDate.Date).TotalDays);
		}
	}
}
