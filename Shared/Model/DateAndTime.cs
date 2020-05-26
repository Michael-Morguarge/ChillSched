using Shared.Global;

namespace Shared.Model
{
    /// <summary>
    /// Combination of Date and Time
    /// </summary>
    public class DateAndTime
    {
        /// <summary>
        /// The date
        /// </summary>
        public Date Date { get; private set; }

        /// <summary>
        /// The time
        /// </summary>
        public Time Time { get; private set; }

        /// <summary>
        /// Constructor for DateAndTime
        /// </summary>
        /// <param name="date">The date</param>
        /// <param name="time">The time</param>
        public DateAndTime(Date date, Time time)
        {
            Date = date;
            Time = time;
        }
    }
}
