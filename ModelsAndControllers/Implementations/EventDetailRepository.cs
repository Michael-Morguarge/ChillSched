using Backend.Inferface;
using Backend.Model;
using Shared.Model;
using Shared.Utility;

namespace Backend.Implementations
{
    public class EventDetailRepository : IEventDetailRepository
    {
        public EventDetail CreateEvent(string title, string comment, Date ad, Time at, Date dd, Time dt)
        {
            return new EventDetail
            {
                Id = Ids.CreateId().ToString(),
                Title = title,
                Comment = comment,
                ActivationDate = ad,
                ActivationTime = at,
                DeactivationDate = dd,
                DeactivationTime = dt
            };
        }
    }
}
