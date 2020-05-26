using FileOperations.Constants;
using System;
using System.IO;
using System.Linq;

namespace FileOperations.Implementations
{
    public static class AllIO
    {
        public static (string Events, string Messages) ImportChanges(string path = null)
        {
            string content = File.ReadAllText(string.IsNullOrEmpty(path) ? AllIOConsts.DefaultPath : path);
            (int[] Event, int[] Message) = FileType.RankFileTypes(content);

            int eventLength = Event[0] > -1 ?
                Event[1] + (Environment.NewLine + IO.Tildes + Environment.NewLine).Length : Event[0];
            int messageLength = Message[0] > -1 ?
                Message[1] + (Environment.NewLine + IO.Tildes + Environment.NewLine).Length : Message[0];

            string events = string.Empty;
            string messages = string.Empty;

            if (Event[0] > Message[0])
            {
                if (messageLength > -1 && eventLength > -1)
                    messages = content.Substring(messageLength, Math.Abs(Event[0] - eventLength));

                events = content.Substring(eventLength);
            }
            else if (Message[0] > Event[0])
            {
                if (eventLength > -1 && messageLength > -1)
                    events = content.Substring(eventLength, Math.Abs(Message[0] - messageLength));

                messages = content.Substring(Message[0] + messageLength);
            }

            return (Events: events, Messages: messages);
        }

        public static void BackupChanges(string content, FileTypes fileType)
        {
            string eventFileTypeString =
                    FileType.GetFileTypeString(FileTypes.EVENT) + Environment.NewLine + IO.Tildes + Environment.NewLine;
            string messageFileTypeString =
                    FileType.GetFileTypeString(FileTypes.MESSAGE) + Environment.NewLine + IO.Tildes + Environment.NewLine;

            (string Events, string Messages) = ImportChanges(AllIOConsts.DefaultPath);

            string combinedContent = fileType == FileTypes.EVENT ?
                eventFileTypeString + content + messageFileTypeString + Messages
                : eventFileTypeString + Events + Environment.NewLine + messageFileTypeString + content;

            File.WriteAllText(AllIOConsts.DefaultPath, combinedContent);
        }

        public static void ExportSingle(string path, FileTypes fileType)
        {
            string eventFileTypeString =
                    FileType.GetFileTypeString(FileTypes.EVENT) + Environment.NewLine + IO.Tildes + Environment.NewLine;
            string messageFileTypeString =
                    FileType.GetFileTypeString(FileTypes.MESSAGE) + Environment.NewLine + IO.Tildes + Environment.NewLine;

            string exportName = fileType == FileTypes.EVENT ? EIOConsts.DefaultFileName : MIOConsts.DefaultFileName;

            (string Events, string Messages) = ImportChanges(AllIOConsts.DefaultPath);
            string combinedContent = fileType == FileTypes.EVENT ? eventFileTypeString + Events : messageFileTypeString + Messages;

            DateTime date = DateTime.Now;
            string realPath = path + "//" + string.Format(exportName, date.ToString("(MM-dd-yy-hh-mm-ss)"));
            File.WriteAllText(realPath, combinedContent);
        }

        public static void ExportAll(string path)
        {
            string eventFileTypeString =
                    FileType.GetFileTypeString(FileTypes.EVENT) + Environment.NewLine + IO.Tildes + Environment.NewLine;
            string messageFileTypeString =
                    FileType.GetFileTypeString(FileTypes.MESSAGE) + Environment.NewLine + IO.Tildes + Environment.NewLine;

            (string Events, string Messages) = ImportChanges(AllIOConsts.DefaultPath);
            string combinedContent = eventFileTypeString + Events + Environment.NewLine + messageFileTypeString + Messages;

            DateTime date = DateTime.Now;
            string realPath = path + "//" + string.Format(AllIOConsts.DefaultFileName, date.ToString("(MM-dd-yy-hh-mm-ss)"));
            File.WriteAllText(realPath, combinedContent);
        }
    }
}
