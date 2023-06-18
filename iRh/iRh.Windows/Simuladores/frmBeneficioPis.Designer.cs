namespace iRh.Windows.Simuladores
{
    partial class frmBeneficioPis
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
            this.panelResultado = new System.Windows.Forms.Panel();
            this.lblTituloResultado = new System.Windows.Forms.Label();
            this.lblResultado = new System.Windows.Forms.Label();
            this.btnCalcular = new System.Windows.Forms.Button();
            this.txtSalarioBase = new System.Windows.Forms.TextBox();
            this.lblSalarioBase = new System.Windows.Forms.Label();
            this.cmbRecebeAdicionalNoturno = new System.Windows.Forms.ComboBox();
            this.lblAnosTrabalhados = new System.Windows.Forms.Label();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.lblMesesTrabalhados = new System.Windows.Forms.Label();
            this.panelResultado.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelResultado
            // 
            this.panelResultado.BackColor = System.Drawing.Color.Transparent;
            this.panelResultado.Controls.Add(this.lblTituloResultado);
            this.panelResultado.Controls.Add(this.lblResultado);
            this.panelResultado.Location = new System.Drawing.Point(87, 203);
            this.panelResultado.Name = "panelResultado";
            this.panelResultado.Size = new System.Drawing.Size(343, 83);
            this.panelResultado.TabIndex = 33;
            this.panelResultado.Visible = false;
            // 
            // lblTituloResultado
            // 
            this.lblTituloResultado.AutoSize = true;
            this.lblTituloResultado.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTituloResultado.Location = new System.Drawing.Point(3, 0);
            this.lblTituloResultado.Name = "lblTituloResultado";
            this.lblTituloResultado.Size = new System.Drawing.Size(140, 20);
            this.lblTituloResultado.TabIndex = 26;
            this.lblTituloResultado.Text = "Valor do Adicional:";
            // 
            // lblResultado
            // 
            this.lblResultado.AutoSize = true;
            this.lblResultado.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblResultado.Location = new System.Drawing.Point(103, 35);
            this.lblResultado.Name = "lblResultado";
            this.lblResultado.Size = new System.Drawing.Size(126, 30);
            this.lblResultado.TabIndex = 4;
            this.lblResultado.Text = "lblResultado";
            // 
            // btnCalcular
            // 
            this.btnCalcular.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCalcular.Location = new System.Drawing.Point(12, 148);
            this.btnCalcular.Name = "btnCalcular";
            this.btnCalcular.Size = new System.Drawing.Size(127, 33);
            this.btnCalcular.TabIndex = 32;
            this.btnCalcular.Text = "Calcular";
            this.btnCalcular.UseVisualStyleBackColor = true;
            this.btnCalcular.Click += new System.EventHandler(this.btnCalcular_Click);
            // 
            // txtSalarioBase
            // 
            this.txtSalarioBase.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSalarioBase.Location = new System.Drawing.Point(15, 30);
            this.txtSalarioBase.Name = "txtSalarioBase";
            this.txtSalarioBase.Size = new System.Drawing.Size(130, 25);
            this.txtSalarioBase.TabIndex = 27;
            // 
            // lblSalarioBase
            // 
            this.lblSalarioBase.AutoSize = true;
            this.lblSalarioBase.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSalarioBase.Location = new System.Drawing.Point(12, 9);
            this.lblSalarioBase.Name = "lblSalarioBase";
            this.lblSalarioBase.Size = new System.Drawing.Size(133, 17);
            this.lblSalarioBase.TabIndex = 26;
            this.lblSalarioBase.Text = "Valor do Salário Base";
            // 
            // cmbRecebeAdicionalNoturno
            // 
            this.cmbRecebeAdicionalNoturno.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbRecebeAdicionalNoturno.FormattingEnabled = true;
            this.cmbRecebeAdicionalNoturno.Items.AddRange(new object[] {
            "Não",
            "Sim"});
            this.cmbRecebeAdicionalNoturno.Location = new System.Drawing.Point(225, 30);
            this.cmbRecebeAdicionalNoturno.Name = "cmbRecebeAdicionalNoturno";
            this.cmbRecebeAdicionalNoturno.Size = new System.Drawing.Size(121, 25);
            this.cmbRecebeAdicionalNoturno.TabIndex = 28;
            // 
            // lblAnosTrabalhados
            // 
            this.lblAnosTrabalhados.AutoSize = true;
            this.lblAnosTrabalhados.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAnosTrabalhados.Location = new System.Drawing.Point(222, 9);
            this.lblAnosTrabalhados.Name = "lblAnosTrabalhados";
            this.lblAnosTrabalhados.Size = new System.Drawing.Size(168, 17);
            this.lblAnosTrabalhados.TabIndex = 27;
            this.lblAnosTrabalhados.Text = "Trabalha a 5 anos ou mais?";
            // 
            // comboBox1
            // 
            this.comboBox1.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Items.AddRange(new object[] {
            "01",
            "02",
            "03",
            "04",
            "05",
            "06",
            "07",
            "08",
            "09",
            "10",
            "11",
            "12"});
            this.comboBox1.Location = new System.Drawing.Point(15, 96);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(121, 25);
            this.comboBox1.TabIndex = 35;
            // 
            // lblMesesTrabalhados
            // 
            this.lblMesesTrabalhados.AutoSize = true;
            this.lblMesesTrabalhados.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMesesTrabalhados.Location = new System.Drawing.Point(12, 75);
            this.lblMesesTrabalhados.Name = "lblMesesTrabalhados";
            this.lblMesesTrabalhados.Size = new System.Drawing.Size(220, 17);
            this.lblMesesTrabalhados.TabIndex = 34;
            this.lblMesesTrabalhados.Text = "Quantos meses trabalhou esse ano?";
            // 
            // frmBeneficioPis
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(543, 344);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.lblMesesTrabalhados);
            this.Controls.Add(this.cmbRecebeAdicionalNoturno);
            this.Controls.Add(this.panelResultado);
            this.Controls.Add(this.lblAnosTrabalhados);
            this.Controls.Add(this.btnCalcular);
            this.Controls.Add(this.txtSalarioBase);
            this.Controls.Add(this.lblSalarioBase);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "frmBeneficioPis";
            this.Text = "Beneficio PIS";
            this.panelResultado.ResumeLayout(false);
            this.panelResultado.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panelResultado;
        private System.Windows.Forms.Label lblTituloResultado;
        private System.Windows.Forms.Label lblResultado;
        private System.Windows.Forms.Button btnCalcular;
        private System.Windows.Forms.TextBox txtSalarioBase;
        private System.Windows.Forms.Label lblSalarioBase;
        private System.Windows.Forms.ComboBox cmbRecebeAdicionalNoturno;
        private System.Windows.Forms.Label lblAnosTrabalhados;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Label lblMesesTrabalhados;
    }
}