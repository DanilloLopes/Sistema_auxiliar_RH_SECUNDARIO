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
            cmbTrabalhaAPenasANoite.Enabled = false;
            txtHorasNoturnas.Enabled = false;
            cmbTemDescontoValeTransporte.SelectedIndex = 0;
            cmbRecebePericulosidade.SelectedIndex = 0;
        }
        private void cmbRecebeAdicionalNoturno_SelectedIndexChanged(object sender, EventArgs e)
        {
            if(cmbRecebeAdicionalNoturno.SelectedIndex == 0)
            {
                cmbTrabalhaAPenasANoite.Enabled = false;
                return;
            }
            if(cmbRecebeAdicionalNoturno.SelectedIndex == 1)
            {
                cmbTrabalhaAPenasANoite.Enabled = true;
                return;
            }
        }
        private void btnGerarDetalhamento_Click(object sender, EventArgs e)
        {
            
        }

    }
}
