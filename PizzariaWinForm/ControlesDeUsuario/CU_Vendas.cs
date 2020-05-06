using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PizzariaWinForm.ControlesDeUsuario
{
    public partial class CU_Vendas : UserControl
    {
        public CU_Vendas()
        {
            InitializeComponent();
        }
        Vendas vend = new Vendas();
        private void btnAddVenda_Click(object sender, EventArgs e)
        {
            using (Formularios.frmVendas abn = new Formularios.frmVendas())
            {
                abn.ShowDialog();

            }
        }

        private void btnAtualizar_Click(object sender, EventArgs e)
        {
            vend.Dados = dgvVenda;

            vend.Listar();
        }

        private void dgvVenda_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
