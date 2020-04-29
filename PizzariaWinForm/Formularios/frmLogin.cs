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
