using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace PizzariaWinForm
{
    class Cliente

    {
        private string nome;
        private string endereco;
        private string telefone;
        private string email;



        public string Nome
        {
            get { return nome; }
            set { nome = value; }
        }
        public string Endereco
        {
            get { return endereco; }
            set { endereco = value; }
        }
        public string Telefone
        {
            get { return telefone; }
            set { telefone = value; }
        }
        public string Email
        {
            get { return email; }
            set { email = value; }
        }

        public void Cadastrar()
        {

            dbConc conexao = new dbConc();
            MySqlCommand comando;
            bool cad = false;
            try
            {

                string strSql = "INSERT INTO CLIENTE (nome_cliente, endereco_cliente, telefone_cliente, email_cliente) " +
                    "VALUES ('" + nome + "','" + endereco + "','" + telefone + "' , '" + email + "')";
                comando = new MySqlCommand(strSql, conexao.AbrirBanco());
                comando.ExecuteNonQuery();
                cad = true;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                cad = false;
            }
            finally
            {
                conexao.FecharBanco(conexao.AbrirBanco());
                conexao = null;
                comando = null;
            }
            if(cad == true)
            {
                MessageBox.Show("Cadastrado com sucesso!", MessageBoxButtons.OK.ToString());
            }

        }
        public void Alterar()
        {

        }
        public void Excluir()
        {

        }
        public void Listar()
        {

        }

    }
}
