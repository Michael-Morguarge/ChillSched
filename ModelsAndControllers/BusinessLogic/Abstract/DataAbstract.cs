using System;
using System.Collections.Generic;
using System.Data;
using System.Data.OleDb;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Backend.BusinessLogic.Abstract
{
    public abstract class DataAbstract
    {
        private readonly string connectionString;
        private OleDbConnection connection;

        protected DataAbstract(string connString)
        {
            connectionString = connString;
        }

        protected void Open()
        {
            if (connection.State == ConnectionState.Closed)
            {
                connection = new OleDbConnection(connectionString);
                connection.Open();
            }
        }

        protected void Close()
        {
            if (connection.State == ConnectionState.Open)
            {
                connection.Close();
            }
        }

        protected bool IsUsing()
        {
            return new List<ConnectionState> {
                ConnectionState.Connecting, ConnectionState.Executing, ConnectionState.Fetching
            }.Contains(connection.State);
        }
    }
}
