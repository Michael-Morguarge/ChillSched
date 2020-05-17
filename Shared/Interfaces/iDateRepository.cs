using Shared.Model;
using Shared.Global;

namespace Shared.Interface
{
    /// <summary>
    /// The date interface
    /// </summary>
    public interface IDateRepository
    {
        /// <summary>
        /// Creates a custom date
        /// </summary>
        /// <param name="month">The month</param>
        /// <param name="day">The day</param>
        /// <param name="year">The year</param>
        /// <param name="dow">The day of the week</param>
        /// <returns>A date object</returns>
        Date GetCustomDate(Months month, int day, int year, DayOfTheWeek dow);

        /// <summary>
        /// Return for an error
        /// </summary>
        /// <returns>A date object</returns>
        Date GetErrorTime();
    }
}
