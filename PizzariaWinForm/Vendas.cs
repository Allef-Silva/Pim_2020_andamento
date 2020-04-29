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

    }
}
