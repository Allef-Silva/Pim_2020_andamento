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
        Cliente cad = new Cliente();





        private void btnAtulizar_Click(object sender, EventArgs e)
        {
            cad.Dados = dgvCliente;

            cad.Listar();


        }


       

        private void dgvCliente_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {


            string idDgv;
            string nomeDgv;
            string enderecoDgv;
            string numeroDgv;
            string telefoneDgv;
            string cpfdDgv;
            dgvCliente.CurrentRow.Selected = true;
            idDgv = dgvCliente.Rows[e.RowIndex].Cells["Cliente"].FormattedValue.ToString();
            nomeDgv = dgvCliente.Rows[e.RowIndex].Cells["Nome"].FormattedValue.ToString();
            enderecoDgv = dgvCliente.Rows[e.RowIndex].Cells["Endereco"].FormattedValue.ToString();
            numeroDgv = dgvCliente.Rows[e.RowIndex].Cells["Numero"].FormattedValue.ToString();
            telefoneDgv = dgvCliente.Rows[e.RowIndex].Cells["Telefone"].FormattedValue.ToString();
            cpfdDgv = dgvCliente.Rows[e.RowIndex].Cells["Cpf"].FormattedValue.ToString();



            Formularios.frmCadastroCliente cad = new Formularios.frmCadastroCliente();

            cad.RecebendoValorDgv(idDgv,nomeDgv, enderecoDgv, numeroDgv,telefoneDgv,cpfdDgv);
            cad.Show();


        }
      
    }
}
