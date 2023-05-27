namespace iRh.Windows.Cadastros
{
    partial class frmFuncionario
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
            this.cmbGenero = new System.Windows.Forms.ComboBox();
            this.rbTemFilhosSim = new System.Windows.Forms.RadioButton();
            this.rbTemFilhosNão = new System.Windows.Forms.RadioButton();
            this.lblTemFilhos = new System.Windows.Forms.Label();
            this.txtFilhoNome = new System.Windows.Forms.TextBox();
            this.lblFilhoNome = new System.Windows.Forms.Label();
            this.lblFilhoDataNascimento = new System.Windows.Forms.Label();
            this.lblIdade = new System.Windows.Forms.Label();
            this.panelExibeDadosFilhos = new System.Windows.Forms.Panel();
            this.txtFilhoDataNascimento = new System.Windows.Forms.MaskedTextBox();
            this.panelExibeDadosFilhos.SuspendLayout();
            this.SuspendLayout();
            // 
            // cmbGenero
            // 
            this.cmbGenero.FormattingEnabled = true;
            this.cmbGenero.Items.AddRange(new object[] {
            "Feminino",
            "Masculino",
            "Neutro",
            "Prefiro Não Dizer",
            "Outros"});
            this.cmbGenero.Location = new System.Drawing.Point(39, 42);
            this.cmbGenero.Name = "cmbGenero";
            this.cmbGenero.Size = new System.Drawing.Size(186, 21);
            this.cmbGenero.TabIndex = 0;
            // 
            // rbTemFilhosSim
            // 
            this.rbTemFilhosSim.AutoSize = true;
            this.rbTemFilhosSim.Location = new System.Drawing.Point(42, 111);
            this.rbTemFilhosSim.Name = "rbTemFilhosSim";
            this.rbTemFilhosSim.Size = new System.Drawing.Size(42, 17);
            this.rbTemFilhosSim.TabIndex = 1;
            this.rbTemFilhosSim.Text = "Sim";
            this.rbTemFilhosSim.UseVisualStyleBackColor = true;
            this.rbTemFilhosSim.CheckedChanged += new System.EventHandler(this.rbTemFilhosSim_CheckedChanged);
            // 
            // rbTemFilhosNão
            // 
            this.rbTemFilhosNão.AutoSize = true;
            this.rbTemFilhosNão.Location = new System.Drawing.Point(87, 111);
            this.rbTemFilhosNão.Name = "rbTemFilhosNão";
            this.rbTemFilhosNão.Size = new System.Drawing.Size(45, 17);
            this.rbTemFilhosNão.TabIndex = 2;
            this.rbTemFilhosNão.Text = "Não";
            this.rbTemFilhosNão.UseVisualStyleBackColor = true;
            this.rbTemFilhosNão.CheckedChanged += new System.EventHandler(this.rbTemFilhosNão_CheckedChanged);
            // 
            // lblTemFilhos
            // 
            this.lblTemFilhos.AutoSize = true;
            this.lblTemFilhos.Location = new System.Drawing.Point(39, 95);
            this.lblTemFilhos.Name = "lblTemFilhos";
            this.lblTemFilhos.Size = new System.Drawing.Size(85, 13);
            this.lblTemFilhos.TabIndex = 3;
            this.lblTemFilhos.Text = "Você tem filhos?";
            // 
            // txtFilhoNome
            // 
            this.txtFilhoNome.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtFilhoNome.Location = new System.Drawing.Point(0, 25);
            this.txtFilhoNome.Name = "txtFilhoNome";
            this.txtFilhoNome.Size = new System.Drawing.Size(100, 20);
            this.txtFilhoNome.TabIndex = 4;
            // 
            // lblFilhoNome
            // 
            this.lblFilhoNome.AutoSize = true;
            this.lblFilhoNome.Location = new System.Drawing.Point(-3, 0);
            this.lblFilhoNome.Name = "lblFilhoNome";
            this.lblFilhoNome.Size = new System.Drawing.Size(100, 13);
            this.lblFilhoNome.TabIndex = 6;
            this.lblFilhoNome.Text = "Nome do Seu Filho:";
            // 
            // lblFilhoDataNascimento
            // 
            this.lblFilhoDataNascimento.AutoSize = true;
            this.lblFilhoDataNascimento.Location = new System.Drawing.Point(114, 0);
            this.lblFilhoDataNascimento.Name = "lblFilhoDataNascimento";
            this.lblFilhoDataNascimento.Size = new System.Drawing.Size(107, 13);
            this.lblFilhoDataNascimento.TabIndex = 7;
            this.lblFilhoDataNascimento.Text = "Data de Nascimento:";
            // 
            // lblIdade
            // 
            this.lblIdade.AutoSize = true;
            this.lblIdade.Location = new System.Drawing.Point(223, 28);
            this.lblIdade.Name = "lblIdade";
            this.lblIdade.Size = new System.Drawing.Size(44, 13);
            this.lblIdade.TabIndex = 8;
            this.lblIdade.Text = "lblIdade";
            // 
            // panelExibeDadosFilhos
            // 
            this.panelExibeDadosFilhos.Controls.Add(this.txtFilhoDataNascimento);
            this.panelExibeDadosFilhos.Controls.Add(this.lblFilhoNome);
            this.panelExibeDadosFilhos.Controls.Add(this.txtFilhoNome);
            this.panelExibeDadosFilhos.Controls.Add(this.lblIdade);
            this.panelExibeDadosFilhos.Controls.Add(this.lblFilhoDataNascimento);
            this.panelExibeDadosFilhos.Location = new System.Drawing.Point(42, 155);
            this.panelExibeDadosFilhos.Name = "panelExibeDadosFilhos";
            this.panelExibeDadosFilhos.Size = new System.Drawing.Size(271, 66);
            this.panelExibeDadosFilhos.TabIndex = 9;
            // 
            // txtFilhoDataNascimento
            // 
            this.txtFilhoDataNascimento.Location = new System.Drawing.Point(117, 25);
            this.txtFilhoDataNascimento.Mask = "00/00/0000";
            this.txtFilhoDataNascimento.Name = "txtFilhoDataNascimento";
            this.txtFilhoDataNascimento.Size = new System.Drawing.Size(100, 20);
            this.txtFilhoDataNascimento.TabIndex = 10;
            this.txtFilhoDataNascimento.ValidatingType = typeof(System.DateTime);
            this.txtFilhoDataNascimento.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtFilhoDataNascimento_KeyDown);
            // 
            // frmFuncionario
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.lblTemFilhos);
            this.Controls.Add(this.panelExibeDadosFilhos);
            this.Controls.Add(this.rbTemFilhosNão);
            this.Controls.Add(this.rbTemFilhosSim);
            this.Controls.Add(this.cmbGenero);
            this.Name = "frmFuncionario";
            this.Text = "frmFuncionario";
            this.Load += new System.EventHandler(this.frmFuncionario_Load);
            this.panelExibeDadosFilhos.ResumeLayout(false);
            this.panelExibeDadosFilhos.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox cmbGenero;
        private System.Windows.Forms.RadioButton rbTemFilhosSim;
        private System.Windows.Forms.RadioButton rbTemFilhosNão;
        private System.Windows.Forms.Label lblTemFilhos;
        private System.Windows.Forms.TextBox txtFilhoNome;
        private System.Windows.Forms.Label lblFilhoNome;
        private System.Windows.Forms.Label lblFilhoDataNascimento;
        private System.Windows.Forms.Label lblIdade;
        private System.Windows.Forms.Panel panelExibeDadosFilhos;
        private System.Windows.Forms.MaskedTextBox txtFilhoDataNascimento;
    }
}