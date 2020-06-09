using System;
using System.Windows.Forms;
using System.Diagnostics;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.IO.Compression;
using Vip.Notification;

namespace Holtz_Compacta
{
    public class Compactador
    {
        public void Compactar(string ParCaminhoOrigem, string ParCaminhoDestino, string ParNomeArquivo, string ParTipo, string ParCaminhoTemp)
        {
            ParCaminhoOrigem += @"\";
            ParCaminhoDestino += @"\";
            ParCaminhoTemp += @"\";
            EsvaziarPastaTemp(ParCaminhoTemp);
            string CaminhoZip = ParCaminhoDestino + ParNomeArquivo + ParTipo.ToLower();

            Directory.CreateDirectory(ParCaminhoTemp);
            Copiar(ParCaminhoOrigem, ParCaminhoTemp);
            if (!Directory.Exists(ParCaminhoDestino)) { Directory.CreateDirectory(ParCaminhoDestino); }

            ZipFile.CreateFromDirectory(ParCaminhoTemp, CaminhoZip);
            Alert.ShowSucess("Arquivo(os) compactado(os) com sucesso!");
            EsvaziarPastaTemp(ParCaminhoTemp);
        }

        private void Copiar(string ParCaminhoOrigem, string ParTemp)
        {
            if (Directory.Exists(ParCaminhoOrigem))
            {
                // Copy folder structure
                foreach (string sourceSubFolder in Directory.GetDirectories(ParCaminhoOrigem, "*", SearchOption.AllDirectories))
                {
                    Directory.CreateDirectory(sourceSubFolder.Replace(ParCaminhoOrigem, ParTemp));
                }

                // Copy files
                foreach (string sourceFile in Directory.GetFiles(ParCaminhoOrigem, "*", SearchOption.AllDirectories))
                {
                    string destinationFile = sourceFile.Replace(ParCaminhoOrigem, ParTemp);
                    sourceFile.ToLower(); //para minusculo

                    if ((!sourceFile.Contains(".cs") || sourceFile.Contains(".css")) && !sourceFile.Contains(".config") && !sourceFile.Contains(".002") && !sourceFile.Contains(".rsp")
                        && !sourceFile.Contains(".sql") && !sourceFile.Contains(".xls") && !sourceFile.Contains(".pdf") && !sourceFile.Contains(".xlsx"))
                    {
                        File.Copy(sourceFile, destinationFile, true);
                    }
                }

                //deletar pastas desejadas
                foreach (string sourceSubFolder in Directory.GetDirectories(ParTemp, "*", SearchOption.TopDirectoryOnly))
                {
                    if (sourceSubFolder.ToLower().Contains("publictempstorage") || sourceSubFolder.ToLower().Contains("privatetempstorage"))
                    {
                        Directory.Delete(sourceSubFolder, true);
                    }
                }
            }
        }

        private static void EsvaziarPastaTemp(string CaminhoTemp)
        {
            //deletando pastas
            foreach (string sourceSubFolder in Directory.GetDirectories(CaminhoTemp, "*", SearchOption.AllDirectories))
            {
                if (Directory.Exists(sourceSubFolder)) { Directory.Delete(sourceSubFolder, true); }
            }

            //deletando arquivos
            foreach (string sourceFile in Directory.GetFiles(CaminhoTemp, "*", SearchOption.AllDirectories))
            {
                if (File.Exists(sourceFile)) { File.Delete(sourceFile); }
            }
        }
    }
}
