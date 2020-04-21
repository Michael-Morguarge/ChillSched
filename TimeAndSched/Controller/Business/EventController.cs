using Backend.Implementations;
using Backend.Model;
using Shared.Model;
using Shared.Global;
using System.Collections.Generic;

namespace FrontEnd.Controller
{
    public class EventController
    {
        private EventRepository _eventRepo;

        public EventController()
        {
            _eventRepo = new EventRepository();
        }

        public SavedEvent GetEvent(string id)
        {
            return _eventRepo.GetEvent(id);
        }

        public IEnumerable<SavedEvent> GetEvents(Date selectedDate)
        {
            return _eventRepo.GetEvents(selectedDate);
        }

        public bool CreateEvent(SavedEvent @event)
        {
            @event.DateCreated = TimeAndDateUtility.GetCurrentDate();
            @event.TimeCreated = TimeAndDateUtility.GetCurrentTime();

            return _eventRepo.AddEvent(@event);
        }

        public bool EditEvent(SavedEvent @event)
        {
            return _eventRepo.UpdateEvent(@event);
        }

        public bool DeleteEvent(string id)
        {
            return _eventRepo.RemoveEvent(id);
        }
    }
}
