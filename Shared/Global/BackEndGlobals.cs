namespace Shared.Global
{
    /// <summary>
    /// Globals for time and date
    /// </summary>
    public struct TimeAndDateGlobals
    {
        /// <summary>
        /// Gets the month name
        /// </summary>
        /// <param name="aMonth">The Integer month</param>
        /// <returns>The string month</returns>
        public static string GetMonth(int aMonth)
        {
            string month = string.Empty;

            switch(aMonth)
            {
                case (int) Months.January: month = "January"; break;
                case (int) Months.February: month = "February"; break;
                case (int) Months.March: month = "March"; break;
                case (int) Months.April: month = "April"; break;
                case (int) Months.May: month = "May"; break;
                case (int) Months.June: month = "June"; break;
                case (int) Months.July: month = "July"; break;
                case (int) Months.August: month = "August"; break;
                case (int) Months.September: month = "September"; break;
                case (int) Months.October: month = "October"; break;
                case (int) Months.November: month = "November"; break;
                case (int) Months.December: month = "December"; break;
                default: break;
            }

            return month;
        }

        /// <summary>
        /// Gets the month number
        /// </summary>
        /// <param name="aMonth">The string month</param>
        /// <returns>The Integer month</returns>
        public static Months GetMonth(string aMonth)
        {
            Months month = Months.None;

            switch (aMonth)
            {
                case "January":  month = Months.January; break;
                case "February": month = Months.February; break;
                case "March": month = Months.March; break;
                case "April": month = Months.April; break;
                case "May": month = Months.May; break;
                case "June": month = Months.June; break;
                case "July": month = Months.July; break;
                case "August": month = Months.August; break;
                case "September": month = Months.September; break;
                case "October": month = Months.October; break;
                case "November": month = Months.November; break;
                case "December": month = Months.December; break;
                default: break;
            }

            return month;
        }

        /// <summary>
        /// Gets the day of the week
        /// </summary>
        /// <param name="dayOfWeek">The Integer day</param>
        /// <returns>The string day</returns>
        public static string GetDayOfTheWeek(int theDayOfWeek)
        {
            string dayOfWeek = string.Empty;

            switch (theDayOfWeek)
            {
                case (int)DayOfTheWeek.Sun: dayOfWeek = "Sunday"; break;
                case (int)DayOfTheWeek.Mon: dayOfWeek = "Monday"; break;
                case (int)DayOfTheWeek.Tues: dayOfWeek = "Tuesday"; break;
                case (int)DayOfTheWeek.Wed: dayOfWeek = "Wednesday"; break;
                case (int)DayOfTheWeek.Thur: dayOfWeek = "Thursday"; break;
                case (int)DayOfTheWeek.Fri: dayOfWeek = "Friday"; break;
                case (int)DayOfTheWeek.Sat: dayOfWeek = "Saturday"; break;
                default: break;
            }

            return dayOfWeek;
        }

        /// <summary>
        /// Gets the day of the week number
        /// </summary>
        /// <param name="dayOfWeek">The string day</param>
        /// <returns>The Integer day</returns>
        public static int GetDayOfTheWeek(string theDayOfWeek)
        {
            int dayOfWeek = -1;

            switch (theDayOfWeek)
            {
                case "Sunday": dayOfWeek = (int)DayOfTheWeek.Sun; break;
                case "Monday": dayOfWeek = (int)DayOfTheWeek.Mon; break;
                case "Tuesday": dayOfWeek = (int)DayOfTheWeek.Tues; break;
                case "Wednesday": dayOfWeek = (int)DayOfTheWeek.Wed; break;
                case "Thursday": dayOfWeek = (int)DayOfTheWeek.Thur; break;
                case "Friday": dayOfWeek = (int)DayOfTheWeek.Fri; break;
                case "Saturday": dayOfWeek = (int)DayOfTheWeek.Sat; break;
                default: break;
            }

            return dayOfWeek;
        }

        /// <summary>
        /// Gets the time of day
        /// </summary>
        /// <param name="timeOfDay">The Integer time of day</param>
        /// <returns>The string time of day</returns>
        public static string GetTimeOfDay(int timeOfDay)
        {
            string morning = string.Empty;

            switch (timeOfDay)
            {
                case (int)TimeOfDay.AM: morning = "AM"; break;
                case (int)TimeOfDay.PM: morning = "PM"; break;
                default: break;
            };

            return morning;
        }

        /// <summary>
        /// Gets the time of day
        /// </summary>
        /// <param name="timeOfDay">The string time of day</param>
        /// <returns>The Integer time of day</returns>
        public static int GetTimeOfDay(string timeOfDay)
        {
            int morning = -1;

            switch (timeOfDay)
            {
                case "AM": morning = (int)TimeOfDay.AM; break;
                case "PM": morning = (int)TimeOfDay.PM; break;
                default: break;
            };

            return morning;
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
