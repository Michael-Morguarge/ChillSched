using System.Configuration;
using Backend.Database.Access;

namespace FrontEnd.DataAccess
{
    public class DataAccess : AppSettingsReader
    {
        public AccessDatabase _connection { get; private set; }

        public DataAccess()
        {
            var x = new AppSettingsReader();
            _connection = new AccessDatabase(x.GetValue("databaseConnectionString", typeof(string)) as string);
        }
    }
}
