using Backend.Inferfaces;
using Backend.Model;
using Shared.Global;
using Shared.Model;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;

namespace Backend.Implementations
{
    /// <summary>
    /// Class for the Message Repository
    /// </summary>
    public class MessageRepository : IMessageRepository
    {
        private readonly List<AppMessage> Messages;

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

        /// <summary>
        /// Constructor for the Message Repository
        /// </summary>
        public MessageRepository()
        {
            Messages = new List<AppMessage>();
        }

        /// <summary>
        /// Implements <see cref="IMessageRepository.AddMessage(AppMessage)" />
        /// </summary>
        public bool AddMessage(AppMessage toAdd)
        {
            bool added = false;

            if (toAdd != null)
            {
                Messages.Add(toAdd);
                added = true;
            }

            return added;
        }

        /// <summary>
        /// Implements <see cref="IMessageRepository.DeleteMessage(string)" />
        /// </summary>
        public bool DeleteMessage(string id)
        {
            bool deleted = false;

            try
            {
                if (!string.IsNullOrEmpty(id))
                {
                    AppMessage existingMessage = Messages.SingleOrDefault(x => x.Id == id);

                    if (existingMessage == null)
                        throw new Exception();

                    deleted = Messages.Remove(existingMessage);
                }
            }
            catch(Exception)
            {
                deleted = false;
            }

            return deleted;
        }

        /// <summary>
        /// Implements <see cref="IMessageRepository.GetMessage(string)" />
        /// </summary>
        public AppMessage GetMessage(string id)
        {
            AppMessage message = null;

            if (!string.IsNullOrEmpty(id))
            {
                message = Messages.SingleOrDefault(x => x.Id == id);
            }

            return message;
        }

        /// <summary>
        /// Implements <see cref="IMessageRepository.GetMessages()" />
        /// </summary>
        public IEnumerable<AppMessage> GetMessages()
        {
            return Messages.AsReadOnly();
        }

        /// <summary>
        /// Implements <see cref="IMessageRepository.GetMessages(string)" />
        /// </summary>
        public IEnumerable<AppMessage> GetMessages(string searchTerm)
        {
            IEnumerable<AppMessage> messages = new List<AppMessage>();

            if (!string.IsNullOrEmpty(searchTerm))
            {
                string loweredString = searchTerm.ToLower();
                messages =
                    Messages.Where(x =>
                        x.Title.Contains(loweredString)
                        || x.Author.ToLower().Contains(loweredString)
                        || x.Quote.ToLower().Contains(loweredString)
                        || x.Source.ToLower().Contains(loweredString)
                    );
            }

            return messages;
        }

        /// <summary>
        /// Implements <see cref="IMessageRepository.LoadMessages()" />
        /// </summary>
        public bool LoadMessages()
        {
            bool loaded = false;

            try
            {
#if DEBUG
                string content = File.ReadAllText("..\\..\\Resources\\Messages\\MessageTestDebug.saved");
#else
                string content = File.ReadAllText(".\\Resources\\Messages\\MessageLog.saved");
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

                    foreach (List<KeyValuePair<string, string>> data in dataArray)
                    {
                        AppMessage item = CreateMessageFromLoadedData(data);
                        Messages.Add(item);
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

        private AppMessage CreateMessageFromLoadedData(List<KeyValuePair<string, string>> data)
        {
            string id = data.Single(x => x.Key == "Id").Value.Replace(Quotation, string.Empty);
            string title = FormatText(data.Single(x => x.Key == "Title").Value);
            string quote = FormatRichText(data.Single(x => x.Key == "Quote").Value);
            string author = FormatText(data.Single(x => x.Key == "Author").Value);
            string source = FormatText(data.Single(x => x.Key == "Source").Value);

            bool show = bool.Parse(data.Single(x => x.Key == "Show").Value.Replace(Quotation, string.Empty));

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
                dateAndTime.Replace(Quotation, string.Empty)
                           .Split(new[] { DateSeparator }, StringSplitOptions.RemoveEmptyEntries);
            bool containsBoth = date_time.Length == 2;
            Date date = containsBoth ? TimeAndDateUtility.ConvertString_Date(date_time[0]) : null;
            Time time = containsBoth ? TimeAndDateUtility.ConvertString_Time(date_time[1]) : null;

            return (date, time);
        }

        /// <summary>
        /// Implements <see cref="IMessageRepository.SaveMessages()" />
        /// </summary>
        public void SaveMessages()
        {
            string messageString = string.Empty;

            foreach (AppMessage message in Messages)
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

#if DEBUG
            File.WriteAllText("..\\..\\Resources\\Messages\\MessageResultDebug.saved", messageString);
#else
            File.WriteAllText(".\\Resources\\Messages\\MessageLog.saved", messageString);
#endif
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

        /// <summary>
        /// Implements <see cref="IMessageRepository.UpdateMessage(AppMessage)" />
        /// </summary>
        public bool UpdateMessage(AppMessage toUpdate)
        {
            bool updated = false;

            try
            {
                if (toUpdate != null)
                {
                    AppMessage message = Messages.SingleOrDefault(x => x.Id == toUpdate.Id);

                    if (message != null)
                    {
                        message.Title = toUpdate.Title;
                        message.Quote = toUpdate.Quote;
                        message.Author = toUpdate.Author;
                        message.Source = toUpdate.Source;
                        message.Show = toUpdate.Show;
                        message.LastDateDisplayed = toUpdate.LastDateDisplayed;
                        message.LastTimeDisplayed = toUpdate.LastTimeDisplayed;

                        updated = true;
                    }
                }
            }
            catch (Exception)
            {
                updated = false;
            }

            return updated;
        }
    }
}