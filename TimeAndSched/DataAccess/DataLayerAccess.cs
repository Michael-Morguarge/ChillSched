using System.Configuration;
using Backend.Database.Access;

namespace TimeAndSched.DataAccess
{
    public class DataAccess
    {
        public AccessDatabase _connection { get; private set; }

        public DataAccess()
        {
            _connection = new AccessDatabase(ConfigurationManager.AppSettings["Backend.Properties.Settings.databaseConnectionString"]);
        }
    }
}
