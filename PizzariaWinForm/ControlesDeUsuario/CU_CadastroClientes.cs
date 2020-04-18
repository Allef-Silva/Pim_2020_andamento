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
    public partial class CU_CadastroClientes : UserControl
    {
        public CU_CadastroClientes()
        {
            InitializeComponent();
        }

        private void btnAdicionarFornecedor_Click(object sender, EventArgs e)
        {
            using (Formularios.frmCadastroCliente abn = new Formularios.frmCadastroCliente())
            {
                abn.ShowDialog();
            }
        }
    }
}
