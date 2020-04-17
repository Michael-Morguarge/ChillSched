
using Shared.Model;
using System;

namespace Shared.Utility
{
    /// <summary>
    /// The time and date utility
    /// </summary>
    public static class TimeAndDateUtility
    {
        #region Time

        /// <summary>
        /// The current string time
        /// </summary>
        /// <returns>The current time</returns>
        public static string GetCurrentTimeString()
        {
            var now = DateTime.Now;
            return string.Format(
                "{0}:{1}:{2} {3}",
                (now.Hour > 12 ? (now.Hour - 12) : now.Hour),
                now.Minute.ToString().PadLeft(2, '0'),
                now.Second.ToString().PadLeft(2, '0'),
                (now.Hour > 12 ? TimeAndDateGlobals.GetTimeOfDay(12) : TimeAndDateGlobals.GetTimeOfDay(0))
            );
        }

        /// <summary>
        /// The current time object
        /// </summary>
        /// <returns>The current time</returns>
        public static Time GetCurrentTime()
        {
            var now = DateTime.Now;
            return new Time
            {
                Hours = now.Hour,
                Minutes = now.Minute,
                Seconds = now.Second,
                TimeofDay = (now.Hour > 12 ? TimeAndDateGlobals.GetTimeOfDay(12) : TimeAndDateGlobals.GetTimeOfDay(0))
            };
        }

        /// <summary>
        /// Converts datetime to time string
        /// </summary>
        /// <param name="time"></param>
        /// <returns>The string converted time</returns>
        public static string ConvertDateTimeTimeString(DateTime time)
        {
            return string.Format(
                "{0}:{1}:{2} {3}",
                (time.Hour > 12 ? (time.Hour - 12) : time.Hour).ToString().PadRight(2, '0'),
                time.Minute.ToString().PadLeft(2, '0'),
                time.Second.ToString().PadLeft(2, '0'),
                (time.Hour > 12 ? TimeAndDateGlobals.GetTimeOfDay(12) : TimeAndDateGlobals.GetTimeOfDay(0))
            );
        }

        /// <summary>
        /// Converts datetime to a time object
        /// </summary>
        /// <param name="time">The datetime time</param>
        /// <returns>The converted time</returns>
        public static Time ConvertDateTimeToTime(DateTime time)
        {
            return new Time
            {
                Hours = time.Hour,
                Minutes = time.Minute,
                Seconds = time.Second,
                TimeofDay = (time.Hour > 12 ? TimeAndDateGlobals.GetTimeOfDay(12) : TimeAndDateGlobals.GetTimeOfDay(0))
            };
        }

        /// <summary>
        /// Converts the datetime to 
        /// </summary>
        /// <param name="time">The string time</param>
        /// <returns>The converted string time</returns>
        public static Time ConvertStringTime(string time)
        {
            var timeElements = time.Split(':');
            var secondsAndTod = timeElements[2].Split(' ');

            return new Time
            {
                Hours = int.Parse(timeElements[0]),
                Minutes = int.Parse(timeElements[1]),
                Seconds = int.Parse(secondsAndTod[0]),
                TimeofDay = secondsAndTod[1]
            };
        }

        #endregion Time

        #region Date

        /// <summary>
        /// Gets the current date
        /// </summary>
        /// <returns>The current date string</returns>
        public static string GetCurrentDateString()
        {
            var date = DateTime.Now;
            return string.Format(
                "{0}, {1} {2}, {3}",
                TimeAndDateGlobals.GetDayOfTheWeek((int)date.DayOfWeek),
                TimeAndDateGlobals.GetMonthName(date.Month),
                date.Day,
                date.Year
            );
        }

        /// <summary>
        /// Gets the current date
        /// </summary>
        /// <returns>The current date object</returns>
        public static Date GetCurrentDate()
        {
            var now = DateTime.Now;

            return new Date
            {
                Month = TimeAndDateGlobals.GetMonthName(now.Month),
                Day = now.Day,
                Year = now.Year,
                DayOfWeek = now.DayOfWeek.ToString()
            };
        }
        
        /// <summary>
        /// Converts a string date into a date object
        /// </summary>
        /// <param name="date">The string date</param>
        /// <returns>The date object</returns>
        public static Date ConvertStringDate(string date)
        {
            var dateElements = date.Split(',');
            var dow = dateElements[0];
            var monthAndDay = dateElements[1].TrimStart(' ').Split(' ');
            var month = monthAndDay[0];
            var day = int.Parse(monthAndDay[1]);
            var year = int.Parse(dateElements[2].TrimStart(' '));

            return new Date
            {
                Month = month,
                Day = day,
                Year = year,
                DayOfWeek = dow
            };
        }

        /// <summary>
        /// Converts a datetime into a date object
        /// </summary>
        /// <param name="date">The date</param>
        /// <returns>A date object</returns>
        public static Date ConvertDateTimeDate(DateTime date)
        {
            return new Date
            {
                DayOfWeek = TimeAndDateGlobals.GetDayOfTheWeek((int)date.DayOfWeek),
                Month = TimeAndDateGlobals.GetMonthName(date.Month),
                Day = date.Day,
                Year = date.Year
            };
        }

        /// <summary>
        /// Converts a datetime into a date string
        /// </summary>
        /// <param name="date">The date</param>
        /// <returns>The date string</returns>
        public static string ConvertDateTimeDateString(DateTime date)
        {
            return string.Format(
                "{0}, {1} {2}, {3}",
                TimeAndDateGlobals.GetDayOfTheWeek((int)date.DayOfWeek),
                TimeAndDateGlobals.GetMonthName(date.Month),
                date.Day,
                date.Year
            );
        }

        /// <summary>
        /// Creates a custom date
        /// </summary>
        /// <param name="month">The month</param>
        /// <param name="day">The day</param>
        /// <param name="year">The year</param>
        /// <param name="dow">The day of the week</param>
        /// <returns>A date object</returns>
        public static Date GetCustomDate(Months month, int day, int year, DayOfTheWeek dow)
        {
            return new Date
            {
                Month = TimeAndDateGlobals.GetMonthName((int) month),
                Day = day,
                Year = year,
                DayOfWeek = TimeAndDateGlobals.GetDayOfTheWeek((int) dow)
            };
        }

        #endregion Date
    }
}
