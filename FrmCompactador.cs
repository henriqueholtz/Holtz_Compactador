using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Web.Script.Serialization;
using Vip.Notification;
using System.IO;
using System.Data.SqlTypes;
using System.IO.Compression;
using Ionic.Zip;
using System.Net.Configuration;
using Holtz_Compactador;
using Nevron.Nov.Diagram.Shapes;
using System.Diagnostics;

namespace Holtz_Compacta
{
    public partial class FrmCompactador : Form
    {
        public FrmCompactador()
        {
            InitializeComponent();
        }

        private void FrmCompactador_Load(object sender, EventArgs e)
        {
            LoadConfig.CarregaJson();
            comboTipo.SelectedItem = LoadConfig.ParTipo;
            TxtCaminhoOrigem.Text  = LoadConfig.ParCaminhoOrigem;
            txtCaminhoDestino.Text = LoadConfig.ParCaminhoDestino;
            txtCaminhoTemp.Text    = LoadConfig.ParCaminhoTemp;
            txtNomeArquivo.Text    = LoadConfig.ParNomeArquivo;
            checkSalvarOrigem.Checked      = true;
            checkSalvarDestino.Checked     = true;
            checkSalvarTemp.Checked        = true;
            checkSalvarTipo.Checked        = true;
            checkSalvarNomeArquivo.Checked = true;
        }

        private void imgConfigCaminhoDestino_Click(object sender, EventArgs e)
        {
            if (folderDialog.ShowDialog() != DialogResult.OK) return;
            txtCaminhoDestino.Text = folderDialog.SelectedPath.ToString();
        }

        private void imgConfigCaminhoOrigem_Click(object sender, EventArgs e)
        {
            if (folderDialog.ShowDialog() != DialogResult.OK) return;
            TxtCaminhoOrigem.Text = folderDialog.SelectedPath.ToString();
        }

        private void BtnGerar_Click(object sender, EventArgs e)
        {
            //Salva na classe, e de lá com o método 'GravaJson()' salva no arquivo físico (Config.json);
            if (checkSalvarTipo.Checked == true) { LoadConfig.ParTipo = comboTipo.SelectedItem.ToString(); }
            if (checkSalvarOrigem.Checked == true)  { LoadConfig.ParCaminhoOrigem = TxtCaminhoOrigem.Text; }
            if (checkSalvarDestino.Checked == true) { LoadConfig.ParCaminhoDestino = txtCaminhoDestino.Text; }
            if (checkSalvarTemp.Checked == true)    { LoadConfig.ParCaminhoTemp = txtCaminhoTemp.Text; }
            if (checkSalvarNomeArquivo.Checked == true) { LoadConfig.ParNomeArquivo = txtNomeArquivo.Text; }    
            
            LoadConfig.GravaJson();

            Verifica(comboTipo.SelectedItem.ToString(), TxtCaminhoOrigem.Text, txtCaminhoDestino.Text, txtNomeArquivo.Text,txtCaminhoTemp.Text);
            
            if (LoadConfig.ParIsErro == false)
            {
                Compactador varCompactador = new Compactador();
                varCompactador.Compactar(TxtCaminhoOrigem.Text, txtCaminhoDestino.Text, txtNomeArquivo.Text, comboTipo.SelectedItem.ToString(), txtCaminhoTemp.Text);
            }
            BtnGerar.Enabled = true;
            BtnGerarSemGravar.Enabled = true;
            txtCaminhoDestino.Enabled = true;
            txtCaminhoTemp.Enabled = true;
            txtNomeArquivo.Enabled = true;
            TxtCaminhoOrigem.Enabled = true;
            checkSalvarDestino.Enabled = true;
            checkSalvarOrigem.Enabled = true;
            checkSalvarTemp.Enabled = true;
            SobrePastaTemporaria.Enabled = true;
            extensoesToolStripMenuItem.Enabled = true;
            comboTipo.Enabled = true;
            imgConfigCaminhoDestino.Enabled = true;
            imgConfigCaminhoOrigem.Enabled = true;
            imgConfigCaminhoTemp.Enabled = true;
        }

        private void BtnGerarSemGravar_Click(object sender, EventArgs e)
        {
            Verifica(comboTipo.SelectedItem.ToString(), TxtCaminhoOrigem.Text, txtCaminhoDestino.Text, txtNomeArquivo.Text,txtCaminhoTemp.Text);
            //IEnumerable<string> folders = Directory.EnumerateDirectories(@"c:\pasta", "*.*", SearchOption.AllDirectories); //Curso Nelio Alves
            //IEnumerable<string> files = Directory.EnumerateFiles(@"C:\pasta", "*.*", SearchOption.AllDirectories);//Curso Nelio Alves
            //Path.GetFileName(@"c:\temp\arq.txt"); //= "arq.txt"
            if (LoadConfig.ParIsErro == false)
            {
                Compactador varCompactador = new Compactador();
                varCompactador.Compactar(TxtCaminhoOrigem.Text, txtCaminhoDestino.Text, txtNomeArquivo.Text, comboTipo.SelectedItem.ToString(), txtCaminhoTemp.Text);
            }
            BtnGerar.Enabled = true;
            BtnGerarSemGravar.Enabled = true;
            txtCaminhoDestino.Enabled = true;
            txtCaminhoTemp.Enabled = true;
            txtNomeArquivo.Enabled = true;
            TxtCaminhoOrigem.Enabled = true;
            checkSalvarDestino.Enabled = true;
            checkSalvarOrigem.Enabled = true;
            checkSalvarTemp.Enabled = true;
            checkSalvarTipo.Enabled = true;
            checkSalvarNomeArquivo.Enabled = true;
            SobrePastaTemporaria.Enabled = true;
            extensoesToolStripMenuItem.Enabled = true;
            comboTipo.Enabled = true;
            imgConfigCaminhoDestino.Enabled = true;
            imgConfigCaminhoOrigem.Enabled = true;
            imgConfigCaminhoTemp.Enabled = true;
        }

