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
    public partial class frmDescontoIrrf : Form
    {
        public frmDescontoIrrf()
        {
            InitializeComponent();
        }

        private void bntCalcularIrrf_Click(object sender, EventArgs e)
        {
            if(string.IsNullOrEmpty(txtSalarioBaseIrrf.Text))
            {
                MessageBox.Show("Informe seu salário base", "Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtSalarioBaseIrrf.Focus();
                return;
            }
            try
            {
                var salario = double.Parse(txtSalarioBaseIrrf.Text);
                var descontoIrrf = Core.Irrf.Calcula(salario);
                lblResultadoIrrf.Text = descontoIrrf.ToString("C");
                panelResultadoIrrf.Visible = true;
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
