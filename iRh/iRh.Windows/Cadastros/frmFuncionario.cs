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
        }
        private void CarregarEstados()
        {
            var estado = new Estados();
            var listaEStados = estado.ObterTodosEstados();
            cmbUf.Items.Clear();
            cmbUf.DataSource = listaEStados.OrderBy(x => x.Sigla);
            cmbUf.DisplayMember = "Sigla";
            cmbUf.ValueMember = "Id";

        }

        
    }
}
