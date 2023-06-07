namespace iRh.Windows.Simuladores
{
    partial class frmBeneficioValeTransporte
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
            this.txtSalarioBaseValeTransporte = new System.Windows.Forms.TextBox();
            this.lblSalarioValeTrasporte = new System.Windows.Forms.Label();
            this.bntCalcularValeTransporte = new System.Windows.Forms.Button();
            this.lblResultadoIrrf = new System.Windows.Forms.Label();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.lblTextoValeAPenaOuNao = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // txtSalarioBaseValeTransporte
            // 
            this.txtSalarioBaseValeTransporte.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSalarioBaseValeTransporte.Location = new System.Drawing.Point(28, 62);
            this.txtSalarioBaseValeTransporte.Name = "txtSalarioBaseValeTransporte";
            this.txtSalarioBaseValeTransporte.Size = new System.Drawing.Size(222, 29);
            this.txtSalarioBaseValeTransporte.TabIndex = 2;
            // 
            // lblSalarioValeTrasporte
            // 
            this.lblSalarioValeTrasporte.AutoSize = true;
            this.lblSalarioValeTrasporte.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSalarioValeTrasporte.Location = new System.Drawing.Point(23, 29);
            this.lblSalarioValeTrasporte.Name = "lblSalarioValeTrasporte";
            this.lblSalarioValeTrasporte.Size = new System.Drawing.Size(124, 30);
            this.lblSalarioValeTrasporte.TabIndex = 4;
            this.lblSalarioValeTrasporte.Text = "Salário Base";
            // 
            // bntCalcularValeTransporte
            // 
            this.bntCalcularValeTransporte.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bntCalcularValeTransporte.Location = new System.Drawing.Point(28, 201);
            this.bntCalcularValeTransporte.Name = "bntCalcularValeTransporte";
            this.bntCalcularValeTransporte.Size = new System.Drawing.Size(168, 28);
            this.bntCalcularValeTransporte.TabIndex = 5;
            this.bntCalcularValeTransporte.Text = "Calcular Vale Transporte";
            this.bntCalcularValeTransporte.UseVisualStyleBackColor = true;
            // 
            // lblResultadoIrrf
            // 
            this.lblResultadoIrrf.AutoSize = true;
            this.lblResultadoIrrf.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblResultadoIrrf.Location = new System.Drawing.Point(430, 58);
            this.lblResultadoIrrf.Name = "lblResultadoIrrf";
            this.lblResultadoIrrf.Size = new System.Drawing.Size(135, 30);
            this.lblResultadoIrrf.TabIndex = 0;
            this.lblResultadoIrrf.Text = "lblResultado";
            // 
            // textBox2
            // 
            this.textBox2.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox2.Location = new System.Drawing.Point(28, 156);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(234, 29);
            this.textBox2.TabIndex = 7;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(23, 114);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(146, 30);
            this.label2.TabIndex = 9;
            this.label2.Text = "Valor do Passe";
            // 
            // lblTextoValeAPenaOuNao
            // 
            this.lblTextoValeAPenaOuNao.AutoSize = true;
            this.lblTextoValeAPenaOuNao.Location = new System.Drawing.Point(445, 201);
            this.lblTextoValeAPenaOuNao.Name = "lblTextoValeAPenaOuNao";
            this.lblTextoValeAPenaOuNao.Size = new System.Drawing.Size(35, 13);
            this.lblTextoValeAPenaOuNao.TabIndex = 10;
            this.lblTextoValeAPenaOuNao.Text = "label1";
            // 
            // frmBeneficioValeTransporte
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(672, 361);
            this.Controls.Add(this.lblTextoValeAPenaOuNao);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.lblResultadoIrrf);
            this.Controls.Add(this.bntCalcularValeTransporte);
            this.Controls.Add(this.lblSalarioValeTrasporte);
            this.Controls.Add(this.txtSalarioBaseValeTransporte);
            this.Name = "frmBeneficioValeTransporte";
            this.Text = "Vale Transporte";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtSalarioBaseValeTransporte;
        private System.Windows.Forms.Label lblSalarioValeTrasporte;
        private System.Windows.Forms.Button bntCalcularValeTransporte;
        private System.Windows.Forms.Label lblResultadoIrrf;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lblTextoValeAPenaOuNao;
    }
}