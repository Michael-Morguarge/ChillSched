
using Shared.Model;
using Shared.Utility;

namespace Shared.Interface
{
    public interface ITimeRepository
    {
        Time GetCustomTime(int hours, int minutes, int seconds, TimeOfDay timeOfDay);
        Time GetErrorTime();
    }
}
