using iRh.Windows.Core;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace iRh.Windows.Simuladores
{
    public partial class frmBeneficioPericulosidade : Form
    {
        public frmBeneficioPericulosidade()
        {
            InitializeComponent();
        }

        private void btnCalcular_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtSalarioBase.Text))
            {
                MessageBox.Show("Informe seu salário base", "Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtSalarioBase.Focus();
                panelResultado.Visible = false;
                return;
            }

            try
            {
                var salario = double.Parse(txtSalarioBase.Text);
                var adicionalPericulosidade = AdicionalPericulosidade.Calcula(salario);

                lblResultado.Text = adicionalPericulosidade.ToString("C");
                panelResultado.Visible = true; 
                
            }
            catch (Exception)
            {
                MessageBox.Show("Informe um valor de salário válido, ex. 3500",
                                    "Atenção",
                                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }
    }
}
