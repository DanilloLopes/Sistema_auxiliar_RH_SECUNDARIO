namespace iRh.Windows.Simuladores
{
    partial class frmBeneficioPericulosidade
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
            this.panelResultado.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelResultado
            // 
            this.panelResultado.BackColor = System.Drawing.Color.Transparent;
            this.panelResultado.Controls.Add(this.lblTituloResultado);
            this.panelResultado.Controls.Add(this.lblResultado);
            this.panelResultado.Location = new System.Drawing.Point(67, 167);
            this.panelResultado.Name = "panelResultado";
            this.panelResultado.Size = new System.Drawing.Size(343, 83);
            this.panelResultado.TabIndex = 33;
            this.panelResultado.Visible = false;
            // 
            // lblTituloResultado
            // 
            this.lblTituloResultado.AutoSize = true;
            this.lblTituloResultado.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTituloResultado.Location = new System.Drawing.Point(-4, 0);
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
            this.btnCalcular.Location = new System.Drawing.Point(31, 85);
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
            this.txtSalarioBase.Location = new System.Drawing.Point(34, 41);
            this.txtSalarioBase.Name = "txtSalarioBase";
            this.txtSalarioBase.Size = new System.Drawing.Size(130, 25);
            this.txtSalarioBase.TabIndex = 27;
            // 
            // lblSalarioBase
            // 
            this.lblSalarioBase.AutoSize = true;
            this.lblSalarioBase.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSalarioBase.Location = new System.Drawing.Point(31, 20);
            this.lblSalarioBase.Name = "lblSalarioBase";
            this.lblSalarioBase.Size = new System.Drawing.Size(133, 17);
            this.lblSalarioBase.TabIndex = 26;
            this.lblSalarioBase.Text = "Valor do Salário Base";
            // 
            // frmBeneficioPericulosidade
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(508, 283);
            this.Controls.Add(this.panelResultado);
            this.Controls.Add(this.btnCalcular);
            this.Controls.Add(this.txtSalarioBase);
            this.Controls.Add(this.lblSalarioBase);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "frmBeneficioPericulosidade";
            this.Text = "Adicional Periculosidade";
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
    }
}