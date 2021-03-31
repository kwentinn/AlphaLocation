using AlphaLocation.Document.Html;
using AlphaLocation.Document.Shared.RentalAgreements;
using Microsoft.AspNetCore.Mvc;
using System.Threading.Tasks;

namespace AlphaLocation.Pdf.Api.Controllers
{
	[ApiController]
	[Route("[controller]")]
	public class DocumentController : ControllerBase
	{
		private readonly DocumentService documentService;
		private readonly HtmlRenderingService htmlRenderingService;

		public DocumentController(DocumentService documentService, HtmlRenderingService htmlRenderingService)
		{
			this.documentService = documentService;
			this.htmlRenderingService = htmlRenderingService;
		}

		[HttpPost]
		public async Task<IActionResult> GenerateDocument([FromBody]RentalAgreement rentalAgreement)
		{
			return new FileContentResult
			(
				await this.documentService.RenderDocumentAsync(rentalAgreement),
				"application/pdf"
			);
		}

		[HttpPost]
		[Route("html")]
		public async Task<IActionResult> GenerateHtmlDocument([FromBody]RentalAgreement rentalAgreement)
		{
			return this.Ok(await this.htmlRenderingService.RenderAsync(rentalAgreement));
		}
	}
}
