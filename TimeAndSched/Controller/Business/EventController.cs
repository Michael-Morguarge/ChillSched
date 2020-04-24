using Backend.Implementations;
using Backend.Model;
using Shared.Model;
using Shared.Global;
using System.Collections.Generic;
using System;

namespace FrontEnd.Controller
{
    public class EventController
    {
        private readonly EventRepository _eventRepo;

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

        public bool ToggleStatus(string id)
        {
            SavedEvent @event = GetEvent(id);

            if (@event == null)
                return false;

            if (@event.Completed)
            {
                @event.Completed = false;
                @event.DateCompleted = null;
                @event.TimeCompleted = null;
            }
            else
            {
                DateTime date = DateTime.Now;
                @event.Completed = true;
                @event.DateCompleted = TimeAndDateUtility.ConvertDate_Date(date);
                @event.TimeCompleted = TimeAndDateUtility.ConvertTime_Time(date);
            }

            return _eventRepo.UpdateEvent(@event);
        }

        public bool DeleteEvent(string id)
        {
            return _eventRepo.RemoveEvent(id);
        }
    }
}
