namespace iRh.Windows.Simuladores
{
    partial class frmDescontoInss
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
            this.lblSalario = new System.Windows.Forms.Label();
            this.txtSalario = new System.Windows.Forms.TextBox();
            this.btnCalcularInss = new System.Windows.Forms.Button();
            this.panelResultadoInss = new System.Windows.Forms.Panel();
            this.lblResultadoInss = new System.Windows.Forms.Label();
            this.panelResultadoInss.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblSalario
            // 
            this.lblSalario.AutoSize = true;
            this.lblSalario.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSalario.Location = new System.Drawing.Point(12, 18);
            this.lblSalario.Name = "lblSalario";
            this.lblSalario.Size = new System.Drawing.Size(124, 30);
            this.lblSalario.TabIndex = 0;
            this.lblSalario.Text = "Salário Base";
            // 
            // txtSalario
            // 
            this.txtSalario.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSalario.Location = new System.Drawing.Point(17, 51);
            this.txtSalario.Name = "txtSalario";
            this.txtSalario.Size = new System.Drawing.Size(249, 35);
            this.txtSalario.TabIndex = 1;
            // 
            // btnCalcularInss
            // 
            this.btnCalcularInss.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCalcularInss.Location = new System.Drawing.Point(17, 107);
            this.btnCalcularInss.Name = "btnCalcularInss";
            this.btnCalcularInss.Size = new System.Drawing.Size(119, 30);
            this.btnCalcularInss.TabIndex = 2;
            this.btnCalcularInss.Text = "Calcular INSS";
            this.btnCalcularInss.UseVisualStyleBackColor = true;
            this.btnCalcularInss.Click += new System.EventHandler(this.btnCalcular_Click);
            // 
            // panelResultadoInss
            // 
            this.panelResultadoInss.BackColor = System.Drawing.Color.Transparent;
            this.panelResultadoInss.Controls.Add(this.lblResultadoInss);
            this.panelResultadoInss.Location = new System.Drawing.Point(17, 162);
            this.panelResultadoInss.Name = "panelResultadoInss";
            this.panelResultadoInss.Size = new System.Drawing.Size(343, 83);
            this.panelResultadoInss.TabIndex = 3;
            this.panelResultadoInss.Visible = false;
            // 
            // lblResultadoInss
            // 
            this.lblResultadoInss.AutoSize = true;
            this.lblResultadoInss.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblResultadoInss.Location = new System.Drawing.Point(97, 26);
            this.lblResultadoInss.Name = "lblResultadoInss";
            this.lblResultadoInss.Size = new System.Drawing.Size(126, 30);
            this.lblResultadoInss.TabIndex = 4;
            this.lblResultadoInss.Text = "lblResultado";
            // 
            // frmDescontoInss
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(384, 261);
            this.Controls.Add(this.panelResultadoInss);
            this.Controls.Add(this.btnCalcularInss);
            this.Controls.Add(this.txtSalario);
            this.Controls.Add(this.lblSalario);
            this.MaximizeBox = false;
            this.Name = "frmDescontoInss";
            this.Text = "Desconto de INSS";
            this.panelResultadoInss.ResumeLayout(false);
            this.panelResultadoInss.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblSalario;
        private System.Windows.Forms.TextBox txtSalario;
        private System.Windows.Forms.Button btnCalcularInss;
        private System.Windows.Forms.Panel panelResultadoInss;
        private System.Windows.Forms.Label lblResultadoInss;
    }
}