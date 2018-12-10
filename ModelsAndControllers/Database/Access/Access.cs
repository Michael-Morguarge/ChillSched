using Backend.BusinessLogic.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Backend.Database.Access
{
    public class Access : DataAbstract
    {
        public Access(string connection) : base(connection)
        {

        }
    }
}
