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
            this.txtSalarioBase = new System.Windows.Forms.TextBox();
            this.lblSalarioValeTrasporte = new System.Windows.Forms.Label();
            this.bntCalcularValeTransporte = new System.Windows.Forms.Button();
            this.lblResultado = new System.Windows.Forms.Label();
            this.txtValorDoPasse = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.panelResultado = new System.Windows.Forms.Panel();
            this.flpValeAPenaOuNao = new System.Windows.Forms.FlowLayoutPanel();
            this.lblTextoValeAPenaOuNao = new System.Windows.Forms.Label();
            this.lblResultadoTitulo = new System.Windows.Forms.Label();
            this.lblDica = new System.Windows.Forms.Label();
            this.panelResultado.SuspendLayout();
            this.flpValeAPenaOuNao.SuspendLayout();
            this.SuspendLayout();
            // 
            // txtSalarioBase
            // 
            this.txtSalarioBase.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSalarioBase.Location = new System.Drawing.Point(28, 62);
            this.txtSalarioBase.Name = "txtSalarioBase";
            this.txtSalarioBase.Size = new System.Drawing.Size(222, 29);
            this.txtSalarioBase.TabIndex = 2;
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
            this.bntCalcularValeTransporte.Click += new System.EventHandler(this.bntCalcularValeTransporte_Click);
            // 
            // lblResultado
            // 
            this.lblResultado.AutoSize = true;
            this.lblResultado.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblResultado.Location = new System.Drawing.Point(131, 63);
            this.lblResultado.Name = "lblResultado";
            this.lblResultado.Size = new System.Drawing.Size(135, 30);
            this.lblResultado.TabIndex = 0;
            this.lblResultado.Text = "lblResultado";
            // 
            // txtValorDoPasse
            // 
            this.txtValorDoPasse.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtValorDoPasse.Location = new System.Drawing.Point(28, 156);
            this.txtValorDoPasse.Name = "txtValorDoPasse";
            this.txtValorDoPasse.Size = new System.Drawing.Size(222, 29);
            this.txtValorDoPasse.TabIndex = 7;
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
            // panelResultado
            // 
            this.panelResultado.Controls.Add(this.lblResultadoTitulo);
            this.panelResultado.Controls.Add(this.flpValeAPenaOuNao);
            this.panelResultado.Controls.Add(this.lblResultado);
            this.panelResultado.Location = new System.Drawing.Point(283, 51);
            this.panelResultado.Name = "panelResultado";
            this.panelResultado.Size = new System.Drawing.Size(377, 298);
            this.panelResultado.TabIndex = 11;
            this.panelResultado.Visible = false;
            // 
            // flpValeAPenaOuNao
            // 
            this.flpValeAPenaOuNao.Controls.Add(this.lblDica);
            this.flpValeAPenaOuNao.Controls.Add(this.lblTextoValeAPenaOuNao);
            this.flpValeAPenaOuNao.FlowDirection = System.Windows.Forms.FlowDirection.TopDown;
            this.flpValeAPenaOuNao.Location = new System.Drawing.Point(0, 134);
            this.flpValeAPenaOuNao.Name = "flpValeAPenaOuNao";
            this.flpValeAPenaOuNao.Size = new System.Drawing.Size(377, 186);
            this.flpValeAPenaOuNao.TabIndex = 12;
            // 
            // lblTextoValeAPenaOuNao
            // 
            this.lblTextoValeAPenaOuNao.AutoSize = true;
            this.lblTextoValeAPenaOuNao.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTextoValeAPenaOuNao.Location = new System.Drawing.Point(3, 30);
            this.lblTextoValeAPenaOuNao.Name = "lblTextoValeAPenaOuNao";
            this.lblTextoValeAPenaOuNao.Size = new System.Drawing.Size(124, 17);
            this.lblTextoValeAPenaOuNao.TabIndex = 13;
            this.lblTextoValeAPenaOuNao.Text = "lblValeAPenaOuNao";
            // 
            // lblResultadoTitulo
            // 
            this.lblResultadoTitulo.AutoSize = true;
            this.lblResultadoTitulo.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblResultadoTitulo.Location = new System.Drawing.Point(-5, 0);
            this.lblResultadoTitulo.Name = "lblResultadoTitulo";
            this.lblResultadoTitulo.Size = new System.Drawing.Size(199, 30);
            this.lblResultadoTitulo.TabIndex = 13;
            this.lblResultadoTitulo.Text = "Valor do Desconto:";
            // 
            // lblDica
            // 
            this.lblDica.AutoSize = true;
            this.lblDica.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDica.Location = new System.Drawing.Point(3, 0);
            this.lblDica.Name = "lblDica";
            this.lblDica.Size = new System.Drawing.Size(59, 30);
            this.lblDica.TabIndex = 12;
            this.lblDica.Text = "Dica:";
            // 
            // frmBeneficioValeTransporte
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(672, 361);
            this.Controls.Add(this.panelResultado);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtValorDoPasse);
            this.Controls.Add(this.bntCalcularValeTransporte);
            this.Controls.Add(this.lblSalarioValeTrasporte);
            this.Controls.Add(this.txtSalarioBase);
            this.Name = "frmBeneficioValeTransporte";
            this.Text = "Vale Transporte";
            this.panelResultado.ResumeLayout(false);
            this.panelResultado.PerformLayout();
            this.flpValeAPenaOuNao.ResumeLayout(false);
            this.flpValeAPenaOuNao.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtSalarioBase;
        private System.Windows.Forms.Label lblSalarioValeTrasporte;
        private System.Windows.Forms.Button bntCalcularValeTransporte;
        private System.Windows.Forms.Label lblResultado;
        private System.Windows.Forms.TextBox txtValorDoPasse;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Panel panelResultado;
        private System.Windows.Forms.FlowLayoutPanel flpValeAPenaOuNao;
        private System.Windows.Forms.Label lblTextoValeAPenaOuNao;
        private System.Windows.Forms.Label lblResultadoTitulo;
        private System.Windows.Forms.Label lblDica;
    }
}