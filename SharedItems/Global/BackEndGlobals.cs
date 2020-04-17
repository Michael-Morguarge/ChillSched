
namespace Shared.Utility
{
    /// <summary>
    /// Globals for time and date
    /// </summary>
    public struct TimeAndDateGlobals
    {
        /// <summary>
        /// Gets the month name
        /// </summary>
        /// <param name="month">The <see cref="int"/> month</param>
        /// <returns>The string month</returns>
        public static string GetMonthName(int month)
        {
            switch(month)
            {
                case (int) Months.January: return "January";
                case (int) Months.February: return "February";
                case (int) Months.March: return "March";
                case (int) Months.April: return "April";
                case (int) Months.May: return "May";
                case (int) Months.June: return "June";
                case (int) Months.July: return "July";
                case (int) Months.August: return "August";
                case (int) Months.September: return "September";
                case (int) Months.October: return "October";
                case (int) Months.November: return "November";
                case (int) Months.December: return "December";
                default: return string.Empty;
            }
        }

        /// <summary>
        /// Gets the day of the week
        /// </summary>
        /// <param name="dayOfWeek">The <see cref="int"/> day</param>
        /// <returns>The string day</returns>
        public static string GetDayOfTheWeek(int dayOfWeek)
        {
            switch (dayOfWeek)
            {
                case (int)DayOfTheWeek.Sun: return "Sunday";
                case (int)DayOfTheWeek.Mon: return "Monday";
                case (int)DayOfTheWeek.Wed: return "Wednesday";
                case (int)DayOfTheWeek.Thur: return "Thursday";
                case (int)DayOfTheWeek.Fri: return "Friday";
                case (int)DayOfTheWeek.Sat: return "Saturday";
                default: return string.Empty;
            }
        }

        /// <summary>
        /// Gets the time of day
        /// </summary>
        /// <param name="timeOfDay">The time of day</param>
        /// <returns>The string time of day</returns>
        public static string GetTimeOfDay(int timeOfDay)
        {
            switch (timeOfDay)
            {
                case (int)TimeOfDay.AM: return "AM";
                case (int)TimeOfDay.PM: return "PM";
                default: return string.Empty;
            };
        }
    }

    /// <summary>
    /// The months
    /// </summary>
    public enum Months
    {
        None, January, February, March, April, May, June, July, August, September, October, November, December
    }

    /// <summary>
    /// The time of day
    /// </summary>
    public enum TimeOfDay
    {
        AM = 0, PM = 12
    }

    /// <summary>
    /// The day of the week
    /// </summary>
    public enum DayOfTheWeek
    {
        Sun, Mon, Tues, Wed, Thur, Fri, Sat
    }
}
