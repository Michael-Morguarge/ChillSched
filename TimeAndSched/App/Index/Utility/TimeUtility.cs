using Backend.OutputLogic.Global;
using System;

namespace TimeAndSched.App.Index.Utility
{
    public class TimeUtility
    {
        public static string GetCurrentTime()
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

        public static string FormatTime(DateTime time)
        {
            return string.Format(
                "{0}:{1}:{2} {3}",
                (time.Hour > 12 ? (time.Hour - 12) : time.Hour),
                time.Minute.ToString().PadLeft(2, '0'),
                time.Second.ToString().PadLeft(2, '0'),
                (time.Hour > 12 ? "PM" : "AM")
            );
        }

        public static string GetCurrentDate()
        {
            var date = DateTime.Now;
            return string.Format("{0}, {1} {2}, {3}", date.DayOfWeek, TimeAndDateGlobals.GetMonthName(date.Month), date.Day, date.Year);
        }

        public static string FormatDate(DateTime date)
        {
            return string.Format("{0}, {1} {2}, {3}", date.DayOfWeek, TimeAndDateGlobals.GetMonthName(date.Month), date.Day, date.Year);
        }

    }
}
