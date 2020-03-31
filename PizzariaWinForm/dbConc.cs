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
        string conexao = "Server=localhost;Database=pizzaria;Uid=root;Pwd=Brasileiro55@";
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

        }/*
        public void ExecutarComando(string strQuery)
        {
            MySqlConnection cn = new MySqlConnection();
            try
            {
                cn = AbrirBanco();
                MySqlCommand cmd = new MySqlCommand();
                cmd.CommandText = strQuery.ToString();
                cmd.CommandType = CommandType.Text;
                cmd.Connection = cn;
                cmd.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                throw ex;
            }
            finally
            {
                FecharBanco(cn);
            }
        }
        public DataSet RetornarDataSet(string strQuery)
        {
            MySqlConnection cn = new MySqlConnection();
            try
            {
                cn = AbrirBanco();
                MySqlCommand cmd = new MySqlCommand();
                cmd.CommandText = strQuery.ToString();
                cmd.CommandType = CommandType.Text;
                cmd.Connection = cn;
                cmd.ExecuteNonQuery();
                /*  Declarado um dataadapter e um dataset
                    passar o comando para o da (SqlDataAdapter) e
                    carregar o dataset com resultado da busca 
                MySqlDataAdapter da = new MySqlDataAdapter();
                DataSet ds = new DataSet();
                da.SelectCommand = cmd;
                da.Fill(ds);
                return ds;
            }
            catch (Exception ex)
            {
                throw ex;
            }
            finally
            {
                FecharBanco(cn);
            }
        }
        public MySqlDataReader RetornarDataReader(string strQuery)
        {
            MySqlConnection cn = new MySqlConnection();
            try
            {
                cn = AbrirBanco();
                MySqlCommand cmd = new MySqlCommand();
                cmd.CommandText = strQuery.ToString();
                cmd.CommandType = CommandType.Text;
                cmd.Connection = cn;
                return cmd.ExecuteReader();
            }
            catch (Exception ex)
            {
                throw ex;
            }
            finally
            {
                FecharBanco(cn);
            }
        }
        public int RetornarIdNumerico(string strQuery)
        {
            MySqlConnection cn = new MySqlConnection();
            try
            {
                cn = AbrirBanco();
                MySqlCommand cmd = new MySqlCommand();
                cmd.CommandText = strQuery.ToString();
                cmd.CommandType = CommandType.Text;
                cmd.Connection = cn;
                MySqlDataReader dr = cmd.ExecuteReader();
                int codigo;
                if (dr.Read())
                    codigo = Convert.ToInt16(dr[0]) + 1;
                else
                    codigo = 1;
                return codigo;
            }
            catch (Exception ex)
            {
                throw ex;
            }
            finally
            {
                FecharBanco(cn);
            }

        }
        */

    }
}

