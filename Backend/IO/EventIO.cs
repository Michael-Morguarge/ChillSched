using Backend.Model;
using FileOperations.Constants;
using FileOperations.Interfaces;
using FileOperations.Models;
using Shared.Model;
using System;
using System.Collections.Generic;
using System.IO;
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
        public bool FullyLoaded { get; private set; } = true;

        /// <summary>
        /// Whether the data was fully saved
        /// </summary>
        public bool FullySaved { get; private set; } = true;

        /// <summary>
        /// Implements <see cref="IFileOperations{SavedEvent}.Load(string)" />
        /// </summary>
        public List<SavedEvent> Load(string path = null)
        {
            List<SavedEvent> events = new List<SavedEvent>();

            try
            {
                Data<string, string> data = new Data<string, string>();
                string content = File.ReadAllText(string.IsNullOrEmpty(path) ? EIOConstants.DefaultImportPath : path);

                if (!string.IsNullOrEmpty(content))
                {
                    data.TempDataStore =
                        content.Split(new[] { IO.Tildes }, StringSplitOptions.RemoveEmptyEntries)
                               .Select(x =>
                                   x.Split(new[] { Environment.NewLine }, StringSplitOptions.RemoveEmptyEntries)
                                    .Select(y =>
                                        y.Split(new[] { IO.EqSign }, StringSplitOptions.None))
                                         .Select(a => new KeyValuePair<string, string>(a[0], a.ElementAtOrDefault(1) ?? string.Empty))
                                    .ToList())
                               .Where(x => x.Any())
                               .ToList();

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
                string eventString = string.Empty;

                foreach (SavedEvent @event in events)
                {
                    try
                    {
                        string isCompleted = @event.Completed ? "True" : "False";
                        string created = IO.FormatDate(@event.DateCreated, @event.TimeCreated);
                        string completed = IO.FormatDate(@event.DateCompleted, @event.TimeCompleted);
                        string active = IO.FormatDate(@event.ActivationDate, @event.ActivationTime);
                        string inactive = IO.FormatDate(@event.DeactivationDate, @event.DeactivationTime);
                        string title = IO.FormatText(@event.Title, true);
                        string comment = IO.FormatRichText(@event.Comment, true);

                        eventString +=
                            $"{EIOConstants.Id}{IO.EqSign}{IO.Quotes}{@event.Id}{IO.Quotes}{Environment.NewLine}" +
                            $"{EIOConstants.Title}{IO.EqSign}{IO.Quotes}{title}{IO.Quotes}{Environment.NewLine}" +
                            $"{EIOConstants.Comment}{IO.EqSign}{IO.Quotes}{comment}{IO.Quotes}{Environment.NewLine}" +
                            $"{EIOConstants.Completed}{IO.EqSign}{IO.Quotes}{isCompleted}{IO.Quotes}{Environment.NewLine}" +
                            $"{EIOConstants.DateCreated}{IO.EqSign}{IO.Quotes}{created}{IO.Quotes}{Environment.NewLine}" +
                            $"{EIOConstants.DateCompleted}{IO.EqSign}{IO.Quotes}{completed}{IO.Quotes}{Environment.NewLine}" +
                            $"{EIOConstants.ActivationDate}{IO.EqSign}{IO.Quotes}{active}{IO.Quotes}{Environment.NewLine}" +
                            $"{EIOConstants.DeactivationDate}{IO.EqSign}{IO.Quotes}{inactive}{IO.Quotes}{Environment.NewLine}" +
                            $"{IO.Tildes}{Environment.NewLine}";
                    }
                    catch (Exception)
                    {
                        FullySaved = false;
                    }
                }

                File.WriteAllText(string.IsNullOrEmpty(path) ? EIOConstants.DefaultExportPath : path, eventString);
            }
            catch (Exception)
            {
                FullySaved = false;
            }
        }

        #region HELPERS

        private SavedEvent CreateEventFromLoadedData(List<KeyValuePair<string, string>> data)
        {
            string id = IO.TestId(data.Single(x => x.Key == EIOConstants.Id).Value.Replace(IO.Quotes, string.Empty));
            string title = IO.FormatText(IO.TestText(data.Single(x => x.Key == EIOConstants.Title).Value));
            string comment = IO.FormatRichText(IO.TestText(data.Single(x => x.Key == EIOConstants.Comment).Value));

            bool completed = IO.TestBoolean(data.Single(x => x.Key == EIOConstants.Completed).Value);

            (Date Date, Time Time) created_date_time = IO.TestDate(data.Single(x => x.Key == EIOConstants.DateCreated).Value);
            (Date Date, Time Time) completed_date_time = IO.TestDate(data.Single(x => x.Key == EIOConstants.DateCompleted).Value);
            (Date Date, Time Time) activation_date_time = IO.TestDate(data.Single(x => x.Key == EIOConstants.ActivationDate).Value);
            (Date Date, Time Time) deactivation_date_time = IO.TestDate(data.Single(x => x.Key == EIOConstants.DeactivationDate).Value);

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

        #endregion HELPERS
    }
}
