using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PizzariaWinForm.Formularios
{
    public partial class frmCadastroProduto : Form
    {
        Produto prod = new Produto();

        public frmCadastroProduto()
        {
            InitializeComponent();


            prod.PreencherFornecedor(cmbFornecedor);
        }

        private void frmCadastroProduto_Load(object sender, EventArgs e)
        {

        }

        private void btnSair_Click(object sender, EventArgs e)
        {
            this.Close();
        }


        private void RecebendoValor()
        {

            prod.Descricao = txtNome.Text;
            prod.Preco = double.Parse(txtPrecoCusto.Text);
            prod.PrecoVenda = double.Parse(txtPrecoVenda.Text);
            prod.Quantidade = int.Parse(txtQuantidade.Text);
            prod.Fabricante = cmbFornecedor.SelectedValue.ToString();
            prod.Categoria = cmbCategoria.Text;
        }
        private void RecebendoValorDgv()
        {
            txtNome.Text = prod.Descricao;
            txtPrecoCusto.Text = prod.Preco.ToString();
            txtPrecoVenda.Text = prod.PrecoVenda.ToString();
            txtQuantidade.Text = prod.Quantidade.ToString();
            cmbFornecedor.Text = prod.Fabricante;


        }
        private void EsvaziandoCampos()
        {
            txtNome.Text = ""; 
            txtPrecoCusto.Text = "";
            txtPrecoVenda.Text = "";
            txtQuantidade.Text = "";
            cmbFornecedor.Text = "";
        }


        private void btnCadastrar_Click(object sender, EventArgs e)
        {
            if (txtNome.Text != " " && txtPorcentagem.Text != " " && txtPrecoCusto.Text != "" && txtQuantidade.Text != "" && txtPrecoVenda.Text != "")
            {

                RecebendoValor();
                

              
                
                prod.Cadastrar();
                var result = MessageBox.Show("Cadastrado com sucesso!", MessageBoxButtons.OK.ToString());
                EsvaziandoCampos();
                if (result == DialogResult.OK)
                {
                    this.Close();

                }

            }

            else
            {
                MessageBox.Show("Os campos devem ser preenchidos!!", MessageBoxButtons.OK.ToString());

            }

        }

        private void txtPrecoCusto_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((Char.IsLetter(e.KeyChar)))
                e.Handled = true;
        }

        private void txtQuantidade_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((Char.IsLetter(e.KeyChar)))
                e.Handled = true;
        }

        private void txtPorcentagem_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((Char.IsLetter(e.KeyChar)))
                e.Handled = true;
        }

        private void txtPrecoVenda_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((Char.IsLetter(e.KeyChar)))
                e.Handled = true;
        }
    }
}

