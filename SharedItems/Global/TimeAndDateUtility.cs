using Shared.Model;
using System;

namespace Shared.Global
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
            DateTime now = DateTime.Now;
            return string.Format(
                "{0}:{1}:{2} {3}",
                now.Hour == 0 || now.Hour > 12 ? Math.Abs(now.Hour - 12) : now.Hour,
                now.Minute.ToString().PadLeft(2, '0'),
                now.Second.ToString().PadLeft(2, '0'),
                now.Hour > 12 ? TimeAndDateGlobals.GetTimeOfDay(12) : TimeAndDateGlobals.GetTimeOfDay(0)
            );
        }

        /// <summary>
        /// The current time object
        /// </summary>
        /// <returns>The current time</returns>
        public static Time GetCurrentTime()
        {
            DateTime now = DateTime.Now;
            return new Time
            {
                Hours = now.Hour == 0 || now.Hour > 12 ? Math.Abs(now.Hour - 12) : now.Hour,
                Minutes = now.Minute,
                Seconds = now.Second,
                TimeofDay = now.Hour > 12 ? TimeAndDateGlobals.GetTimeOfDay(12) : TimeAndDateGlobals.GetTimeOfDay(0)
            };
        }

        /// <summary>
        /// Converts datetime to time string
        /// </summary>
        /// <param name="time">The time to convert</param>
        /// <returns>The string converted time</returns>
        public static string ConvertTime_String(DateTime time)
        {
            return string.Format(
                "{0}:{1}:{2} {3}",
                (time.Hour == 0 || time.Hour > 12 ? Math.Abs(time.Hour - 12) : time.Hour).ToString().PadLeft(2, '0'),
                time.Minute.ToString().PadLeft(2, '0'),
                time.Second.ToString().PadLeft(2, '0'),
                time.Hour > 12 ? TimeAndDateGlobals.GetTimeOfDay(12) : TimeAndDateGlobals.GetTimeOfDay(0)
            );
        }

        /// <summary>
        /// Converts datetime to time string
        /// </summary>
        /// <param name="time">The time to convert</param>
        /// <returns>The string converted time</returns>
        public static string ConvertTime_String(Time time)
        {
            return string.Format(
                "{0}:{1}:{2} {3}",
                time.Hours.ToString().PadLeft(2, '0'),
                time.Minutes.ToString().PadLeft(2, '0'),
                time.Seconds.ToString().PadLeft(2, '0'),
                time.TimeofDay
            );
        }

        /// <summary>
        /// Converts datetime to a time object
        /// </summary>
        /// <param name="time">The datetime time</param>
        /// <returns>The converted time</returns>
        public static Time ConvertTime_Time(DateTime time)
        {
            return new Time
            {
                Hours = time.Hour == 0 || time.Hour > 12 ? Math.Abs(time.Hour - 12) : time.Hour,
                Minutes = time.Minute,
                Seconds = time.Second,
                TimeofDay = time.Hour > 12 ? TimeAndDateGlobals.GetTimeOfDay(12) : TimeAndDateGlobals.GetTimeOfDay(0)
            };
        }

        /// <summary>
        /// Converts the datetime to 
        /// </summary>
        /// <param name="time">The string time</param>
        /// <returns>The converted string time</returns>
        public static Time ConvertString_Time(string time)
        {
            string[] timeElements = time.Split(':');
            string[] secondsAndTod = timeElements[2].Split(' ');

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
            DateTime date = DateTime.Now;
            return string.Format(
                "{0}, {1} {2}, {3}",
                TimeAndDateGlobals.GetDayOfTheWeek((int)date.DayOfWeek),
                TimeAndDateGlobals.GetMonth(date.Month),
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
            DateTime now = DateTime.Now;

            return new Date
            {
                Month = TimeAndDateGlobals.GetMonth(now.Month),
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
        public static Date ConvertString_Date(string date)
        {
            string[] dateElements = date.Split(',');
            string dow = dateElements[0];
            string[] monthAndDay = dateElements[1].TrimStart(' ').Split(' ');
            string month = monthAndDay[0];
            int day = int.Parse(monthAndDay[1]);
            int year = int.Parse(dateElements[2].TrimStart(' '));

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
        public static Date ConvertDate_Date(DateTime date)
        {
            return new Date
            {
                DayOfWeek = TimeAndDateGlobals.GetDayOfTheWeek((int)date.DayOfWeek),
                Month = TimeAndDateGlobals.GetMonth(date.Month),
                Day = date.Day,
                Year = date.Year
            };
        }

        /// <summary>
        /// Converts a datetime into a date string
        /// </summary>
        /// <param name="date">The date</param>
        /// <returns>The date string</returns>
        public static string ConvertDate_String(DateTime date, bool shorten = false)
        {
            string dateString = shorten
                ? string.Format(
                    "{0} / {1} / {2}",
                    (int)TimeAndDateGlobals.GetMonth(TimeAndDateGlobals.GetMonth(date.Month)),
                    date.Day,
                    date.Year
                )
                : string.Format(
                    "{0}, {1} {2}, {3}",
                    TimeAndDateGlobals.GetDayOfTheWeek((int)date.DayOfWeek),
                    TimeAndDateGlobals.GetMonth(date.Month),
                    date.Day,
                    date.Year
                );

            return dateString;
        }

        /// <summary>
        /// Converts a datetime into a date string
        /// </summary>
        /// <param name="date">The date</param>
        /// <returns>The date string</returns>
        public static string ConvertDate_String(Date date, bool shorten = false)
        {
            string dateString = shorten
                ? string.Format(
                    "{0} / {1} / {2}",
                    (int)TimeAndDateGlobals.GetMonth(date.Month),
                    date.Day,
                    date.Year
                )
                : string.Format(
                    "{0}, {1} {2}, {3}",
                    date.DayOfWeek,
                    date.Month,
                    date.Day,
                    date.Year
                );

            return dateString;
        }

        /// <summary>
        /// Creates a custom date
        /// </summary>
        /// <param name="month">The month</param>
        /// <param name="day">The day</param>
        /// <param name="year">The year</param>
        /// <param name="dow">The day of the week</param>
        /// <returns>A date object</returns>
        public static Date MakeCustomDate(Months month, int day, int year, DayOfTheWeek dow)
        {
            return new Date
            {
                Month = TimeAndDateGlobals.GetMonth((int) month),
                Day = day,
                Year = year,
                DayOfWeek = TimeAndDateGlobals.GetDayOfTheWeek((int) dow)
            };
        }

        #endregion Date

        #region DateTime

        /// <summary>
        /// Converts a Date and Time object into a DateTime object
        /// </summary>
        /// <param name="date">The date</param>
        /// <param name="time">The time</param>
        /// <returns>A datetime object</returns>
        public static DateTime ConvertDateAndTime_Date(Date date, Time time = null)
        {
            DateTime newDate = new DateTime(
                date.Year,
                (int) TimeAndDateGlobals.GetMonth(date.Month),
                date.Day,
                time == null ? 12 :time.Hours,
                time == null ? 0 : time.Minutes,
                time == null ? 0 : time.Seconds
            );

            newDate = time == null ? newDate : TimeAndDateGlobals.GetTimeOfDay(time.TimeofDay) == 0 ? newDate : newDate.AddHours(12);

            return newDate;
        }

        #endregion DateTime

        #region Comparisons

        /// <summary>
        /// Checks if date is within range
        /// </summary>
        /// <param name="beginDate">The start date</param>
        /// <param name="dateToCheck">Date to examine</param>
        /// <param name="endDate">The end date</param>
        /// <returns>Whether the date is within range</returns>
        public static bool IsWithinRange(Date beginDate, Date dateToCheck, Date endDate)
        {
            DateTime begin = ConvertDateAndTime_Date(beginDate);
            DateTime end = ConvertDateAndTime_Date(endDate);
            DateTime curr = ConvertDateAndTime_Date(dateToCheck);

            bool beginMatchRange = curr >= begin;
            bool endMatchRange = curr <= end;

            return beginMatchRange && endMatchRange;
        }

        /// <summary>
        /// Checks if date is within range
        /// </summary>
        /// <param name="beginDate">The start date</param>
        /// <param name="beginTime">The start time</param>
        /// <param name="dateToCheck">Date to examine</param>
        /// <param name="timeToCheck">Time to examine</param>
        /// <param name="endDate">The end date</param>
        /// <param name="endTime">The end time</param>
        /// <returns>Whether the date is within range</returns>
        public static bool IsWithinRange(Date beginDate, Time beginTime, Date dateToCheck, Time timeToCheck, Date endDate, Time endTime)
        {
            DateTime begin = ConvertDateAndTime_Date(beginDate, beginTime);
            DateTime end = ConvertDateAndTime_Date(endDate, endTime);
            DateTime curr = ConvertDateAndTime_Date(dateToCheck, timeToCheck);

            bool beginMatchRange = curr >= begin;
            bool endMatchRange = curr <= end;

            return beginMatchRange && endMatchRange;
        }

        /// <summary>
        /// Checks if date is before range
        /// </summary>
        /// <param name="beginDate">The start date</param>
        /// <param name="beginTime">The start time</param>
        /// <param name="dateToCheck">Date to examine</param>
        /// <param name="timeToCheck">Time to examine</param>
        /// <returns>Whether the date is before range</returns>
        public static bool IsBeforeRange(Date beginDate, Time beginTime, Date dateToCheck, Time timeToCheck)
        {
            DateTime begin = ConvertDateAndTime_Date(beginDate, beginTime);
            DateTime curr = ConvertDateAndTime_Date(dateToCheck, timeToCheck);

            bool beginMatchRange = curr < begin;

            return beginMatchRange;
        }

        #endregion Comparisons
    }
}
