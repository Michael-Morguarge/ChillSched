using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TimeAndSched.Backend.Model;

namespace TimeAndSched.Backend.Implementation
{
    public interface ITimeRepository
    {
        Time GetTime();
        Date GetDate();
    }
}
