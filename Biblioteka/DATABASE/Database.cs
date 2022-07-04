using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;

namespace Biblioteka.DATABASE
{





    class Database
    {
        //connection
        MySqlConnection connection = new MySqlConnection("server=localhost;port=3306;username=root;password=;database=biblioteka");

        //create a function to open connection
        public void openConnection()
        {
            if(connection.State == System.Data.ConnectionState.Closed)
            {
                connection.Open();
            }
        }

        //close connection
        public void closeConnection()
        {
            if (connection.State == System.Data.ConnectionState.Open)
            {
                connection.Close();
            }
        }

        //return connection
        public MySqlConnection GetConnection()
        {
            return connection;
        }

        //return data
        public DataTable GetData(string query, MySqlParameter[] param)
        {
            MySqlCommand command = new MySqlCommand(query, GetConnection());
            if(param != null)
            {
                command.Parameters.AddRange(param);
            }
            DataTable table = new DataTable();
            MySqlDataAdapter adapter = new MySqlDataAdapter();
            adapter.SelectCommand = command;
            adapter.Fill(table);
            return table;
        }

        //set data
        public int SetData(string query, MySqlParameter[] param)
        {
            MySqlCommand command = new MySqlCommand(query, GetConnection());
            if (param != null)
            {
                command.Parameters.AddRange(param);
            }

            openConnection();

            int commandState = command.ExecuteNonQuery();

            closeConnection();

            return commandState;
        }
    }
}
