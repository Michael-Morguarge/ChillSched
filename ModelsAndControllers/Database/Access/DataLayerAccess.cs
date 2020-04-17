using System.Configuration;
using Backend.Database.Access;

namespace Backend.DataAccess
{
    public class DataLayer : AppSettingsReader
    {
        private const string _connectionName = "databaseConnectionString";

        public AccessDatabase Database { get; protected set; }
        private AppSettingsReader _connStrings;

        public DataLayer()
        {
            //_connStrings = new AppSettingsReader();
        }

        public void SetDb()
        {
            //Database = new AccessDatabase(_connStrings.GetValue(_connectionName, typeof(string)) as string);
            //Database.OpenConnection();
        }
    }
}
