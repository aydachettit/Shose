using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Shoes.DAL
{
    public class DBConnection
    {
        static string shoestoreConnectionString = @"Data Source=DESKTOP-54VDS9I\SQLEXPRESS;Initial Catalog=shoestore;Integrated Security=True";
        public SqlConnection con = new SqlConnection(shoestoreConnectionString);
        public void checkConnection()
        {
            if (con == null)
            {
                con = new SqlConnection(shoestoreConnectionString);
            }
            if (con.State == ConnectionState.Closed)
            {
                con.Open();
            }
        }
    }
}
