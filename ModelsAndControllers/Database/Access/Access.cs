using Backend.BusinessLogic.Abstract;
using System.Collections.Generic;

namespace Backend.Database.Access
{
    public class AccessDatabase : DataAbstract
    {
        public AccessDatabase(string connection) : base(connection)
        {
            Open();
        }

        public List<IReadOnlyList<string>> GetDataFromTable(string query)
        {
            if (string.IsNullOrEmpty(query) || string.IsNullOrWhiteSpace(query))
                return new List<IReadOnlyList<string>>();

            return GetData(query);
        }

        public int Update(string query)
        {
            if (string.IsNullOrEmpty(query) || string.IsNullOrWhiteSpace(query))
                return -1;

            return UpdateData(query);
        }

        public int Insert(string query)
        {
            if (string.IsNullOrEmpty(query) || string.IsNullOrWhiteSpace(query))
                return -1;

            return InsertData(query);
        }

        public int Delete(string query)
        {
            if (string.IsNullOrEmpty(query) || string.IsNullOrWhiteSpace(query))
                return -1;

            return DeleteData(query);
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
