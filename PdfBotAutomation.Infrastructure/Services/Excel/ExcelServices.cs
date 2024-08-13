using OfficeOpenXml;
using PdfBotAutomation.Domain.Interfaces.IExcel;

namespace PdfBotAutomation.Infrastructure.Services.Excel;

public class ExcelServices : IExcelInterface
{
    public void SaveCurriculosToExcel(IEnumerable<Domain.Entities.Curriculo> curriculos, string filePath)
    {
        using (var package = new ExcelPackage())
        {
            var worksheet = package.Workbook.Worksheets.Add("Curriculos");
            worksheet.Cells[1, 1].Value = "Nome do Arquivo";
            worksheet.Cells[1, 2].Value = "Conteúdo";

            int row = 2;
            foreach (var curriculo in curriculos)
            {
                worksheet.Cells[row, 1].Value = curriculo.Name;
                worksheet.Cells[row, 2].Value = curriculo.Content;
                row++;
            }

            package.SaveAs(new FileInfo(filePath));
        }
    }
}
