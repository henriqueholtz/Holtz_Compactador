using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Windows.Forms;
using System.Web.Script.Serialization;
using Ionic.Zip;
using System.Drawing;
using Vip.Notification;

namespace Holtz_Compactador
{
    public class Compactor
    {
        private static List<string> ExtensionsExceptions = new List<string>();
        private static List<string> FoldersExceptions = new List<string>();
        private static string BaseDirectory = Path.GetDirectoryName(System.AppDomain.CurrentDomain.BaseDirectory);
        private static string PathExtensionsJson = Directory.GetParent(Directory.GetParent(BaseDirectory).FullName).FullName + @"\Extensoes.json";
        private static string PathFoldersJson = Directory.GetParent(Directory.GetParent(BaseDirectory).FullName).FullName + @"\Pastas.json";
        private static string WindowsFolderTemp = Path.GetTempPath();
        private static char separator = Path.DirectorySeparatorChar;

        public static void Compact(string sourceFolder, string targetFolder, string targetFileName, string extension)
        {
            string FinishTotalName = targetFolder + @"\" + targetFileName + extension.ToLower();
            try
            {
                if (!Directory.Exists(sourceFolder))  { throw new CompactorException("Diretório de ORIGEM não existe. Verifique!"); }
                if (File.Exists(FinishTotalName)) { throw new CompactorException("Já existe um arquivo compactado com este nome e extensão nesta pasta de destino. Verifique!"); }
                if (!File.Exists(PathExtensionsJson)) { File.Create(PathExtensionsJson); }
                if (!File.Exists(PathFoldersJson))    { File.Create(PathFoldersJson); }
                if (!Directory.Exists(targetFolder))  { Directory.CreateDirectory(targetFolder); }
                GetExtensionsAndFoldersExceptions();

                LoadExcecoes.LimparExtensoesN();
                LoadExcecoes.LimparPastasN();
                LoadExcecoes.CarregaExtensoesN();
                LoadExcecoes.CarregaPastasN();

                // Structure Folders and Files
                IEnumerable<string> folders = Directory.EnumerateDirectories(sourceFolder, "*.*", SearchOption.AllDirectories);
                IEnumerable<string> files = Directory.EnumerateFiles(sourceFolder, "*.*", SearchOption.AllDirectories);
                List<string> ListFiles = files.ToList(); //Para conseguir excluir
                //ListFiles.Count =816!!!!
                //Excluindo conforme exceções de PASTAS
                foreach (string folder in folders)
                {
                    //string folderName = Path.GetDirectoryName(folder); //pega primeira pasta exemplo web de c:\web
                    string[] temp = folder.Split(separator);
                    IEnumerable<string> tempEnum = temp.AsEnumerable();
                    string LastFolderName = tempEnum.Last(); //pega ultimo pq vai ser o nome da pasta

                    foreach (string item in LoadExcecoes.ParPastasN)
                    {
                        if (item.ToLower() == LastFolderName.ToLower())
                        {
                            foreach (string itemList in files) //ou AuxListFiles
                            {
                                if (itemList.Contains(folder))
                                {
                                    ListFiles.Remove(itemList);
                                    //break;
                                }
                            }
                        }
                    }
                }

                //Excluindo conforme exceções de EXTENSÕES
                foreach (string file in files)
                {
                    string ext = Path.GetExtension(file);
                    foreach (string item in LoadExcecoes.ParExtensoesN)
                    {
                        if (item.ToLower() == ext.ToLower())
                        {
                            ListFiles.Remove(file);
                        }
                    }
                }

                using (ZipFile FileCompacted = new ZipFile(FinishTotalName))
                {
                    //compactando
                    foreach (string file in ListFiles)
                    {
                        int lengthSource = sourceFolder.Length + 1; //Pega o caminho + a '\'
                        int lengthItem = file.Length -1; //Pega o caminho - a '\'
                        string directoryPathInArqchive = file.Substring(lengthSource, lengthItem - lengthSource);
                        if (!directoryPathInArqchive.Contains(separator)) //dignifica que este "file" está na raiz
                        {
                            directoryPathInArqchive = "";
                        }
                        FileCompacted.AddItem(file, directoryPathInArqchive);
                    }

                    //Save File compacted
                    try
                    {
                        FileCompacted.Save();
                        Alert.ShowSucess("Arquivo compactado com sucesso!");
                    }
                    catch
                    {
                        throw;
                    }
                }

            }
            catch (CompactorException e)
            {
                MessageBox.Show(e.Message);
            }
            catch (IOException e) //capturar exceções mais genéricas
            {
                MessageBox.Show(e.Message);
            }
            //catch (InvalidOperationException e) //capturar exceções mais genéricas
            //{
            //    MessageBox.Show(e.Message);
            //}
        }

        private static void GetExtensionsAndFoldersExceptions()
        {
            //Load extensions exceptions
            //ExtensionsExceptions.Clear();
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
            //FoldersExceptions.Clear();
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
        
        private static void AddFile(string fileName)
        {

        }
    }
}
