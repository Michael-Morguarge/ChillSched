using FileOperations.Models;
using Shared.Global;
using Shared.Model;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;

namespace FileOperations.Constants
{
    /// <summary>
    /// File type enum
    /// </summary>
    public enum FileTypes
    {
        ALL, EVENT, MESSAGE
    }

    public static class FileType
    {
        private const string MessageFileType = "MESSAGES";
        private const string EventFileType = "EVENTS";

        private const string FileTypeFormat = "[FileType=\"{0}\"]";

        public static bool IsValidFileType(string fileType, FileTypes type)
        {
            bool isValid = false;
            string fileTypeExpected =
                type == FileTypes.EVENT ? EventFileType :
                    type == FileTypes.MESSAGE ? MessageFileType : null;

            if (fileTypeExpected != null && fileType == string.Format(FileTypeFormat, fileTypeExpected))
                isValid = true;

            return isValid;
        }

        public static string GetFileTypeString(FileTypes type)
        {
            string result = null;
            string fileTypeExpected =
                type == FileTypes.EVENT ? EventFileType :
                    type == FileTypes.MESSAGE ? MessageFileType : null;

            if (fileTypeExpected != null)
                result = string.Format(FileTypeFormat, fileTypeExpected);

            return result;
        }

        public static (int[] EventHeader, int[] MessageHeader) RankFileTypes(string content)
        {
            string @event = GetFileTypeString(FileTypes.EVENT);
            string message = GetFileTypeString(FileTypes.MESSAGE);

            int eventTypeIndex = content.IndexOf(GetFileTypeString(FileTypes.EVENT));
            int messageTypeIndex = content.IndexOf(GetFileTypeString(FileTypes.MESSAGE));

            return 
                (EventHeader: new int[] { eventTypeIndex, @event.Length },
                MessageHeader: new int[] { messageTypeIndex, message.Length });
        }
    }

    /// <summary>
    /// IO constants
    /// </summary>
    public static class IO
    {
        public const string PlusSign = "+";
        public const string EqSign = "=";
        public const string Tildes = "~~~";
        public const string Quotes = "\"";
        public const string Tilde = "~";

        public const string TildeReplace = "{TILDE}";
        public const string PlusReplace = "{PLUS}";
        public const string InnerNewlineReplace = "{INNERNEWLINE}";
        public const string QuotationReplace = "{D_QUOTE}";
        public const string EqualsReplace = "{EQ_SIGN}";

        public static Data<string, string> ParseContent(string content)
        {
            Data<string, string> data = new Data<string, string>
            {
                TempDataStore =
                    content.Split(new[] { IO.Tildes }, StringSplitOptions.RemoveEmptyEntries)
                           .Select(x =>
                               x.Split(new[] { Environment.NewLine }, StringSplitOptions.RemoveEmptyEntries)
                                .Select(y =>
                                   y.Split(new[] { IO.EqSign }, StringSplitOptions.None))
                                    .Select(a => new KeyValuePair<string, string>(a[0], a.ElementAtOrDefault(1) ?? string.Empty))
                                .ToList())
                           .Where(x => x.Any())
                           .ToList()
            };

            return data;
        }

        public static string FormatText(string text, bool isExport = false)
        {
            return isExport ?
                text.Replace(Quotes, QuotationReplace)
                    .Replace(PlusSign, PlusReplace)
                    .Replace(Tilde, TildeReplace)
                    .Replace(EqSign, EqualsReplace)
                : text.Replace(Quotes, string.Empty)
                      .Replace(QuotationReplace, Quotes)
                      .Replace(PlusReplace, PlusSign)
                      .Replace(TildeReplace, Tilde)
                      .Replace(EqualsReplace, EqSign);
        }

        public static string FormatRichText(string text, bool isExport = false)
        {
            return isExport ?
                text.Replace(Quotes, QuotationReplace)
                    .Replace(PlusSign, PlusReplace)
                    .Replace(Environment.NewLine, InnerNewlineReplace)
                    .Replace("\n", InnerNewlineReplace)
                    .Replace(Tilde, TildeReplace)
                    .Replace(EqSign, EqualsReplace)
                : text.Replace(Quotes, string.Empty)
                      .Replace(QuotationReplace, Quotes)
                      .Replace(InnerNewlineReplace, Environment.NewLine)
                      .Replace(PlusReplace, PlusSign)
                      .Replace(TildeReplace, Tilde)
                      .Replace(EqualsReplace, EqSign);
        }

