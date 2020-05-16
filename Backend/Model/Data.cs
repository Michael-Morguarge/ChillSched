using Shared.Global;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

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