        private void Verifica(string ParTipo,string ParCaminhoOrigem, string ParCaminhoDestino, string ParNomeArquivo, string ParCaminhoTemp)
        {
            BtnGerar.Enabled = false;
            BtnGerarSemGravar.Enabled = false;
            txtCaminhoDestino.Enabled = false;
            txtCaminhoTemp.Enabled = false;
            txtNomeArquivo.Enabled = false;
            TxtCaminhoOrigem.Enabled = false;
            checkSalvarDestino.Enabled = false;
            checkSalvarOrigem.Enabled = false;
            checkSalvarTemp.Enabled = false;
            checkSalvarTipo.Enabled = false;
            checkSalvarNomeArquivo.Enabled = false;
            SobrePastaTemporaria.Enabled = false;
            extensoesToolStripMenuItem.Enabled = false;
            comboTipo.Enabled = false;
            imgConfigCaminhoDestino.Enabled = false;
            imgConfigCaminhoOrigem.Enabled = false;
            imgConfigCaminhoTemp.Enabled = false;
            LoadConfig.ParIsErro = false;
            string mensagem = String.Empty;
            //Alert.ShowInformation("Em desenvolvimento by: Henrique Holtz");
            if (ParCaminhoOrigem.Length <= 3)
            {
                LoadConfig.ParIsErro = true;
                mensagem += " O caminho de origem não está válido. Verifique!";
            }
            if (ParCaminhoDestino.Length <= 3)
            {
                LoadConfig.ParIsErro = true;
                mensagem += " O caminho de Destino não está válido. Verifique!";
            }
            if (ParCaminhoTemp.Length <= 3)
            {
                LoadConfig.ParIsErro = true;
                mensagem += " O caminho da pasta Temp não está válido. Verifique!";
            }
            if (ParTipo.Length != 4)
            {
                LoadConfig.ParIsErro = true;
                mensagem += " O Tipo não é válido. Utilize '.RAR' ou '.ZIP'";
            }
            if (ParNomeArquivo.Length == 0)
            {
                LoadConfig.ParIsErro = true;
                mensagem += " O Nome do arquivo não pode ser vazio.";
            }
            if (File.Exists(ParCaminhoDestino + @"\" +  ParNomeArquivo + ParTipo.ToLower()))
            {
                LoadConfig.ParIsErro = true;
                mensagem += "Já existe um arquivo com o nome escolhido, e a mesma extensão.Exclua o arquivo ou escolha outro nome.";
            }
            if (LoadConfig.ParIsErro == true)
            {
                Alert.ShowError(mensagem);
            }
            else
            {
                if (!Directory.Exists(ParCaminhoDestino)) { Directory.CreateDirectory(ParCaminhoDestino); }
                if (!Directory.Exists(ParCaminhoTemp)) { Directory.CreateDirectory(ParCaminhoTemp); }
                LoadExcecoes.LimparExtensoesN();
                LoadExcecoes.LimparPastasN();
                LoadExcecoes.CarregaExtensoesN();
                LoadExcecoes.CarregaPastasN();
                Alert.ShowSucess("Pronto para compactar");
            }
        }

        private void imgConfigCaminhoTemp_Click(object sender, EventArgs e)
        {
            if (folderDialog.ShowDialog() != DialogResult.OK) return;
            txtCaminhoTemp.Text = folderDialog.SelectedPath.ToString();
        }

        private void SobrePastaTemporaria_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Esta pasta é ESVAZIADA, depois usada para copiar os aqruivos antes de compactar,e depois é ESVAZIADA novamente! ");
        }

        private void txtComoFunciona_Click(object sender, EventArgs e)
        {
            FrmSobre msg = new FrmSobre();
            msg.ShowDialog();
        }

        private void extensoesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmExcecoes exc = new FrmExcecoes();
            exc.ShowDialog();
        }

        private void imgOpenPastaTemp_Click(object sender, EventArgs e)
        {
            if (Directory.Exists(txtCaminhoTemp.Text))
            {
                Process.Start(txtCaminhoTemp.Text);
            }
            else
            {
                Alert.ShowError("Esta pasta não existe ou não foi localizada. Verifique!");
            }
        }

        private void imgOpenCaminhoOrigem_Click(object sender, EventArgs e)
        {
            if (Directory.Exists(TxtCaminhoOrigem.Text))
            {
                Process.Start(TxtCaminhoOrigem.Text);
            }
            else
            {
                Alert.ShowError("Esta pasta não existe ou não foi localizada. Verifique!");
            }
        }

        private void imgOpenZip_Click(object sender, EventArgs e)
        {
            string file = txtCaminhoDestino.Text + "\\" + txtNomeArquivo.Text + comboTipo.SelectedItem.ToString();
            if (File.Exists(file))
            {
                Process.Start(file);
            }
            else
            {
                Alert.ShowError("Este Arquivo não existe ou não foi localizada. Verifique!");
            }
        }

        private void imgOpenCaminhoDestino_Click(object sender, EventArgs e)
        {
            if (Directory.Exists(txtCaminhoDestino.Text))
            {
                Process.Start(txtCaminhoDestino.Text);
            }
            else
            {
                Alert.ShowError("Esta pasta não existe ou não foi localizada. Verifique!");
            }
        }

        private void BtnTest_Click(object sender, EventArgs e)
        {
            Compactor.Compact(TxtCaminhoOrigem.Text, txtCaminhoDestino.Text, txtNomeArquivo.Text, comboTipo.SelectedItem.ToString());
        }
    }
}
