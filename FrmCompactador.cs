using System;
using System.Windows.Forms;
using Vip.Notification;
using System.IO;
using Holtz_Compactador;
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
            TxtCaminhoOrigem.Text = LoadConfig.ParCaminhoOrigem;
            txtCaminhoDestino.Text = LoadConfig.ParCaminhoDestino;
            txtNomeArquivo.Text = LoadConfig.ParNomeArquivo;
            checkSalvarOrigem.Checked = true;
            checkSalvarDestino.Checked = true;
            checkSalvarTipo.Checked = true;
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
            try
            {
                if (comboTipo.SelectedItem == null) { throw new CompactorException("Você deve selecionar um Tipo de compactação!"); }
                Verifica(comboTipo.SelectedItem.ToString(), TxtCaminhoOrigem.Text, txtCaminhoDestino.Text, txtNomeArquivo.Text);
                //Salva na classe, e de lá com o método 'GravaJson()' salva no arquivo físico (Config.json);
                if (checkSalvarTipo.Checked == true) { LoadConfig.ParTipo = comboTipo.SelectedItem.ToString(); }
                if (checkSalvarOrigem.Checked == true) { LoadConfig.ParCaminhoOrigem = TxtCaminhoOrigem.Text; }
                if (checkSalvarDestino.Checked == true) { LoadConfig.ParCaminhoDestino = txtCaminhoDestino.Text; }
                if (checkSalvarNomeArquivo.Checked == true) { LoadConfig.ParNomeArquivo = txtNomeArquivo.Text; }

                LoadConfig.GravaJson();
                Compactor.Compact(TxtCaminhoOrigem.Text, txtCaminhoDestino.Text, txtNomeArquivo.Text, comboTipo.SelectedItem.ToString());

            }
            catch (CompactorException ex)
            {
                Alert.ShowError(ex.Message);
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
            try
            {
                if (comboTipo.SelectedItem == null) { throw new CompactorException("Você deve selecionar um Tipo de compactação!"); }
                Verifica(comboTipo.SelectedItem.ToString(), TxtCaminhoOrigem.Text, txtCaminhoDestino.Text, txtNomeArquivo.Text);
                Compactor.Compact(TxtCaminhoOrigem.Text, txtCaminhoDestino.Text, txtNomeArquivo.Text, comboTipo.SelectedItem.ToString());
            }
            catch (CompactorException ex)
            {
                Alert.ShowError(ex.Message);
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

        private void Verifica(string ParTipo, string ParCaminhoOrigem, string ParCaminhoDestino, string ParNomeArquivo)
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
            
            if (ParCaminhoOrigem.Length <= 3)
            {
                throw new CompactorException(" O caminho de origem não está válido. Verifique!");
            }
            if (ParCaminhoDestino.Length <= 3)
            {
                throw new CompactorException(" O caminho de Destino não está válido. Verifique!");
            }
            if (ParTipo.Length != 4)
            {
                throw new CompactorException(" O Tipo não é válido. Utilize '.RAR' ou '.ZIP'");
            }
            if (/*ParNomeArquivo ==*/ String.IsNullOrWhiteSpace(ParNomeArquivo) /* .Length == 0*/)
            {
                throw new CompactorException(" O Nome do arquivo não pode ser vazio.");
            }
            if (File.Exists(ParCaminhoDestino + @"\" + ParNomeArquivo + ParTipo.ToLower()))
            {
                throw new CompactorException("Já existe um arquivo com o nome escolhido, e a mesma extensão.Exclua o arquivo ou escolha outro nome.");
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

        private void limparConfiguraçõesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            string CaminhoArquivoExt = Path.GetDirectoryName(System.AppDomain.CurrentDomain.BaseDirectory);
            string caminhoArquivo = Directory.GetParent(Directory.GetParent(CaminhoArquivoExt).FullName).FullName;
            caminhoArquivo += @"\Config.json";
            using (StreamWriter sr = new StreamWriter(caminhoArquivo))
            {
                sr.Write("");
            }
            LoadConfig.CarregaJson();
            comboTipo.SelectedItem = null;
            TxtCaminhoOrigem.Text = LoadConfig.ParCaminhoOrigem;
            txtCaminhoDestino.Text = LoadConfig.ParCaminhoDestino;
            txtNomeArquivo.Text = LoadConfig.ParNomeArquivo;
            checkSalvarOrigem.Checked = true;
            checkSalvarDestino.Checked = true;
            checkSalvarTipo.Checked = true;
            checkSalvarNomeArquivo.Checked = true;
            Alert.ShowSucess("Todas Configurações foram excluídas.");
        }

        private void limparExceçõesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            string CaminhoArquivoExt = Path.GetDirectoryName(System.AppDomain.CurrentDomain.BaseDirectory);
            string caminhoArquivo = Directory.GetParent(Directory.GetParent(CaminhoArquivoExt).FullName).FullName;
            string arquivo = caminhoArquivo + @"\Pastas.json";
            using (StreamWriter sr = new StreamWriter(arquivo))
            {
                sr.Write("");
            }

            arquivo = String.Empty;
            arquivo = caminhoArquivo + @"\Extensoes.json";
            using (StreamWriter sr = new StreamWriter(arquivo))
            {
                sr.Write("");
            }
            LoadExcecoes.ClearAll();
            Alert.ShowSucess("Todas Exceções foram excluídas.");
        }
    }
}
