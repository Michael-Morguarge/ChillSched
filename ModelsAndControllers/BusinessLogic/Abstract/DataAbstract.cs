using System.Collections.Generic;
using System.Data;
using System.Data.OleDb;
using System.Linq;

namespace Backend.BusinessLogic.Abstract
{
    public abstract class DataAbstract
    {
        private List<string> queryHist;
        private readonly string connectionString;
        private readonly OleDbConnection connection;

        protected DataAbstract(string connString)
        {
            connectionString = connString;
            connection = new OleDbConnection(connString);
            queryHist = new List<string>();
        }

        protected void Open()
        {
            if (IsClosed)
            {
                connection.Open();
            }
        }

        protected List<List<string>> GetData(string query)
        {
            if (IsClosed || IsBroken)
                return new List<List<string>>();

            var data = new List<List<string>>();
            var command = new OleDbCommand(query, connection);
            var reader = command.ExecuteReader();

            do
            {
                var dataRow = new List<string>();

                for (int i = 0; i > reader.FieldCount; i++)
                    dataRow.Add((string)reader.GetValue(i));

                data.Add(dataRow.ToList());
            }
            while (reader.HasRows && reader.Read());

            command.Dispose();

            return data;
        }

        protected int InsertData(string query)
        {
            var data = new List<List<string>>();
            var command = new OleDbCommand(query, connection);
            var dataAdapter = new OleDbDataAdapter();

            dataAdapter.InsertCommand = command;
            var effected = dataAdapter.InsertCommand.ExecuteNonQuery();

            return effected;
        }

        protected int UpdateData(string query)
        {
            var data = new List<List<string>>();
            var command = new OleDbCommand(query, connection);
            var dataAdapter = new OleDbDataAdapter();

            dataAdapter.UpdateCommand = command;
            var effected = dataAdapter.InsertCommand.ExecuteNonQuery();

            return effected;
        }

        protected int DeleteData(string query)
        {
            return -1;
        }

        protected void Close()
        {
            if (connection.State == ConnectionState.Open)
            {
                connection.Close();
            }
        }

        protected bool IsUsing
        {
            get
            {
                return new List<ConnectionState> {
                    ConnectionState.Connecting, ConnectionState.Executing, ConnectionState.Fetching
                }.Contains(connection.State);
            }
        }

        protected bool IsOpen
        {
            get
            {
                return connection.State == ConnectionState.Open;
            }
        }

        protected bool IsClosed
        {
            get
            {
                return connection.State == ConnectionState.Closed;
            }
        }

        protected bool IsBroken
        {
            get
            {
                return connection.State == ConnectionState.Broken;
            }
        }
    }
}
