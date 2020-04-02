using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PizzariaWinForm
{
    public partial class frmProduto : Form
    {
        public frmProduto()
        {
            InitializeComponent();

        }


        Produto prod = new Produto();
        private void RecebendoValor()
        {

            prod.Descricao = txtNome.Text;
            prod.Preco = decimal.Parse(txtPreco.Text);
            prod.Quantidade = int.Parse(txtQuantidade.Text);
            prod.Fabricante = cmbRazaoSocial.SelectedValue.ToString();

        }
        private void EsvaziandoValores()
        {
            txtId.Text = " ";
            txtNome.Text = " ";
            txtPreco.Text = " ";
            txtQuantidade.Text = " ";



        }


        private void btnCadastrar_Click(object sender, EventArgs e)
        {

            RecebendoValor();


            if (txtNome.Text == "")
            {
                MessageBox.Show("O CAMPO NOME DEVE ESTAR PREENCHIDO", "NOME", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtNome.Select();
                return;
            }

            if (cmbRazaoSocial.Text == "")
            {
                MessageBox.Show("O CAMPO E-MAIL DEVE ESTAR PREENCHIDO", "CPF", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                cmbRazaoSocial.Select();
                return;
            }

            //VA
            if (txtNome.Text != " " && cmbRazaoSocial.Text != " ")

                prod.Cadastrar();
            EsvaziandoValores();

        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            frmMenu menu = new frmMenu();
            this.Hide();
            menu.Show();
        }

        private void btnExibir_Click(object sender, EventArgs e)
        {
            prod.Dados = dgvProduto;

            prod.Listar();
        }

        private void frmProduto_Load(object sender, EventArgs e)
        {

            prod.Preencher(cmbRazaoSocial);
        }

        private void btnAlterar_Click(object sender, EventArgs e)
        {
            RecebendoValor();
            prod.Id = int.Parse(txtId.Text);
            prod.Alterar();
            EsvaziandoValores();
        }

        private void dgvProduto_CellClick(object sender, DataGridViewCellEventArgs e)
        {

            dgvProduto.CurrentRow.Selected = true;
            txtId.Text = dgvProduto.Rows[e.RowIndex].Cells["id_produto"].FormattedValue.ToString();
            txtNome.Text = dgvProduto.Rows[e.RowIndex].Cells["descricao"].FormattedValue.ToString();
            txtPreco.Text = dgvProduto.Rows[e.RowIndex].Cells["preco"].FormattedValue.ToString();
            txtQuantidade.Text = dgvProduto.Rows[e.RowIndex].Cells["quantidade"].FormattedValue.ToString();
            cmbRazaoSocial.Text = dgvProduto.Rows[e.RowIndex].Cells["fornecedor"].FormattedValue.ToString();
        }

        private void btnExcluir_Click(object sender, EventArgs e)
        {
            RecebendoValor();
            prod.Id = int.Parse(txtId.Text);
            prod.Excluir();
            EsvaziandoValores();
        }
    }
}
