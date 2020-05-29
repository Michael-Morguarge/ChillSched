using Shared.Model;

namespace Shared.Interface
{
    public interface IDelay
    {
        void Unlock(DateAndTime currDate);

        void SetDelay(int delay, DateAndTime date);
    }
}
