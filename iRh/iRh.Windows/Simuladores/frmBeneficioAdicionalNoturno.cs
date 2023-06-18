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
    public partial class frmBeneficioAdicionalNoturno : Form
    {
        public frmBeneficioAdicionalNoturno()
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
            if (string.IsNullOrEmpty(txtTrabalhaQuantasHoras.Text))
            {
                MessageBox.Show("Informe a quantidade de horas trabalhadas", "Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtTrabalhaQuantasHoras.Focus();
                return;
            }
            if (string.IsNullOrEmpty(txtHorasNoturnas.Text))
            {
                MessageBox.Show("Informe a quantidade de horas noturnas", "Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtTrabalhaQuantasHoras.Focus();
                return;
            }
            try
            {
                var quantidadeDeHorasTrabalhadas = double.Parse(txtTrabalhaQuantasHoras.Text);
                var salarioBase = double.Parse(txtSalarioBase.Text);
                var horasNoturnas = double.Parse(txtHorasNoturnas.Text);

                var valorAdicionalNoturno = AdicionalNoturno.Calcula(salarioBase, horasNoturnas, quantidadeDeHorasTrabalhadas);

                lblResultado.Text = valorAdicionalNoturno.ToString("C");

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
