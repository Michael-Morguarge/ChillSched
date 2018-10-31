using System;
using TimeAndSched.Backend.Globals;
using TimeAndSched.Backend.Implementation;
using TimeAndSched.Backend.Model;

namespace TimeAndSched.Backend.Repository
{
    public class TimeRepository
    {
        public Time GetCustomTime(int hours, int minutes, int seconds, string timeOfDay)
        {
            return new Time(hours, minutes, seconds, timeOfDay);
        }

        public Time GetErrorTime()
        {
            return new Time(false);
        }
    }
}
