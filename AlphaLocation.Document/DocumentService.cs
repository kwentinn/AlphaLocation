using AlphaLocation.Document.Html;
using AlphaLocation.Document.Pdf;
using AlphaLocation.Document.Shared;
using System.Threading.Tasks;

namespace AlphaLocation.Pdf
{
	public class DocumentService
	{
		private readonly PdfService pdfService;
		private readonly HtmlRenderingService htmlRenderingService;

		public DocumentService(PdfService pdfService, HtmlRenderingService htmlRenderingService)
		{
			this.pdfService = pdfService;
			this.htmlRenderingService = htmlRenderingService;
		}

		public async Task<byte[]> RenderDocumentAsync(ITemplateModel templateModel)
		{
			string html = await this.htmlRenderingService.RenderAsync(templateModel);
			return await this.pdfService.RenderPdfAsync(html);
		}
	}
}
