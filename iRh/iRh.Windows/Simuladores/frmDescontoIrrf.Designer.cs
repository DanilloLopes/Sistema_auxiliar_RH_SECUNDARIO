namespace iRh.Windows.Simuladores
{
    partial class frmDescontoIrrf
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
            this.bntCalcularIrrf = new System.Windows.Forms.Button();
            this.txtSalarioBaseIrrf = new System.Windows.Forms.TextBox();
            this.panelResultadoIrrf = new System.Windows.Forms.Panel();
            this.lblResultadoIrrf = new System.Windows.Forms.Label();
            this.lblSalarioIrrf = new System.Windows.Forms.Label();
            this.panelResultadoIrrf.SuspendLayout();
            this.SuspendLayout();
            // 
            // bntCalcularIrrf
            // 
            this.bntCalcularIrrf.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bntCalcularIrrf.Location = new System.Drawing.Point(31, 99);
            this.bntCalcularIrrf.Name = "bntCalcularIrrf";
            this.bntCalcularIrrf.Size = new System.Drawing.Size(127, 28);
            this.bntCalcularIrrf.TabIndex = 0;
            this.bntCalcularIrrf.Text = "Calcular IRRF";
            this.bntCalcularIrrf.UseVisualStyleBackColor = true;
            this.bntCalcularIrrf.Click += new System.EventHandler(this.bntCalcularIrrf_Click);
            // 
            // txtSalarioBaseIrrf
            // 
            this.txtSalarioBaseIrrf.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSalarioBaseIrrf.Location = new System.Drawing.Point(31, 55);
            this.txtSalarioBaseIrrf.Name = "txtSalarioBaseIrrf";
            this.txtSalarioBaseIrrf.Size = new System.Drawing.Size(222, 29);
            this.txtSalarioBaseIrrf.TabIndex = 1;
            // 
            // panelResultadoIrrf
            // 
            this.panelResultadoIrrf.BackColor = System.Drawing.Color.Transparent;
            this.panelResultadoIrrf.Controls.Add(this.lblResultadoIrrf);
            this.panelResultadoIrrf.Location = new System.Drawing.Point(31, 149);
            this.panelResultadoIrrf.Name = "panelResultadoIrrf";
            this.panelResultadoIrrf.Size = new System.Drawing.Size(295, 100);
            this.panelResultadoIrrf.TabIndex = 2;
            this.panelResultadoIrrf.Visible = false;
            // 
            // lblResultadoIrrf
            // 
            this.lblResultadoIrrf.AutoSize = true;
            this.lblResultadoIrrf.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblResultadoIrrf.Location = new System.Drawing.Point(87, 31);
            this.lblResultadoIrrf.Name = "lblResultadoIrrf";
            this.lblResultadoIrrf.Size = new System.Drawing.Size(135, 30);
            this.lblResultadoIrrf.TabIndex = 0;
            this.lblResultadoIrrf.Text = "lblResultado";
            // 
            // lblSalarioIrrf
            // 
            this.lblSalarioIrrf.AutoSize = true;
            this.lblSalarioIrrf.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSalarioIrrf.Location = new System.Drawing.Point(26, 22);
            this.lblSalarioIrrf.Name = "lblSalarioIrrf";
            this.lblSalarioIrrf.Size = new System.Drawing.Size(124, 30);
            this.lblSalarioIrrf.TabIndex = 3;
            this.lblSalarioIrrf.Text = "Salário Base";
            // 
            // frmDescontoIrrf
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(384, 261);
            this.Controls.Add(this.lblSalarioIrrf);
            this.Controls.Add(this.panelResultadoIrrf);
            this.Controls.Add(this.txtSalarioBaseIrrf);
            this.Controls.Add(this.bntCalcularIrrf);
            this.MaximizeBox = false;
            this.Name = "frmDescontoIrrf";
            this.Text = "Desconto IRRF";
            this.panelResultadoIrrf.ResumeLayout(false);
            this.panelResultadoIrrf.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button bntCalcularIrrf;
        private System.Windows.Forms.TextBox txtSalarioBaseIrrf;
        private System.Windows.Forms.Panel panelResultadoIrrf;
        private System.Windows.Forms.Label lblResultadoIrrf;
        private System.Windows.Forms.Label lblSalarioIrrf;
    }
}