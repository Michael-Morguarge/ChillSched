
using Shared.Model;
using Shared.Interface;
using Shared.Global;

namespace Shared.Implementation
{
    /// <summary>
    /// The time repository
    /// </summary>
    public class TimeRepository : ITimeRepository
    {
        /// <summary>
        /// See <see cref="ITimeRepository.GetCustomTime(int, int, int, TimeOfDay)"/>
        /// </summary>
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

        /// <summary>
        /// See <see cref="ITimeRepository.GetErrorTime"/>
        /// </summary>
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
