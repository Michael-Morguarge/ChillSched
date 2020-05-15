//using Backend.Database.Access;
using Backend.Model;
using System.Collections.Generic;
using System.IO;
using Backend.Inferfaces;
using System.Linq;
using System;
using Shared.Model;
using Shared.Global;
using Microsoft.SqlServer.Server;

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
        private const string InnerNewlineReplace = "{INNERNEWLINE}";
        private const string QuotationReplace = "{D_QUOTE}";
        private const string EqualsReplace = "{EQ_SIGN}";

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
        /// Implements <see cref="IEventRepository.GetEvents(string)" />
        /// </summary>
        public IEnumerable<SavedEvent> GetEvents(string searchTerm)
        {
            string loweredString = searchTerm.ToLower();
            return SavedEvents.Where(x =>
                                x.Title.ToLower().Contains(loweredString)
                                || x.Comment.ToLower().Contains(loweredString))
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
#if DEBUG
                string content = File.ReadAllText("..\\..\\Resources\\Events\\EventTestDebug.saved");
#else
                string content = File.ReadAllText(".\\Resources\\Events\\EventLog.saved");
#endif

                if (!string.IsNullOrEmpty(content))
                {
                    List<List<KeyValuePair<string, string>>> dataArray =
                        content.Split(new[] { EventSeparator }, StringSplitOptions.RemoveEmptyEntries)
                               .Select(x =>
                                   x.Split(new[] { Environment.NewLine }, StringSplitOptions.RemoveEmptyEntries)
                                    .Select(y =>
                                        y.Split(new[] { AssignSeparator }, StringSplitOptions.None))
                                         .Select(a => new KeyValuePair<string, string>(a[0], a.ElementAtOrDefault(1) ?? string.Empty))
                                    .ToList())
                               .Where(x => x.Any())
                               .ToList();

                    List<SavedEvent> events = new List<SavedEvent>();

                    foreach (List<KeyValuePair<string, string>> data in dataArray)
                    {
                        SavedEvent item = CreateEventFromLoadedData(data);
                        SavedEvents.Add(item);
                    }

                    loaded = true;
                }
            }
            catch (Exception)
            {
                loaded = false;
            }

            return loaded;
        }

        private SavedEvent CreateEventFromLoadedData(List<KeyValuePair<string, string>> data)
        {
            string id = data.Single(x => x.Key == "Id").Value.Replace(Quotation, string.Empty);
            string title = FormatText(data.Single(x => x.Key == "Title").Value);
            string comment = FormatRichText(data.Single(x => x.Key == "Comment").Value);

            bool completed = bool.Parse(data.Single(x => x.Key == "Completed").Value.Replace(Quotation, string.Empty));

            (Date Date, Time Time) created_date_time = GetDateAndTime(data.Single(x => x.Key == "DateCreated").Value);
            (Date Date, Time Time) completed_date_time = GetDateAndTime(data.Single(x => x.Key == "DateCompleted").Value);
            (Date Date, Time Time) activation_date_time = GetDateAndTime(data.Single(x => x.Key == "ActivationDate").Value);
            (Date Date, Time Time) deactivation_date_time = GetDateAndTime(data.Single(x => x.Key == "DeactivationDate").Value);

            SavedEvent @event =
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
            return @event;
        }

        private (Date Date, Time Time) GetDateAndTime(string dateAndTime)
        {
            string[] date_time =
                dateAndTime.Replace(Quotation, string.Empty)
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
            try
            {
                string eventString = string.Empty;

                foreach (SavedEvent @event in SavedEvents)
                {
                    string isCompleted = @event.Completed ? "True" : "False";
                    string created = FormatDate(@event.DateCreated, @event.TimeCreated);
                    string completed = FormatDate(@event.DateCompleted, @event.TimeCompleted);
                    string active = FormatDate(@event.ActivationDate, @event.ActivationTime);
                    string inactive = FormatDate(@event.DeactivationDate, @event.DeactivationTime);
                    string title = FormatText(@event.Title, true);
                    string comment = FormatRichText(@event.Comment, true);

                    eventString +=
                        $"Id=\"{@event.Id}\"{Environment.NewLine}" +
                        $"Title=\"{title}\"{Environment.NewLine}" +
                        $"Comment=\"{comment}\"{Environment.NewLine}" +
                        $"Completed=\"{isCompleted}\"{Environment.NewLine}" +
                        $"DateCreated=\"{created}\"{Environment.NewLine}" +
                        $"DateCompleted=\"{completed}\"{Environment.NewLine}" +
                        $"ActivationDate=\"{active}\"{Environment.NewLine}" +
                        $"DeactivationDate=\"{inactive}\"{Environment.NewLine}" +
                        $"~~~{Environment.NewLine}";
                }

#if DEBUG
                File.WriteAllText("..\\..\\Resources\\Events\\EventResultDebug.saved", eventString);
#else
                File.WriteAllText(".\\Resources\\Events\\EventLog.saved", eventString);
#endif
            }
            catch (Exception)
            {
                // Something happened
            }
        }

        private string FormatDate(Date date, Time time)
        {
            return $"{TimeAndDateUtility.ConvertDate_String(date)}+{TimeAndDateUtility.ConvertTime_String(time)}";
        }

        private string FormatText(string text, bool isExport = false)
        {
            return isExport ?
                text.Replace(Quotation, QuotationReplace)
                    .Replace(DateSeparator, PlusReplace)
                    .Replace(Tilde, TildeReplace)
                    .Replace(AssignSeparator, EqualsReplace)
                : text.Replace(Quotation, string.Empty)
                      .Replace(QuotationReplace, Quotation)
                      .Replace(PlusReplace, DateSeparator)
                      .Replace(TildeReplace, Tilde)
                      .Replace(EqualsReplace, AssignSeparator);
        }

        private string FormatRichText(string text, bool isExport = false)
        {
            return isExport ?
                text.Replace(Quotation, QuotationReplace)
                    .Replace(Environment.NewLine, InnerNewlineReplace)
                    .Replace("\n", InnerNewlineReplace)
                    .Replace(DateSeparator, PlusReplace)
                    .Replace(Tilde, TildeReplace)
                    .Replace(AssignSeparator, EqualsReplace)
                : text.Replace(Quotation, string.Empty)
                      .Replace(QuotationReplace, Quotation)
                      .Replace(InnerNewlineReplace, Environment.NewLine)
                      .Replace(PlusReplace, DateSeparator)
                      .Replace(TildeReplace, Tilde)
                      .Replace(EqualsReplace, AssignSeparator);
        }
    }
}
