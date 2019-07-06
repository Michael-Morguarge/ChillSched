
using Shared.Model;
using Shared.Interface;
using Shared.Utility;

namespace Shared.Implementation
{
    public class DateRepository : IDateRepository
    {
        public Date GetCustomDate(Months month, int day, int year, DayOfTheWeek dow)
        {
            return new Date
            {
                Month = TimeAndDateGlobals.GetMonthName((int)month),
                Day = day,
                Year = year,
                DayOfWeek = TimeAndDateGlobals.GetDayOfTheWeek((int)dow)
            };
        }

        public Date GetErrorTime()
        {
            return new Date
            {
                Month = "N/A",
                Day = -1,
                Year = -1,
                DayOfWeek = "N/A"
            };
        }
    }
}
