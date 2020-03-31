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
            Produto prod = new Produto();
            prod.Preencher(cmbRazaoSocial);
        }


        
        

        private void btnCadastrar_Click(object sender, EventArgs e)
        {

            Produto prod = new Produto();
            prod.Descricao = txtNome.Text;
            prod.Preco = decimal.Parse(txtPreco.Text);
            prod.Quantidade = int.Parse(txtQuantidade.Text);
            prod.Fabricante = cmbRazaoSocial.SelectedValue.ToString();
            


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

        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            frmMenu menu = new frmMenu();
            this.Hide();
            menu.Show();
        }
    }
}
