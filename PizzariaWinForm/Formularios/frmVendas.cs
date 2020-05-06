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
    public partial class frmVendas : Form
    {
        Vendas vendas = new Vendas();
        public frmVendas()
        {
            InitializeComponent();
            vendas.PreencherCliente(cmbCliente);
            vendas.PreencherFornecedor(cmbProduto);
        }


        string mensagem = "Deseja sair do cadastro?";
        string fechar = "fechando cadastro!!";


        private void txtTotal_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((Char.IsLetter(e.KeyChar)))
                e.Handled = true;
        }

        private void txtQuantidade_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((Char.IsLetter(e.KeyChar)))
                e.Handled = true;
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

        private void txtPreco_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((Char.IsLetter(e.KeyChar)))
                e.Handled = true;
        }

        private void cmbProduto_SelectedIndexChanged(object sender, EventArgs e)
        {
            vendas.PreencherText(cmbProduto, txtPreco, txtTipo);
        }

        private void txtTipo_TextChanged(object sender, EventArgs e)
        {
            if (txtTipo.Text == "Pizza")
            {
                rbBroto.Visible = true;
                rbInteira.Visible = true;
            }
            else
            {
                rbBroto.Visible = false;
                rbInteira.Visible = false;
            }
        }
    }
}
