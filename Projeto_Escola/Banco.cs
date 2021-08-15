using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;
using System.Data;
using System.Collections;
using System.Text.RegularExpressions;

namespace Projeto_Escola
{
    class Banco
    {
        public MySqlConnection conexao = 
            new MySqlConnection("SERVER=localhost;UID=root;PASSWORD=root;DATABASE=projeto_escola");
        public MySqlDataReader Dados;
        public MySqlCommand cSQL;

        public bool OpenDataBase()
        {
            try
            {
                conexao.Open();
                return true;
            }
            catch
            { return false; }
        }

        public void CloseDataBase()
        {
            if (Dados != null && !Dados.IsClosed) { Dados.Close(); }
            if (conexao.State == ConnectionState.Open) { conexao.Close(); }
        }     
    }
}
