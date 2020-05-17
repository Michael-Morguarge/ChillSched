using Shared.Global;
using Shared.Model;
using System;

namespace FileOperations.Constants
{
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

    /// <summary>
    /// Message IO Constants
    /// </summary>
    public static class MIOConts
    {
        public const string Id = "Id";
        public const string Title = "Title";
        public const string Quote = "Quote";
        public const string Author = "Author";
        public const string Source = "Source";
        public const string Show = "Show";
        public const string DateCreated = "DateCreated";
        public const string DateLastDisplayed = "DateLastDisplayed";

#if DEBUG
        public const string DefaultImportPath = "..\\..\\Resources\\Messages\\MessageTestDebug.saved";
        public const string DefaultExportPath = "..\\..\\Resources\\Messages\\MessageResultDebug.saved";
#else
        public const string DefaultImportPath = ".\\Resources\\Messages\\MessageLog.saved";
        public const string DefaultExportPath = ".\\Resources\\Messages\\MessageLog.saved";
#endif
    }

    /// <summary>
    /// Event IO Constants
    /// </summary>
    public static class EIOConstants
    {
        public const string Id = "Id";
        public const string Title = "Title";
        public const string Comment = "Comment";
        public const string Completed = "Completed";
        public const string DateCreated = "DateCreated";
        public const string DateCompleted = "DateCompleted";
        public const string ActivationDate = "ActivationDate";
        public const string DeactivationDate = "DeactivationDate";

#if DEBUG
        public const string DefaultImportPath = "..\\..\\Resources\\Events\\EventTestDebug.saved";
        public const string DefaultExportPath = "..\\..\\Resources\\Events\\EventResultDebug.saved";
#else
        private const string DefaultImportPath = ".\\Resources\\Events\\EventLog.saved";
        private const string DefaultExportPath = ".\\Resources\\Events\\EventLog.saved";
#endif
    }
}
