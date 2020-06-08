using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Web.Script.Serialization;
using Nevron.Nov.Diagram.Shapes;

namespace Holtz_Compacta
{
    public class LoadConfig
    {
        private static string CaminhoOrigem;
        private static string CaminhoDestino;
        private static string CaminhoTemp;
        private static string NomeArquivo;
        private static string Tipo;
        private static bool IsErro;
        //arquivo que nao vao ser copiados, ex: .txt
        //pastas que não vão ser copiados, exemplo publictemp
        private static string CaminhoArquivoExt = Path.GetDirectoryName(System.AppDomain.CurrentDomain.BaseDirectory);
        public static string ParCaminhoOrigem
        {
            get { return CaminhoOrigem; }
            set { CaminhoOrigem = value; }
        }
        public static string ParCaminhoDestino
        {
            get { return CaminhoDestino; }
            set { CaminhoDestino = value; }
        }
        public static string ParCaminhoTemp
        {
            get { return CaminhoTemp; }
            set { CaminhoTemp = value; }
        }
        public static string ParNomeArquivo
        {
            get { return NomeArquivo; }
            set { NomeArquivo = value; }
        }
        public static string ParTipo
        {
            get { return Tipo; }
            set { Tipo = value; }
        }
        public static bool ParIsErro
        {
            get { return IsErro; }
            set { IsErro = value; }
        }

        public static void CarregaJson()
        {
            string caminhoArquivo = Directory.GetParent(Directory.GetParent(CaminhoArquivoExt).FullName).FullName;
            caminhoArquivo += @"\Config.json";
            JavaScriptSerializer serializer = new JavaScriptSerializer();
            string json = File.ReadAllText(caminhoArquivo);
            dynamic resultado = serializer.DeserializeObject(json);
            foreach (KeyValuePair<string, object> entry in resultado)
            {
                var key = entry.Key;
                var value = entry.Value as string;
                switch (key)
                {
                    case "CaminhoOrigem":
                        CaminhoOrigem = String.Format("{1}", key, value);
                        break;
                    case "CaminhoDestino":
                        CaminhoDestino = String.Format("{1}", key, value);
                        break;
                    case "NomeArquivo":
                        NomeArquivo = String.Format("{1}", key, value);
                        break;
                    case "Tipo":
                        Tipo = String.Format("{1}",key, value);
                        break;
                    case "CaminhoTemp":
                        CaminhoTemp = String.Format("{1}", key, value);
                        break;
                }
            }
        }

        public static void GravaJson()
        {
            string caminhoArquivo = Directory.GetParent(Directory.GetParent(CaminhoArquivoExt).FullName).FullName;
            caminhoArquivo += @"\Config.json";

            //serialize vai por aspas duplas :   "valor"
            JavaScriptSerializer serializer = new JavaScriptSerializer();
            string ParCaminhoOrigem  = serializer.Serialize(CaminhoOrigem);
            string ParCaminhoDestino = serializer.Serialize(CaminhoDestino);
            string ParCaminhoTemp    = serializer.Serialize(CaminhoTemp);
            string ParNomeArquivo    = serializer.Serialize(NomeArquivo);
            string ParTipo           = serializer.Serialize(Tipo);

            string json = "{" + 
                "\"Tipo\": "           + ParTipo           + ", " +
                "\"CaminhoOrigem\": "  + ParCaminhoOrigem  + ", " +
                "\"CaminhoDestino\": " + ParCaminhoDestino + ", " +
                "\"NomeArquivo\": "    + ParNomeArquivo    + ", " +
                "\"CaminhoTemp\": "    + ParCaminhoTemp +
                "}";

            File.WriteAllText(caminhoArquivo, json); //Grava no arquivo físico
        }
    }
}
