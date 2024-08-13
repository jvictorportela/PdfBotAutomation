using PdfBotAutomation.Infrastructure.Services.Curriculo;
using PdfBotAutomation.Infrastructure.Services.Excel;
using PdfBotAutomation.Infrastructure.Services.Pdf;

var pdfService = new PdfServices();
var excelService = new ExcelServices();
var processorService = new CurriculoServices(pdfService, excelService);

string pdfFolder = "C:\\Users\\jvict\\Desktop\\Curriculos";
string outPutExcel = "C:\\Users\\jvict\\Desktop\\Curriculos\\CurriculosTeste";

processorService.ProcessCurriculos(pdfFolder, outPutExcel);

Console.WriteLine("Processamento concluído! Planilha gerada em: " + outPutExcel);