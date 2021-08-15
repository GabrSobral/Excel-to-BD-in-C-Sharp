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
    class UserClass
    {
        public int rm;
        public string nome;
        public string turma;
        public string grupo = "T";
        public int ano_turma;

        public string register(ArrayList users) 
        {
            Banco banco = new Banco();
            banco.cSQL = new MySqlCommand("RegisterUser", banco.conexao);
            banco.cSQL.CommandType = CommandType.StoredProcedure;

            banco.OpenDataBase();
            foreach (UserClass user in users) 
            {
                banco.cSQL.Parameters.Clear();
                banco.cSQL.Parameters.Add(new MySqlParameter("vCD_USUARIO", user.rm));
                banco.cSQL.Parameters.Add(new MySqlParameter("vNM_USUARIO", user.nome));
                banco.cSQL.Parameters.Add(new MySqlParameter("vNM_TURMA", user.turma));
                banco.cSQL.Parameters.Add(new MySqlParameter("vNM_GRUPO", user.grupo));
                banco.cSQL.Parameters.Add(new MySqlParameter("vIC_QUESTIONARIO_APROVADO", false));
                banco.cSQL.Parameters.Add(new MySqlParameter("vAA_TURMA", user.ano_turma));

                try { banco.cSQL.ExecuteNonQuery(); }
                catch (Exception error)
                {
                    string[] errorParts =  error.Message.Split(null);
                    if (errorParts[0] == "Duplicate") { return $"Tabela contém usuários já cadastrados: \n RM:{user.rm} TURMA: {user.turma}"; }
                    return error.Message; 
                }
            }
            banco.CloseDataBase();
            return "Sucesso";
        }
    }
}
