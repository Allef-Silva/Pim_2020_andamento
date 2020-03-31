using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace PizzariaWinForm
{

    

    class Fornecedor
    {
        private string razao_social;
        private string cnpj;
        private string nome;
        private string telefone;
        private string endereco;


        public string Cnpj
        {
            get { return cnpj; }
            set { cnpj = value; }
        }
        public string Razao_social
        {
            get { return razao_social; }
            set { razao_social = value; }
        }

        public string Nome
        {
            get { return nome; }
            set { nome = value; }
        }
        public string Telefone
        {
            get { return telefone; }
            set { telefone = value; }
        }
        public string Endereco
        {
            get { return endereco; }
            set { endereco = value; }
        }




        public void Cadastrar()
        {

            dbConc conexao = new dbConc();
            MySqlCommand comando;
            bool cad = false;
            try
            {

                string strSql = "INSERT INTO FORNECEDOR (razao_social, cnpj, nome, endereco, telefone) " +
                    "VALUES ('" + razao_social + "','" + cnpj + "','" + nome + "' , '" + telefone + "','" + endereco + "')";
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
            if (cad == true)
            {
                MessageBox.Show("Cadastrado com sucesso!", MessageBoxButtons.OK.ToString());
            }
            else
            {
                MessageBox.Show("Tente Novamente!", MessageBoxButtons.OK.ToString());
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
