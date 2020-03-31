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
    public partial class frmMenu : Form
    {
        public frmMenu()
        {
            InitializeComponent();
           
            
        }

        private void clientesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmCliente cli = new frmCliente();
            this.Hide();
            cli.Show();
        }

        private void frmMenu_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

        private void fornecedoresToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmFornecedor forn = new frmFornecedor();
            this.Hide();
            forn.Show();
        }

        private void produtoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmProduto forn = new frmProduto();
            this.Hide();
            forn.Show();
        }
    }
}
