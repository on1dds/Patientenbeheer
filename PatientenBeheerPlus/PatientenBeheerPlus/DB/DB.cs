using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace PatientenBeheerPlus
{

    public static class DB
    {
        public const int PRESTATIESTATUS_VERSTREKT = 1;
        public const int PRESTATIESTATUS_AFGESLOTEN = 2;
        public const int PRESTATIESTATUS_AAGEREKEND = 3;
        public const int PRESTATIESTATUS_BETAALD = 4;

        public static SqlConnection GetConnection()
        {
            string connectionString = "Data Source=localhost\\SqlExpress;Initial Catalog=patienten;Integrated Security=True";
            SqlConnection connection = new SqlConnection(connectionString);
            return connection;
        }


    }
}
