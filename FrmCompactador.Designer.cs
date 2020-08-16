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
            this.BtnGerarSemGravar = new System.Windows.Forms.Button();
            this.folderDialog = new System.Windows.Forms.FolderBrowserDialog();
            this.txtComoFunciona = new System.Windows.Forms.Label();
            this.checkSalvarOrigem = new System.Windows.Forms.CheckBox();
            this.checkSalvarDestino = new System.Windows.Forms.CheckBox();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.extensoesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.checkSalvarNomeArquivo = new System.Windows.Forms.CheckBox();
            this.checkSalvarTipo = new System.Windows.Forms.CheckBox();
            this.imgOpenZip = new System.Windows.Forms.PictureBox();
            this.imgOpenCaminhoDestino = new System.Windows.Forms.PictureBox();
            this.imgOpenCaminhoOrigem = new System.Windows.Forms.PictureBox();
            this.imgConfigCaminhoOrigem = new System.Windows.Forms.PictureBox();
            this.imgConfigCaminhoDestino = new System.Windows.Forms.PictureBox();
            this.opçõesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.limparExceçõesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.limparConfiguraçõesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.imgOpenZip)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.imgOpenCaminhoDestino)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.imgOpenCaminhoOrigem)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.imgConfigCaminhoOrigem)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.imgConfigCaminhoDestino)).BeginInit();
            this.SuspendLayout();
            // 
            // TxtCaminhoOrigem
            // 
            this.TxtCaminhoOrigem.BackColor = System.Drawing.Color.Silver;
            this.TxtCaminhoOrigem.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.TxtCaminhoOrigem.Location = new System.Drawing.Point(100, 105);
            this.TxtCaminhoOrigem.Name = "TxtCaminhoOrigem";
            this.TxtCaminhoOrigem.Size = new System.Drawing.Size(225, 20);
            this.TxtCaminhoOrigem.TabIndex = 0;
            // 
            // txtNomeArquivo
            // 
            this.txtNomeArquivo.BackColor = System.Drawing.Color.Silver;
            this.txtNomeArquivo.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtNomeArquivo.Location = new System.Drawing.Point(100, 156);
            this.txtNomeArquivo.Name = "txtNomeArquivo";
            this.txtNomeArquivo.Size = new System.Drawing.Size(225, 20);
            this.txtNomeArquivo.TabIndex = 1;
            // 
            // txtCaminhoDestino
            // 
            this.txtCaminhoDestino.BackColor = System.Drawing.Color.Silver;
            this.txtCaminhoDestino.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtCaminhoDestino.Location = new System.Drawing.Point(100, 203);
            this.txtCaminhoDestino.Name = "txtCaminhoDestino";
            this.txtCaminhoDestino.Size = new System.Drawing.Size(225, 20);
            this.txtCaminhoDestino.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label1.Location = new System.Drawing.Point(100, 92);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(97, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "Caminho de origem";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label2.Location = new System.Drawing.Point(100, 143);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(114, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "Nome do Arquivo Final";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label3.Location = new System.Drawing.Point(100, 190);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(87, 13);
            this.label3.TabIndex = 5;
            this.label3.Text = "Caminho Destino";
            // 
            // BtnGerar
            // 
            this.BtnGerar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.BtnGerar.FlatAppearance.BorderColor = System.Drawing.Color.Gray;
            this.BtnGerar.FlatAppearance.BorderSize = 2;
            this.BtnGerar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnGerar.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnGerar.ForeColor = System.Drawing.Color.White;
            this.BtnGerar.Location = new System.Drawing.Point(235, 269);
            this.BtnGerar.Name = "BtnGerar";
            this.BtnGerar.Size = new System.Drawing.Size(153, 73);
            this.BtnGerar.TabIndex = 7;
            this.BtnGerar.Text = "COMPACTAR E SALVAR";
            this.BtnGerar.UseVisualStyleBackColor = false;
            this.BtnGerar.Click += new System.EventHandler(this.BtnGerar_Click);
            // 
            // comboTipo
            // 
            this.comboTipo.BackColor = System.Drawing.Color.Silver;
            this.comboTipo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboTipo.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboTipo.Items.AddRange(new object[] {
            ".RAR",
            ".ZIP"});
            this.comboTipo.Location = new System.Drawing.Point(151, 45);
            this.comboTipo.MaxLength = 4;
            this.comboTipo.Name = "comboTipo";
            this.comboTipo.Size = new System.Drawing.Size(121, 21);
            this.comboTipo.TabIndex = 8;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label4.Location = new System.Drawing.Point(117, 48);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(28, 13);
            this.label4.TabIndex = 9;
            this.label4.Text = "Tipo";
            // 
            // BtnGerarSemGravar
            // 
            this.BtnGerarSemGravar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.BtnGerarSemGravar.FlatAppearance.BorderColor = System.Drawing.Color.Gray;
            this.BtnGerarSemGravar.FlatAppearance.BorderSize = 2;
            this.BtnGerarSemGravar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnGerarSemGravar.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnGerarSemGravar.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.BtnGerarSemGravar.Location = new System.Drawing.Point(34, 269);
            this.BtnGerarSemGravar.Name = "BtnGerarSemGravar";
            this.BtnGerarSemGravar.Size = new System.Drawing.Size(153, 73);
            this.BtnGerarSemGravar.TabIndex = 16;
            this.BtnGerarSemGravar.Text = "COMPACTAR";
            this.BtnGerarSemGravar.UseVisualStyleBackColor = false;
            this.BtnGerarSemGravar.Click += new System.EventHandler(this.BtnGerarSemGravar_Click);
            // 
            // txtComoFunciona
            // 
            this.txtComoFunciona.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.txtComoFunciona.AutoSize = true;
            this.txtComoFunciona.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.txtComoFunciona.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.txtComoFunciona.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtComoFunciona.ForeColor = System.Drawing.Color.Silver;
            this.txtComoFunciona.Location = new System.Drawing.Point(283, 6);
            this.txtComoFunciona.Name = "txtComoFunciona";
            this.txtComoFunciona.Size = new System.Drawing.Size(127, 16);
            this.txtComoFunciona.TabIndex = 19;
            this.txtComoFunciona.Text = "Como Funciona ?";
            this.txtComoFunciona.Click += new System.EventHandler(this.txtComoFunciona_Click);
            // 
            // checkSalvarOrigem
            // 
            this.checkSalvarOrigem.AutoSize = true;
            this.checkSalvarOrigem.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.checkSalvarOrigem.Location = new System.Drawing.Point(332, 107);
            this.checkSalvarOrigem.Name = "checkSalvarOrigem";
            this.checkSalvarOrigem.Size = new System.Drawing.Size(56, 17);
            this.checkSalvarOrigem.TabIndex = 22;
            this.checkSalvarOrigem.Text = "Salvar";
            this.checkSalvarOrigem.UseVisualStyleBackColor = true;
            // 
            // checkSalvarDestino
            // 
            this.checkSalvarDestino.AutoSize = true;
            this.checkSalvarDestino.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.checkSalvarDestino.Location = new System.Drawing.Point(332, 205);
            this.checkSalvarDestino.Name = "checkSalvarDestino";
            this.checkSalvarDestino.Size = new System.Drawing.Size(56, 17);
            this.checkSalvarDestino.TabIndex = 23;
            this.checkSalvarDestino.Text = "Salvar";
            this.checkSalvarDestino.UseVisualStyleBackColor = true;
            // 
            // menuStrip1
            // 
            this.menuStrip1.BackColor = System.Drawing.Color.Black;
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.extensoesToolStripMenuItem,
            this.opçõesToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(412, 24);
            this.menuStrip1.TabIndex = 25;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // extensoesToolStripMenuItem
            // 
            this.extensoesToolStripMenuItem.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.extensoesToolStripMenuItem.Name = "extensoesToolStripMenuItem";
            this.extensoesToolStripMenuItem.Size = new System.Drawing.Size(66, 20);
            this.extensoesToolStripMenuItem.Text = "Exceções";
            this.extensoesToolStripMenuItem.Click += new System.EventHandler(this.extensoesToolStripMenuItem_Click);
            // 
            // checkSalvarNomeArquivo
            // 
            this.checkSalvarNomeArquivo.AutoSize = true;
            this.checkSalvarNomeArquivo.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.checkSalvarNomeArquivo.Location = new System.Drawing.Point(332, 156);
            this.checkSalvarNomeArquivo.Name = "checkSalvarNomeArquivo";
            this.checkSalvarNomeArquivo.Size = new System.Drawing.Size(56, 17);
            this.checkSalvarNomeArquivo.TabIndex = 26;
            this.checkSalvarNomeArquivo.Text = "Salvar";
            this.checkSalvarNomeArquivo.UseVisualStyleBackColor = true;
            // 
            // checkSalvarTipo
            // 
            this.checkSalvarTipo.AutoSize = true;
            this.checkSalvarTipo.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.checkSalvarTipo.Location = new System.Drawing.Point(278, 49);
            this.checkSalvarTipo.Name = "checkSalvarTipo";
            this.checkSalvarTipo.Size = new System.Drawing.Size(56, 17);
            this.checkSalvarTipo.TabIndex = 27;
            this.checkSalvarTipo.Text = "Salvar";
            this.checkSalvarTipo.UseVisualStyleBackColor = true;
            // 
            // imgOpenZip
            // 
            this.imgOpenZip.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("imgOpenZip.BackgroundImage")));
            this.imgOpenZip.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.imgOpenZip.Location = new System.Drawing.Point(68, 143);
            this.imgOpenZip.Name = "imgOpenZip";
            this.imgOpenZip.Size = new System.Drawing.Size(28, 33);
            this.imgOpenZip.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.imgOpenZip.TabIndex = 31;
            this.imgOpenZip.TabStop = false;
            this.imgOpenZip.Click += new System.EventHandler(this.imgOpenZip_Click);
            // 
            // imgOpenCaminhoDestino
            // 
            this.imgOpenCaminhoDestino.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("imgOpenCaminhoDestino.BackgroundImage")));
            this.imgOpenCaminhoDestino.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.imgOpenCaminhoDestino.Location = new System.Drawing.Point(68, 195);
            this.imgOpenCaminhoDestino.Name = "imgOpenCaminhoDestino";
            this.imgOpenCaminhoDestino.Size = new System.Drawing.Size(28, 33);
            this.imgOpenCaminhoDestino.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.imgOpenCaminhoDestino.TabIndex = 30;
            this.imgOpenCaminhoDestino.TabStop = false;
            this.imgOpenCaminhoDestino.Click += new System.EventHandler(this.imgOpenCaminhoDestino_Click);
            // 
            // imgOpenCaminhoOrigem
            // 
            this.imgOpenCaminhoOrigem.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("imgOpenCaminhoOrigem.BackgroundImage")));
            this.imgOpenCaminhoOrigem.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.imgOpenCaminhoOrigem.Location = new System.Drawing.Point(68, 94);
            this.imgOpenCaminhoOrigem.Name = "imgOpenCaminhoOrigem";
            this.imgOpenCaminhoOrigem.Size = new System.Drawing.Size(28, 33);
            this.imgOpenCaminhoOrigem.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.imgOpenCaminhoOrigem.TabIndex = 29;
            this.imgOpenCaminhoOrigem.TabStop = false;
            this.imgOpenCaminhoOrigem.Click += new System.EventHandler(this.imgOpenCaminhoOrigem_Click);
            // 
            // imgConfigCaminhoOrigem
            // 
            this.imgConfigCaminhoOrigem.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("imgConfigCaminhoOrigem.BackgroundImage")));
            this.imgConfigCaminhoOrigem.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.imgConfigCaminhoOrigem.Location = new System.Drawing.Point(34, 97);
            this.imgConfigCaminhoOrigem.Name = "imgConfigCaminhoOrigem";
            this.imgConfigCaminhoOrigem.Size = new System.Drawing.Size(28, 28);
            this.imgConfigCaminhoOrigem.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.imgConfigCaminhoOrigem.TabIndex = 14;
            this.imgConfigCaminhoOrigem.TabStop = false;
            this.imgConfigCaminhoOrigem.Click += new System.EventHandler(this.imgConfigCaminhoOrigem_Click);
            // 
            // imgConfigCaminhoDestino
            // 
            this.imgConfigCaminhoDestino.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("imgConfigCaminhoDestino.BackgroundImage")));
            this.imgConfigCaminhoDestino.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.imgConfigCaminhoDestino.Location = new System.Drawing.Point(34, 195);
            this.imgConfigCaminhoDestino.Name = "imgConfigCaminhoDestino";
            this.imgConfigCaminhoDestino.Size = new System.Drawing.Size(28, 28);
            this.imgConfigCaminhoDestino.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.imgConfigCaminhoDestino.TabIndex = 13;
            this.imgConfigCaminhoDestino.TabStop = false;
            this.imgConfigCaminhoDestino.Click += new System.EventHandler(this.imgConfigCaminhoDestino_Click);
            // 
            // opçõesToolStripMenuItem
            // 
            this.opçõesToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.limparExceçõesToolStripMenuItem,
            this.limparConfiguraçõesToolStripMenuItem});
            this.opçõesToolStripMenuItem.ForeColor = System.Drawing.Color.White;
            this.opçõesToolStripMenuItem.Name = "opçõesToolStripMenuItem";
            this.opçõesToolStripMenuItem.Size = new System.Drawing.Size(59, 20);
            this.opçõesToolStripMenuItem.Text = "Opções";
            // 
            // limparExceçõesToolStripMenuItem
            // 
            this.limparExceçõesToolStripMenuItem.Name = "limparExceçõesToolStripMenuItem";
            this.limparExceçõesToolStripMenuItem.Size = new System.Drawing.Size(191, 22);
            this.limparExceçõesToolStripMenuItem.Text = "Limpar Exceções";
            this.limparExceçõesToolStripMenuItem.Click += new System.EventHandler(this.limparExceçõesToolStripMenuItem_Click);
            // 
            // limparConfiguraçõesToolStripMenuItem
            // 
            this.limparConfiguraçõesToolStripMenuItem.Name = "limparConfiguraçõesToolStripMenuItem";
            this.limparConfiguraçõesToolStripMenuItem.Size = new System.Drawing.Size(191, 22);
            this.limparConfiguraçõesToolStripMenuItem.Text = "Limpar Configurações";
            this.limparConfiguraçõesToolStripMenuItem.Click += new System.EventHandler(this.limparConfiguraçõesToolStripMenuItem_Click);
            // 
            // FrmCompactador
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Black;
            this.ClientSize = new System.Drawing.Size(412, 360);
            this.Controls.Add(this.imgOpenZip);
            this.Controls.Add(this.imgOpenCaminhoDestino);
            this.Controls.Add(this.imgOpenCaminhoOrigem);
            this.Controls.Add(this.checkSalvarTipo);
            this.Controls.Add(this.checkSalvarNomeArquivo);
            this.Controls.Add(this.checkSalvarDestino);
            this.Controls.Add(this.checkSalvarOrigem);
            this.Controls.Add(this.txtComoFunciona);
            this.Controls.Add(this.BtnGerarSemGravar);
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
            this.Controls.Add(this.menuStrip1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStrip1;
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(428, 399);
            this.Name = "FrmCompactador";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "COMPACTADOR HOLTZ";
            this.Load += new System.EventHandler(this.FrmCompactador_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.imgOpenZip)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.imgOpenCaminhoDestino)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.imgOpenCaminhoOrigem)).EndInit();
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
        private System.Windows.Forms.Button BtnGerarSemGravar;
        private System.Windows.Forms.FolderBrowserDialog folderDialog;
        private System.Windows.Forms.Label txtComoFunciona;
        private System.Windows.Forms.CheckBox checkSalvarOrigem;
        private System.Windows.Forms.CheckBox checkSalvarDestino;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem extensoesToolStripMenuItem;
        private System.Windows.Forms.CheckBox checkSalvarNomeArquivo;
        private System.Windows.Forms.CheckBox checkSalvarTipo;
        private System.Windows.Forms.PictureBox imgOpenCaminhoOrigem;
        private System.Windows.Forms.PictureBox imgOpenCaminhoDestino;
        private System.Windows.Forms.PictureBox imgOpenZip;
        private System.Windows.Forms.ToolStripMenuItem opçõesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem limparExceçõesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem limparConfiguraçõesToolStripMenuItem;
    }
}

