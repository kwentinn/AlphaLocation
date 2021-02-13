using SelectPdf;
using System.Threading.Tasks;

namespace AlphaLocation.Document.Pdf
{
	public class PdfService
	{
		public async Task<byte[]> RenderPdfAsync(string html)
		{
			HtmlToPdf converter = new HtmlToPdf();

			converter.Options.PdfPageSize = PdfPageSize.A4;
			converter.Options.PdfPageOrientation = PdfPageOrientation.Portrait;
			converter.Options.AutoFitHeight = HtmlToPdfPageFitMode.NoAdjustment;
			converter.Options.MarginTop = 40;

			PdfDocument doc = converter.ConvertHtmlString(html);

			byte[] bytes = doc.Save();
			doc.Close();

			return await Task.FromResult(bytes);
		}
	}
}
