using System.Configuration;
using Backend.Database.Access;

namespace FrontEnd.DataAccess
{
    public class DataLayerAccess : AppSettingsReader
    {
        public AccessDatabase _connection { get; private set; }

        public DataLayerAccess()
        {
            var x = new AppSettingsReader();
            _connection = new AccessDatabase(x.GetValue("databaseConnectionString", typeof(string)) as string);
        }
    }
}
