using iTextSharp.text.pdf;
using iTextSharp.text.pdf.parser;
using PdfBotAutomation.Domain.Entities;
using PdfBotAutomation.Domain.Interfaces.IPdf;
using System.Text;
using Path = System.IO.Path;

namespace PdfBotAutomation.Infrastructure.Services.Pdf;

public class PdfServices : IPdfInterface
{
    public string ExtractTextFromPdf(string pdfPath)
    {
        using (PdfReader reader = new PdfReader(pdfPath))
        {
            StringBuilder text = new StringBuilder();

            for (int i = 1; i <= reader.NumberOfPages; i++)
            {
                text.Append(PdfTextExtractor.GetTextFromPage(reader, i));
            }

            return text.ToString();
        }
    }

    public IEnumerable<Domain.Entities.Curriculo> GetCurriculosFromFolder(string folderPath)
    {
        try
        {
            if (folderPath is null)
            {
                throw new ArgumentNullException("Caminho da pasta é nulo!");
            }

            var files = Directory.GetFiles(folderPath, "*.pdf");
            var curriculos = new List<Domain.Entities.Curriculo>();

            foreach (var file in files)
            {
                var content = ExtractTextFromPdf(file);
                curriculos.Add(new Domain.Entities.Curriculo
                {
                    Name = Path.GetFileName(file),
                    Content = content,
                    FilePath = file
                });

                Console.WriteLine($"Currículo {file} extraído.");

                if (content is null)
                {
                    Console.WriteLine($"Conteúdo nulo");
                }
            }

            return curriculos;
        }
        catch (Exception ex)
        {
            throw new Exception(ex.Message);
        }
    }
}
