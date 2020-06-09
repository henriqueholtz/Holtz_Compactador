using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web.Script.Serialization;
using System.Windows.Forms;

namespace Holtz_Compactador
{
    public class LoadExcecoes
    {
        private static List<string> ExtensoesN = new List<string>();
        private static List<string> PastasN = new List<string>();
        private static string CaminhoArquivoExt = Path.GetDirectoryName(System.AppDomain.CurrentDomain.BaseDirectory);
        public static void LimparExtensoesN()
        {
            ExtensoesN.Clear();
        }
        public static void LimparPastasN()
        {
            PastasN.Clear();
        }
        public static List<string> ParExtensoesN
        {
            get { return ExtensoesN; }
            set { ExtensoesN = value; }
        }
        public static void ParAddExtensaoN(string Item)
        {
            ExtensoesN.Add(Item);
        }
        public static void ParAddPastaN(string Item)
        {
            PastasN.Add(Item);
        }
        public static List<string> ParPastasN
        {
            get { return PastasN; }
            set { PastasN = value; }
        }
        public static void CarregaExtensoesN()
        {
            ExtensoesN.Clear();
            string caminhoArquivo = Directory.GetParent(Directory.GetParent(CaminhoArquivoExt).FullName).FullName;
            caminhoArquivo += @"\Extensoes.json";
            JavaScriptSerializer serializer = new JavaScriptSerializer();
            string json = File.ReadAllText(caminhoArquivo);
            dynamic resultado = serializer.DeserializeObject(json);
            foreach (KeyValuePair<string, object> entry in resultado)
            {
                var key = entry.Key;
                var value = entry.Value as string;
                ExtensoesN.Add(value);
            }
        }
        public static void CarregaPastasN()
        {
            PastasN.Clear();
            string caminhoArquivo = Directory.GetParent(Directory.GetParent(CaminhoArquivoExt).FullName).FullName;
            caminhoArquivo += @"\Pastas.json";
            JavaScriptSerializer serializer = new JavaScriptSerializer();
            string json = File.ReadAllText(caminhoArquivo);
            dynamic resultado = serializer.DeserializeObject(json);
            foreach (KeyValuePair<string, object> entry in resultado)
            {
                var key = entry.Key;
                var value = entry.Value as string;
                PastasN.Add(value);
            }
        }
        public static void GravaJsonExtensoes() //grava no arquivo físico
        {
            string caminhoArquivo = Directory.GetParent(Directory.GetParent(CaminhoArquivoExt).FullName).FullName;
            caminhoArquivo += @"\Extensoes.json";

            //serialize vai por aspas duplas :   "valor"
            JavaScriptSerializer serializer = new JavaScriptSerializer();
            string json = "{";
            int count = 0;
            foreach (var item in ExtensoesN)
            {
                string itemSerializer = serializer.Serialize(item);
                count += 1;
                if (count > 1) { json += ","; }
                json += "\"ExtN" + count.ToString() + "\": " + itemSerializer;
            }
            json += "}";
            File.WriteAllText(caminhoArquivo, json); //grava no arquivo físico
        }

        public static void GravaJsonPastas() //grava no arquivo físico
        {
            string caminhoArquivo = Directory.GetParent(Directory.GetParent(CaminhoArquivoExt).FullName).FullName;
            caminhoArquivo += @"\Pastas.json";

            //serialize vai por aspas duplas :   "valor"
            JavaScriptSerializer serializer = new JavaScriptSerializer();
            string json = "{";
            int count = 0;
            foreach (var item in PastasN)
            {
                string itemSerializer = serializer.Serialize(item);
                count += 1;
                if (count > 1) { json += ","; }
                json += "\"ExtN" + count.ToString() + "\": " + itemSerializer;
            }
            json += "}";
            File.WriteAllText(caminhoArquivo, json); //grava no arquivo físico
        }
    }
}
