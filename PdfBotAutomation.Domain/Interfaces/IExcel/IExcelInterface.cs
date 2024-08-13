using PdfBotAutomation.Domain.Entities;

namespace PdfBotAutomation.Domain.Interfaces.IExcel;

public interface IExcelInterface
{
    void SaveCurriculosToExcel(IEnumerable<Curriculo> curriculos, string filePath);
}
