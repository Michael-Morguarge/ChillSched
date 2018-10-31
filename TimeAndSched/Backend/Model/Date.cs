using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TimeAndSched.Backend.Globals;

namespace TimeAndSched.Backend.Model
{
    public class Date
    {
        public Date(bool defDate = false)
        {
            if (defDate)
            {
                Month = DateGlobals.GetMonthName(DateTime.Now.Month);
                Day = DateTime.Now.Day;
                Year = DateTime.Now.Year;
                DayOfWeek = DateTime.Now.DayOfWeek.ToString();
            }
            else
            {
                SetDefault();
            }
        }

        public Date(int month, int day, int year, string dow)
        {
                Month = DateGlobals.GetMonthName(month);
                Day = day;
                Year = year;
                DayOfWeek = dow;
        }

        public Date(string date)
        {
            var dateElements = date.Split(',');
            var day = dateElements[0];
            var monthAndDay = dateElements[1].TrimStart(' ').Split(' ')[0];
            var month = monthAndDay[0];
            var day = monthAndDay[1];
            var year = dateElements[2].TrimStart(' ');
            Month = DateGlobals.GetMonthName(month);
            Day = day;
            Year = year;
            DayOfWeek = dow;
        }

        private void SetDefault()
        {
            Month = "N/A";
            Day = -1;
            Year = -1;
            DayOfWeek = "N/A";
        }

        public string Month { get; private set; }
        public int Day { get; private set; }
        public int Year { get; private set; }
        public string DayOfWeek { get; private set; }

        public override string ToString()
        {
            return string.Format("{0}, {1} {2}, {3}", DayOfWeek, Month, Day, Year); 
        }
    }
}
