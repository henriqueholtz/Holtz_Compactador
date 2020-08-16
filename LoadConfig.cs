using System;
using System.Collections.Generic;
using System.IO;
using System.Web.Script.Serialization;

namespace Holtz_Compacta
{
    public class LoadConfig
    {
        private static string CaminhoOrigem;
        private static string CaminhoDestino;
        private static string NomeArquivo;
        private static string Tipo;
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

        public static void CarregaJson()
        {
            string caminhoArquivo = Directory.GetParent(Directory.GetParent(CaminhoArquivoExt).FullName).FullName;
            caminhoArquivo += @"\Config.json";
            if (!File.Exists(caminhoArquivo))  //Caso não tenha o Config.json 
            { 
                File.Create(caminhoArquivo); 
            }
            else //só carrega se tiver o arquivo
            {
                JavaScriptSerializer serializer = new JavaScriptSerializer();
                string json = File.ReadAllText(caminhoArquivo);
                if (json.Length > 2) //Garantir que o Config.Json não esteja vazio 
                {
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
                                Tipo = String.Format("{1}", key, value);
                                break;
                        }
                    }
                }
                else
                {
                    CaminhoOrigem = "";
                    CaminhoDestino = "";
                    NomeArquivo = "";
                    Tipo = "";
                }
            }
        }

        public static void GravaJson()
        {
            string caminhoArquivo = Directory.GetParent(Directory.GetParent(CaminhoArquivoExt).FullName).FullName;
            caminhoArquivo += @"\Config.json";
            if (!File.Exists(caminhoArquivo))  //Caso não tenha o Config.json 
            {
                using (FileStream fs = File.Create(caminhoArquivo)) { }
            }
            //serialize vai por aspas duplas :   "valor"
            JavaScriptSerializer serializer = new JavaScriptSerializer();
            string ParCaminhoOrigem = serializer.Serialize(CaminhoOrigem);
            string ParCaminhoDestino = serializer.Serialize(CaminhoDestino);
            string ParNomeArquivo = serializer.Serialize(NomeArquivo);
            string ParTipo = serializer.Serialize(Tipo);

            string json = "{" +
                "\"Tipo\": " + ParTipo + ", " +
                "\"CaminhoOrigem\": " + ParCaminhoOrigem + ", " +
                "\"CaminhoDestino\": " + ParCaminhoDestino + ", " +
                "\"NomeArquivo\": " + ParNomeArquivo +
                "}";

            using (StreamWriter sr = new StreamWriter(caminhoArquivo))
            {
                sr.Write(json);
            }
        }
    }
}
