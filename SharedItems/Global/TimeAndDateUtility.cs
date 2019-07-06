
using Shared.Model;
using System;

namespace Shared.Utility
{
    public static class TimeAndDateUtility
    {
        #region Time

        public static string GetCurrentStringTime()
        {
            var now = DateTime.Now;
            return string.Format(
                "{0}:{1}:{2} {3}",
                (now.Hour > 12 ? (now.Hour - 12) : now.Hour),
                now.Minute.ToString().PadLeft(2, '0'),
                now.Second.ToString().PadLeft(2, '0'),
                (now.Hour > 12 ? "PM" : "AM")
            );
        }

        public static Time GetCurrentTime()
        {
            var now = DateTime.Now;
            return new Time
            {
                Hours = now.Hour,
                Minutes = now.Minute,
                Seconds = now.Second,
                TimeofDay = (now.Hour > 12 ? "PM" : "AM")
            };
        }

        public static string ConvertDateTimeTime(DateTime time)
        {
            return string.Format(
                "{0}:{1}:{2} {3}",
                (time.Hour > 12 ? (time.Hour - 12) : time.Hour),
                time.Minute.ToString().PadLeft(2, '0'),
                time.Second.ToString().PadLeft(2, '0'),
                (time.Hour > 12 ? "PM" : "AM")
            );
        }

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

        public static Date GetCurrentDate()
        {
            var date = DateTime.Now;

            return new Date
            {
                Month = TimeAndDateGlobals.GetMonthName(DateTime.Now.Month),
                Day = DateTime.Now.Day,
                Year = DateTime.Now.Year,
                DayOfWeek = DateTime.Now.DayOfWeek.ToString()
            };
        }

        public static string GetCurrentStringDate()
        {
            var date = DateTime.Now;
            return string.Format(
                "{0}, {1} {2}, {3}",
                TimeAndDateGlobals.GetDayOfTheWeek((int) date.DayOfWeek),
                TimeAndDateGlobals.GetMonthName(date.Month),
                date.Day,
                date.Year
            );
        }

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

        public static string ConvertDateTimeDate(DateTime date)
        {
            return string.Format(
                "{0}, {1} {2}, {3}",
                TimeAndDateGlobals.GetDayOfTheWeek((int)date.DayOfWeek),
                TimeAndDateGlobals.GetMonthName(date.Month),
                date.Day,
                date.Year
            );
        }

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
