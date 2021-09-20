using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;
using System.Data;

namespace Projeto_Escola.classes
{
    class Turma : Database
    {
        public string Initials { get; private set; }
        public string Group { get; private set; }

        public Turma():base() { }

        public Turma(string initials, string group):base()
        {
            this.Initials = initials;
            this.Group = group;
        }

        public void Insert() 
        {
            string[,] parameters = new string[2,2];
            parameters[0,0] = "vInitials";
            parameters[0,1] = Initials;
            parameters[1,0] = "vGroup";
            parameters[1,1] = Group;
            Execute("HandleTurma", parameters);
        }
    }
}