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
    public partial class CU_VendaPizza : UserControl
    {
        public CU_VendaPizza()
        {
            InitializeComponent();
        }

        private void CU_Cadastrar_Load(object sender, EventArgs e)
        {

        }

        private void button7_Click(object sender, EventArgs e)
        {
            using(Formularios.frmCadastroFim uf = new Formularios.frmCadastroFim())
            {
                uf.ShowDialog();
            }
        }
    }
}
