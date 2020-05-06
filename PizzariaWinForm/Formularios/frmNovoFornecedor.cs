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

            fornecedor.Razao_social = txtRazaoSocial.Text;
            fornecedor.Nome = txtNome.Text;
            fornecedor.Endereco = txtEndereco.Text;
            fornecedor.Telefone = mskTelefone.Text;
            fornecedor.Cnpj = txtCnpj.Text;
            fornecedor.Numero = int.Parse(txtNumero.Text);
            fornecedor.Obs = rtxtObservacoes.Text;
        }
        public void RecebendoValorDgv( string razao_social, string nome, string endereco, string numero, string telefone, string cnpj , string obs)
        {
            btnCadastrar.Visible = false;
            btnAlterar.Visible = true;
            txtRazaoSocial.Text = razao_social;
            txtNome.Text = nome;
            txtEndereco.Text = endereco;
            mskTelefone.Text = telefone;
            txtCnpj.Text = cnpj;
            txtNumero.Text = numero;
            rtxtObservacoes.Text = obs;
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
        string mensagem = "Deseja sair do cadastro?";
        string fechar = "fechando cadastro!!";

        private void btnCadastrar_Click(object sender, EventArgs e)
        {
            if (txtCnpj.Text != " " && txtNome.Text != " " && txtEndereco.Text != "" && mskTelefone.Text != "" && txtNumero.Text != "" && txtRazaoSocial.Text != " " && rtxtObservacoes.Text !="") 
            {

                RecebendoValor();
               

                fornecedor.Cadastrar();
                var result = MessageBox.Show("Cadastrado com sucesso!", MessageBoxButtons.OK.ToString());

                if (result == DialogResult.OK)
                {
                    this.Close();

                }
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

        private void btnAlterar_Click(object sender, EventArgs e)
        {
            if (txtCnpj.Text != " " && txtNome.Text != " " && txtEndereco.Text != "" && mskTelefone.Text != "" && txtNumero.Text != "" && txtRazaoSocial.Text != " " && rtxtObservacoes.Text != "")
            {

                RecebendoValor();



                fornecedor.Alterar();
                var result = MessageBox.Show("Fornecedor Alterado com sucesso!", MessageBoxButtons.OK.ToString());

                if (result == DialogResult.OK)
                {
                    this.Close();

                }
                EsvaziandoCampos();

            }

            else
            {
                MessageBox.Show("Os campos devem ser preenchidos!!", MessageBoxButtons.OK.ToString());

            }
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
    }
}

