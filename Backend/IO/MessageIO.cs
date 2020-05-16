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
    /// File operations for Messages
    /// </summary>
    public class MessageIO : IFileOperations<AppMessage>
    {
#if DEBUG
        private const string DefaultImportPath = "..\\..\\Resources\\Messages\\MessageTestDebug.saved";
        private const string DefaultExportPath = "..\\..\\Resources\\Messages\\MessageResultDebug.saved";
#else
        private const string DefaultImportPath = ".\\Resources\\Messages\\MessageLog.saved";
        private const string DefaultExportPath = ".\\Resources\\Messages\\MessageLog.saved";
#endif
        /// <summary>
        /// Implements <see cref="IFileOperations{SavedEvent}.Load(string)" />
        /// </summary>
        public List<AppMessage> Load(string path = null)
        {
            List<AppMessage> messages = new List<AppMessage>();

            try
            {
                Data<string, string> data = new Data<string, string>();
                string content = File.ReadAllText(string.IsNullOrEmpty(path) ? DefaultImportPath : path);

                if (!string.IsNullOrEmpty(content) && messages != null)
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
                        AppMessage item = CreateMessageFromLoadedData(subData);
                        messages.Add(item);
                    }
                }
            }
            catch (Exception)
            {
                //Something happened
            }

            return messages;
        }

        /// <summary>
        /// Implements <see cref="IFileOperations{SavedEvent}.Save(List{SavedEvent}, string)" />
        /// </summary>
        public void Save(List<AppMessage> messages, string path = null)
        {
            string messageString = string.Empty;

            foreach (AppMessage message in messages)
            {
                string show = message.Show ? "True" : "False";
                string created = FormatDate(message.DateCreated, message.TimeCreated);
                string lastDisplayed = FormatDate(message.LastDateDisplayed, message.LastTimeDisplayed);
                string title = FormatText(message.Title, true);
                string quote = FormatRichText(message.Quote, true);
                string author = FormatText(message.Author, true);
                string source = FormatText(message.Source, true);

                messageString +=
                    $"Id=\"{message.Id}\"{Environment.NewLine}" +
                    $"Title=\"{title}\"{Environment.NewLine}" +
                    $"Quote=\"{quote}\"{Environment.NewLine}" +
                    $"Author=\"{author}\"{Environment.NewLine}" +
                    $"Source=\"{source}\"{Environment.NewLine}" +
                    $"Show=\"{show}\"{Environment.NewLine}" +
                    $"DateCreated=\"{created}\"{Environment.NewLine}" +
                    $"DateLastDisplayed=\"{lastDisplayed}\"{Environment.NewLine}" +
                    $"~~~{Environment.NewLine}";

                File.WriteAllText(string.IsNullOrEmpty(path) ? DefaultExportPath : path, messageString);
            }
        }

        #region HELPERS

        private AppMessage CreateMessageFromLoadedData(List<KeyValuePair<string, string>> data)
        {
            string id = data.Single(x => x.Key == "Id").Value.Replace(IO.Quotation, string.Empty);
            string title = FormatText(data.Single(x => x.Key == "Title").Value);
            string quote = FormatRichText(data.Single(x => x.Key == "Quote").Value);
            string author = FormatText(data.Single(x => x.Key == "Author").Value);
            string source = FormatText(data.Single(x => x.Key == "Source").Value);

            bool show = bool.Parse(data.Single(x => x.Key == "Show").Value.Replace(IO.Quotation, string.Empty));

            (Date Date, Time Time) created_date_time = GetDateAndTime(data.Single(x => x.Key == "DateCreated").Value);
            (Date Date, Time Time) lastDisplayed_date_time = GetDateAndTime(data.Single(x => x.Key == "DateLastDisplayed").Value);

            AppMessage message =
                new AppMessage
                {
                    Id = id,
                    Title = title,
                    Quote = quote,
                    Author = author,
                    Source = source,
                    Show = show,
                    DateCreated = created_date_time.Date,
                    TimeCreated = created_date_time.Time,
                    LastDateDisplayed = lastDisplayed_date_time.Date,
                    LastTimeDisplayed = lastDisplayed_date_time.Time
                };

            return message;
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
