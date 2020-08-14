namespace Holtz_Compactador
{
    partial class FrmExcecoes
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmExcecoes));
            this.label1 = new System.Windows.Forms.Label();
            this.listExtensoes = new System.Windows.Forms.ListBox();
            this.listPastas = new System.Windows.Forms.ListBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txtNovaExtensao = new System.Windows.Forms.TextBox();
            this.BtnAddExtensao = new System.Windows.Forms.Button();
            this.BtnAddPasta = new System.Windows.Forms.Button();
            this.txtNovaPasta = new System.Windows.Forms.TextBox();
            this.BtnGravar = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.BtnRemoverExtensao = new System.Windows.Forms.Button();
            this.BtnRemoverPasta = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.label1.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(92, 14);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(509, 36);
            this.label1.TabIndex = 0;
            this.label1.Text = "         Aqui você pode configurar extensões e pastas \r\nPARA NÃO COPIAR NO ARQUIV" +
    "O FINAL (COMPACTADO)";
            // 
            // listExtensoes
            // 
            this.listExtensoes.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.listExtensoes.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.listExtensoes.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.listExtensoes.FormattingEnabled = true;
            this.listExtensoes.Location = new System.Drawing.Point(25, 109);
            this.listExtensoes.Name = "listExtensoes";
            this.listExtensoes.Size = new System.Drawing.Size(228, 130);
            this.listExtensoes.TabIndex = 1;
            this.listExtensoes.SelectedIndexChanged += new System.EventHandler(this.listExtensoes_SelectedIndexChanged);
            // 
            // listPastas
            // 
            this.listPastas.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.listPastas.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.listPastas.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.listPastas.FormattingEnabled = true;
            this.listPastas.Location = new System.Drawing.Point(328, 109);
            this.listPastas.Name = "listPastas";
            this.listPastas.Size = new System.Drawing.Size(303, 130);
            this.listPastas.TabIndex = 2;
            this.listPastas.SelectedIndexChanged += new System.EventHandler(this.listPastas_SelectedIndexChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label2.Location = new System.Drawing.Point(25, 90);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(56, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Extensões";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label3.Location = new System.Drawing.Point(328, 90);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(39, 13);
            this.label3.TabIndex = 4;
            this.label3.Text = "Pastas";
            // 
            // txtNovaExtensao
            // 
            this.txtNovaExtensao.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.txtNovaExtensao.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtNovaExtensao.ForeColor = System.Drawing.SystemColors.Window;
            this.txtNovaExtensao.Location = new System.Drawing.Point(25, 250);
            this.txtNovaExtensao.Name = "txtNovaExtensao";
            this.txtNovaExtensao.Size = new System.Drawing.Size(139, 20);
            this.txtNovaExtensao.TabIndex = 5;
            // 
            // BtnAddExtensao
            // 
            this.BtnAddExtensao.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.BtnAddExtensao.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.BtnAddExtensao.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.BtnAddExtensao.Location = new System.Drawing.Point(170, 249);
            this.BtnAddExtensao.Name = "BtnAddExtensao";
            this.BtnAddExtensao.Size = new System.Drawing.Size(83, 23);
            this.BtnAddExtensao.TabIndex = 6;
            this.BtnAddExtensao.Text = "Add Extensão";
            this.BtnAddExtensao.UseVisualStyleBackColor = false;
            this.BtnAddExtensao.Click += new System.EventHandler(this.BtnAddExtensao_Click);
            // 
            // BtnAddPasta
            // 
            this.BtnAddPasta.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.BtnAddPasta.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.BtnAddPasta.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.BtnAddPasta.Location = new System.Drawing.Point(548, 249);
            this.BtnAddPasta.Name = "BtnAddPasta";
            this.BtnAddPasta.Size = new System.Drawing.Size(83, 23);
            this.BtnAddPasta.TabIndex = 8;
            this.BtnAddPasta.Text = "Add Pasta";
            this.BtnAddPasta.UseVisualStyleBackColor = false;
            this.BtnAddPasta.Click += new System.EventHandler(this.BtnAddPasta_Click);
            // 
            // txtNovaPasta
            // 
            this.txtNovaPasta.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.txtNovaPasta.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtNovaPasta.ForeColor = System.Drawing.SystemColors.Window;
            this.txtNovaPasta.Location = new System.Drawing.Point(328, 250);
            this.txtNovaPasta.Name = "txtNovaPasta";
            this.txtNovaPasta.Size = new System.Drawing.Size(214, 20);
            this.txtNovaPasta.TabIndex = 7;
            // 
            // BtnGravar
            // 
            this.BtnGravar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.BtnGravar.FlatAppearance.BorderColor = System.Drawing.Color.Gray;
            this.BtnGravar.FlatAppearance.BorderSize = 2;
            this.BtnGravar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnGravar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnGravar.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.BtnGravar.Location = new System.Drawing.Point(328, 279);
            this.BtnGravar.Name = "BtnGravar";
            this.BtnGravar.Size = new System.Drawing.Size(303, 62);
            this.BtnGravar.TabIndex = 9;
            this.BtnGravar.Text = "GRAVAR TODAS EXCEÇÕES";
            this.BtnGravar.UseVisualStyleBackColor = false;
            this.BtnGravar.Click += new System.EventHandler(this.BtnGravar_Click);
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.button2.FlatAppearance.BorderColor = System.Drawing.Color.Gray;
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.button2.Location = new System.Drawing.Point(58, 288);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(156, 47);
            this.button2.TabIndex = 10;
            this.button2.Text = "FECHAR SEM SALVAR";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // BtnRemoverExtensao
            // 
            this.BtnRemoverExtensao.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.BtnRemoverExtensao.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.BtnRemoverExtensao.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.BtnRemoverExtensao.Location = new System.Drawing.Point(178, 80);
            this.BtnRemoverExtensao.Name = "BtnRemoverExtensao";
            this.BtnRemoverExtensao.Size = new System.Drawing.Size(75, 23);
            this.BtnRemoverExtensao.TabIndex = 11;
            this.BtnRemoverExtensao.Text = "Remover";
            this.BtnRemoverExtensao.UseVisualStyleBackColor = false;
            this.BtnRemoverExtensao.Click += new System.EventHandler(this.BtnRemoverExtensao_Click);
            // 
            // BtnRemoverPasta
            // 
            this.BtnRemoverPasta.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.BtnRemoverPasta.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.BtnRemoverPasta.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.BtnRemoverPasta.Location = new System.Drawing.Point(556, 80);
            this.BtnRemoverPasta.Name = "BtnRemoverPasta";
            this.BtnRemoverPasta.Size = new System.Drawing.Size(75, 23);
            this.BtnRemoverPasta.TabIndex = 12;
            this.BtnRemoverPasta.Text = "Remover";
            this.BtnRemoverPasta.UseVisualStyleBackColor = false;
            this.BtnRemoverPasta.Click += new System.EventHandler(this.BtnRemoverPasta_Click);
            // 
            // FrmExcecoes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Black;
            this.ClientSize = new System.Drawing.Size(648, 353);
            this.Controls.Add(this.BtnRemoverPasta);
            this.Controls.Add(this.BtnRemoverExtensao);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.BtnGravar);
            this.Controls.Add(this.BtnAddPasta);
            this.Controls.Add(this.txtNovaPasta);
            this.Controls.Add(this.BtnAddExtensao);
            this.Controls.Add(this.txtNovaExtensao);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.listPastas);
            this.Controls.Add(this.listExtensoes);
            this.Controls.Add(this.label1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(664, 392);
            this.MinimizeBox = false;
            this.MinimumSize = new System.Drawing.Size(664, 392);
            this.Name = "FrmExcecoes";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "CONFIGURAÇÃO DE EXCEÇÕES";
            this.Load += new System.EventHandler(this.FrmExcecoes_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ListBox listExtensoes;
        private System.Windows.Forms.ListBox listPastas;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtNovaExtensao;
        private System.Windows.Forms.Button BtnAddExtensao;
        private System.Windows.Forms.Button BtnAddPasta;
        private System.Windows.Forms.TextBox txtNovaPasta;
        private System.Windows.Forms.Button BtnGravar;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button BtnRemoverExtensao;
        private System.Windows.Forms.Button BtnRemoverPasta;
    }
}