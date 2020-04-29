using Backend.Implementations;
using Backend.Model;
using Shared.Model;
using Shared.Global;
using System.Collections.Generic;
using System;
using System.Linq;
using BackEnd.Inferfaces;

namespace FrontEnd.Controller
{
    /// <summary>
    /// Controller for Events
    /// </summary>
    public class EventController
    {
        private readonly IEventRepository _eventRepo;

        /// <summary>
        /// Constructor for the EventController
        /// </summary>
        public EventController()
        {
            _eventRepo = new EventRepository();
        }

        /// <summary>
        /// Gets an Event based on the id
        /// </summary>
        /// <param name="id">The event id</param>
        /// <returns>The event</returns>
        public SavedEvent GetEvent(string id)
        {
            return _eventRepo.GetEvent(id);
        }

        /// <summary>
        /// Gets all dates that have events
        /// </summary>
        /// <returns>A list of the dates where events occur</returns>
        public IEnumerable<DateTime> GetAllEventDates()
        {
            IEnumerable<DateTime> dates = 
                _eventRepo.GetEvents()
                          .Select(x => TimeAndDateUtility.ConvertDateAndTime_Date(x.ActivationDate))
                          .Distinct()
                          .OrderBy(x => x);

            return dates;
        }

        /// <summary>
        /// Gets all events between specified date range
        /// </summary>
        /// <param name="start">The start date</param>
        /// <param name="end">The end date</param>
        /// <returns>The list of events between date range</returns>
        public IEnumerable<SavedEvent> GetEvents(Date start, Date end)
        {
            return _eventRepo.GetEvents(start, end).OrderBy(x => x.Title);
        }

        /// <summary>
        /// Gets all events for that date
        /// </summary>
        /// <param name="selectedDate">The date to search with</param>
        /// <returns>The events on that specified date</returns>
        public IEnumerable<SavedEvent> GetEvents(Date selectedDate)
        {
            return _eventRepo.GetEvents(selectedDate).OrderBy(x => x.Title);
        }

        /// <summary>
        /// Creates an event
        /// </summary>
        /// <param name="event">The event created by the user</param>
        /// <returns>Whether the event was added</returns>
        public bool CreateEvent(SavedEvent @event)
        {
            @event.DateCreated = TimeAndDateUtility.GetCurrentDate();
            @event.TimeCreated = TimeAndDateUtility.GetCurrentTime();

            return _eventRepo.AddEvent(@event);
        }

        /// <summary>
        /// Updates an event
        /// </summary>
        /// <param name="event">The event updated by the user</param>
        /// <returns>Whether the event was updated</returns>
        public bool EditEvent(SavedEvent @event)
        {
            return _eventRepo.UpdateEvent(@event);
        }

        /// <summary>
        /// Toggles the complete status on an event
        /// </summary>
        /// <param name="id">The id of the event to toggle</param>
        /// <returns>Whether the event was updated</returns>
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

        /// <summary>
        /// Deletes an event
        /// </summary>
        /// <param name="id">The id of the event to delete</param>
        /// <returns>Whether the event was deleted</returns>
        public bool DeleteEvent(string id)
        {
            return _eventRepo.DeleteEvent(id);
        }

        public void LoadEvents()
        {
            _eventRepo.LoadEvents();
        }

        public void SaveEvents()
        {
            _eventRepo.SaveEvents();
        }
    }
}
