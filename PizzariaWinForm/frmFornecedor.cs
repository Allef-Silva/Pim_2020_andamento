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
    public partial class frmFornecedor : Form
    {
        public frmFornecedor()
        {
            InitializeComponent();
        }

        private void btnCadastar_Click(object sender, EventArgs e)
        {
            Fornecedor forn = new Fornecedor();
            forn.Cnpj = mskTxtBoxCnpj.Text;
            forn.Nome = txtNome.Text;
            forn.Endereco = txtEndereco.Text;
            forn.Telefone = mskTxtBoxTelefone.Text;
            forn.Razao_social = txtRazaoSocial.Text;

           
            
            if (mskTxtBoxCnpj.Text == "")
            {
                MessageBox.Show("O CAMPO CNPJ DEVE ESTAR PREENCHIDO", "NOME", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                mskTxtBoxCnpj.Select();
            }              if (txtNome.Text == "")
            {
                MessageBox.Show("O CAMPO Nome DEVE ESTAR PREENCHIDO", "NOME", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtNome.Select();
                return;
            }


            //VA
            if (txtNome.Text != " " && mskTxtBoxCnpj.Text != " ")
                forn.Cadastrar();
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            frmMenu menu = new frmMenu();
            this.Hide();
            menu.Show();
        }
    }
}
