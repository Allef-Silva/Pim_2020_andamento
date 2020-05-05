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
    class Produto
    {
        dbConc conexao = new dbConc();
        MySqlCommand comando;
        MySqlDataAdapter da;

        private string descricao;
        private double preco;
        private double precoVenda;
        private int quantidade;
        private string fabricante;
        private int id;
        private DataGridView dados;
     

        private string categoria;




        public string Descricao
        {
            get { return descricao; }
            set { descricao = value; }
        }
    
        public string Categoria
        {
            get { return categoria; }
            set { categoria = value; }
        }

      
        public int Id
        {
            get { return id; }
            set { id = value; }
        }
        public int Quantidade
        {
            get { return quantidade; }
            set { quantidade = value; }
        }
        public string Fabricante
        {
            get { return fabricante; }
            set { fabricante = value; }
        }
        public double Preco
        {
            get { return preco; }
            set { preco = value; }
        }
        public double PrecoVenda
        {
            get { return precoVenda; }
            set { precoVenda = value; }
        }

        public DataGridView Dados
        {

            get { return dados; }
            set { dados = value; }
        }
        bool cad = false;
        public void Cadastrar()
        {



            try
            {
                                               
                      string strSql = "INSERT INTO produto (descricao, preco, precoVenda, categoria,quantidade, fornecedor) " +
                      "VALUES ('" + descricao + "','" + preco + "','" + precoVenda + "' , '" + categoria + "', '" + quantidade + "', '" + fabricante + "')";
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
            try
            {
                

                string strSql = "UPDATE produto SET descricao='" + descricao + "', preco= '" + preco + "', precoVenda= '" + PrecoVenda + "' , categoria= '" + categoria + "', quantidade= '" + quantidade + "', fornecedor= '" + fabricante + "' where id_produto='" + id + "'";

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
            try
            {

                string strSql = "DELETE FROM PRODUTO where id_produto='" + id + "' ";

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
                MessageBox.Show("exluido com sucesso!", MessageBoxButtons.OK.ToString());
            }


        }
        public void Listar()
        {
            string strMySql = "SELECT *FROM produto";
            comando = new MySqlCommand(strMySql, conexao.AbrirBanco());

            try
            {
                MySqlDataAdapter da = new MySqlDataAdapter(comando);

                DataTable dtLista = new DataTable();

                da.Fill(dtLista);

                dados.DataSource = dtLista;



            }
            catch (Exception ex)
            {
                MessageBox.Show("Ocorreu um erro" + ex);
            }
        }
    
        public void PreencherFornecedor(ComboBox comboBox)
        {


            try
            {
                string tbFornecedor = "select *from Fornecedor";
                comando = new MySqlCommand(tbFornecedor, conexao.AbrirBanco());
                DataSet ds = new DataSet();
                da = new MySqlDataAdapter(comando);
                da.Fill(ds);
                comboBox.DataSource = ds.Tables[0];
                comboBox.DisplayMember = "nome_fantasia";
                comboBox.ValueMember = "cnpj";



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
