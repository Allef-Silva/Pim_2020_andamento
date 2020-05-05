using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;
using System.Data;

namespace PizzariaWinForm
{



    class Fornecedor
    {
        private string razao_social;
        private string cnpj;
        private string nome;
        private string telefone;
        private string endereco;
        private string obs;
        private int numero;
        private DataGridView dados;


        public string Cnpj
        {
            get { return cnpj; }
            set { cnpj = value; }
        } 
        public int Numero
        {
            get { return numero; }
            set { numero = value; }
        }
        public string Razao_social
        {
            get { return razao_social; }
            set { razao_social = value; }
        }  
        public string Obs
        {
            get { return obs; }
            set { obs = value; }
        }
        public DataGridView Dados
        {
            get { return dados; }
            set { dados = value; }
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

        dbConc conexao = new dbConc();
        MySqlCommand comando;


        public void Cadastrar()
        {
            string strSql = "INSERT INTO Fornecedor (razao_social, cnpj, nome_fantasia ,endereco, numero, telefone, Observacoes) " +
                   "VALUES ('" + razao_social + "','" + cnpj + "','" + nome + "' ,'" + endereco + "' , '" + numero + "', '" + telefone + "', '" + obs + "')";

            try
            {

                comando = new MySqlCommand(strSql, conexao.AbrirBanco());
                comando.ExecuteNonQuery();

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);

            }
            finally
            {
                conexao.FecharBanco(conexao.AbrirBanco());
                // conexao = null;
                // comando = null;
            }


         

        }
        public void Alterar()
        {
            
            string strSql =  "UPDATE Fornecedor SET razao_social = '" + razao_social +
                "', nome_fantasia= '" + nome + "' , endereco= '" + endereco + "', numero= '" + numero + "' , telefone= '" + telefone + "', Observacoes= '" + obs + "' where cnpj= '" + cnpj + "'";
            try
            {

                comando = new MySqlCommand(strSql, conexao.AbrirBanco());
                comando.ExecuteNonQuery();

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);

            }
            finally
            {
                conexao.FecharBanco(conexao.AbrirBanco());

                //conexao = null;
                //comando = null;
            }


        }
        public void Excluir()
        {
            string strSql = "a";
            try
            {

                comando = new MySqlCommand(strSql, conexao.AbrirBanco());
                comando.ExecuteNonQuery();

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);

            }
            finally
            {
                conexao.FecharBanco(conexao.AbrirBanco());
                //conexao = null;
                //comando = null;
            }



        }
        public void Listar()
           
        {
            string strSql = "select razao_social as Social, cnpj as CNPJ, nome_fantasia as Nome , endereco as Endereco, numero as Numero, telefone as Telefone, Observacoes  from Fornecedor"; 
            comando = new MySqlCommand(strSql, conexao.AbrirBanco());

            try
            {
                MySqlDataAdapter da = new MySqlDataAdapter(comando);

                DataTable dtLista = new DataTable();
                DataSet ds = new DataSet();
                da.Fill(dtLista);


                dados.DataSource = dtLista;

            }
            catch (Exception ex)
            {
                MessageBox.Show("Ocorreu um erro" + ex);
            }
        }
    }
}
