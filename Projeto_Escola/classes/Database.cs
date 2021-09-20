using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;
using System.Data;

namespace Projeto_Escola.classes
{
    class Database
    {
        MySqlConnection connection = null;
        MySqlCommand cSQL = null;
        string connectionLine = "";

        #region Constructor
        public Database() 
        {
            connectionLine = Connection.getConnection();
        }
        #endregion

        #region Open and Close Database
        private bool OpenDatabase() 
        {
            connection = new MySqlConnection(connectionLine);
            try {
                connection.Open();
                return true;
            }
            catch { return false; }
        }

        public bool CloseDatabase() 
        {
            try
            {
                if (connection.State == ConnectionState.Open) { connection.Close(); }
                return true;
            }
            catch
            {
                return false;
            }
        }
        #endregion

        #region Consult
        public MySqlDataReader Consult(string command) 
        {
            MySqlDataReader data = null;
            try
            {
                if (OpenDatabase())
                {
                    cSQL = new MySqlCommand(command, connection);
                    data = cSQL.ExecuteReader();
                }
                else
                {
                    return null;
                }
                return data;
            }
            catch 
            {
                CloseDatabase();
                return null;
            }
        }

        public bool Consult(string StoreProcedureName, string[,] args, ref MySqlDataReader data) 
        {
            try
            {
                if (OpenDatabase())
                {
                    cSQL = new MySqlCommand(StoreProcedureName, connection);
                    cSQL.CommandType = CommandType.StoredProcedure;
                    cSQL.Parameters.Clear();

                    if (args != null)
                    {
                        for (int i = 0; i < args.Length / 2; i++)
                        {
                            cSQL.Parameters.Add(new MySqlParameter(args[i,0], args[i,1]));
                        }
                    }
                    data = cSQL.ExecuteReader();
                    return true;
                }
                else { return false; }
            }
            catch (Exception)
            {

                throw;
            }
        }
        #endregion

        #region Execute
        public bool ExecuteNoSP(string command) 
        {
            try
            {
                if (OpenDatabase())
                {
                    cSQL = new MySqlCommand(command, connection);
                    cSQL.ExecuteNonQuery();
                    CloseDatabase();
                    return true;
                }
                else
                {
                    return false;
                }
            }
            catch
            {
                CloseDatabase();
                return false;
            }
        }
        public bool Execute(string StoreProcedureName, string[,] args) 
        {
            try
            {
                if (OpenDatabase())
                {
                    cSQL = new MySqlCommand(StoreProcedureName, connection);
                    cSQL.CommandType = CommandType.StoredProcedure;
                    cSQL.Parameters.Clear();

                    if (args != null)
                    {
                        for (int i = 0; i < args.Length / 2; i++)
                        {
                            cSQL.Parameters.Add(new MySqlParameter(args[i, 0], args[i, 1]));
                        }
                        cSQL.ExecuteNonQuery();
                        CloseDatabase();
                    }
                    return true;
                }
                else 
                {
                    return false;
                }
            }
            catch (Exception error)
            {
                CloseDatabase();
                return false;
            }
        }
        #endregion
    }
}
