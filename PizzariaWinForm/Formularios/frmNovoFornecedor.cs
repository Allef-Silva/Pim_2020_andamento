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
    public partial class frmNovoFornecedor : Form
    {
        public frmNovoFornecedor()
        {
            InitializeComponent();
        }
        Fornecedor fornecedor = new Fornecedor();
        private void RecebendoValor()
        {

            fornecedor.Nome = txtNome.Text;
            fornecedor.Endereco = txtEndereco.Text;
            fornecedor.Telefone = mskTelefone.Text;
            fornecedor.Cnpj = txtCnpj.Text;
            fornecedor.Numero = int.Parse(txtNumero.Text);
            fornecedor.Obs = rtxtObservacoes.Text;
        }
        private void RecebendoValorDgv()
        {

            txtNome.Text = fornecedor.Nome;
            txtEndereco.Text = fornecedor.Endereco;
            mskTelefone.Text = fornecedor.Telefone;
            txtCnpj.Text = fornecedor.Cnpj;
            txtNumero.Text = fornecedor.Numero.ToString();
            rtxtObservacoes.Text = fornecedor.Obs;
        }
        private void EsvaziandoCampos()
        {
            txtCnpj.Clear();
            txtNome.Clear();
            txtEndereco.Text = "";
            mskTelefone.Text = "";
            rtxtObservacoes.Text = "";
            txtNumero.Clear();
        }

        private void btnCadastrar_Click(object sender, EventArgs e)
        {
            if (txtCnpj.Text != " " && txtNome.Text != " " && txtEndereco.Text != "" && mskTelefone.Text != "" && txtNumero.Text != "")
            {

                RecebendoValor();
                var result = MessageBox.Show("Cadastrado com sucesso!", MessageBoxButtons.OK.ToString());

                if (result == DialogResult.OK)
                {
                    this.Close();

                }

                fornecedor.Cadastrar();
                EsvaziandoCampos();

            }

            else
            {
                MessageBox.Show("Os campos devem ser preenchidos!!", MessageBoxButtons.OK.ToString());

            }

        }

        private void txtNumero_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((Char.IsLetter(e.KeyChar)))
                e.Handled = true;
        }
    }
}

