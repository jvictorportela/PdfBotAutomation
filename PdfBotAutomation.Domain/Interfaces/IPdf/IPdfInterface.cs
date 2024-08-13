using PdfBotAutomation.Domain.Entities;

namespace PdfBotAutomation.Domain.Interfaces.IPdf;

public interface IPdfInterface
{
    IEnumerable<Curriculo> GetCurriculosFromFolder(string folderPath);
    string ExtractTextFromPdf(string pdfPath);
}
