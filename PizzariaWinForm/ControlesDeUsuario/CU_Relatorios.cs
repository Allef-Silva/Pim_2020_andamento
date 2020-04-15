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
    public partial class CU_Relatorios : UserControl
    {
        public CU_Relatorios()
        {
            InitializeComponent();
        }

        private void btnAdicionarFornecedor_Click(object sender, EventArgs e)
        {
            using (Formularios.frmAddDespesa ae = new Formularios.frmAddDespesa()) 
            {
                ae.ShowDialog();
            }

        }
    }
}
