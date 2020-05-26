using Backend.Implementations;
using Backend.Model;
using Shared.Model;
using Shared.Global;
using System.Collections.Generic;
using System;
using System.Linq;
using Backend.Inferfaces;

namespace Frontend.Controller.Business
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
            return 
                _eventRepo.GetEvents()
                          .Select(x => TimeAndDateUtility.ConvertDateAndTime_DateTime(x.ActivationDate))
                          .Distinct()
                          .OrderBy(x => x);
        }

        /// <summary>
        /// Gets all events between specified date range
        /// </summary>
        /// <param name="start">The start date</param>
        /// <param name="end">The end date</param>
        /// <param name="searchTerm">The search term</param>
        /// <returns>The list of events between date range</returns>
        public IEnumerable<SavedEvent> GetEvents(DateAndTime start = null, DateAndTime end = null, string searchTerm = null)
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

        private IEnumerable<SavedEvent> GetDateRestrictedResults(DateAndTime start, DateAndTime end)
        {
            bool nullStart = start == null;
            bool nullEnd = end == null;

            new List<SavedEvent>();
            DateAndTime min = TimeAndDateUtility.ConvertDateTime_DateAndTime(DateTime.MinValue);

            IEnumerable<SavedEvent> events = !nullEnd && !nullStart ?
                _eventRepo.GetEvents(start, end).ToList() : (nullEnd && !nullStart ?
                    _eventRepo.GetEvents(start).ToList() : (nullStart && !nullEnd ?
                        _eventRepo.GetEvents(min, end).ToList() : new List<SavedEvent>()));

            return events;
        }

        private IEnumerable<SavedEvent> GetSearchResults(DateAndTime start, DateAndTime end, string searchTerm)
        {
            bool nullStart = start == null;
            bool nullEnd = end == null;
            bool nullSearch = string.IsNullOrEmpty(searchTerm);

            IEnumerable<SavedEvent> events = new List<SavedEvent>();
            DateAndTime min = TimeAndDateUtility.ConvertDateTime_DateAndTime(DateTime.MinValue);

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
            @event.CreatedDate = new DateAndTime(TimeAndDateUtility.GetCurrentDate(), TimeAndDateUtility.GetCurrentTime());

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
                @event.CompletedDate = null;
            }
            else
            {
                DateTime date = DateTime.Now;
                @event.Completed = true;
                @event.CompletedDate = TimeAndDateUtility.ConvertDateTime_DateAndTime(date);
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
        /// <param name="overwrite">Whether to overwrite data</param>
        /// <returns>Whether the events loaded</returns>
        public bool LoadEvents(bool overwrite = false)
        {
            return _eventRepo.LoadEvents(overwrite);
        }

        /// <summary>
        /// Loads saved events from file
        /// </summary>
        /// <param name="path">The file path to load from</param>
        /// <param name="overwrite">Whether to overwrite data</param>
        /// <returns>Whether the events loaded</returns>
        public bool LoadEvents(string path, bool overwrite = false)
        {
            return _eventRepo.LoadEvents(path, overwrite);
        }

        /// <summary>
        /// Saves events to file
        /// </summary>
        /// <returns>Whether the events were fully saved</returns>
        public bool SaveEvents()
        {
            return _eventRepo.SaveEvents();
        }

        /// <summary>
        /// Saves events to file
        /// </summary>
        /// <param name="path">The file path to save to</param>
        /// <returns>Whether the events were fully saved</returns>
        public bool SaveEvents(string path)
        {
            return _eventRepo.SaveEvents(path);
        }
    }
}
