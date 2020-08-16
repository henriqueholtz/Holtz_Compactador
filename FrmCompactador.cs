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
            txtNomeArquivo.Text    = LoadConfig.ParNomeArquivo;
            checkSalvarOrigem.Checked      = true;
            checkSalvarDestino.Checked     = true;
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
            if (checkSalvarNomeArquivo.Checked == true) { LoadConfig.ParNomeArquivo = txtNomeArquivo.Text; }    
            
            LoadConfig.GravaJson();

            Verifica(comboTipo.SelectedItem.ToString(), TxtCaminhoOrigem.Text, txtCaminhoDestino.Text, txtNomeArquivo.Text);
            
            if (LoadConfig.ParIsErro == false)
            {
                //Compactador varCompactador = new Compactador();
                //varCompactador.Compactar(TxtCaminhoOrigem.Text, txtCaminhoDestino.Text, txtNomeArquivo.Text, comboTipo.SelectedItem.ToString(), txtCaminhoTemp.Text);
                Compactor.Compact(TxtCaminhoOrigem.Text, txtCaminhoDestino.Text, txtNomeArquivo.Text, comboTipo.SelectedItem.ToString());
            }
            BtnGerar.Enabled = true;
            BtnGerarSemGravar.Enabled = true;
            txtCaminhoDestino.Enabled = true;
            txtNomeArquivo.Enabled = true;
            TxtCaminhoOrigem.Enabled = true;
            checkSalvarDestino.Enabled = true;
            checkSalvarOrigem.Enabled = true;
            extensoesToolStripMenuItem.Enabled = true;
            comboTipo.Enabled = true;
            imgConfigCaminhoDestino.Enabled = true;
            imgConfigCaminhoOrigem.Enabled = true;
        }

        private void BtnGerarSemGravar_Click(object sender, EventArgs e)
        {
            Verifica(comboTipo.SelectedItem.ToString(), TxtCaminhoOrigem.Text, txtCaminhoDestino.Text, txtNomeArquivo.Text);
            if (LoadConfig.ParIsErro == false)
            {
                //Compactador varCompactador = new Compactador();
                //varCompactador.Compactar(TxtCaminhoOrigem.Text, txtCaminhoDestino.Text, txtNomeArquivo.Text, comboTipo.SelectedItem.ToString(), txtCaminhoTemp.Text);
                Compactor.Compact(TxtCaminhoOrigem.Text, txtCaminhoDestino.Text, txtNomeArquivo.Text, comboTipo.SelectedItem.ToString());
            }
            BtnGerar.Enabled = true;
            BtnGerarSemGravar.Enabled = true;
            txtCaminhoDestino.Enabled = true;
            txtNomeArquivo.Enabled = true;
            TxtCaminhoOrigem.Enabled = true;
            checkSalvarDestino.Enabled = true;
            checkSalvarOrigem.Enabled = true;
            checkSalvarTipo.Enabled = true;
            checkSalvarNomeArquivo.Enabled = true;
            extensoesToolStripMenuItem.Enabled = true;
            comboTipo.Enabled = true;
            imgConfigCaminhoDestino.Enabled = true;
            imgConfigCaminhoOrigem.Enabled = true;
        }

        private void Verifica(string ParTipo,string ParCaminhoOrigem, string ParCaminhoDestino, string ParNomeArquivo)
        {
            BtnGerar.Enabled = false;
            BtnGerarSemGravar.Enabled = false;
            txtCaminhoDestino.Enabled = false;
            txtNomeArquivo.Enabled = false;
            TxtCaminhoOrigem.Enabled = false;
            checkSalvarDestino.Enabled = false;
            checkSalvarOrigem.Enabled = false;
            checkSalvarTipo.Enabled = false;
            checkSalvarNomeArquivo.Enabled = false;
            extensoesToolStripMenuItem.Enabled = false;
            comboTipo.Enabled = false;
            imgConfigCaminhoDestino.Enabled = false;
            imgConfigCaminhoOrigem.Enabled = false;
            LoadConfig.ParIsErro = false;
            string mensagem = String.Empty;
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
                Alert.ShowError("Este Arquivo não existe ou não foi localizado. Verifique!");
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
    }
}
