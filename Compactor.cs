using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Windows.Forms;
using System.Web.Script.Serialization;

namespace Holtz_Compactador
{
    public class Compactor
    {
        private static List<string> ExtensionsExceptions;
        private static List<string> FoldersExceptions;
        private static string BaseDirectory = Path.GetDirectoryName(System.AppDomain.CurrentDomain.BaseDirectory);
        private static string PathExtensionsJson = Directory.GetParent(Directory.GetParent(BaseDirectory).FullName).FullName + @"\Extensoes.json";
        private static string PathFoldersJson = Directory.GetParent(Directory.GetParent(BaseDirectory).FullName).FullName + @"\Pastas.json";

        public static void Compact(string sourceFolder, string targetFolder, string targetFileName, string extension)
        {
            //IEnumerable<string> folders = Directory.EnumerateDirectories(@"c:\pasta", "*.*", SearchOption.AllDirectories); //Curso Nelio Alves
            //IEnumerable<string> files = Directory.EnumerateFiles(@"C:\pasta", "*.*", SearchOption.AllDirectories);//Curso Nelio Alves
            //Path.GetFileName(@"c:\temp\arq.txt"); //= "arq.txt"

            try
            {
                if (!Directory.Exists(sourceFolder))  { throw new CompactorException("Este diretório não existe. Verifique!"); }
                if (!File.Exists(PathExtensionsJson)) { File.Create(PathExtensionsJson); }
                if (!File.Exists(PathFoldersJson))    { File.Create(PathFoldersJson); }
                if (!Directory.Exists(targetFolder))  { Directory.CreateDirectory(targetFolder); }
                GetExtensionsAndFoldersExceptions();

            }
            catch (CompactorException e)
            {
                MessageBox.Show(e.Message);
            }
            catch (IOException e) //capturar exceções mais genéricas
            {
                MessageBox.Show(e.Message);
            }
        }

        private static void GetExtensionsAndFoldersExceptions()
        {
            //Load extensions exceptions
            ExtensionsExceptions.Clear();
            JavaScriptSerializer serializer = new JavaScriptSerializer();
            string Extensionsjson = File.ReadAllText(PathExtensionsJson);
            dynamic resultado = serializer.DeserializeObject(Extensionsjson);
            foreach (KeyValuePair<string, object> entry in resultado)
            {
                var key = entry.Key;
                var value = entry.Value as string;
                ExtensionsExceptions.Add(value);
            }
            serializer = null;
            resultado = null;

            //Load folders exceptions
            FoldersExceptions.Clear();
            serializer = new JavaScriptSerializer();
            string Foldersjson = File.ReadAllText(PathFoldersJson);
            resultado = serializer.DeserializeObject(Foldersjson);
            foreach (KeyValuePair<string, object> entry in resultado)
            {
                var key = entry.Key;
                var value = entry.Value as string;
                FoldersExceptions.Add(value);
            }
        }
    }
}
