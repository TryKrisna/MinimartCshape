using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace Minimart_Management
{
    class DBConnect
    {
        private SqlConnection connection = new SqlConnection(@"Data Source=LAPTOP-J7GFH444;Initial Catalog=Minimart;Integrated Security=True");
        public SqlConnection Getcon()
        {
            return connection;
        }
        public void Opencon()
        {
            if(connection.State == System.Data.ConnectionState.Closed)
            {
                connection.Open();
            }
        }
        public void Closecon()
        {
            if(connection.State == System.Data.ConnectionState.Open)
            {
                connection.Close();
            }
        }
    }
}
