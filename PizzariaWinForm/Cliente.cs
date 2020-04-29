using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

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

    }
}
