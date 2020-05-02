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
            RecebendoValorDgv();
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
        private void RecebendoValorDgv()
        {

            txtNomeCliente.Text = cli.Nome;
            txtEndereco.Text = cli.Endereco  ;
            mskTelefone.Text = cli.Telefone;
            txtCpf.Text = cli.CPF;
            txtNumero.Text =  cli.Numero.ToString() ;
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

            if (result == DialogResult.No)
            {

            }
            else
            {
                this.Close();
            }
        }

        private void btnFecharCad_Click(object sender, EventArgs e)
        {
            var result = MessageBox.Show(mensagem, fechar,
                             MessageBoxButtons.YesNo,
                             MessageBoxIcon.Question);

            if (result == DialogResult.No)
            {

            }
            else
            {
                this.Close();
            }
        }

        private void txtNumero_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((Char.IsLetter(e.KeyChar)))
                e.Handled = true;
        }
       

    }
}
