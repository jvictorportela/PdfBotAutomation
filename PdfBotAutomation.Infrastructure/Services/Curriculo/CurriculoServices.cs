using PdfBotAutomation.Domain.Interfaces.ICurriculo;
using PdfBotAutomation.Domain.Interfaces.IExcel;
using PdfBotAutomation.Domain.Interfaces.IPdf;

namespace PdfBotAutomation.Infrastructure.Services.Curriculo;

public class CurriculoServices : ICurriculoInterface
{
    private readonly IPdfInterface _pdfInterface;
    private readonly IExcelInterface _excelInterface;

    public CurriculoServices(IPdfInterface pdfInterface, IExcelInterface excelInterface)
    {
        _pdfInterface = pdfInterface;
        _excelInterface = excelInterface;
    }

    public void ProcessCurriculos(string pdfFolder, string outputExcel)
    {
        try
        {
            var curriculos = _pdfInterface.GetCurriculosFromFolder(pdfFolder);
            var filteredCurriculos = curriculos
                .Where(c => c.Content.Contains("superior completo"))
                .ToList();

            _excelInterface.SaveCurriculosToExcel(filteredCurriculos, outputExcel);
        }
        catch (Exception ex)
        {
            Console.WriteLine("Não possui Superior Completo");
            throw new Exception(ex.Message);
        }
    }
}
