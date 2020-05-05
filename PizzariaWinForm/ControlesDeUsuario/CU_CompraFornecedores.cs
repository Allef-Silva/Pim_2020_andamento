using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PizzariaWinForm.ControlesDeUsuario
{
    public partial class CU_CompraFornecedores : UserControl
    {
        public CU_CompraFornecedores()
        {
            InitializeComponent();
        }

        private void btnAdicionarFornecedor_Click(object sender, EventArgs e)
        {
            using (Formularios.frmNovoFornecedor abn = new Formularios.frmNovoFornecedor())
            {
                abn.ShowDialog();
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            using (Formularios.frmCadastroEstoque ads = new Formularios.frmCadastroEstoque())
            {
                ads.ShowDialog();
            }
        }

    

        private void btnAtulizar_Click(object sender, EventArgs e)
        {
            Fornecedor fornecedor = new Fornecedor();
            fornecedor.Dados = dgvFornecedor;

            fornecedor.Listar();
        }

        private void dgvFornecedor_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            string razao_socialDgv;
            string cnpjDgv;
            string nomeDgv;
            string numeroDgv;
            string enderecoDgv;
            string telefoneDgv;
         
            string obsDgv;
            
            dgvFornecedor.CurrentRow.Selected = true;
            razao_socialDgv = dgvFornecedor.Rows[e.RowIndex].Cells["Social"].FormattedValue.ToString();
            cnpjDgv = dgvFornecedor.Rows[e.RowIndex].Cells["CNPJ"].FormattedValue.ToString();
            nomeDgv = dgvFornecedor.Rows[e.RowIndex].Cells["Nome"].FormattedValue.ToString();
            enderecoDgv = dgvFornecedor.Rows[e.RowIndex].Cells["Endereco"].FormattedValue.ToString();
            numeroDgv = dgvFornecedor.Rows[e.RowIndex].Cells["Numero"].FormattedValue.ToString();
            telefoneDgv = dgvFornecedor.Rows[e.RowIndex].Cells["Telefone"].FormattedValue.ToString();
            obsDgv = dgvFornecedor.Rows[e.RowIndex].Cells["Observacoes"].FormattedValue.ToString();



            Formularios.frmNovoFornecedor fornecedor = new Formularios.frmNovoFornecedor();

            fornecedor.RecebendoValorDgv(razao_socialDgv, nomeDgv, enderecoDgv, numeroDgv, telefoneDgv, cnpjDgv, obsDgv);
            fornecedor.Show();
        }
    }
}
