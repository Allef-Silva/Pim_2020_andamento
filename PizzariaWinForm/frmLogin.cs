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

            login.Usuario = txtUsuario.Text;
            login.Senha = txtSenha.Text;

            if (login.Verificao() == false)
            {
                txtUsuario.Clear();
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

        private void frmLogin_Load(object sender, EventArgs e)
        {
            pnlLogin.Location = new Point(this.Width / 2 - 161, this.Height / 2 - 104);
        }

        private void pnlLogin_Paint(object sender, PaintEventArgs e)
        {

        }

        private void txtUsuario_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnEntrar_Click(object sender, EventArgs e)
        {
            Login login = new Login();

            login.Usuario = txtUsuario.Text;
            login.Senha = txtSenha.Text;

            if (login.Verificao() == false)
            {
                txtUsuario.Clear();
                txtSenha.Clear();

            }
            else
            {
                this.Hide();
            }
            


        }
    }
}
