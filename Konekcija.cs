using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KontrolniA
{
    class Konekcija
    {
        static string connstr = @"Data Source=DESKTOP-KHDOA1Q; integrated security=true; Initial Catalog= Hotel";
        static SqlConnection GetConnection()
        {
            return new SqlConnection(connstr);
        }
        public static SqlCommand GetCommand()
        {
            SqlCommand command = new SqlCommand();
            command.Connection = GetConnection();
            command.CommandType = CommandType.StoredProcedure;
            return command;
        }
    }
}
