using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Projeto_Escola.classes
{
    class Connection
    {
        private static string connectionLine = "SERVER=localhost;UID=root;PASSWORD=root;DATABASE=escalaaula";

        public static string getConnection()
        {
            return connectionLine;
        }
    }
}
