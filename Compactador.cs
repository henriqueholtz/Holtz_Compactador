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
using Holtz_Compactador;

namespace Holtz_Compacta
{
    public class Compactador
    {
        public void Compactar(string ParCaminhoOrigem, string ParCaminhoDestino, string ParNomeArquivo, string ParTipo, string ParCaminhoTemp)
        {
            
            ParCaminhoOrigem += @"\";
            ParCaminhoDestino += @"\";
            ParCaminhoTemp += @"\";
            try
            {
                EsvaziarPastaTemp(ParCaminhoTemp);
                string CaminhoZip = ParCaminhoDestino + ParNomeArquivo + ParTipo.ToLower();

                Directory.CreateDirectory(ParCaminhoTemp);
                Copiar(ParCaminhoOrigem, ParCaminhoTemp);
                if (!Directory.Exists(ParCaminhoDestino)) { Directory.CreateDirectory(ParCaminhoDestino); }

                ZipFile.CreateFromDirectory(ParCaminhoTemp, CaminhoZip);
                Alert.ShowSucess("Arquivo(os) compactado(os) com sucesso!");
                EsvaziarPastaTemp(ParCaminhoTemp);
            }
            catch (IOException e)
            {
                MessageBox.Show(e.Message);
            }
        }

        private void Copiar(string ParCaminhoOrigem, string ParTemp)
        {
            if (Directory.Exists(ParCaminhoOrigem))
            {

                // Copy folder structure
                foreach (string sourceSubFolder in Directory.GetDirectories(ParCaminhoOrigem, "*", SearchOption.AllDirectories))
                {
                    bool IsExcecao = false;
                    foreach (string excecao in LoadExcecoes.ParPastasN)
                    {
                        string auxExcecao = excecao.ToLowerInvariant();
                        string auxSourceSubFolder = "\\" + sourceSubFolder.ToLowerInvariant();
                        if (auxSourceSubFolder.Contains(auxExcecao))
                        {
                            IsExcecao = true;
                            break;
                        }                        
                    }
                    if (IsExcecao == false) { Directory.CreateDirectory(sourceSubFolder.Replace(ParCaminhoOrigem, ParTemp)); }
                    IsExcecao = false;
                }

                // Copy files
                foreach (string sourceFile in Directory.GetFiles(ParCaminhoOrigem, "*", SearchOption.AllDirectories))
                {
                    string destinationFile = sourceFile.Replace(ParCaminhoOrigem, ParTemp);
                    sourceFile.ToLower(); //para minusculo
                    bool IsExcecao = false;
                    foreach (string item in LoadExcecoes.ParExtensoesN)
                    {
                        string auxDestinationFile = destinationFile.ToLowerInvariant();
                        string auxItem = item.ToLowerInvariant();
                        if (Path.GetExtension(auxDestinationFile) == auxItem)
                        {
                            IsExcecao = true;
                            break; //interrompe a busca por outras extensoes de exceção, afinal já achou
                        }
                    }
                    if (IsExcecao == false) { File.Copy(sourceFile, destinationFile, true); }
                    IsExcecao = false;
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
