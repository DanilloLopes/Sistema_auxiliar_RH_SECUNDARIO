namespace iRh.Windows.Simuladores
{
    partial class frmBeneficioHoraExtra
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
            this.txtHorasExtras = new System.Windows.Forms.TextBox();
            this.lblHorasExtras = new System.Windows.Forms.Label();
            this.txtTrabalhaQuantasHoras = new System.Windows.Forms.TextBox();
            this.lblTrabalhaQuantasHoras = new System.Windows.Forms.Label();
            this.txtSalarioBase = new System.Windows.Forms.TextBox();
            this.lblSalarioBase = new System.Windows.Forms.Label();
            this.panelResultado.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelResultado
            // 
            this.panelResultado.BackColor = System.Drawing.Color.Transparent;
            this.panelResultado.Controls.Add(this.lblTituloResultado);
            this.panelResultado.Controls.Add(this.lblResultado);
            this.panelResultado.Location = new System.Drawing.Point(88, 236);
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
            this.btnCalcular.Location = new System.Drawing.Point(18, 153);
            this.btnCalcular.Name = "btnCalcular";
            this.btnCalcular.Size = new System.Drawing.Size(127, 33);
            this.btnCalcular.TabIndex = 32;
            this.btnCalcular.Text = "Calcular";
            this.btnCalcular.UseVisualStyleBackColor = true;
            this.btnCalcular.Click += new System.EventHandler(this.btnCalcular_Click);
            // 
            // txtHorasExtras
            // 
            this.txtHorasExtras.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtHorasExtras.Location = new System.Drawing.Point(18, 97);
            this.txtHorasExtras.Name = "txtHorasExtras";
            this.txtHorasExtras.Size = new System.Drawing.Size(152, 25);
            this.txtHorasExtras.TabIndex = 31;
            // 
            // lblHorasExtras
            // 
            this.lblHorasExtras.AutoSize = true;
            this.lblHorasExtras.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblHorasExtras.Location = new System.Drawing.Point(15, 77);
            this.lblHorasExtras.Name = "lblHorasExtras";
            this.lblHorasExtras.Size = new System.Drawing.Size(171, 17);
            this.lblHorasExtras.TabIndex = 30;
            this.lblHorasExtras.Text = "Quantidade de horas extras";
            // 
            // txtTrabalhaQuantasHoras
            // 
            this.txtTrabalhaQuantasHoras.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTrabalhaQuantasHoras.Location = new System.Drawing.Point(196, 29);
            this.txtTrabalhaQuantasHoras.Name = "txtTrabalhaQuantasHoras";
            this.txtTrabalhaQuantasHoras.Size = new System.Drawing.Size(130, 25);
            this.txtTrabalhaQuantasHoras.TabIndex = 29;
            // 
            // lblTrabalhaQuantasHoras
            // 
            this.lblTrabalhaQuantasHoras.AutoSize = true;
            this.lblTrabalhaQuantasHoras.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTrabalhaQuantasHoras.Location = new System.Drawing.Point(193, 9);
            this.lblTrabalhaQuantasHoras.Name = "lblTrabalhaQuantasHoras";
            this.lblTrabalhaQuantasHoras.Size = new System.Drawing.Size(198, 17);
            this.lblTrabalhaQuantasHoras.TabIndex = 28;
            this.lblTrabalhaQuantasHoras.Text = "Trabalha quantas horas no mês?";
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
            // frmBeneficioHoraExtra
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(548, 343);
            this.Controls.Add(this.panelResultado);
            this.Controls.Add(this.btnCalcular);
            this.Controls.Add(this.txtHorasExtras);
            this.Controls.Add(this.lblHorasExtras);
            this.Controls.Add(this.txtTrabalhaQuantasHoras);
            this.Controls.Add(this.lblTrabalhaQuantasHoras);
            this.Controls.Add(this.txtSalarioBase);
            this.Controls.Add(this.lblSalarioBase);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.MaximizeBox = false;
            this.Name = "frmBeneficioHoraExtra";
            this.Text = "Hora Extra";
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
        private System.Windows.Forms.TextBox txtHorasExtras;
        private System.Windows.Forms.Label lblHorasExtras;
        private System.Windows.Forms.TextBox txtTrabalhaQuantasHoras;
        private System.Windows.Forms.Label lblTrabalhaQuantasHoras;
        private System.Windows.Forms.TextBox txtSalarioBase;
        private System.Windows.Forms.Label lblSalarioBase;
    }
}