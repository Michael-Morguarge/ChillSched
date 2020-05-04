
using Shared.Model;
using Shared.Interface;
using Shared.Global;

namespace Shared.Implementation
{
    /// <summary>
    /// The date repository
    /// </summary>
    public class DateRepository : IDateRepository
    {
        /// <summary>
        /// See <see cref="IDateRepository.GetCustomDate(Months, int, int, DayOfTheWeek)"/>
        /// </summary>
        public Date GetCustomDate(Months month, int day, int year, DayOfTheWeek dow)
        {
            return new Date
            {
                Month = TimeAndDateGlobals.GetMonth((int)month),
                Day = day,
                Year = year,
                DayOfWeek = TimeAndDateGlobals.GetDayOfTheWeek((int)dow)
            };
        }

        /// <summary>
        /// See <see cref="IDateRepository.GetErrorTime"/>
        /// </summary>
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
