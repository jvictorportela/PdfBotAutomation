PdfBotAutomation
PdfBotAutomation é um bot de automação desenvolvido em .NET que processa currículos em formato PDF, localizados em uma pasta específica, e filtra aqueles que contêm a expressão "superior completo". Os currículos selecionados são exportados para uma planilha Excel.

Funcionalidades
Lê todos os arquivos PDF de uma pasta especificada.
Extrai o conteúdo textual dos PDFs.
Filtra os currículos que contêm a frase "superior completo".
Exporta os currículos filtrados para uma planilha Excel.
Tecnologias Utilizadas
.NET
iTextSharp - Para leitura e extração de texto dos PDFs.
EPPlus - Para geração da planilha Excel.
Estrutura do Projeto
Domain: Contém as entidades e interfaces que definem as regras de negócio.
Application: Contém a lógica de aplicação e orquestração das operações.
Infrastructure: Contém as implementações concretas para leitura de PDFs e criação de planilhas Excel.
Presentation: Aplicativo de console que serve como interface de usuário para iniciar o processo.
Como Utilizar
1. Preparar o Ambiente
Certifique-se de que o .NET SDK está instalado em seu ambiente.

Clone este repositório:

git clone https://github.com/SEU_USUARIO/PdfBotAutomation.git
cd PdfBotAutomation
2. Configurar pastas de currículos e pasta de outPut para o excel
Certifique-se de por no projeto os caminhos corretos.
3. Compile e rode o projeto.
