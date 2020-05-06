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
            var result = MessageBox.Show(mensagem, fechar,
                           MessageBoxButtons.YesNo,
                           MessageBoxIcon.Question);

            if (result != DialogResult.No)
            {
                this.Close();
            }

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
        public void RecebendoValorDgv(string id, string descricao, string preco, string precoVenda, string quantidade, string fornecedor, string categoria)
        {

            btnCadastrar.Visible = false;
            btnAlterar.Visible = true;
            txtID.Text = id;
            cmbCategoria.Text = categoria;
            txtNome.Text = descricao;
            txtPrecoCusto.Text = preco;
            txtPrecoVenda.Text = precoVenda;
            txtQuantidade.Text = quantidade;
            cmbFornecedor.Text = fornecedor;


        }
        private void EsvaziandoCampos()
        {
            txtNome.Text = ""; 
            txtPrecoCusto.Text = "";
            txtPrecoVenda.Text = "";
            txtQuantidade.Text = "";
            cmbFornecedor.Text = "";
        }
        string mensagem = "Deseja sair do cadastro?";
        string fechar = "fechando cadastro!!";


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

        private void cmbCategoria_SelectedIndexChanged(object sender, EventArgs e)
        {
           
        
        }

        private void btnAlterar_Click(object sender, EventArgs e)
        {
            if (txtNome.Text != " " && txtPorcentagem.Text != " " && txtPrecoCusto.Text != "" && txtPrecoVenda.Text != "" && txtQuantidade.Text != "")
            {

                RecebendoValor();
                prod.Id = int.Parse(txtID.Text);
                prod.Alterar();
            }

            
            var result = MessageBox.Show("Cliente, Alterado com sucesso!", MessageBoxButtons.OK.ToString());

            if (result == DialogResult.OK)
            {
                this.Close();

                EsvaziandoCampos();

            }

            else
            {
                MessageBox.Show("Os campos devem ser preenchidos!!", MessageBoxButtons.OK.ToString());

            }
        }

        private void txtPorcentagem_TextChanged(object sender, EventArgs e)
        {
            float porcentagem = 0;
            float total = 0;

            float precoCusto = 0;
            if (txtPorcentagem.Text != "")
            {
                porcentagem = float.Parse(txtPorcentagem.Text);
            }
            if (txtPrecoCusto.Text != "") {

                precoCusto = float.Parse(txtPrecoCusto.Text);
            }
                

                porcentagem += 100;
                total = (porcentagem / 100) * precoCusto;

                txtPrecoVenda.Text = total.ToString("F2");
            

        }

        private void btnFechar_Click(object sender, EventArgs e)
        {
            var result = MessageBox.Show(mensagem, fechar,
                           MessageBoxButtons.YesNo,
                           MessageBoxIcon.Question);

            if (result != DialogResult.No)
            {
                this.Close();
            }

        }
    }
}

