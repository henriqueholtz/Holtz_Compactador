using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Vip.Notification;

namespace Holtz_Compactador
{
    public partial class FrmExcecoes : Form
    {
        private List<string> pastasN = new List<string>();
        private List<string> extensoesN = new List<string>();
        public FrmExcecoes()
        {
            InitializeComponent();
        }

        private void FrmExcecoes_Load(object sender, EventArgs e)
        {
            BtnRemoverExtensao.Enabled = false;
            BtnRemoverPasta.Enabled = false;
            LoadExcecoes.CarregaExtensoesN();
            LoadExcecoes.CarregaPastasN();
            //List<string> extensoesN = new List<string>();
            extensoesN = LoadExcecoes.ParExtensoesN;
            foreach (var item in extensoesN)
            {
                listExtensoes.Items.Add(item);
            }
            //List<string> pastasN = new List<string>();
            pastasN = LoadExcecoes.ParPastasN;
            foreach(var item in pastasN)
            {
                listPastas.Items.Add(item);
            }
        }

        private void BtnAddExtensao_Click(object sender, EventArgs e)
        {
            if (txtNovaExtensao.TextLength <= 2 || txtNovaExtensao.TextLength > 12)
            {
                Alert.ShowError("Extensão inválida");
            }
            else
            {
                listExtensoes.Items.Add(txtNovaExtensao.Text);
                txtNovaExtensao.Text = string.Empty;
            }
        }

        private void BtnAddPasta_Click(object sender, EventArgs e)
        {
            if (txtNovaPasta.TextLength > 80)
            {
                Alert.ShowError("Tamanho máximo permitido: 80 caracteres");
            }
            else
            {
                listPastas.Items.Add(txtNovaPasta.Text);
                txtNovaPasta.Text = string.Empty;
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void BtnGravar_Click(object sender, EventArgs e)
        {
            LoadExcecoes.LimparExtensoesN(); //Clear
            LoadExcecoes.LimparPastasN(); //Clear
            foreach (string item in listExtensoes.Items)
            {
                LoadExcecoes.ParAddExtensaoN(item);
            }
            LoadExcecoes.GravaJsonExtensoes();
            foreach (string item in listPastas.Items)
            {
                LoadExcecoes.ParAddPastaN(item);
            }
            LoadExcecoes.GravaJsonPastas();
            this.Close();
        }

        private void BtnRemoverExtensao_Click(object sender, EventArgs e)
        {
            listExtensoes.Items.Remove(listExtensoes.SelectedItem);
            BtnRemoverExtensao.Enabled = false;
        }

        private void listExtensoes_SelectedIndexChanged(object sender, EventArgs e)
        {
            BtnRemoverExtensao.Enabled = true;
        }

        private void BtnRemoverPasta_Click(object sender, EventArgs e)
        {
            listPastas.Items.Remove(listPastas.SelectedItem);
            BtnRemoverPasta.Enabled = false;
        }

        private void listPastas_SelectedIndexChanged(object sender, EventArgs e)
        {
            BtnRemoverPasta.Enabled = true;
        }
    }
}
