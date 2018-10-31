using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TimeAndSched.Backend.Globals;

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
                string.Format("{0}".PadLeft(2, '0'), now.Minute),
                now.Second,
                (now.Hour > 12 ? "PM" : "AM")
            );
        }

        public static string FormatTime(DateTime time)
        {
            return string.Format(
                "{0}:{1}:{2} {3}",
                (time.Hour > 12 ? (time.Hour - 12) : time.Hour),
                string.Format("{0}".PadLeft(2, '0'), time.Minute),
                time.Second,
                (time.Hour > 12 ? "PM" : "AM")
            );
        }

        public static string GetCurrentDate()
        {
            var date = DateTime.Now;
            return string.Format("{0}, {1} {2}, {3}", date.DayOfWeek, DateGlobals.GetMonthName(date.Month), date.Day, date.Year);
        }

        public static string FormatDate(DateTime date)
        {
            return string.Format("{0}, {1} {2}, {3}", date.DayOfWeek, DateGlobals.GetMonthName(date.Month), date.Day, date.Year);
        }

    }
}
