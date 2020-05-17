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
    /// File operations for Messages
    /// </summary>
    public class MessageIO : IFileOperations<AppMessage>
    {
        /// <summary>
        /// Whether the data was fully loaded
        /// </summary>
        public bool FullyLoaded { get; private set; } = true;

        /// <summary>
        /// Whether the data was fully saved
        /// </summary>
        public bool FullySaved { get; private set; } = true;

        /// <summary>
        /// Implements <see cref="IFileOperations{SavedEvent}.Load(string)" />
        /// </summary>
        public List<AppMessage> Load(string path = null)
        {
            List<AppMessage> messages = new List<AppMessage>();

            try
            {
                Data<string, string> data = new Data<string, string>();
                string content = File.ReadAllText(string.IsNullOrEmpty(path) ?  MIOConts.DefaultImportPath : path);

                if (!string.IsNullOrEmpty(content) && messages != null)
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
                            AppMessage item = CreateMessageFromLoadedData(subData);
                            messages.Add(item);
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

            return messages;
        }

        /// <summary>
        /// Implements <see cref="IFileOperations{SavedEvent}.Save(List{SavedEvent}, string)" />
        /// </summary>
        public void Save(List<AppMessage> messages, string path = null)
        {
            try
            {
                string messageString = string.Empty;

                foreach (AppMessage message in messages)
                {
                    try
                    {
                        string show = message.Show ? "True" : "False";
                        string created = IO.FormatDate(message.DateCreated, message.TimeCreated);
                        string lastDisplayed = IO.FormatDate(message.LastDateDisplayed, message.LastTimeDisplayed);
                        string title = IO.FormatText(message.Title, true);
                        string quote = IO.FormatRichText(message.Quote, true);
                        string author = IO.FormatText(message.Author, true);
                        string source = IO.FormatText(message.Source, true);

                        messageString +=
                            $"{MIOConts.Id}{IO.EqSign}{IO.Quotes}{message.Id}{IO.Quotes}{Environment.NewLine}" +
                            $"{MIOConts.Title}{IO.EqSign}{IO.Quotes}{title}{IO.Quotes}{Environment.NewLine}" +
                            $"{MIOConts.Quote}{IO.EqSign}{IO.Quotes}{quote}{IO.Quotes}{Environment.NewLine}" +
                            $"{MIOConts.Author}{IO.EqSign}{IO.Quotes}{author}{IO.Quotes}{Environment.NewLine}" +
                            $"{MIOConts.Source}{IO.EqSign}{IO.Quotes}{source}{IO.Quotes}{Environment.NewLine}" +
                            $"{MIOConts.Show}{IO.EqSign}{IO.Quotes}{show}{IO.Quotes}{Environment.NewLine}" +
                            $"{MIOConts.DateCreated}{IO.EqSign}{IO.Quotes}{created}{IO.Quotes}{Environment.NewLine}" +
                            $"{MIOConts.DateLastDisplayed}{IO.EqSign}{IO.Quotes}{lastDisplayed}{IO.Quotes}{Environment.NewLine}" +
                            $"{IO.Tildes}{Environment.NewLine}";
                    }
                    catch (Exception)
                    {
                        FullySaved = false;
                    }
                }

                File.WriteAllText(string.IsNullOrEmpty(path) ? MIOConts.DefaultExportPath : path, messageString);
            }
            catch (Exception)
            {
                FullySaved = false;
            }
        }

        #region HELPERS

        private AppMessage CreateMessageFromLoadedData(List<KeyValuePair<string, string>> data)
        {
            string id = IO.TestId(data.Single(x => x.Key == MIOConts.Id).Value.Replace(IO.Quotes, string.Empty));

            string title = IO.FormatText(IO.TestText(data.Single(x => x.Key == MIOConts.Title).Value));
            string quote = IO.FormatRichText(IO.TestText(data.Single(x => x.Key == MIOConts.Quote).Value));
            string author = IO.FormatText(IO.TestText(data.Single(x => x.Key == MIOConts.Author).Value));
            string source = IO.FormatText(IO.TestText(data.Single(x => x.Key == MIOConts.Source).Value));

            bool show = IO.TestBoolean(data.Single(x => x.Key == MIOConts.Show).Value);

            (Date Date, Time Time) created_date_time = IO.TestDate(data.Single(x => x.Key == MIOConts.DateCreated).Value);
            (Date Date, Time Time) lastDisplayed_date_time = IO.TestDate(data.Single(x => x.Key == MIOConts.DateLastDisplayed).Value);

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

        #endregion HELPERS
    }
}
