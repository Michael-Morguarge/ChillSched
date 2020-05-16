using Backend.Model;
using FileOperations.Interfaces;
using FileOperations.Models;
using Shared.Global;
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
#if DEBUG
        private const string DefaultImportPath = "..\\..\\Resources\\Events\\EventTestDebug.saved";
        private const string DefaultExportPath = "..\\..\\Resources\\Events\\EventResultDebug.saved";
#else
        private const string DefaultImportPath = ".\\Resources\\Events\\EventLog.saved";
        private const string DefaultExportPath = ".\\Resources\\Events\\EventLog.saved";
#endif
        /// <summary>
        /// Implements <see cref="IFileOperations{SavedEvent}.Load(string)" />
        /// </summary>
        public List<SavedEvent> Load(string path = null)
        {
            List<SavedEvent> events = new List<SavedEvent>();

            try
            {
                Data<string, string> data = new Data<string, string>();
                string content = File.ReadAllText(string.IsNullOrEmpty(path) ? DefaultImportPath : path);

                if (!string.IsNullOrEmpty(content))
                {
                    data.TempDataStore =
                        content.Split(new[] { IO.EventSeparator }, StringSplitOptions.RemoveEmptyEntries)
                               .Select(x =>
                                   x.Split(new[] { Environment.NewLine }, StringSplitOptions.RemoveEmptyEntries)
                                    .Select(y =>
                                        y.Split(new[] { IO.AssignSeparator }, StringSplitOptions.None))
                                         .Select(a => new KeyValuePair<string, string>(a[0], a.ElementAtOrDefault(1) ?? string.Empty))
                                    .ToList())
                               .Where(x => x.Any())
                               .ToList();

                    foreach (List<KeyValuePair<string, string>> subData in data.TempDataStore)
                    {
                        SavedEvent item = CreateEventFromLoadedData(subData);
                        events.Add(item);
                    }
                }
            }
            catch (Exception)
            {
                //Something happened
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

                File.WriteAllText(string.IsNullOrEmpty(path) ? DefaultExportPath : path, eventString);
            }
            catch (Exception)
            {
                // Something happened
            }
        }

        #region HELPERS

        private SavedEvent CreateEventFromLoadedData(List<KeyValuePair<string, string>> data)
        {
            string id = data.Single(x => x.Key == "Id").Value.Replace(IO.Quotation, string.Empty);
            string title = FormatText(data.Single(x => x.Key == "Title").Value);
            string comment = FormatRichText(data.Single(x => x.Key == "Comment").Value);

            bool completed = bool.Parse(data.Single(x => x.Key == "Completed").Value.Replace(IO.Quotation, string.Empty));

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
                dateAndTime.Replace(IO.Quotation, string.Empty)
                           .Split(new[] { IO.DateSeparator }, StringSplitOptions.RemoveEmptyEntries);
            bool containsBoth = date_time.Length == 2;
            Date date = containsBoth ? TimeAndDateUtility.ConvertString_Date(date_time[0]) : null;
            Time time = containsBoth ? TimeAndDateUtility.ConvertString_Time(date_time[1]) : null;

            return (date, time);
        }

        private string FormatDate(Date date, Time time)
        {
            return $"{TimeAndDateUtility.ConvertDate_String(date)}+{TimeAndDateUtility.ConvertTime_String(time)}";
        }

        private string FormatText(string text, bool isExport = false)
        {
            return isExport ?
                text.Replace(IO.Quotation, IO.QuotationReplace)
                    .Replace(IO.DateSeparator, IO.PlusReplace)
                    .Replace(IO.Tilde, IO.TildeReplace)
                    .Replace(IO.AssignSeparator, IO.EqualsReplace)
                : text.Replace(IO.Quotation, string.Empty)
                      .Replace(IO.QuotationReplace, IO.Quotation)
                      .Replace(IO.PlusReplace, IO.DateSeparator)
                      .Replace(IO.TildeReplace, IO.Tilde)
                      .Replace(IO.EqualsReplace, IO.AssignSeparator);
        }

        private string FormatRichText(string text, bool isExport = false)
        {
            return isExport ?
                text.Replace(IO.Quotation, IO.QuotationReplace)
                    .Replace(Environment.NewLine, IO.InnerNewlineReplace)
                    .Replace("\n", IO.InnerNewlineReplace)
                    .Replace(IO.DateSeparator, IO.PlusReplace)
                    .Replace(IO.Tilde, IO.TildeReplace)
                    .Replace(IO.AssignSeparator, IO.EqualsReplace)
                : text.Replace(IO.Quotation, string.Empty)
                      .Replace(IO.QuotationReplace, IO.Quotation)
                      .Replace(IO.InnerNewlineReplace, Environment.NewLine)
                      .Replace(IO.PlusReplace, IO.DateSeparator)
                      .Replace(IO.TildeReplace, IO.Tilde)
                      .Replace(IO.EqualsReplace, IO.AssignSeparator);
        }

        #endregion HELPERS
    }
}
