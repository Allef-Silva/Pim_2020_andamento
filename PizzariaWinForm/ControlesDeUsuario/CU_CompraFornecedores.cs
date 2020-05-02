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
    public partial class CU_CompraFornecedores : UserControl
    {
        public CU_CompraFornecedores()
        {
            InitializeComponent();
        }

        private void btnAdicionarFornecedor_Click(object sender, EventArgs e)
        {
            using (Formularios.frmNovoFornecedor abn = new Formularios.frmNovoFornecedor())
            {
                abn.ShowDialog();
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            using (Formularios.frmCadastroEstoque ads = new Formularios.frmCadastroEstoque())
            {
                ads.ShowDialog();
            }
        }

    

        private void btnAtulizar_Click(object sender, EventArgs e)
        {
            Fornecedor fornecedor = new Fornecedor();
            fornecedor.Dados = dgvFornecedor;

            fornecedor.Listar();
        }
    }
}
