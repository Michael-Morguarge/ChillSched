
using Shared.Model;
using Shared.Utility;

namespace Shared.Interface
{
    public interface IDateRepository
    {
        Date GetCustomDate(Months month, int day, int year, DayOfTheWeek dow);
        Date GetErrorTime();
    }
}
