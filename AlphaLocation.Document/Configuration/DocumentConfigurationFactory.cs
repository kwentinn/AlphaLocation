using System;
using System.Globalization;

namespace AlphaLocation.Document.Configuration
{
	public class DocumentConfigurationFactory
	{
		public IDocumentConfiguration CreateFrom(CultureInfo cultureInfo)
			=> cultureInfo.Name switch
			{
				"fr-FR" => new FrenchDocumentConfiguration(),
				_ => throw new InvalidOperationException("Unknown culture")
			};
	}
}
