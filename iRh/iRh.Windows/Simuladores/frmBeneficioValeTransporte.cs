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
    public partial class frmBeneficioValeTransporte : Form
    {
        public frmBeneficioValeTransporte()
        {
            InitializeComponent();
        }

        private void bntCalcularValeTransporte_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtSalarioBase.Text))
            {
                MessageBox.Show("Informe seu salário base.", "Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtSalarioBase.Focus();
                return;
            }
            if(string.IsNullOrEmpty(txtValorDoPasse.Text))
            {
                MessageBox.Show("Informe o valor do passe de ônibus.", "Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtSalarioBase.Focus();
                return;
            }
            try
            {
                var salario = double.Parse(txtSalarioBase.Text);
                var descontoValeTransporte = Core.ValeTransporte.Calcula(salario);
                lblResultado.Text = descontoValeTransporte.ToString("C");

                var valorDoPasseMensal = double.Parse(txtValorDoPasse.Text) * 4 * 20;
                
                if(valorDoPasseMensal > descontoValeTransporte)
                {
                    lblTextoValeAPenaOuNao.Text = "Com base nos valores apresentados recomenda-se" + "\n" + "que se escolha a opção de utilizar" +
                        " o Vale Transporte " + "\n" + "da empresa, pois o valor descontado será de " + descontoValeTransporte.ToString("C") + "\n" +
                        " e o valor que seria utilizado pagando 4 passes por dia durante 20 dias é de " + valorDoPasseMensal.ToString("C");
                }
                else if(valorDoPasseMensal == descontoValeTransporte){ 
                    

                }else{


                }
                
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
