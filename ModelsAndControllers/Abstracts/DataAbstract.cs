using System;
using System.Collections.Generic;
using System.Data;
using System.Data.OleDb;
using System.Linq;

namespace Backend.Database.Abstract
{
    public abstract class DataAbstract : IDisposable
    {
        private readonly string _connectionString;
        private readonly OleDbConnection _connection;
        
        public void Dispose()
        {
            _connection.Dispose();
            GC.SuppressFinalize(this);
        }

        protected DataAbstract(string connString)
        {
            _connectionString = connString;
            _connection = new OleDbConnection(connString);
        }

        protected void Open()
        {
            if (IsClosed)
            {
                _connection.Open();
            }
        }

        protected List<List<string>> GetData(string query)
        {
            if (IsClosed || IsBroken)
                return new List<List<string>>();

            List<List<string>> data = new List<List<string>>();
            OleDbCommand command = new OleDbCommand(query, _connection);
            OleDbDataReader reader = command.ExecuteReader();

            do
            {
                List<string> dataRow = new List<string>();
                //Store name of column and value in a keypair<string, object>
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
            List<List<string>> data = new List<List<string>>();
            OleDbCommand command = new OleDbCommand(query, _connection);
            OleDbDataAdapter dataAdapter = new OleDbDataAdapter
            {
                InsertCommand = command
            };
            int effected = dataAdapter.InsertCommand.ExecuteNonQuery();

            return effected;
        }

        protected int UpdateData(string query)
        {
            List<List<string>> data = new List<List<string>>();
            OleDbCommand command = new OleDbCommand(query, _connection);
            OleDbDataAdapter dataAdapter = new OleDbDataAdapter
            {
                UpdateCommand = command
            };
            int effected = dataAdapter.InsertCommand.ExecuteNonQuery();

            return effected;
        }

        protected int DeleteData(string query)
        {
            return -1;
        }

        protected void Close()
        {
            if (_connection.State == ConnectionState.Open)
            {
                _connection.Close();
            }
        }

        protected bool IsUsing => new List<ConnectionState> {
                    ConnectionState.Connecting, ConnectionState.Executing, ConnectionState.Fetching
                }.Contains(_connection.State);

        protected bool IsOpen => _connection.State == ConnectionState.Open;

        protected bool IsClosed => _connection.State == ConnectionState.Closed;

        protected bool IsBroken => _connection.State == ConnectionState.Broken;
    }
}
