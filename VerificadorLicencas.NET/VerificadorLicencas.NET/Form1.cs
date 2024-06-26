

using System.Runtime.Serialization;
using System.Security.Cryptography;
using System.Text;
using VerificadorLicencas.NET.Helper;

namespace VerificadorLicencas.NET
{
    public partial class Form1 : Form
    {

        private static readonly byte[] BIv = { 0x50, 0x08, 0xF1, 0xDD, 0xDE, 0x3C, 0xF2, 0x18, 0x44, 0x74, 0x19, 0x2C, 0x53, 0x49, 0xAB, 0xBC };
        private const string CryptoKey = "KJKhkjhkasnckashLHfkjahslkfju987ombnjkaslj9=";
        private License _license = new License();
        public ExcelHelper excelHelper = new ExcelHelper();
        public Form1()
        {
            InitializeComponent();
        }

        private void btnExecutar_Click(object sender, EventArgs e)
        {
            var localArquivo = @"D:\\wesley\\myrepos\\Ferramentas.NET\\VerificadorLicencas.NET\DadosLicenša.xlsx";

            var dados = excelHelper.GetDados(localArquivo);

            for (int i = 0; i < dados.Count; i++)
            {
                var row = dados[i];

                var result = DeSerialize<License>(row.Valor, true);

                if (result != null)
                {

                    row.DataLincenciamento = result.ActivateDate;
                    row.DataFim = result.ExpireDate;
                    row.Quantidade = result.UserCount;
                }


            }


            excelHelper.GerarExcel(@"D:\\wesley\\myrepos\\Ferramentas.NET\\VerificadorLicencas.NET\Resultado.xlsx", "Result", dados);



        }

        private static T DeSerialize<T>(string objeto)
        {
            using (MemoryStream mStream = new MemoryStream(StringToUTF8ByteArray(objeto)))
            {
                DataContractSerializer dcSerializer = new DataContractSerializer(typeof(License));
                return (T)dcSerializer.ReadObject(mStream);
            }

        }

        private static T DeSerialize<T>(string objeto, bool encrypt)
        {
            return encrypt ? DeSerialize<T>(Decrypt(objeto)) : DeSerialize<T>(objeto);
        }

        // ReSharper disable once InconsistentNaming
        private static byte[] StringToUTF8ByteArray(String pXmlString)
        {
            UTF8Encoding encoding = new UTF8Encoding();
            byte[] byteArray = encoding.GetBytes(pXmlString);
            return byteArray;
        }
        

        private static string Decrypt(string texto)
        {
            try
            {
                if (!string.IsNullOrEmpty(texto))
                {
                    using (var aesAlg = Aes.Create())
                    {
                        var key = Convert.FromBase64String(CryptoKey);

                        ICryptoTransform decryptor = aesAlg.CreateDecryptor(key, BIv);

                        var bText = Convert.FromBase64String(texto);

                        using (MemoryStream msDecrypt = new MemoryStream(bText))
                        {
                            using (CryptoStream csDecrypt = new CryptoStream(msDecrypt, decryptor, CryptoStreamMode.Read))
                            {
                                using (StreamReader srDecrypt = new StreamReader(csDecrypt))
                                {
                                    return srDecrypt.ReadToEnd();
                                }
                            }
                        }
                    }
                }
                else
                    return null;
            }
            catch (Exception ex)
            {
                throw new ApplicationException("Erro ao descriptografar", ex);
            }
        }

       
    }

    [DataContract(Name = "Licensing", Namespace = "Implanta.Licensing")]
    internal class License : IExtensibleDataObject
    {
        [DataMember()]
        public string Module { get; set; }

        [DataMember()]
        public DateTime ActivateDate { get; set; }

        [DataMember()]
        public DateTime ExpireDate { get; set; }

        [DataMember()]
        public LicenseType Type { get; set; }

        [DataMember()]
        public string Version { get; set; }

        [DataMember()]
        public int UserCount { get; set; }

        public ExtensionDataObject ExtensionData { get; set; }
    }


    public enum LicenseType
    {
        Demo = 68,
        Register = 82,
        AdicionarLicensa = 76
    }
}