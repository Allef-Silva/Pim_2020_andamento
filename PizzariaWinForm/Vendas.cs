using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using MySql.Data.MySqlClient;
using System.Windows.Forms;


namespace PizzariaWinForm
{
    class Vendas
    {
        private float total;
        private DateTime dataVenda;
        private int quantidade;
        private int produto;
        private int cliente;
        private float preco;
        private int numVenda;
        

        
        public int Produto
        {
            get { return produto; }
            set { produto = value; }
        } 
        public int Cliente
        {
            get { return cliente; }
            set { cliente = value; }
        }    
         public float Preco
        {
            get { return preco; }
            set { preco = value; }
        } 
        public float Total 
        {
            get { return total; }
            set {  total = value; }
        } 
        public DateTime DataVenda 
        {
            get { return dataVenda; }
            set { dataVenda = value ; }
        } 
        public int Quantidade 
        {
            get { return quantidade; }
            set { quantidade = value; }
        } 
        public int  NumVenda
        {
            get { return numVenda; }
            set { numVenda = value; }
        }



        MySqlCommand comando;
        MySqlDataAdapter da;
        dbConc conexao = new dbConc();

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
                   "VALUES ";

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


        }
        public void Alterar()
        {

            string strSql = "UPDATE cliente SET nome_cliente='" ;

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

        public void PreencherProduto(ComboBox box)
        {

            try
            {
                string tbFornecedor = "select * from produto";
                comando = new MySqlCommand(tbFornecedor, conexao.AbrirBanco());
                DataSet ds = new DataSet();
                da = new MySqlDataAdapter(comando);
                da.Fill(ds);
                box.DataSource = ds.Tables[0];
                box.DisplayMember = "descricao";
                box.ValueMember = "id_produto";


            }

            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                conexao.FecharBanco(conexao.AbrirBanco());
            }

        }

        public void PreencherText(ComboBox box, TextBox texto)
        {
            
            string strPtext = "select *from produto where descricao='" + box.Text + "'";
            comando = new MySqlCommand(strPtext, conexao.AbrirBanco());
            comando.ExecuteNonQuery();
            MySqlDataReader dr;
            dr = comando.ExecuteReader();
            while (dr.Read())
            {
                string preco = (string)dr["preco"].ToString();
                texto.Text = preco;


            }

        }

        public void PreencherCliente(ComboBox comboBox)
        {


            try
            {
                string tbFornecedor = "select * from cliente";
                comando = new MySqlCommand(tbFornecedor, conexao.AbrirBanco());
                DataSet ds = new DataSet();
                da = new MySqlDataAdapter(comando);
                da.Fill(ds);
                comboBox.DataSource = ds.Tables[0];
                comboBox.DisplayMember = "nome_cliente";
                comboBox.ValueMember = "cod_cliente";



            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                conexao.FecharBanco(conexao.AbrirBanco());
            }

        }
        public void PreencherFornecedor(ComboBox comboBox)
        {


            try
            {
                string tbFornecedor = "select *from produto";
                comando = new MySqlCommand(tbFornecedor, conexao.AbrirBanco());
                DataSet ds = new DataSet();
                da = new MySqlDataAdapter(comando);
                da.Fill(ds);
                comboBox.DataSource = ds.Tables[0];
                comboBox.DisplayMember = "descricao";
                comboBox.ValueMember = "id_produto";



            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                conexao.FecharBanco(conexao.AbrirBanco());
            }

        }

    }
}
