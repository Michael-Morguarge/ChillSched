//using Backend.Database.Access;
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
    /// <summary>
    /// Class for the Event Repository
    /// </summary>
    public class EventRepository : IEventRepository
    {
        private const string DateSeparator = "+";
        private const string AssignSeparator = "=";
        private const string EventSeparator = "~~~";
        private const string Quotation = "\"";
        private const string Tilde = "~";
        private const string TildeReplace = "{TILDE}";
        private const string PlusReplace = "{PLUS}";
        private const string NewlineReplace = "{NEWLINE}";
        private const string InnerNewlineReplace = "{INNERNEWLINE}";
        private const string QuotationReplace = "{D_QUOTE}";

        //private readonly DataLayer _dataAccess;

        private readonly List<SavedEvent> SavedEvents;

        /// <summary>
        /// Construtor for the EventRepository
        /// </summary>
        public EventRepository()
        {
            SavedEvents = new List<SavedEvent>();
            //_dataAccess = new DataLayer();

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
                SavedEvents.Add(aEvent);

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
                SavedEvent existingEvent = SavedEvents.SingleOrDefault(x => x.Id == id);

                if (existingEvent == null)
                    throw new Exception("Event not found.");

                return SavedEvents.Remove(existingEvent);
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

            SavedEvent @event = SavedEvents.SingleOrDefault(x => x.Id == id);

            return @event;
        }

        /// <summary>
        /// Implements <see cref="IEventRepository.GetEvents(Date, Date)" />
        /// </summary>
        public IEnumerable<SavedEvent> GetEvents(Date start, Date end)
        {
            return
                SavedEvents.Where(x =>
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
                SavedEvents.Where(x => TimeAndDateUtility.IsWithinRange(x.ActivationDate, date, x.DeactivationDate))
                           .ToList()
                           .AsReadOnly();
        }

        /// <summary>
        /// Implements <see cref="IEventRepository.GetEvents()" />
        /// </summary>
        public IEnumerable<SavedEvent> GetEvents()
        {
            return SavedEvents.AsReadOnly();
        }

        /// <summary>
        /// Implements <see cref="IEventRepository.LoadEvents()" />
        /// </summary>
        public bool LoadEvents()
        {
            bool loaded = false;

            try
            {
                string content = string.Empty;
#if DEBUG
                content = File.ReadAllText("..\\..\\Resources\\Events\\temp.saved");
#else
                content = File.ReadAllText(".\\Resources\\Events\\temp.saved");
#endif 

                if (!string.IsNullOrEmpty(content))
                {
                    List<List<List<KeyValuePair<string, string>>>> eventsArray =
                        content.Split(new[] { EventSeparator }, StringSplitOptions.None)
                               .Select(x =>
                                   x.Split(new[] { NewlineReplace }, StringSplitOptions.None)
                                     .Select(y =>
                                         y.Split(new[] { Environment.NewLine }, StringSplitOptions.RemoveEmptyEntries)
                                          .Select(z =>
                                              z.Split(new[] { AssignSeparator }, StringSplitOptions.None))
                                          .Select(a => new KeyValuePair<string, string>(a[0], a.ElementAtOrDefault(1) ?? string.Empty))
                                          .ToList())
                                    .ToList())
                               .ToList();

                    List<SavedEvent> events = new List<SavedEvent>();

                    foreach (List<List<KeyValuePair<string, string>>> level1 in eventsArray)
                    {
                        foreach (List<KeyValuePair<string, string>> level2 in level1)
                        {
                            if (level2.Any())
                            {
                                SavedEvent item = CreateEventFromLoadedData(level2);
                                SavedEvents.Add(item);
                            }
                        }
                    }

                    loaded = true;
                }
            }
            catch (Exception e)
            {
                loaded = false;
            }

            return loaded;
        }

        private SavedEvent CreateEventFromLoadedData(List<KeyValuePair<string, string>> data)
        {
            string id = data.Single(x => x.Key == "Id").Value.Replace(Quotation, string.Empty);

            string title =
                data.Single(x => x.Key == "Title").Value
                    .Replace(Quotation, string.Empty)
                    .Replace(QuotationReplace, Quotation)
                    .Replace(PlusReplace, DateSeparator)
                    .Replace(TildeReplace, Tilde);

            string comment =
                data.Single(x => x.Key == "Comment").Value
                    .Replace(Quotation, string.Empty)
                    .Replace(QuotationReplace, Quotation)
                    .Replace(InnerNewlineReplace, Environment.NewLine)
                    .Replace(PlusReplace, DateSeparator)
                    .Replace(TildeReplace, Tilde);

            bool completed = bool.Parse(data.Single(x => x.Key == "Completed").Value.Replace(Quotation, string.Empty));

            (Date Date, Time Time) created_date_time = GetDateAndTime(data, "DateCreated");
            (Date Date, Time Time) completed_date_time = GetDateAndTime(data, "DateCompleted");
            (Date Date, Time Time) activation_date_time = GetDateAndTime(data, "ActivationDate");
            (Date Date, Time Time) deactivation_date_time = GetDateAndTime(data, "DeactivationDate");

            SavedEvent outgoing =
                new SavedEvent
                {
                    Id = id,
                    Title = title,
                    Comment = comment,
                    DateCreated = created_date_time.Date,
                    TimeCreated = created_date_time.Time,
                    Completed = completed,
                    DateCompleted = completed_date_time.Date,
                    TimeCompleted = completed_date_time.Time,
                    ActivationDate = activation_date_time.Date,
                    ActivationTime = activation_date_time.Time,
                    DeactivationDate = deactivation_date_time.Date,
                    DeactivationTime = deactivation_date_time.Time
                };
            return outgoing;
        }

        private (Date Date, Time Time) GetDateAndTime(List<KeyValuePair<string, string>> dateAndTime, string field)
        {
            string[] date_time =
                dateAndTime.Single(x => x.Key == field).Value
                           .Replace(Quotation, string.Empty)
                           .Split(new[] { DateSeparator }, StringSplitOptions.RemoveEmptyEntries);
            bool containsBoth = date_time.Length == 2;
            Date date = containsBoth ? TimeAndDateUtility.ConvertString_Date(date_time[0]) : null;
            Time time = containsBoth ? TimeAndDateUtility.ConvertString_Time(date_time[1]) : null;

            return (date, time);
        }

        /// <summary>
        /// Implements <see cref="IEventRepository.SaveEvents()" />
        /// </summary>
        public void SaveEvents()
        {
            string eventString = string.Empty;
            foreach (SavedEvent @event in SavedEvents)
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

                string title = @event.Title.Replace(Quotation, QuotationReplace).Replace(DateSeparator, PlusReplace).Replace(Tilde, TildeReplace);
                string comment = @event.Comment.Replace(Quotation, QuotationReplace).Replace(Environment.NewLine, InnerNewlineReplace).Replace("\n", InnerNewlineReplace).Replace(DateSeparator, PlusReplace).Replace(Tilde, TildeReplace);

                eventString +=
                    $"Id=\"{@event.Id}\"{Environment.NewLine}" +
                    $"Title=\"{title}\"{Environment.NewLine}" +
                    $"Comment=\"{comment}\"{Environment.NewLine}" +
                    $"Completed=\"{completed}\"{Environment.NewLine}" +
                    $"DateCreated=\"{createdDate}+{createdTime}\"{Environment.NewLine}" +
                    $"DateCompleted=\"{completeDate}+{completeTime}\"{Environment.NewLine}" +
                    $"ActivationDate=\"{activeDate}+{activeTime}\"{Environment.NewLine}" +
                    $"DeactivationDate=\"{inactiveDate}+{inactiveTime}\"{Environment.NewLine}" +
                    $"~~~{Environment.NewLine}";
            }

            File.WriteAllText(".\\Resources\\Events\\temp.saved", eventString);
        }
    }
}
