using Backend.BusinessLogic.Model;
using Backend.OutputLogic.Global;

namespace Backend.BusinessLogic.Implementation
{
    public interface iDateRepository
    {
        Date GetCustomDate(Months month, int day, int year, DayOfTheWeek dow);
        Date GetErrorTime();
    }
}
