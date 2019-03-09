using Backend.BusinessLogic.Model;
using Backend.OutputLogic.Global;

namespace Backend.BusinessLogic.Repository
{
    public class EventDetailRepository : iEventDetailRepository
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
