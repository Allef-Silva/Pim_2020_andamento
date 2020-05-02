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
    public partial class CU_Cardapio : UserControl
    {
        public CU_Cardapio()
        {
            InitializeComponent();
        }
        Produto prod = new Produto();
        private void btnAdicionarFornecedor_Click(object sender, EventArgs e)
        {
            using (Formularios.frmCadastroPizzas ab = new Formularios.frmCadastroPizzas())
            {
                ab.ShowDialog();
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            using (Formularios.frmCadastroProduto abc = new Formularios.frmCadastroProduto())
            {
                abc.ShowDialog();
            }
        }

        private void dgvProduto_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            
        }

        private void btnAtulizar_Click(object sender, EventArgs e)
        {
            prod.Dados = dgvProduto;

            prod.Listar();
        }
    }
}
