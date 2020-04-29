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
        private readonly Events _events;
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
            catch (Exception)
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
                SavedEvent existingEvent = _events.SavedEvents.SingleOrDefault(x => x.Id == @event.Id);

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
            catch (Exception)
            {
                return false;
            }
        }

        /// <summary>
        /// Implements <see cref="IEventRepository.DeleteEvent(string)" />
        /// </summary>
        public bool DeleteEvent(string id)
        {
            try
            {
                SavedEvent existingEvent = _events.SavedEvents.SingleOrDefault(x => x.Id == id);

                if (existingEvent == null)
                    throw new Exception("Event not found.");

                return _events.SavedEvents.Remove(existingEvent);
            }
            catch (Exception)
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

            SavedEvent @event = _events.SavedEvents.SingleOrDefault(x => x.Id == id);

            return @event;
        }

        /// <summary>
        /// Implements <see cref="IEventRepository.GetEvents(Date, Date)" />
        /// </summary>
        public IEnumerable<SavedEvent> GetEvents(Date start, Date end)
        {
            return
                _events.SavedEvents
                       .Where(x =>
                            TimeAndDateUtility.IsWithinRange(start, x.ActivationDate, end)
                            || TimeAndDateUtility.IsWithinRange(start, x.DeactivationDate, end))
                       .ToList()
                       .AsReadOnly();
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

        /// <summary>
        /// Implements <see cref="IEventRepository.GetEvents()" />
        /// </summary>
        public IEnumerable<SavedEvent> GetEvents()
        {
            return _events.SavedEvents.AsReadOnly();
        }

        /// <summary>
        /// Implements <see cref="IEventRepository.LoadEvents()" />
        /// </summary>
        public void LoadEvents()
        {
            string dateSeparator = "+";
            string assignSeparator = "=";
            string eventSeparator = "~~~";
            string tildeReplace = "{TILDE}";
            string plusReplace = "{PLUS}";
            string newlineReplace = "{NEWLINE}";

            string content = File.ReadAllText("..\\..\\Resources\\Events\\temp.saved");
            if (string.IsNullOrEmpty(content))
            {

            }
            else
            {
                string[][][][] eventsArray = 
                    content.Split(new[] { eventSeparator }, StringSplitOptions.None)
                           .Select(x =>
                                x.Split(new[] { newlineReplace }, StringSplitOptions.None)
                                 .Select(y =>
                                    y.Split(new[] { Environment.NewLine }, StringSplitOptions.RemoveEmptyEntries)
                                     .Select(z => z.Split(new[] { assignSeparator }, StringSplitOptions.None))
                                     .ToArray())
                                 .ToArray())
                           .ToArray();

                List<SavedEvent> events = new List<SavedEvent>();

                foreach (string[][][] level1 in eventsArray)
                {
                    foreach (string[][] level2 in level1)
                    {
                        foreach (string[] level3 in level2)
                        {
                            foreach(string level4 in level3)
                            {

                            }
                        }
                    }
                }
            }
        }

        /// <summary>
        /// Implements <see cref="IEventRepository.SaveEvents()" />
        /// </summary>
        public void SaveEvents()
        {
            string eventString = string.Empty;
            foreach (SavedEvent @event in _events.SavedEvents)
            {
                string completed = @event.Completed ? "True" : "False";

                string createdDate = TimeAndDateUtility.ConvertDate_String(@event.DateCreated);
                string createdTime = TimeAndDateUtility.ConvertTime_String(@event.TimeCreated);

                string completeDate = TimeAndDateUtility.ConvertDate_String(@event.DateCompleted);
                string completeTime = TimeAndDateUtility.ConvertTime_String(@event.TimeCompleted);

                string activeDate = TimeAndDateUtility.ConvertDate_String(@event.ActivationDate);
                string activeTime = TimeAndDateUtility.ConvertTime_String(@event.ActivationTime);

                string inactiveDate = TimeAndDateUtility.ConvertDate_String(@event.DeactivationDate);
                string inactiveTime = TimeAndDateUtility.ConvertTime_String(@event.DeactivationTime);

                eventString +=
                    $"Id=\"{@event.Id}\"{Environment.NewLine}" +
                    $"Title=\"{@event.Title.Replace("+", "{PLUS}").Replace("~", "{TILDE}")}\"{Environment.NewLine}" +
                    $"Comment=\"{@event.Comment.Replace(Environment.NewLine, "{NEWLINE}").Replace("+", "{PLUS}").Replace("~", "{TILDE}")}\"{Environment.NewLine}" +
                    $"Complete=\"{completed}\"{Environment.NewLine}" +
                    $"DateCreated=\"{createdDate}+{createdTime}\"{Environment.NewLine}" +
                    $"DateCompleted=\"{completeDate}+{completeTime}\"{Environment.NewLine}" +
                    $"ActivationDate=\"{activeDate}+{activeTime}\"{Environment.NewLine}" +
                    $"DeactivationDate=\"{inactiveDate}+{inactiveTime}\"{Environment.NewLine}" +
                    $"~~~{Environment.NewLine}";
            }

            File.WriteAllText("..\\..\\Resources\\Events\\temp.saved", eventString);
        }
    }
}
