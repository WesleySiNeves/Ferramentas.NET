using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VerificadorLicencas.NET.Helper
{
    public class InformacaoArquivo 
    {

        public InformacaoArquivo()
        {

        }

        public string Cliente { get; set; }


        public string Sistema { get; set; }


        public string Configuracao { get; set;}


        public string Valor { get; set; }


        public DateTime? DataLincenciamento { get; set; }

        public DateTime? DataFim { get; set; }


        public int? Quantidade { get; set; }

    }

   
}
