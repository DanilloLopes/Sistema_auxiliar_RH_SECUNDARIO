namespace iRh.Windows.Simuladores
{
    partial class frmBeneficioAdicionalNoturno
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
            this.txtTrabalhaQuantasHoras = new System.Windows.Forms.TextBox();
            this.lblTrabalhaQuantasHoras = new System.Windows.Forms.Label();
            this.txtSalarioBase = new System.Windows.Forms.TextBox();
            this.lblSalarioBase = new System.Windows.Forms.Label();
            this.txtHorasNoturnas = new System.Windows.Forms.TextBox();
            this.lblHorasNoturnas = new System.Windows.Forms.Label();
            this.btnCalcular = new System.Windows.Forms.Button();
            this.panelResultado = new System.Windows.Forms.Panel();
            this.lblResultado = new System.Windows.Forms.Label();
            this.lblTituloResultado = new System.Windows.Forms.Label();
            this.panelResultado.SuspendLayout();
            this.SuspendLayout();
            // 
            // txtTrabalhaQuantasHoras
            // 
            this.txtTrabalhaQuantasHoras.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTrabalhaQuantasHoras.Location = new System.Drawing.Point(193, 29);
            this.txtTrabalhaQuantasHoras.Name = "txtTrabalhaQuantasHoras";
            this.txtTrabalhaQuantasHoras.Size = new System.Drawing.Size(130, 25);
            this.txtTrabalhaQuantasHoras.TabIndex = 21;
            // 
            // lblTrabalhaQuantasHoras
            // 
            this.lblTrabalhaQuantasHoras.AutoSize = true;
            this.lblTrabalhaQuantasHoras.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTrabalhaQuantasHoras.Location = new System.Drawing.Point(190, 9);
            this.lblTrabalhaQuantasHoras.Name = "lblTrabalhaQuantasHoras";
            this.lblTrabalhaQuantasHoras.Size = new System.Drawing.Size(198, 17);
            this.lblTrabalhaQuantasHoras.TabIndex = 20;
            this.lblTrabalhaQuantasHoras.Text = "Trabalha quantas horas no mês?";
            // 
            // txtSalarioBase
            // 
            this.txtSalarioBase.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSalarioBase.Location = new System.Drawing.Point(12, 30);
            this.txtSalarioBase.Name = "txtSalarioBase";
            this.txtSalarioBase.Size = new System.Drawing.Size(130, 25);
            this.txtSalarioBase.TabIndex = 19;
            // 
            // lblSalarioBase
            // 
            this.lblSalarioBase.AutoSize = true;
            this.lblSalarioBase.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSalarioBase.Location = new System.Drawing.Point(9, 9);
            this.lblSalarioBase.Name = "lblSalarioBase";
            this.lblSalarioBase.Size = new System.Drawing.Size(133, 17);
            this.lblSalarioBase.TabIndex = 18;
            this.lblSalarioBase.Text = "Valor do Salário Base";
            // 
            // txtHorasNoturnas
            // 
            this.txtHorasNoturnas.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtHorasNoturnas.Location = new System.Drawing.Point(15, 97);
            this.txtHorasNoturnas.Name = "txtHorasNoturnas";
            this.txtHorasNoturnas.Size = new System.Drawing.Size(152, 25);
            this.txtHorasNoturnas.TabIndex = 23;
            // 
            // lblHorasNoturnas
            // 
            this.lblHorasNoturnas.AutoSize = true;
            this.lblHorasNoturnas.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblHorasNoturnas.Location = new System.Drawing.Point(12, 77);
            this.lblHorasNoturnas.Name = "lblHorasNoturnas";
            this.lblHorasNoturnas.Size = new System.Drawing.Size(238, 17);
            this.lblHorasNoturnas.TabIndex = 22;
            this.lblHorasNoturnas.Text = "Quantidade de horas noturnas mensais";
            // 
            // btnCalcular
            // 
            this.btnCalcular.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCalcular.Location = new System.Drawing.Point(15, 153);
            this.btnCalcular.Name = "btnCalcular";
            this.btnCalcular.Size = new System.Drawing.Size(127, 33);
            this.btnCalcular.TabIndex = 24;
            this.btnCalcular.Text = "Calcular";
            this.btnCalcular.UseVisualStyleBackColor = true;
            this.btnCalcular.Click += new System.EventHandler(this.btnCalcular_Click);
            // 
            // panelResultado
            // 
            this.panelResultado.BackColor = System.Drawing.Color.Transparent;
            this.panelResultado.Controls.Add(this.lblTituloResultado);
            this.panelResultado.Controls.Add(this.lblResultado);
            this.panelResultado.Location = new System.Drawing.Point(85, 236);
            this.panelResultado.Name = "panelResultado";
            this.panelResultado.Size = new System.Drawing.Size(343, 83);
            this.panelResultado.TabIndex = 25;
            this.panelResultado.Visible = false;
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
            // frmBeneficioAdicionalNoturno
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(565, 369);
            this.Controls.Add(this.panelResultado);
            this.Controls.Add(this.btnCalcular);
            this.Controls.Add(this.txtHorasNoturnas);
            this.Controls.Add(this.lblHorasNoturnas);
            this.Controls.Add(this.txtTrabalhaQuantasHoras);
            this.Controls.Add(this.lblTrabalhaQuantasHoras);
            this.Controls.Add(this.txtSalarioBase);
            this.Controls.Add(this.lblSalarioBase);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "frmBeneficioAdicionalNoturno";
            this.Text = "Adicional Noturno";
            this.panelResultado.ResumeLayout(false);
            this.panelResultado.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtTrabalhaQuantasHoras;
        private System.Windows.Forms.Label lblTrabalhaQuantasHoras;
        private System.Windows.Forms.TextBox txtSalarioBase;
        private System.Windows.Forms.Label lblSalarioBase;
        private System.Windows.Forms.TextBox txtHorasNoturnas;
        private System.Windows.Forms.Label lblHorasNoturnas;
        private System.Windows.Forms.Button btnCalcular;
        private System.Windows.Forms.Panel panelResultado;
        private System.Windows.Forms.Label lblTituloResultado;
        private System.Windows.Forms.Label lblResultado;
    }
}