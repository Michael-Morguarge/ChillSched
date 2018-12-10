using System;
using Backend.OutputLogic.Global;
using Backend.BusinessLogic.Model;

namespace Backend.BusinessLogic.Repository
{
    public class EventDetailRepository : iEventDetailRepository
    {
        public void CreateEvent(string title, string comment, Date ad, Time at, Date dd, Time dt)
        {
            new EventDetail
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

        public EventDetail GetEvent(string id)
        {
            throw new NotImplementedException();
        }
    }
}
