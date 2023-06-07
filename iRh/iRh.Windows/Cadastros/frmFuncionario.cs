using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace iRh.Windows.Cadastros
{
    public partial class frmFuncionario : Form
    {
        public frmFuncionario()
        {
            InitializeComponent();
        }

        private void frmFuncionario_Load(object sender, EventArgs e)
        {
            rbTemFilhosNão.Checked = true;
            panelExibeDadosFilhos.Visible = false;
        }

        private void rbTemFilhosSim_CheckedChanged(object sender, EventArgs e)
        {
            panelExibeDadosFilhos.Visible = true;
        }

        private void rbTemFilhosNão_CheckedChanged(object sender, EventArgs e)
        {
            panelExibeDadosFilhos.Visible = false;
        }

        private void txtFilhoDataNascimento_KeyDown(object sender, KeyEventArgs e)
        {
            try
            {
                if (e.KeyCode == Keys.Enter)
                {
                    var dataNascimento = DateTime.Parse(txtFilhoDataNascimento.Text);
                    var anoAtual = DateTime.Now;
                    var idade = anoAtual.Year - dataNascimento.Year;
                    if(dataNascimento < anoAtual.AddYears(idade))
                    {
                        idade--;
                    }
                    lblIdade.Text = (idade).ToString();

                }
            }
            catch(Exception ex)
            {
                MessageBox.Show("Informe uma data de nascimento válida, ex. 29/10/1969\n" + ex.Message,
                                    "Atenção" ,
                                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private string Cumprimentador(int opcaoSelecionada)
        {
            return "A";
        }
    }
}
