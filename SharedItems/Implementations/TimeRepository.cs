
using Shared.Model;
using Shared.Interface;
using Shared.Utility;

namespace Shared.Implementation
{
    public class TimeRepository : ITimeRepository
    {
        public Time GetCustomTime(int hours, int minutes, int seconds, TimeOfDay timeOfDay)
        {
            return new Time()
            {
                Hours = hours,
                Minutes = minutes,
                Seconds = seconds,
                TimeofDay = (timeOfDay == TimeOfDay.AM ? "AM" : "PM")
            };
        }

        public Time GetErrorTime()
        {
            return new Time()
            {
                Hours = -1,
                Minutes = -1,
                Seconds = -1,
                TimeofDay = "N/A"
            };
        }
    }
}
