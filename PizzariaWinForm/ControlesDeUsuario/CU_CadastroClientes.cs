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
            using (Formularios.frmCadastroCliente abn = new Formularios.frmCadastroCliente())
            {
                abn.ShowDialog();
                string strSql = "select cod_cliente as Cliente, nome_cliente as Nome, endereco_cliente as Endereco, numero_cliente as Numero, telefone_cliente as Telefone, cpf_cliente as CPF  from cliente"; ;

                Cliente cli = new Cliente();
                dgvCliente.CurrentRow.Selected = true;
                cli.Id =int.Parse(dgvCliente.Rows[e.RowIndex].Cells["Cliente"].FormattedValue.ToString());
                cli.Nome = dgvCliente.Rows[e.RowIndex].Cells["Nome"].FormattedValue.ToString();
                cli.Endereco = dgvCliente.Rows[e.RowIndex].Cells["Endereco"].FormattedValue.ToString();
                cli.Numero =int.Parse( dgvCliente.Rows[e.RowIndex].Cells["Numero"].FormattedValue.ToString());
                cli.Telefone = dgvCliente.Rows[e.RowIndex].Cells["Telefone"].FormattedValue.ToString();
                cli.CPF = dgvCliente.Rows[e.RowIndex].Cells["Cpf"].FormattedValue.ToString();
               
            }

               
        }
    }
}
