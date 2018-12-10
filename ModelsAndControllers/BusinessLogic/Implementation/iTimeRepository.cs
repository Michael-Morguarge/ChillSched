using Backend.BusinessLogic.Model;
using Backend.OutputLogic.Global;

namespace Backend.BusinessLogic.Implementation
{
    public interface iTimeRepository
    {
        Time GetCustomTime(int hours, int minutes, int seconds, TimeOfDay timeOfDay);
        Time GetErrorTime();
    }
}
