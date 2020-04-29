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
    class Cadastros
    {
        dbConc conexao = new dbConc();
        MySqlCommand comando;
        
        private DataGridView dados;
        private string strSql; 


        public DataGridView Dados
        {
            get { return dados; }
            set { dados = value; }
        }
        public string StrSql
        {
            get { return strSql; }
            set { strSql = value; }
        }
        bool cad = false;
        public void Cadastrar()
        {

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
                MessageBox.Show("Cadastrado com sucesso!", MessageBoxButtons.OK.ToString());
            }
            else
            {
                MessageBox.Show("Tente Novamente!", MessageBoxButtons.OK.ToString());
            }

        }
        public void Alterar()
        {
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
                MessageBox.Show("exluido com sucesso!", MessageBoxButtons.OK.ToString());
            }


        }
        public void Listar()
        {
           
            comando = new MySqlCommand(strSql, conexao.AbrirBanco());

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
    }
}
