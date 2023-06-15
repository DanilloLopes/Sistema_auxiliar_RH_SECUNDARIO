using iRh.Windows.Core;
using System.Linq;
using System.Windows.Forms;

namespace iRh.Windows.Cadastros
{
    public partial class frmFuncionario : Form
    {
        public frmFuncionario()
        {
            InitializeComponent();
        }
        private void frmFuncionario_Load(object sender, System.EventArgs e)
        {
            CarregarEstados();
            CarregarDocumentos();
        }
        private void CarregarDocumentos()
        {
            var documento = new Documentos();
            var listaDocumentos = documento.TodosOsDocumentos();
            var documentosAz = listaDocumentos.OrderBy(x => x.Documento).ToList();
            cmbDocumentos.Items.Clear();
            cmbDocumentos.DataSource = documentosAz;
            cmbDocumentos.DisplayMember = "Documento";
            cmbDocumentos.ValueMember = "Id";
        }
        private void CarregarEstados()
        {
            var estado = new Estados();
            var listaEstados = estado.ObterTodosEstados();
            var estadosAz = listaEstados.OrderBy(x => x.Sigla).ToList();
            cmbUf.Items.Clear();
            cmbUf.DataSource = estadosAz;
            cmbUf.DisplayMember = "Nome";
            cmbUf.ValueMember = "Sigla";
        }

        private void btnPesquisar_Click(object sender, System.EventArgs e)
        {
            txtLogradouro.Enabled = true;
            txtBairro.Enabled = true;
            txtCidade.Enabled = true;
            cmbUf.Enabled = true;

            txtLogradouro.Clear();
            txtBairro.Clear();
            txtCidade.Clear();
            cmbUf.SelectedValue = "AC";
            var textoCep = txtCep.Text.ToString();
            if (textoCep.Length != 9)
            {
                MessageBox.Show("Insira um Cep Válido",
                                        "ERRO",
                                        MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            var cepDigitado = txtCep.Text;
            var endereco = new Endereco();
            var enderecoCompleto = endereco.ObterPorCep(cepDigitado);
            var erro = enderecoCompleto.Erro;
            if (erro)
            {
                MessageBox.Show("Insira um Cep Válido","ERRO",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtCep.Focus();
                return;
            }
                
            txtLogradouro.Text = enderecoCompleto.Logradouro;
            txtBairro.Text = enderecoCompleto.Bairro;
            txtCidade.Text = enderecoCompleto.Localidade;
            txtDdd.Text = enderecoCompleto.Ddd;
            cmbUf.SelectedValue = enderecoCompleto.Uf;
            if(!(string.IsNullOrEmpty(txtLogradouro.Text)))
            {
                txtLogradouro.Enabled = false;
            }
            if (!(string.IsNullOrEmpty(txtBairro.Text)))
            {
                txtBairro.Enabled = false;
            }
            if (!(string.IsNullOrEmpty(txtCidade.Text)))
            {
                txtCidade.Enabled = false;
            }
            if (!(string.IsNullOrEmpty(enderecoCompleto.Uf)))
            {
                cmbUf.Enabled = false;
            }


        }

    }
}
