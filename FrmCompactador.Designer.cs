namespace Holtz_Compacta
{
    partial class FrmCompactador
    {
        /// <summary>
        /// Variável de designer necessária.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpar os recursos que estão sendo usados.
        /// </summary>
        /// <param name="disposing">true se for necessário descartar os recursos gerenciados; caso contrário, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código gerado pelo Windows Form Designer

        /// <summary>
        /// Método necessário para suporte ao Designer - não modifique 
        /// o conteúdo deste método com o editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmCompactador));
            this.TxtCaminhoOrigem = new System.Windows.Forms.TextBox();
            this.txtNomeArquivo = new System.Windows.Forms.TextBox();
            this.txtCaminhoDestino = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.BtnGerar = new System.Windows.Forms.Button();
            this.comboTipo = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.nProgressBarControl1 = new Nevron.Nov.WinFormControls.NProgressBarControl();
            this.BtnGerarSemGravar = new System.Windows.Forms.Button();
            this.folderDialog = new System.Windows.Forms.FolderBrowserDialog();
            this.label5 = new System.Windows.Forms.Label();
            this.txtCaminhoTemp = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.checkSalvarTemp = new System.Windows.Forms.CheckBox();
            this.checkSalvarOrigem = new System.Windows.Forms.CheckBox();
            this.checkSalvarDestino = new System.Windows.Forms.CheckBox();
            this.SobrePastaTemporaria = new System.Windows.Forms.Label();
            this.imgConfigCaminhoTemp = new System.Windows.Forms.PictureBox();
            this.imgConfigCaminhoOrigem = new System.Windows.Forms.PictureBox();
            this.imgConfigCaminhoDestino = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.imgConfigCaminhoTemp)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.imgConfigCaminhoOrigem)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.imgConfigCaminhoDestino)).BeginInit();
            this.SuspendLayout();
            // 
            // TxtCaminhoOrigem
            // 
            this.TxtCaminhoOrigem.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.TxtCaminhoOrigem.Location = new System.Drawing.Point(155, 114);
            this.TxtCaminhoOrigem.Name = "TxtCaminhoOrigem";
            this.TxtCaminhoOrigem.Size = new System.Drawing.Size(225, 20);
            this.TxtCaminhoOrigem.TabIndex = 0;
            // 
            // txtNomeArquivo
            // 
            this.txtNomeArquivo.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtNomeArquivo.Location = new System.Drawing.Point(155, 165);
            this.txtNomeArquivo.Name = "txtNomeArquivo";
            this.txtNomeArquivo.Size = new System.Drawing.Size(225, 20);
            this.txtNomeArquivo.TabIndex = 1;
            // 
            // txtCaminhoDestino
            // 
            this.txtCaminhoDestino.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtCaminhoDestino.Location = new System.Drawing.Point(155, 212);
            this.txtCaminhoDestino.Name = "txtCaminhoDestino";
            this.txtCaminhoDestino.Size = new System.Drawing.Size(225, 20);
            this.txtCaminhoDestino.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(155, 101);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(97, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "Caminho de origem";
            // 
            // label2
            // 
            this.label2.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(155, 152);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(114, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "Nome do Arquivo Final";
            // 
            // label3
            // 
            this.label3.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(155, 199);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(87, 13);
            this.label3.TabIndex = 5;
            this.label3.Text = "Caminho Destino";
            // 
            // BtnGerar
            // 
            this.BtnGerar.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.BtnGerar.BackColor = System.Drawing.SystemColors.ControlDark;
            this.BtnGerar.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.BtnGerar.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnGerar.Location = new System.Drawing.Point(288, 274);
            this.BtnGerar.Name = "BtnGerar";
            this.BtnGerar.Size = new System.Drawing.Size(197, 65);
            this.BtnGerar.TabIndex = 7;
            this.BtnGerar.Text = "COMPACTAR E SALVAR";
            this.BtnGerar.UseVisualStyleBackColor = false;
            this.BtnGerar.Click += new System.EventHandler(this.BtnGerar_Click);
            // 
            // comboTipo
            // 
            this.comboTipo.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.comboTipo.Items.AddRange(new object[] {
            ".RAR",
            ".ZIP"});
            this.comboTipo.Location = new System.Drawing.Point(206, 22);
            this.comboTipo.MaxLength = 4;
            this.comboTipo.Name = "comboTipo";
            this.comboTipo.Size = new System.Drawing.Size(121, 21);
            this.comboTipo.TabIndex = 8;
            // 
            // label4
            // 
            this.label4.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(241, 6);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(28, 13);
            this.label4.TabIndex = 9;
            this.label4.Text = "Tipo";
            // 
            // nProgressBarControl1
            // 
            this.nProgressBarControl1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.nProgressBarControl1.AutoSize = false;
            this.nProgressBarControl1.DesignTimeState = null;
            this.nProgressBarControl1.Location = new System.Drawing.Point(189, 239);
            this.nProgressBarControl1.Name = "nProgressBarControl1";
            this.nProgressBarControl1.Size = new System.Drawing.Size(163, 23);
            this.nProgressBarControl1.TabIndex = 15;
            // 
            // BtnGerarSemGravar
            // 
            this.BtnGerarSemGravar.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.BtnGerarSemGravar.BackColor = System.Drawing.SystemColors.ControlDark;
            this.BtnGerarSemGravar.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.BtnGerarSemGravar.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnGerarSemGravar.Location = new System.Drawing.Point(58, 274);
            this.BtnGerarSemGravar.Name = "BtnGerarSemGravar";
            this.BtnGerarSemGravar.Size = new System.Drawing.Size(184, 65);
            this.BtnGerarSemGravar.TabIndex = 16;
            this.BtnGerarSemGravar.Text = "APENAS COMPACTAR";
            this.BtnGerarSemGravar.UseVisualStyleBackColor = false;
            this.BtnGerarSemGravar.Click += new System.EventHandler(this.BtnGerarSemGravar_Click);
            // 
            // label5
            // 
            this.label5.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(155, 52);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(90, 13);
            this.label5.TabIndex = 17;
            this.label5.Text = "Pasta Temporária";
            // 
            // txtCaminhoTemp
            // 
            this.txtCaminhoTemp.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtCaminhoTemp.Location = new System.Drawing.Point(155, 68);
            this.txtCaminhoTemp.Name = "txtCaminhoTemp";
            this.txtCaminhoTemp.Size = new System.Drawing.Size(225, 20);
            this.txtCaminhoTemp.TabIndex = 18;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.SystemColors.ControlLight;
            this.label6.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.DarkBlue;
            this.label6.Location = new System.Drawing.Point(406, 6);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(127, 16);
            this.label6.TabIndex = 19;
            this.label6.Text = "Como Funciona ?";
            this.label6.Click += new System.EventHandler(this.label6_Click);
            // 
            // checkSalvarTemp
            // 
            this.checkSalvarTemp.AutoSize = true;
            this.checkSalvarTemp.Location = new System.Drawing.Point(387, 70);
            this.checkSalvarTemp.Name = "checkSalvarTemp";
            this.checkSalvarTemp.Size = new System.Drawing.Size(56, 17);
            this.checkSalvarTemp.TabIndex = 21;
            this.checkSalvarTemp.Text = "Salvar";
            this.checkSalvarTemp.UseVisualStyleBackColor = true;
            // 
            // checkSalvarOrigem
            // 
            this.checkSalvarOrigem.AutoSize = true;
            this.checkSalvarOrigem.Location = new System.Drawing.Point(387, 116);
            this.checkSalvarOrigem.Name = "checkSalvarOrigem";
            this.checkSalvarOrigem.Size = new System.Drawing.Size(56, 17);
            this.checkSalvarOrigem.TabIndex = 22;
            this.checkSalvarOrigem.Text = "Salvar";
            this.checkSalvarOrigem.UseVisualStyleBackColor = true;
            // 
            // checkSalvarDestino
            // 
            this.checkSalvarDestino.AutoSize = true;
            this.checkSalvarDestino.Location = new System.Drawing.Point(387, 214);
            this.checkSalvarDestino.Name = "checkSalvarDestino";
            this.checkSalvarDestino.Size = new System.Drawing.Size(56, 17);
            this.checkSalvarDestino.TabIndex = 23;
            this.checkSalvarDestino.Text = "Salvar";
            this.checkSalvarDestino.UseVisualStyleBackColor = true;
            // 
            // SobrePastaTemporaria
            // 
            this.SobrePastaTemporaria.AutoSize = true;
            this.SobrePastaTemporaria.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.SobrePastaTemporaria.ForeColor = System.Drawing.Color.Red;
            this.SobrePastaTemporaria.Location = new System.Drawing.Point(249, 51);
            this.SobrePastaTemporaria.Name = "SobrePastaTemporaria";
            this.SobrePastaTemporaria.Size = new System.Drawing.Size(119, 13);
            this.SobrePastaTemporaria.TabIndex = 24;
            this.SobrePastaTemporaria.Text = "ATENÇÃO! Clique aqui.";
            this.SobrePastaTemporaria.Click += new System.EventHandler(this.SobrePastaTemporaria_Click);
            // 
            // imgConfigCaminhoTemp
            // 
            this.imgConfigCaminhoTemp.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.imgConfigCaminhoTemp.BackgroundImage = global::Holtz_Compactador.Properties.Resources.graphite_stripped_folder_developer_14229;
            this.imgConfigCaminhoTemp.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.imgConfigCaminhoTemp.Location = new System.Drawing.Point(111, 62);
            this.imgConfigCaminhoTemp.Name = "imgConfigCaminhoTemp";
            this.imgConfigCaminhoTemp.Size = new System.Drawing.Size(38, 29);
            this.imgConfigCaminhoTemp.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.imgConfigCaminhoTemp.TabIndex = 20;
            this.imgConfigCaminhoTemp.TabStop = false;
            this.imgConfigCaminhoTemp.Click += new System.EventHandler(this.imgConfigCaminhoTemp_Click);
            // 
            // imgConfigCaminhoOrigem
            // 
            this.imgConfigCaminhoOrigem.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.imgConfigCaminhoOrigem.BackgroundImage = global::Holtz_Compactador.Properties.Resources.graphite_stripped_folder_developer_14229;
            this.imgConfigCaminhoOrigem.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.imgConfigCaminhoOrigem.Location = new System.Drawing.Point(111, 107);
            this.imgConfigCaminhoOrigem.Name = "imgConfigCaminhoOrigem";
            this.imgConfigCaminhoOrigem.Size = new System.Drawing.Size(38, 29);
            this.imgConfigCaminhoOrigem.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.imgConfigCaminhoOrigem.TabIndex = 14;
            this.imgConfigCaminhoOrigem.TabStop = false;
            this.imgConfigCaminhoOrigem.Click += new System.EventHandler(this.imgConfigCaminhoOrigem_Click);
            // 
            // imgConfigCaminhoDestino
            // 
            this.imgConfigCaminhoDestino.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.imgConfigCaminhoDestino.BackgroundImage = global::Holtz_Compactador.Properties.Resources.graphite_stripped_folder_developer_14229;
            this.imgConfigCaminhoDestino.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.imgConfigCaminhoDestino.Location = new System.Drawing.Point(111, 206);
            this.imgConfigCaminhoDestino.Name = "imgConfigCaminhoDestino";
            this.imgConfigCaminhoDestino.Size = new System.Drawing.Size(38, 29);
            this.imgConfigCaminhoDestino.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.imgConfigCaminhoDestino.TabIndex = 13;
            this.imgConfigCaminhoDestino.TabStop = false;
            this.imgConfigCaminhoDestino.Click += new System.EventHandler(this.imgConfigCaminhoDestino_Click);
            // 
            // FrmCompactador
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(535, 391);
            this.Controls.Add(this.SobrePastaTemporaria);
            this.Controls.Add(this.checkSalvarDestino);
            this.Controls.Add(this.checkSalvarOrigem);
            this.Controls.Add(this.checkSalvarTemp);
            this.Controls.Add(this.imgConfigCaminhoTemp);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.txtCaminhoTemp);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.BtnGerarSemGravar);
            this.Controls.Add(this.nProgressBarControl1);
            this.Controls.Add(this.imgConfigCaminhoOrigem);
            this.Controls.Add(this.imgConfigCaminhoDestino);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.comboTipo);
            this.Controls.Add(this.BtnGerar);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtCaminhoDestino);
            this.Controls.Add(this.txtNomeArquivo);
            this.Controls.Add(this.TxtCaminhoOrigem);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "FrmCompactador";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "COMPACTADOR HOLTZ";
            this.Load += new System.EventHandler(this.FrmCompactador_Load);
            ((System.ComponentModel.ISupportInitialize)(this.imgConfigCaminhoTemp)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.imgConfigCaminhoOrigem)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.imgConfigCaminhoDestino)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox TxtCaminhoOrigem;
        private System.Windows.Forms.TextBox txtNomeArquivo;
        private System.Windows.Forms.TextBox txtCaminhoDestino;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button BtnGerar;
        private System.Windows.Forms.ComboBox comboTipo;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.PictureBox imgConfigCaminhoDestino;
        private System.Windows.Forms.PictureBox imgConfigCaminhoOrigem;
        private Nevron.Nov.WinFormControls.NProgressBarControl nProgressBarControl1;
        private System.Windows.Forms.Button BtnGerarSemGravar;
        private System.Windows.Forms.FolderBrowserDialog folderDialog;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtCaminhoTemp;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.PictureBox imgConfigCaminhoTemp;
        private System.Windows.Forms.CheckBox checkSalvarTemp;
        private System.Windows.Forms.CheckBox checkSalvarOrigem;
        private System.Windows.Forms.CheckBox checkSalvarDestino;
        private System.Windows.Forms.Label SobrePastaTemporaria;
    }
}

