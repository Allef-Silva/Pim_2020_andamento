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
    public partial class frmLogin : Form
    {
        public frmLogin()
        {
            InitializeComponent();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            Login login = new Login();

            login.Usuario = txtLogin.Text;
            login.Senha = txtSenha.Text;

            if (login.Verificao() == false)
            {
                txtLogin.Clear();
                txtSenha.Clear();

            }
            else
            {
                this.Hide();
            }

        }


        private void btnSair_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
