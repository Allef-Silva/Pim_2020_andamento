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
    class Cliente

    {
        private string nome;
        private string endereco;
        private string telefone;
        private string cpf;
        private int numero;
        private int id;



        public int Id
        {
            get { return id; }
            set { id = value; }
        }  
        public int Numero
        {
            get { return numero; }
            set { numero = value; }
        }
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
        public string CPF
        {
            get { return cpf; }
            set { cpf = value; }
        }
        dbConc conexao = new dbConc();
        MySqlCommand comando;

        private DataGridView dados;



        public DataGridView Dados
        {
            get { return dados; }
            set { dados = value; }
        }


        bool cad = false;
        public void Cadastrar()
        {
            string strSql = "INSERT INTO cliente (nome_cliente, endereco_cliente, numero_cliente ,telefone_cliente, cpf_cliente) " +
                   "VALUES ('" + Nome + "','" + Endereco + "','" + Numero + "' ,'" + Telefone + "' , '" + CPF + "')";

            try
            {

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
                // conexao = null;
                // comando = null;
            }
            if (cad == true)
            {
                //MessageBox.Show("Cadastrado com sucesso!", MessageBoxButtons.OK.ToString());
            }
            else
            {
                MessageBox.Show("Tente Novamente!", MessageBoxButtons.OK.ToString());
            }

        }
        public void Alterar()
        {
            string strSql = "";
            try
            {

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

                //conexao = null;
                //comando = null;
            }
            if (cad == true)
            {
                MessageBox.Show("Atualizado com sucesso!", MessageBoxButtons.OK.ToString());
            }

        }
        public void Excluir()
        {
            string strSql = "a";
            try
            {

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
                //conexao = null;
                //comando = null;
            }



        }
        public void Listar()
        {
            string strSql = "select cod_cliente as Cliente, nome_cliente as Nome, endereco_cliente as Endereco, numero_cliente as Numero, telefone_cliente as Telefone, cpf_cliente as CPF  from cliente"; ;
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