        public static string FormatDate(Date date, Time time)
        {
            return $"{TimeAndDateUtility.ConvertDate_String(date)}{PlusSign}{TimeAndDateUtility.ConvertTime_String(time)}";
        }

        public static string TestId(string id)
        {
            Guid testGuid;

            if (string.IsNullOrEmpty(id))
                throw new Exception("Missing data for id");
            else if (!Guid.TryParse(id, out testGuid))
                throw new Exception("Invalid data for id");

            return testGuid.ToString();
        }

        public static string TestText(string text)
        {
            if (string.IsNullOrEmpty(text))
                throw new Exception("Missing data for Title");

            return text;
        }

        public static (Date Date, Time Time) TestDate(string dateAndTime)
        {
            string[] date_time =
                dateAndTime.Replace(Quotes, string.Empty)
                           .Split(new[] { PlusSign }, StringSplitOptions.RemoveEmptyEntries);
            bool containsBoth =
                date_time.Length == 2 && !string.IsNullOrEmpty(date_time[0]) && !string.IsNullOrEmpty(date_time[1]);
            bool containsNone = date_time.Length == 0;

            if (!containsBoth && !containsNone)
                throw new Exception("Missing data for Dates");
            else if (containsBoth && !DateTime.TryParse($"{date_time[0]} {date_time[1]}", out DateTime testDate))
                throw new Exception("Invalid data for Dates");

            Date date = null;
            Time time = null;

            if (containsBoth)
            {
                date = TimeAndDateUtility.ConvertString_Date(date_time[0]);
                time = TimeAndDateUtility.ConvertString_Time(date_time[1]);
            }

            return (date, time);
        }

        public static bool TestBoolean(string boolean)
        {
            if (!bool.TryParse(boolean.Replace(Quotes, string.Empty), out bool testBool))
                throw new Exception("Invalid data for Boolean");

            return testBool;
        }
    }

    public static class BackupIOConsts
    {
#if DEBUG
        private const string DefaultExportPath = "..\\..\\Resources\\All\\Backup_{0}.saved";
#else
        private const string DefaultExportPath = ".\\Resources\\All\\Backup_{0}.saved";
#endif

        public static void ArchiveOldAll()
        {
            string backup = File.ReadAllText(AllIOConsts.DefaultPath);
            DateTime date = DateTime.Now;
            File.WriteAllText(string.Format(DefaultExportPath, date.ToString("(MM-dd-yy-hh-mm-ss)")), backup);
        }
    }

    public static class AllIOConsts
    {
#if DEBUG
        public const string DefaultPath = "..\\..\\Resources\\All\\AllTest.saved";
#else
        public const string DefaultPath = ".\\Resources\\All\\AllLog.saved";
#endif

        public const string DefaultFileName = "Export_All_{0}.saved";
    }

    /// <summary>
    /// Message IO Constants
    /// </summary>
    public static class MIOConsts
    {
        public const string Id = "Id";
        public const string Title = "Title";
        public const string Quote = "Quote";
        public const string Author = "Author";
        public const string Source = "Source";
        public const string Show = "Show";
        public const string DateCreated = "DateCreated";
        public const string DateLastDisplayed = "DateLastDisplayed";

        public const string DefaultFileName = "Export_Messages_{0}.saved";
    }

    /// <summary>
    /// Event IO Constants
    /// </summary>
    public static class EIOConsts
    {
        public const string Id = "Id";
        public const string Title = "Title";
        public const string Comment = "Comment";
        public const string Completed = "Completed";
        public const string DateCreated = "DateCreated";
        public const string DateCompleted = "DateCompleted";
        public const string ActivationDate = "ActivationDate";
        public const string DeactivationDate = "DeactivationDate";

        public const string DefaultFileName = "Export_Events_{0}.saved";
    }
}
