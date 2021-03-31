using AlphaLocation.Document.Configuration;
using AlphaLocation.Document.Configuration.Formatters;
using AlphaLocation.Document.Html;
using AlphaLocation.Document.Pdf;
using AlphaLocation.Pdf;
using RazorLight.Extensions;
using System;

namespace Microsoft.Extensions.DependencyInjection
{
	public static class ServiceCollectionExtensions
	{
		public static IServiceCollection AddAlphaLocationHtmlRendering(this IServiceCollection services)
		{
			services.AddRazorLight()
				.UseFileSystemProject(AppDomain.CurrentDomain.BaseDirectory)
				.UseMemoryCachingProvider();

			return services
				.AddScoped<IDocumentConfiguration, FrenchDocumentConfiguration>()
				.AddScoped<IDateFormatter, DateFormatter>()
				.AddScoped<IAmountFormatter, AmountFormatter>()
				.AddScoped<DocumentConfigurationFactory>()
				.AddScoped<PdfService>()
				.AddScoped<HtmlRenderingService>()
				.AddScoped<DocumentService>()
			;
		}
	}
}
