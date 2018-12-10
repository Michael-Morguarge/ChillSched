using Backend.BusinessLogic.Model;

namespace Backend.BusinessLogic.Repository
{
    public interface iEventDetailRepository
    {
        EventDetail void CreateEvent(string title, string comment, Date ad, Time at, Date dd, Time dt);
    }
}
