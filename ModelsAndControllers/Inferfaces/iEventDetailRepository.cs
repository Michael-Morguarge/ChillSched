using Backend.Model;
using Shared.Model;

namespace Backend.Inferface
{
    public interface IEventDetailRepository
    {
        EventDetail CreateEvent(string title, string comment, Date ad, Time at, Date dd, Time dt);
    }
}
