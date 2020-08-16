using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Web.Script.Serialization;

namespace Holtz_Compactador
{
    public class LoadExcecoes
    {
        private static List<string> ExtensoesN = new List<string>();
        private static List<string> PastasN = new List<string>();
        private static string CaminhoArquivoExt = Path.GetDirectoryName(System.AppDomain.CurrentDomain.BaseDirectory);
        public static void ClearAll()
        {
            ExtensoesN.Clear();
            PastasN.Clear();
        }
        public static void LoadAll()
        {
            CarregaExtensoesN();
            CarregaPastasN();
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

        public static void Start()
        {
            ClearAll();
            CarregaExtensoesN();
            CarregaPastasN();
        }
        private static void CarregaExtensoesN()
        {
            ExtensoesN.Clear();
            string caminhoArquivo = Directory.GetParent(Directory.GetParent(CaminhoArquivoExt).FullName).FullName;
            caminhoArquivo += @"\Extensoes.json";
            if (!File.Exists(caminhoArquivo))  //Caso não tenha o Config.json 
            {
                using (FileStream fs = File.Create(caminhoArquivo)) { }
            }
            else //só carrega se já tinha o Extensoes.json
            {
                JavaScriptSerializer serializer = new JavaScriptSerializer();
                using (StreamReader sr = File.OpenText(caminhoArquivo))
                {
                    string json = sr.ReadToEnd();
                    if (json.Length > 2) //evitar que o json esteja vazio
                    {
                        dynamic resultado = serializer.DeserializeObject(json);
                        foreach (KeyValuePair<string, object> entry in resultado)
                        {
                            var key = entry.Key;
                            var value = entry.Value as string;
                            ExtensoesN.Add(value);
                        }
                    }
                    sr.Close();
                    sr.Dispose();
                }
            }
        }
        private static void CarregaPastasN()
        {
            PastasN.Clear();
            string caminhoArquivo = Directory.GetParent(Directory.GetParent(CaminhoArquivoExt).FullName).FullName;
            caminhoArquivo += @"\Pastas.json";
            if (!File.Exists(caminhoArquivo))
            {
                using (FileStream fs = File.Create(caminhoArquivo)) { }
            }
            else //só carrega se já tinha o Pastas.json
            {
                JavaScriptSerializer serializer = new JavaScriptSerializer();
                using (StreamReader sr = File.OpenText(caminhoArquivo))
                {
                    string json = sr.ReadToEnd();
                    if (json.Length > 2) //evitar que o json esteja vazio
                    {
                        dynamic resultado = serializer.DeserializeObject(json);
                        foreach (KeyValuePair<string, object> entry in resultado)
                        {
                            var key = entry.Key;
                            var value = entry.Value as string;
                            PastasN.Add(value);
                        }
                    }
                    sr.Close();
                    sr.Dispose();
                }
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

            using (StreamWriter sr = new StreamWriter(caminhoArquivo))
            {
                sr.Write(json);
            }
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
            using (StreamWriter sr = new StreamWriter(caminhoArquivo))
            {
                sr.Write(json);
            }
           
        }
    }
}
