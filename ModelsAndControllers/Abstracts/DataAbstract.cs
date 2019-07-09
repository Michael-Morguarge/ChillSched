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

            var data = new List<List<string>>();
            var command = new OleDbCommand(query, _connection);
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
            var command = new OleDbCommand(query, _connection);
            var dataAdapter = new OleDbDataAdapter
            {
                InsertCommand = command
            };
            var effected = dataAdapter.InsertCommand.ExecuteNonQuery();

            return effected;
        }

        protected int UpdateData(string query)
        {
            var data = new List<List<string>>();
            var command = new OleDbCommand(query, _connection);
            var dataAdapter = new OleDbDataAdapter
            {
                UpdateCommand = command
            };
            var effected = dataAdapter.InsertCommand.ExecuteNonQuery();

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

        protected bool IsUsing
        {
            get
            {
                return new List<ConnectionState> {
                    ConnectionState.Connecting, ConnectionState.Executing, ConnectionState.Fetching
                }.Contains(_connection.State);
            }
        }

        protected bool IsOpen
        {
            get
            {
                return _connection.State == ConnectionState.Open;
            }
        }

        protected bool IsClosed
        {
            get
            {
                return _connection.State == ConnectionState.Closed;
            }
        }

        protected bool IsBroken
        {
            get
            {
                return _connection.State == ConnectionState.Broken;
            }
        }
    }
}
