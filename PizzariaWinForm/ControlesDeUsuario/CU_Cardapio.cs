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
    public partial class CU_Cardapio : UserControl
    {
        public CU_Cardapio()
        {
            InitializeComponent();
        }
     
        private void btnAdicionarFornecedor_Click(object sender, EventArgs e)
        {
            using (Formularios.frmCadastroPizzas ab = new Formularios.frmCadastroPizzas())
            {
                ab.ShowDialog();
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            using (Formularios.frmCadastroProduto abc = new Formularios.frmCadastroProduto())
            {
                abc.ShowDialog();
            }
        }

        private void dgvProduto_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            string descricaoDgv;
            string precoDgv;
            string precoVendaDgv;
            string categoriaDgv;
            string quantidadeDgv;
            string fornecedorDgv;
            string id_produtoDgv;

            dgvProduto.CurrentRow.Selected = true;
            descricaoDgv = dgvProduto.Rows[e.RowIndex].Cells["descricao"].FormattedValue.ToString();
            precoDgv = dgvProduto.Rows[e.RowIndex].Cells["preco"].FormattedValue.ToString();
            precoVendaDgv = dgvProduto.Rows[e.RowIndex].Cells["precoVenda"].FormattedValue.ToString();
            categoriaDgv = dgvProduto.Rows[e.RowIndex].Cells["categoria"].FormattedValue.ToString();
            quantidadeDgv = dgvProduto.Rows[e.RowIndex].Cells["quantidade"].FormattedValue.ToString();
            fornecedorDgv = dgvProduto.Rows[e.RowIndex].Cells["fornecedor"].FormattedValue.ToString();
            id_produtoDgv = dgvProduto.Rows[e.RowIndex].Cells["id_produto"].FormattedValue.ToString();



            Formularios.frmCadastroProduto produto = new Formularios.frmCadastroProduto();

            produto.RecebendoValorDgv(id_produtoDgv, descricaoDgv, precoDgv, precoVendaDgv, quantidadeDgv, fornecedorDgv, categoriaDgv);
            produto.Show();
        }

        private void btnAtulizar_Click(object sender, EventArgs e)
        {
            Produto prod = new Produto();
            prod.Dados = dgvProduto;

            prod.Listar();
        }
    }
}
