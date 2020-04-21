using Backend.Database.Access;
using Backend.Model;
using System.Collections.Generic;
using System.IO;
using BackEnd.Inferfaces;
using System.Linq;
using System;
using Shared.Model;
using Shared.Global;

namespace Backend.Implementations
{
    // Needs major rework

    /// <summary>
    /// Class for the Event Repository
    /// </summary>
    public class EventRepository : IEventRepository
    {
        private Events _events;
        private readonly DataLayer _dataAccess;

        /// <summary>
        /// Construtor for the EventRepository
        /// </summary>
        public EventRepository()
        {
            _events = new Events();
            _dataAccess = new DataLayer();

            // Tables needed from database (Find a way to use model objects to format data)
            // Get rid of Bookmarks
            // Might remove Event Detail Repo
        }

        /// <summary>
        /// Implements <see cref="IEventRepository.AddEvent(SavedEvent)" />
        /// </summary>
        public bool AddEvent(SavedEvent aEvent)
        {
            try
            {
                _events.AddEvent(aEvent);

                return true;
            }
            catch (Exception e)
            {
                return false;
            }
        }

        /// <summary>
        /// Implements <see cref="IEventRepository.UpdateEvent(SavedEvent)" />
        /// </summary>
        public bool UpdateEvent(SavedEvent @event)
        {
            try
            {
                var existingEvent = _events.SavedEvents.SingleOrDefault(x => x.Id == @event.Id);

                if (existingEvent == null)
                    throw new Exception("Event not found.");

                existingEvent.ActivationDate = @event.ActivationDate;
                existingEvent.ActivationTime = @event.ActivationTime;
                existingEvent.Comment = @event.Comment;
                existingEvent.Completed = @event.Completed;
                existingEvent.DeactivationDate = @event.DeactivationDate;
                existingEvent.DeactivationTime = @event.DeactivationTime;
                existingEvent.Title = @event.Title;

                return true;
            }
            catch (Exception e)
            {
                return false;
            }
        }

        /// <summary>
        /// Implements <see cref="IEventRepository.RemoveEvent(string)" />
        /// </summary>
        public bool RemoveEvent(string id)
        {
            try
            {
                var existingEvent = _events.SavedEvents.SingleOrDefault(x => x.Id == id);

                if (existingEvent == null)
                    throw new Exception("Event not found.");

                return _events.SavedEvents.Remove(existingEvent);
            }
            catch (Exception e)
            {
                return false;
            }
        }

        /// <summary>
        /// Implements <see cref="IEventRepository.GetEvent(string)" />
        /// </summary>
        public SavedEvent GetEvent(string id)
        {
            //SavedEvent theEvent = null;
            //var events = _dataAccess.GetDataFromTable("Some query");
            
            if (string.IsNullOrEmpty(id))
                return null;

            var @event = _events.SavedEvents.SingleOrDefault(x => x.Id == id);

            return @event;
        }

        /// <summary>
        /// Implements <see cref="IEventRepository.GetEvents(Date)" />
        /// </summary>
        public IEnumerable<SavedEvent> GetEvents(Date date)
        {
            return 
                _events.SavedEvents
                       .Where(x => TimeAndDateUtility.IsWithinRange(x.ActivationDate, date, x.DeactivationDate))
                       .ToList()
                       .AsReadOnly();
        }

        public void SaveBookmarks()
        {
            foreach (var bookmark in _events.SavedEvents)
            {
                File.WriteAllText(string.Format(@".\Resources\Bookmarks\{0}_{1}.eventsaved", bookmark.Title, bookmark.Id), "");
            }
        }
    }
}
