using Shared.Global;
using System.Collections.Generic;

namespace FileOperations.Models
{
    public class Data<A,B>
    {
        public List<List<KeyValuePair<A, B>>> TempDataStore { get; set; }

        public string OperationName { get; private set; }

        public Data(string operationName = null)
        {
            OperationName = operationName ?? Generate.Id().ToString();
        }
    }
}
