using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;
using System.Data;

namespace PizzariaWinForm
{
    class dbConc
    {
        string conexao = "Server=pim-2020.cj2olk5t1tbe.sa-east-1.rds.amazonaws.com;Database=pizzaria;Uid=Master;Pwd=Brasileiro55";
        public MySqlConnection AbrirBanco()
        {
            MySqlConnection cn = new MySqlConnection(conexao);
            cn.Open();
            return cn;
        }
        public void FecharBanco(MySqlConnection cn)
        {
            if (cn.State == ConnectionState.Open)
                cn.Close();

        }

    }
}

