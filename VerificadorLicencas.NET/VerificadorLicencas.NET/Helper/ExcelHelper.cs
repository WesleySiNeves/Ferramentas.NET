using ClosedXML.Excel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VerificadorLicencas.NET.Helper
{
    public class ExcelHelper
    {
        public List<InformacaoArquivo> GetDados(string caminho)
        {
            List<InformacaoArquivo> dados = new List<InformacaoArquivo>();

            try
            {
                using (var workbook = new XLWorkbook(caminho))
                {
                    var worksheet = workbook.Worksheet(1); // Assume que os dados estão na primeira planilha

                    var rowCount = worksheet.RowsUsed().Count();

                    for (int i = 2; i <= rowCount; i++)
                    {
                        InformacaoArquivo informacao = new InformacaoArquivo
                        {
                            //Popule as propriedades da classe InformacaoArquivo conforme a estrutura do seu arquivo Excel
                            //Exemplo:
                            Cliente = worksheet.Cell(i, 1).Value.ToString(),
                            Sistema = worksheet.Cell(i, 2).Value.ToString(),
                            Configuracao = worksheet.Cell(i, 3).Value.ToString(),
                            Valor = worksheet.Cell(i, 4).Value.ToString()
                        };

                        dados.Add(informacao);
                    }
                }

                Console.WriteLine("Dados lidos com sucesso do arquivo Excel.");
            }
            catch (Exception ex)
            {
                Console.WriteLine("Erro ao ler dados do arquivo Excel: " + ex.Message);
            }

            return dados;
        }


        public void GerarExcel(string caminho, string sheetName, List<InformacaoArquivo> dados)
        {
            // Cria um novo arquivo Excel
            var file = new FileInfo(caminho);



            using (var workbook = new XLWorkbook())
            {
                var planilha = workbook.Worksheets.Add(sheetName);
                // Cria uma nova planilha chamada "inconsistencias"



                planilha.Cell("A1").Value = "Cliente";
                planilha.Cell("B1").Value = "Sistema";
                planilha.Cell("C1").Value = "Configuracao";
                planilha.Cell("D1").Value = "DataLicenciamento";
                planilha.Cell("E1").Value = "DataTermino";
                planilha.Cell("F1").Value = "QuantidadeLicenca";


                var iterador = 2;
                foreach (var registro in dados)
                {
                    planilha.Cells("A" + iterador.ToString()).Value = registro.Cliente.ToString();
                    planilha.Cells("B" + iterador.ToString()).Value = registro.Sistema.ToString();
                    planilha.Cells("C" + iterador.ToString()).Value = registro.Configuracao.ToString();
                    planilha.Cells("D" + iterador.ToString()).Value = registro.DataLincenciamento.ToString();
                    planilha.Cells("E" + iterador.ToString()).Value = registro.DataFim.ToString();
                    planilha.Cells("F" + iterador.ToString()).Value = registro.Quantidade.ToString();



                    iterador++;
                }

                // Salva o arquivo Excel
                workbook.SaveAs(caminho);
            }

            Console.WriteLine("Arquivo Excel criado com sucesso.");
        }


    }
}
