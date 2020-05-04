using Backend.Database.Abstract;
using System.Collections.Generic;

namespace Backend.Database.Access
{
    public class AccessDatabase : DataAbstract
    {
        public AccessDatabase(string connection) : base(connection)
        {
            //connection set in base class
        }

        public List<List<string>> Get(string query)
        {
            if (string.IsNullOrEmpty(query))
                return new List<List<string>>();

            return GetData(query);
        }

        public bool Update(string query)
        {
            if (string.IsNullOrEmpty(query))
                return false;

            return UpdateData(query) > 0;
        }

        public bool Insert(string query)
        {
            if (string.IsNullOrEmpty(query))
                return false;

            return InsertData(query) > 0;
        }

        public bool Delete(string query)
        {
            if (string.IsNullOrEmpty(query))
                return false;

            return DeleteData(query) > 0;
        }

        public bool OpenConnection()
        {
            Open();

            return IsOpen;
        }

        public bool CloseConnection()
        {
            Close();

            return IsClosed || IsBroken;
        }

        public bool IsInUse()
        {
            return IsUsing;
        }
    }
}
