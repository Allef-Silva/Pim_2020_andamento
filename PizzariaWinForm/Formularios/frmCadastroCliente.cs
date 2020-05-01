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
        Cadastros cad = new Cadastros();
        string mensagem = "Deseja sair do cadastro?";
        string fechar = "fechando cadastro!!";
        public void RecebendoValor()
        {

            cli.Nome = txtNomeCliente.Text;
            cli.Endereco = txtEndereco.Text;
            cli.Telefone = mskTelefone.Text;
            cli.CPF = txtCpf.Text;
            cli.Numero = int.Parse(txtNumero.Text);
        }
        public void EsvaziandoCampos()
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
            RecebendoValor();
         

            if (txtNomeCliente.Text == "")
            {
                MessageBox.Show("O CAMPO NOME DEVE ESTAR PREENCHIDO", "NOME", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtNomeCliente.Select();
                return;
            }

            if (txtCpf.Text == "")
            {
                MessageBox.Show("O CAMPO E-MAIL DEVE ESTAR PREENCHIDO", "CPF", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtCpf.Select();
                return;
            }

            //VA
            if (txtCpf.Text != " " && txtNomeCliente.Text != " ")
                cli.Cadastrar();
            var result =  MessageBox.Show("Cadastrado com sucesso!", MessageBoxButtons.OK.ToString());
            EsvaziandoCampos();
            if (result == DialogResult.OK)
            {
                this.Close();
                
            }
            
        }

        private void btnFechar_Click(object sender, EventArgs e)
        {
            
            var result = MessageBox.Show(mensagem,fechar, 
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
    }
}
