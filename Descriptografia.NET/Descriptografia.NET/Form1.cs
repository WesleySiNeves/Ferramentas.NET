using Descriptografia.NET.Helper;
using Implanta.Logon.Entity.Acesso;
using System.Diagnostics;
using System.Text;

namespace Descriptografia.NET
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }



        private void BtnDescriptografar_Click(object sender, EventArgs e)
        {
            List<PermissoesSistemasEntity> retorno = GetDadosDescriptografado();

            montarResultado(retorno);
        }
        private void BtnExportar_Click(object sender, EventArgs e)
        {
            List<PermissoesSistemasEntity> retorno = GetDadosDescriptografado();

            montarResultadoHTML(retorno);

        }
        private void montarResultadoHTML(List<PermissoesSistemasEntity> retorno)
        {
            StringBuilder dadosHtml = new StringBuilder();

            // Iniciar a tabela HTML
            dadosHtml.AppendLine("<html>");
            dadosHtml.AppendLine("<head>");
            dadosHtml.AppendLine("<title>Dados</title>");
            dadosHtml.AppendLine("</head>");
            dadosHtml.AppendLine("<body>");
            dadosHtml.AppendLine("<style>");
            dadosHtml.AppendLine("  table { border-collapse: collapse; width: 100%; }");
            dadosHtml.AppendLine("  th, td { border: 1px solid black; padding: 8px; text-align: left; }");
            dadosHtml.AppendLine("  th { background-color: #f0f0f0; }"); // Cor gelo
            dadosHtml.AppendLine("</style>");
            dadosHtml.AppendLine("<table>");

            int linha = 1;

            foreach (var item in retorno)
            {
                dadosHtml.AppendLine($"<tr><td colspan='4'><strong>{item.NomeSistema} - {item.AcessoString}</strong></td></tr>");

                foreach (var modulo in item.Modulos)
                {
                    dadosHtml.AppendLine($"<tr><td colspan='4'>&nbsp;&nbsp;&nbsp;<em>{modulo.Nome} - {modulo.AcessoString}</em></td></tr>");

                    foreach (var funcionalidade in modulo.Funcionalidades)
                    {
                        // Adicionar linha para a funcionalidade com a coluna "ordem"
                        dadosHtml.AppendLine($"<tr><td>{linha}</td><td>&nbsp;&nbsp;&nbsp;&nbsp;{funcionalidade.Nome}</td><td>{funcionalidade.AcessoString}</td><td></td></tr>");

                        // Alternar a cor de fundo para cada linha
                        dadosHtml.AppendLine(linha % 2 == 0 ? "<style>tr:nth-child(even) { background-color: #ffffff; }</style>" : "<style>tr:nth-child(odd) { background-color: #f0f0f0; }</style>");

                        linha++;
                    }
                }
            }

            // Fechar a tabela e o corpo do HTML
            dadosHtml.AppendLine("</table>");
            dadosHtml.AppendLine("</body>");
            dadosHtml.AppendLine("</html>");



            // Salvar o HTML em um arquivo (opcional)
            string diretorioAplicacao = AppDomain.CurrentDomain.BaseDirectory;
            string caminhoArquivo = Path.Combine(diretorioAplicacao, "exportacao.html");

            File.WriteAllText(caminhoArquivo, dadosHtml.ToString());

            var caminhoNavegador = $@"{txtDiretorioNavegador.Text.Trim()}";




            // Abrir o arquivo HTML no navegador padrão
            // Abrir o arquivo HTML no Google Chrome
            Process.Start(new ProcessStartInfo
            {
                FileName = caminhoNavegador,
                Arguments = caminhoArquivo
            });

        }

        private void montarResultado(List<PermissoesSistemasEntity> retorno)
        {
            StringBuilder dados = new StringBuilder();

            foreach (var item in retorno)
            {
                dados.AppendLine($"{item.NomeSistema} - {item.AcessoString}");

                foreach (var modulo in item.Modulos)
                {
                    dados.AppendLine($"{modulo.Nome} - {modulo.AcessoString}");
                    foreach (var funcionalidade in modulo.Funcionalidades)
                    {
                        dados.AppendLine($"{funcionalidade.Nome} - {funcionalidade.AcessoString}");

                    }
                }
            }

            txtTextoDescriptografado.Text = dados.ToString();

        }







        private List<PermissoesSistemasEntity> GetDadosDescriptografado()
        {
            HelperDescriptografia helper = new HelperDescriptografia();

            var texto = TextoCriptografado;


            bool tipoPermissaoUsuario = true;


            var retorno = helper.Descriptogradar(texto, tipoPermissaoUsuario);
            return retorno;
        }

        public string TextoCriptografado
        {
            get
            {

                return TxtTextoCriptografado.Text;
            }

            set
            {
                TxtTextoCriptografado.Text = value;
            }
        }

        public string TextoDesCriptografado
        {
            get
            {

                return txtTextoDescriptografado.Text;
            }

            set
            {
                txtTextoDescriptografado.Text = value;
            }
        }
    }
}