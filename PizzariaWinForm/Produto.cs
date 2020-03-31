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
        private decimal preco;
        private int quantidade;
        private string fabricante;




        public string Descricao
        {
            get { return descricao; }
            set { descricao = value; }
        }
        public decimal Preco
        {
            get { return preco; }
            set { preco = value; }
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

        public void Cadastrar()
        {
                           
            bool cad = false;
            try
            {

                string strSql = "INSERT INTO PRODUTO (descricao, preco, quantidade, fornecedor) " +
                    "VALUES ('" + descricao + "','" + preco + "','" + quantidade + "' , '" + fabricante + "')";
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
        public void Preencher (ComboBox comboBox)
        {
            

            try
            {
                string tbFornecedor = "select *from Fornecedor";
                comando = new MySqlCommand(tbFornecedor , conexao.AbrirBanco());
                DataSet ds = new DataSet();
                da = new MySqlDataAdapter(comando);
                da.Fill(ds);
                comboBox.DataSource = ds.Tables[0];
                comboBox.DisplayMember = "razao_social";
                comboBox.ValueMember = "razao_social";

                

            }
            catch(Exception ex)
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
