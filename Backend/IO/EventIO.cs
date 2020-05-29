using Backend.Model;
using FileOperations.Constants;
using FileOperations.Interfaces;
using FileOperations.Models;
using Shared.Model;
using System;
using System.Collections.Generic;
using System.Linq;

namespace FileOperations.Implementations
{
    /// <summary>
    /// File operations for Events
    /// </summary>
    public class EventIO : IFileOperations<SavedEvent>
    {
        /// <summary>
        /// Whether the data was fully loaed
        /// </summary>
        public bool FullyLoaded { get; private set; }

        /// <summary>
        /// Whether the data was fully saved
        /// </summary>
        public bool FullySaved { get; private set; }

        /// <summary>
        /// Implements <see cref="IFileOperations{SavedEvent}.ConvertData(List{SavedEvent})" />
        /// </summary>
        public string ConvertData(List<SavedEvent> items)
        {
            return ConvertToData(items);
        }

        /// <summary>
        /// Implements <see cref="IFileOperations{SavedEvent}.Parse(string)" />
        /// </summary>
        public List<SavedEvent> Parse(string content)
        {
            List<SavedEvent> events = new List<SavedEvent>();
            FullyLoaded = true;

            try
            {
                if (!string.IsNullOrEmpty(content))
                {
                    Data<string, string> data = IO.ParseContent(content);

                    foreach (List<KeyValuePair<string, string>> subData in data.TempDataStore)
                    {
                        try
                        {
                            SavedEvent item = CreateEventFromLoadedData(subData);
                            events.Add(item);
                        }
                        catch (Exception)
                        {
                            FullyLoaded = false;
                        }
                    }
                }
            }
            catch (Exception)
            {
                FullyLoaded = false;
            }

            return events;
        }

        /// <summary>
        /// Implements <see cref="IFileOperations{SavedEvent}.Save(List{SavedEvent}, string)" />
        /// </summary>
        public void Save(List<SavedEvent> events, string path = null)
        {
            try
            {
                FullySaved = true;
                string eventString = ConvertToData(events);

                AllIO.BackupChanges(eventString, FileTypes.EVENT);
            }
            catch (Exception)
            {
                FullySaved = false;
            }
        }

        #region HELPERS

        private string ConvertToData(List<SavedEvent> events)
        {
            string eventString = string.Empty;

            foreach (SavedEvent @event in events)
            {
                try
                {
                    string isCompleted = @event.Completed ? "True" : "False";
                    string created = IO.FormatDate(@event.CreatedDate);
                    string completed = IO.FormatDate(@event.CompletedDate);
                    string active = IO.FormatDate(@event.ActivationDate);
                    string inactive = IO.FormatDate(@event.DeactivationDate);
                    string title = IO.FormatText(@event.Title, true);
                    string comment = IO.FormatRichText(@event.Comment, true);
                    string ENL = Environment.NewLine;

                    eventString +=
                        $"{EIOConsts.Id}{IO.EqSign}{IO.Quotes}{@event.Id}{IO.Quotes}{ENL}" +
                        $"{EIOConsts.Title}{IO.EqSign}{IO.Quotes}{title}{IO.Quotes}{ENL}" +
                        $"{EIOConsts.Comment}{IO.EqSign}{IO.Quotes}{comment}{IO.Quotes}{ENL}" +
                        $"{EIOConsts.Completed}{IO.EqSign}{IO.Quotes}{isCompleted}{IO.Quotes}{ENL}" +
                        $"{EIOConsts.DateCreated}{IO.EqSign}{IO.Quotes}{created}{IO.Quotes}{ENL}" +
                        $"{EIOConsts.DateCompleted}{IO.EqSign}{IO.Quotes}{completed}{IO.Quotes}{ENL}" +
                        $"{EIOConsts.ActivationDate}{IO.EqSign}{IO.Quotes}{active}{IO.Quotes}{ENL}" +
                        $"{EIOConsts.DeactivationDate}{IO.EqSign}{IO.Quotes}{inactive}{IO.Quotes}{ENL}" +
                        $"{IO.Tildes}{ENL}";
                }
                catch (Exception)
                {
                    FullySaved = false;
                }
            }

            return eventString;
        }

        private SavedEvent CreateEventFromLoadedData(List<KeyValuePair<string, string>> data)
        {
            string id = IO.TestId(data.Single(x => x.Key == EIOConsts.Id).Value.Replace(IO.Quotes, string.Empty));
            string title = IO.FormatText(IO.TestText(data.Single(x => x.Key == EIOConsts.Title).Value));
            string comment = IO.FormatRichText(IO.TestText(data.Single(x => x.Key == EIOConsts.Comment).Value));

            bool completed = IO.TestBoolean(data.Single(x => x.Key == EIOConsts.Completed).Value);

            DateAndTime created_date_time = IO.TestDate(data.Single(x => x.Key == EIOConsts.DateCreated).Value);
            DateAndTime completed_date_time = IO.TestDate(data.Single(x => x.Key == EIOConsts.DateCompleted).Value);
            DateAndTime activation_date_time = IO.TestDate(data.Single(x => x.Key == EIOConsts.ActivationDate).Value);
            DateAndTime deactivation_date_time = IO.TestDate(data.Single(x => x.Key == EIOConsts.DeactivationDate).Value);

            SavedEvent @event =
                new SavedEvent
                {
                    Id = id,
                    Title = title,
                    Comment = comment,
                    CreatedDate = created_date_time,
                    Completed = completed,
                    CompletedDate = completed_date_time,
                    ActivationDate = activation_date_time,
                    DeactivationDate = deactivation_date_time
                };

            return @event;
        }

        #endregion HELPERS
    }
}
