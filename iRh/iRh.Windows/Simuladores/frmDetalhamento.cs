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
    public partial class frmDetalhamento : Form
    {
        public frmDetalhamento()
        {
            InitializeComponent();
        }
        private void frmDetalhamento_Load(object sender, EventArgs e)
        {
            cmbFezHoraExtra.SelectedIndex = 0;
            txtHoraExtra.Enabled = false;
            cmbRecebeAdicionalNoturno.SelectedIndex = 0;
            txtHorasNoturnas.Enabled = false;
            cmbTemDescontoValeTransporte.SelectedIndex = 0;
            cmbRecebePericulosidade.SelectedIndex = 0;
            pnlDetalhamento.Visible = false;
        }
        private void cmbRecebeAdicionalNoturno_SelectedIndexChanged(object sender, EventArgs e)
        {
            if(cmbRecebeAdicionalNoturno.SelectedIndex == 0)
            {
                txtHorasNoturnas.Enabled = false;
                txtHorasNoturnas.Clear();
                return;
            }
            if(cmbRecebeAdicionalNoturno.SelectedIndex == 1)
            {
                txtHorasNoturnas.Enabled = true;
                return;
            }
        }
        private void cmbFezHoraExtra_SelectedIndexChanged(object sender, EventArgs e)
        {
            if(cmbFezHoraExtra.SelectedIndex == 0)
            {
                txtHoraExtra.Enabled = false;
                txtHoraExtra.Clear();
                return;
            }
            if(cmbFezHoraExtra.SelectedIndex == 1)
            {
                txtHoraExtra.Enabled = true; 
            }
        }
        private void btnGerarDetalhamento_Click(object sender, EventArgs e)
        {
            if(string.IsNullOrEmpty(txtSalarioBase.Text))
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
            if (string.IsNullOrEmpty(txtHoraExtra.Text) && cmbFezHoraExtra.SelectedIndex == 1)
            {
                MessageBox.Show("Informe a quantidade de horas extras", "Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtTrabalhaQuantasHoras.Focus();
                return;
            }
            if (string.IsNullOrEmpty(txtHorasNoturnas.Text) && cmbRecebeAdicionalNoturno.SelectedIndex == 1)
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

                var valorAdicionalNoturno = 0.0;
                if (cmbRecebeAdicionalNoturno.SelectedIndex == 1)
                {
                    var horasNoturnasTrabalhadas = double.Parse(txtHorasNoturnas.Text);
                    valorAdicionalNoturno = AdicionalNoturno.Calcula(salarioBase, horasNoturnasTrabalhadas, quantidadeDeHorasTrabalhadas);
                }

                var valorHoraExtra = 0.0;
                if (cmbFezHoraExtra.SelectedIndex == 1)
                {
                    var horasExtrasTrabalhadas = double.Parse(txtHoraExtra.Text);
                    valorHoraExtra = HoraExtra.Calcula(salarioBase, horasExtrasTrabalhadas, quantidadeDeHorasTrabalhadas);
                }

                var valorPericulosidade = 0.0;
                if(cmbRecebePericulosidade.SelectedIndex == 1)
                {
                    valorPericulosidade = AdicionalPericulosidade.Calcula(salarioBase);
                }

                var totalDeProventos = valorPericulosidade + valorHoraExtra + valorAdicionalNoturno 
                    + salarioBase;

                var valorFgts = Fgts.Calcula(totalDeProventos);

                var valorInss = Inss.Calcula(totalDeProventos);
                var valorIrrf = Irrf.Calcula(totalDeProventos); 
                var valorValeTransporte = 0.0;
                if(cmbTemDescontoValeTransporte.SelectedIndex == 1)
                {
                    valorValeTransporte = ValeTransporte.Calcula(totalDeProventos);
                }

                var totalDeDescontos = valorInss + valorIrrf + valorValeTransporte;

                var salarioLiquido = totalDeProventos - totalDeDescontos;

                lblValorAdicionalNoturno.Text = valorAdicionalNoturno.ToString("C");
                lblValorSalarioBase.Text = salarioBase.ToString("C");
                lblValorAdicionalPericulosidade.Text = valorPericulosidade.ToString("C");
                lblValorFgts.Text = valorFgts.ToString("C");
                lblValorHoraExtra.Text = valorHoraExtra.ToString("C");
                lblValorTotalProventos.Text = totalDeProventos.ToString("C");

                lblValorIrff.Text = valorIrrf.ToString("C");
                lblValorInss.Text = valorInss.ToString("C");
                lblValorValeTransporte.Text = valorValeTransporte.ToString("C");
                lblValorTotalDeDescontos.Text = totalDeDescontos.ToString("C");

                lblValorSalarioLiquido.Text = salarioLiquido.ToString("C");

                pnlDetalhamento.Visible = true;
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
