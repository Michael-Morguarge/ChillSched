using Backend.Implementations;
using Backend.Model;
using Shared.Model;
using Shared.Global;
using System.Collections.Generic;
using System;
using System.Linq;
using Backend.Inferfaces;

namespace FrontEnd.Controller.Business
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
        /// <param name="searchTerm">The search term</param>
        /// <returns>The list of events between date range</returns>
        public IEnumerable<SavedEvent> GetEvents(Date start = null, Date end = null, string searchTerm = null)
        {
            IEnumerable<SavedEvent> events = new List<SavedEvent>();

            if (!string.IsNullOrEmpty(searchTerm))
            {
                events = GetSearchResults(start, end, searchTerm);
            }
            else if (end != null || start != null)
            {
                events = GetDateRestrictedResults(start, end);
            }
            else
            {
                events = _eventRepo.GetEvents();
            }

            return events.Any() ? events.OrderBy(x => x.Title) : events;
        }

        private IEnumerable<SavedEvent> GetDateRestrictedResults(Date start, Date end)
        {
            bool nullStart = start == null;
            bool nullEnd = end == null;

            new List<SavedEvent>();
            Date min = TimeAndDateUtility.ConvertDate_Date(DateTime.MinValue);

            IEnumerable<SavedEvent> events = !nullEnd && !nullStart ?
                _eventRepo.GetEvents(start, end).ToList() : (nullEnd && !nullStart ?
                    _eventRepo.GetEvents(start).ToList() : (nullStart && !nullEnd ?
                        _eventRepo.GetEvents(min, end).ToList() : new List<SavedEvent>()));

            return events;
        }

        private IEnumerable<SavedEvent> GetSearchResults(Date start, Date end, string searchTerm)
        {
            bool nullStart = start == null;
            bool nullEnd = end == null;
            bool nullSearch = string.IsNullOrEmpty(searchTerm);

            IEnumerable<SavedEvent> events = new List<SavedEvent>();
            Date min = TimeAndDateUtility.ConvertDate_Date(DateTime.MinValue);

            List<SavedEvent> searchEvents = _eventRepo.GetEvents(searchTerm).ToList();

            List<SavedEvent> dateEvents;
            if (!nullStart && !nullEnd)
                dateEvents = _eventRepo.GetEvents(start, end).ToList();
            else
                dateEvents = nullEnd && !nullStart ?
                    _eventRepo.GetEvents(start).ToList() : (nullStart && !nullEnd ?
                        _eventRepo.GetEvents(min, end).ToList() : new List<SavedEvent>());

            bool searchHasResults = searchEvents.Any();
            bool dateHasResults = dateEvents.Any();

            if (searchHasResults && dateHasResults)
                events = searchEvents.Concat(dateEvents).GroupBy(x => x.Id).Select(x => x.First());
            else
                events = searchHasResults ?
                    searchEvents : (dateHasResults ?
                        dateEvents : new List<SavedEvent>());

            return events;
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

        /// <summary>
        /// Loads saved events from file
        /// </summary>
        /// <returns>Whether the events loaded</returns>
        public bool LoadEvents()
        {
            return _eventRepo.LoadEvents();
        }

        /// <summary>
        /// Saves events to file
        /// </summary>
        public void SaveEvents()
        {
            _eventRepo.SaveEvents();
        }
    }
}
