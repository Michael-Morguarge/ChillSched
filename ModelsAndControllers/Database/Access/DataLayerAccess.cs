using System.Collections.Generic;
using System.Configuration;

namespace Backend.Database.Access
{
    public class DataLayer : AppSettingsReader
    {
        private const string _connectionName = "ChillSchedDB";
        private AccessDatabase _database;

        public DataLayer()
        {
            var connString = ConfigurationManager.ConnectionStrings[_connectionName].ConnectionString;
            _database = new AccessDatabase(connString);
        }

        public List<List<string>> Get(string query)
        {
            var filteredQuery = FilterQuery(query);
            
            return _database.Get(filteredQuery);
        }

        public bool Add(string query)
        {
            var filteredQuery = FilterQuery(query);

            return _database.Insert(filteredQuery);
        }

        public bool Update(string query)
        {
            var filteredQuery = FilterQuery(query);

            return _database.Update(filteredQuery);
        }

        public bool Delete(string query)
        {
            var filteredQuery = FilterQuery(query);

            return _database.Delete(filteredQuery);
        }

        private string FilterQuery(string originalQuery)
        {
            return originalQuery;
        }

        public void Open()
        {
            _database.OpenConnection();
        }

        public void Close()
        {
            _database.CloseConnection();
        }
    }
}
