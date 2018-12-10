using Backend.BusinessLogic.Implementation;
using Backend.BusinessLogic.Model;
using Backend.OutputLogic.Global;

namespace TimeAndSched.Backend.Repository
{
    public class TimeRepository : iTimeRepository
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
