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
        /// Implements <see cref="IFileOperations{AppMessage}.ConvertData(List{AppMessage})" />
        /// </summary>
        public string ConvertData(List<AppMessage> items)
        {
            return ConvertToData(items);
        }

        /// <summary>
        /// Implements <see cref="IFileOperations{AppMessage}.Parse(string)" />
        /// </summary>
        public List<AppMessage> Parse(string content)
        {
            List<AppMessage> messages = new List<AppMessage>();
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
        /// Implements <see cref="IFileOperations{AppMessage}.Save(List{ApMessage}, string)" />
        /// </summary>
        public void Save(List<AppMessage> messages, string path = null)
        {
            try
            {
                FullySaved = true;
                string messageString = ConvertToData(messages);

                AllIO.BackupChanges(messageString, FileTypes.MESSAGE);
            }
            catch (Exception)
            {
                FullySaved = false;
            }
        }

        #region HELPERS

        private string ConvertToData(List<AppMessage> messages)
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
                    string ENL = Environment.NewLine;

                    messageString +=
                        $"{MIOConsts.Id}{IO.EqSign}{IO.Quotes}{message.Id}{IO.Quotes}{ENL}" +
                        $"{MIOConsts.Title}{IO.EqSign}{IO.Quotes}{title}{IO.Quotes}{ENL}" +
                        $"{MIOConsts.Quote}{IO.EqSign}{IO.Quotes}{quote}{IO.Quotes}{ENL}" +
                        $"{MIOConsts.Author}{IO.EqSign}{IO.Quotes}{author}{IO.Quotes}{ENL}" +
                        $"{MIOConsts.Source}{IO.EqSign}{IO.Quotes}{source}{IO.Quotes}{ENL}" +
                        $"{MIOConsts.Show}{IO.EqSign}{IO.Quotes}{show}{IO.Quotes}{ENL}" +
                        $"{MIOConsts.DateCreated}{IO.EqSign}{IO.Quotes}{created}{IO.Quotes}{ENL}" +
                        $"{MIOConsts.DateLastDisplayed}{IO.EqSign}{IO.Quotes}{lastDisplayed}{IO.Quotes}{ENL}" +
                        $"{IO.Tildes}{ENL}";
                }
                catch (Exception)
                {
                    FullySaved = false;
                }
            }

            return messageString;
        }

        private AppMessage CreateMessageFromLoadedData(List<KeyValuePair<string, string>> data)
        {
            string id = IO.TestId(data.Single(x => x.Key == MIOConsts.Id).Value.Replace(IO.Quotes, string.Empty));

            string title = IO.FormatText(IO.TestText(data.Single(x => x.Key == MIOConsts.Title).Value));
            string quote = IO.FormatRichText(IO.TestText(data.Single(x => x.Key == MIOConsts.Quote).Value));
            string author = IO.FormatText(IO.TestText(data.Single(x => x.Key == MIOConsts.Author).Value));
            string source = IO.FormatText(IO.TestText(data.Single(x => x.Key == MIOConsts.Source).Value));

            bool show = IO.TestBoolean(data.Single(x => x.Key == MIOConsts.Show).Value);

            (Date Date, Time Time) created_date_time = IO.TestDate(data.Single(x => x.Key == MIOConsts.DateCreated).Value);
            (Date Date, Time Time) lastDisplayed_date_time = IO.TestDate(data.Single(x => x.Key == MIOConsts.DateLastDisplayed).Value);

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
