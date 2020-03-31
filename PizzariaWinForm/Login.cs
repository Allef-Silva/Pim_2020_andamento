using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace PizzariaWinForm
{
    class Login
    {
        private string usuario;
        private string senha;


        public string Usuario
        {
            get { return usuario; }
            set { usuario = value; }
        }
        public string Senha
        {
            get { return senha; }
            set { senha = value; }
        }

        public bool Verificao()
        {
            dbConc conex = new dbConc();
            try
            {

                conex.AbrirBanco();

                string strSql = "select * from login where usuario='" + Usuario + "' && senha='" + Senha + "' ";
                
                MySqlDataAdapter data = new MySqlDataAdapter(strSql, conex.AbrirBanco());
                DataTable dt = new DataTable();
                data.Fill(dt);


                if (dt.Rows.Count == 1)
                {
                    frmMenu menu = new PizzariaWinForm.frmMenu();
                    menu.Show();
                    return true;

                }


                else
                {
                    MessageBox.Show("Login nao encontrado", MessageBoxButtons.OK.ToString());
                    return false;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                return false;

            }
            finally
            {
                conex.FecharBanco(conex.AbrirBanco());
                conex = null;
            }

        }


    }


}

