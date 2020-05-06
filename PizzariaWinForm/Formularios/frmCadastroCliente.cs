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
    public partial class frmCadastroCliente : Form
    {
        public frmCadastroCliente()
        {
            InitializeComponent();
            

                   
        }


        Cliente cli = new Cliente();

        string mensagem = "Deseja sair do cadastro?";
        string fechar = "fechando cadastro!!";
        private void RecebendoValor()
        {

            cli.Nome = txtNomeCliente.Text;
            cli.Endereco = txtEndereco.Text;
            cli.Telefone = mskTelefone.Text;
            cli.CPF = txtCpf.Text;
            cli.Numero = int.Parse(txtNumero.Text);
        }
        public void RecebendoValorDgv(string id, string cliente, string endereco, string numero, string telefone, string cpf)
        {
            btnCadastrar.Visible = false;
            btnAlterar.Visible = true;
            txtId.Text = id;
            txtNomeCliente.Text = cliente;
            txtEndereco.Text = endereco;
            mskTelefone.Text = telefone;
            txtCpf.Text = cpf;
            txtNumero.Text = numero;
        }
        private void EsvaziandoCampos()
        {
            txtId.Clear();
            txtNomeCliente.Clear();
            txtEndereco.Text = "";
            mskTelefone.Text = "";
            txtCpf.Text = "";
            txtNumero.Clear();
        }




        private void btnCadastrar_Click(object sender, EventArgs e)
        {
            if (txtCpf.Text != " " && txtNomeCliente.Text != " " && txtEndereco.Text != "" && mskTelefone.Text != "" && txtNumero.Text != "")
            {

                RecebendoValor();
                var result = MessageBox.Show("Cadastrado com sucesso!", MessageBoxButtons.OK.ToString());

                if (result == DialogResult.OK)
                {
                    this.Close();

                }

                cli.Cadastrar();
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

        private void btnFecharCad_Click(object sender, EventArgs e)
        {
            var result = MessageBox.Show(mensagem, fechar,
                             MessageBoxButtons.YesNo,
                             MessageBoxIcon.Question);

            if (result != DialogResult.No  )
            {
                this.Close();
            }
          
        }

        private void txtNumero_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((Char.IsLetter(e.KeyChar)))
                e.Handled = true;
        }

        private void frmCadastroCliente_Load(object sender, EventArgs e)
        {

        }

        private void btnAlterar_Click(object sender, EventArgs e)
        {
            if (txtCpf.Text != " " && txtNomeCliente.Text != " " && txtEndereco.Text != "" && mskTelefone.Text != "" && txtNumero.Text != "")
            {

                RecebendoValor();
                cli.Id = int.Parse(txtId.Text);
                cli.Alterar();

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
    }
}

