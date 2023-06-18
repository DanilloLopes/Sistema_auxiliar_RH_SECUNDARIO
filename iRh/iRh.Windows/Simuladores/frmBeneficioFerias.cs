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
    public partial class frmBeneficioFerias : Form
    {
        public frmBeneficioFerias()
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
                return;
            }
            
            try
            {

                var salarioBase = double.Parse(txtSalarioBase.Text);
                var adicionalFerias = salarioBase + (salarioBase / 3);

                var inss = Inss.Calcula(adicionalFerias);
                var irrf = Irrf.Calcula(adicionalFerias);

                var valorTotal = adicionalFerias - inss - irrf;

                lblResultado.Text = valorTotal.ToString("C");

                panelResultado.Visible = true;
            }
            catch (Exception)
            {
                MessageBox.Show("Informe um valor válido, ex. 3500",
                                    "Atenção",
                                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }
    }
}
