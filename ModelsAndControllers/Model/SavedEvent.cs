using Shared.Model;
using System;
using System.Collections.Generic;
using System.Linq;

namespace Backend.Model
{
    public class SavedEvent
    {
        public SavedEvent()
        {
            Id = Guid.NewGuid().ToString();
        }

        public string Id { get; set; }
        public string Title { get; set; }
        public string Comment { get; set; }
        public bool Completed { get; set; }
        public Date DateCompleted { get; set; }
        public Time TimeCompleted { get; set; }
        public Time TimeCreated { get; set; }
        public Date DateCreated { get; set; }
        public Time ActivationTime { get; set; }
        public Time DeactivationTime { get; set; }
        public Date ActivationDate { get; set; }
        public Date DeactivationDate { get; set; }
    }

    // Needs major rework

    public class Events
    {
        public List<SavedEvent> SavedEvents;

        public Events()
        {
            SavedEvents = new List<SavedEvent>();
        }

        public SavedEvent GetEvent(string id)
        {
            if (string.IsNullOrEmpty(id))
                return null;

            SavedEvent @event = SavedEvents.SingleOrDefault(x => x.Id == id);

            return @event;
        }

        public void AddEvent(SavedEvent @event)
        {
            if (@event == null)
                throw new Exception("Event cannot be added.");

            SavedEvents.Add(@event);
        }

        public void UpdateEvent(SavedEvent @event)
        {
            SavedEvent existingEvent = SavedEvents.SingleOrDefault(x => x.Id == @event.Id);

            if (existingEvent == null)
                throw new Exception("Event not found.");

            existingEvent.ActivationDate = @event.ActivationDate;
            existingEvent.ActivationTime = @event.ActivationTime;
            existingEvent.Comment = @event.Comment;
            existingEvent.Completed = @event.Completed;
            existingEvent.DeactivationDate = @event.DeactivationDate;
            existingEvent.DeactivationTime = @event.DeactivationTime;
            existingEvent.Title = @event.Title;
        }
    }
}
