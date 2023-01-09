using System;
using System.Data.Entity;
using System.Linq;
using MySql.Data.MySqlClient;

namespace apk
{
    public class MYDB : DbContext
    {
    
        public MYDB()
            : base("name=MYDB")
        {
        }

        private MySqlConnection Connection = new MySqlConnection(
            "server=localhost;port=3306;username=root;password=;database=library");

        public void openConnection()
        {
            if (Connection.State == System.Data.ConnectionState.Closed)
            {
                Connection.Open();
            }

        }

        public void closeConnection()
        {
            if (Connection.State == System.Data.ConnectionState.Open)
            {
                Connection.Close();
            }

        }

        public MySqlConnection getConnection()
        {
            return Connection;
        }
    
    }

}