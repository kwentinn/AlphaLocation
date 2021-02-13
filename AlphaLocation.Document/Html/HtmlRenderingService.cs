using AlphaLocation.Document.Shared;
using AlphaLocation.Document.Shared.RentalAgreements;
using RazorLight;
using System;
using System.Threading.Tasks;

namespace AlphaLocation.Document.Html
{
	public class HtmlRenderingService
	{
		private readonly IRazorLightEngine engine;

		public HtmlRenderingService(IRazorLightEngine engine)
		{
			this.engine = engine;
		}

		public async Task<string> RenderAsync(ITemplateModel model)
		{
			if (model is RentalAgreement rentalAgreement)
			{
				return await this.engine.CompileRenderAsync(model.TemplatePath, rentalAgreement);
			}
			throw new InvalidOperationException("Unknown model");
		}
	}
}
