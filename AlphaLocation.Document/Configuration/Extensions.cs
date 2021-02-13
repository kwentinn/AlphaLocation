//using AlphaLocation.Document.Shared.RentalAgreements;
//using System;

//namespace AlphaLocation.Document.Configuration
//{
//	public class Extensions
//	{
//		string GetRentalAmount(RentalAgreement model)
//		{
//			decimal total = model.Rental.PricePerNight.Value * Convert.ToDecimal(model.Rental.Period.NumberOfNights);
//			string amount = FormatAmount(total);
//			return $"{amount} {model.Rental.PricePerNight.Currency}";
//		}
//		string GetTaxeDeSejourTotal(RentalAgreement model)
//		{
//			var amount = FormatAmount(model.Rental.JourneyTaxPricePerPerson.Value * Convert.ToDecimal(model.Rental.Period.NumberOfNights));
//			return $"{amount} {model.Rental.JourneyTaxPricePerPerson.Currency}";
//		}
//		string GetTaxeDeSejourPerNightAndPerPerson(RentalAgreement model)
//		{
//			var amount = FormatAmount(model.Rental.JourneyTaxPricePerPerson.Value);
//			return $"{amount} {model.Rental.JourneyTaxPricePerPerson.Currency}";
//		}

//	}
//}
