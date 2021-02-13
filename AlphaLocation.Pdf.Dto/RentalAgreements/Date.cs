using System;

namespace AlphaLocation.Document.Shared.RentalAgreements
{
	public class Date
	{
		public int Year { get; set; }
		public int Month { get; set; }
		public int Day { get; set; }

		public string ToString(string format)
			 => format switch
			 {
				 "dd/MM/yyyy" => $"{this.AddPadding(this.Day)}/{this.AddPadding(this.Month)}/{this.Year}",
				 _ => throw new InvalidOperationException("Unknown format")
			 };
		private string AddPadding(int input)
		{
			return input.ToString().PadLeft(2, '0');
		}
	}
}
