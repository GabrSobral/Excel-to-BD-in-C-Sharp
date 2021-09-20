using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Projeto_Escola.classes
{
    class Student : Database
    {
        public int RM { get; set; }
        public string Name { get; set; }
        public bool IsAgree { get; set; }
        public bool IsProtocolFinished { get; set; }
        public Turma Turma { get; set; }

        public Student():base() { }

        public Student(int rm, string name, Turma turma, bool isAgree = false, bool isProtocolFinished = false):base() 
        {
            this.RM = rm;
            this.Name = name;
            this.Turma = turma;
            this.IsAgree = isAgree;
            this.IsProtocolFinished = isProtocolFinished;
        }

        public void Insert() 
        {
            Turma.Insert();
            string[,] parameters = new string[6, 2];

            int isProtocolFinished = this.IsProtocolFinished == true ? 1 : 0; 
            int isAgree = this.IsAgree == true ? 1 : 0;

            parameters[0, 0] = "vRM";
            parameters[0, 1] = RM.ToString();

            parameters[1, 0] = "vName";
            parameters[1, 1] = Name.ToString();

            parameters[2, 0] = "vPresencial";
            parameters[2, 1] = isAgree.ToString();

            parameters[3, 0] = "vProtocol";
            parameters[3, 1] = isProtocolFinished.ToString();

            parameters[4, 0] = "vInitials";
            parameters[4, 1] = Turma.Initials;

            parameters[5, 0] = "vGroup";
            parameters[5, 1] = Turma.Group;

            Execute("HandleStudent", parameters);
        }
    }
}
