using Backend.Inferfaces;
using Backend.Model;
using FileOperations.Constants;
using FileOperations.Implementations;
using System;
using System.Collections.Generic;
using System.Linq;

namespace Backend.Implementations
{
    /// <summary>
    /// Class for the Message Repository
    /// </summary>
    public class MessageRepository : IMessageRepository
    {
        private readonly List<AppMessage> AppMessages;
        private readonly MessageIO io;

        /// <summary>
        /// Constructor for the Message Repository
        /// </summary>
        public MessageRepository()
        {
            AppMessages = new List<AppMessage>();
            io = new MessageIO();
        }

        /// <summary>
        /// Implements <see cref="IMessageRepository.AddMessage(AppMessage)" />
        /// </summary>
        public bool AddMessage(AppMessage toAdd)
        {
            bool added = false;

            if (toAdd != null)
            {
                AppMessages.Add(toAdd);
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
                    AppMessage existingMessage = AppMessages.SingleOrDefault(x => x.Id == id);

                    if (existingMessage == null)
                        throw new Exception();

                    deleted = AppMessages.Remove(existingMessage);
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
                message = AppMessages.SingleOrDefault(x => x.Id == id);
            }

            return message;
        }

        /// <summary>
        /// Implements <see cref="IMessageRepository.GetMessages()" />
        /// </summary>
        public IEnumerable<AppMessage> GetMessages()
        {
            return AppMessages.AsReadOnly();
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
                    AppMessages.Where(x =>
                        x.Title.Contains(loweredString)
                        || x.Author.ToLower().Contains(loweredString)
                        || x.Quote.ToLower().Contains(loweredString)
                        || x.Source.ToLower().Contains(loweredString)
                    );
            }

            return messages;
        }

        /// <summary>
        /// Implements <see cref="IMessageRepository.LoadMessages(bool)" />
        /// </summary>
        public bool LoadMessages(bool overwrite = false)
        {
            (string Events, string Messages) = AllIO.ImportChanges();
            List<AppMessage> messages = io.Parse(Messages);
            List<AppMessage> filtered = overwrite ? messages : messages.Where(x => !AppMessages.Any(y => y.Id == x.Id)).ToList();

            if (overwrite)
                AppMessages.Clear();

            if (messages.Any())
                AppMessages.AddRange(filtered);

            return io.FullyLoaded;
        }

        /// <summary>
        /// Implements <see cref="IMessageRepository.LoadMessages(string, bool)" />
        /// </summary>
        public bool LoadMessages(string path, bool overwrite = false)
        {
            (string Events, string Messages) = AllIO.ImportChanges(path);
            List<AppMessage> messages = io.Parse(Messages);
            List<AppMessage> filtered = overwrite ? messages : messages.Where(x => !AppMessages.Any(y => y.Id == x.Id)).ToList();

            if (overwrite)
                AppMessages.Clear();

            if (messages.Any())
                AppMessages.AddRange(filtered);

            return io.FullyLoaded;
        }

        /// <summary>
        /// Implements <see cref="IMessageRepository.SaveMessages()" />
        /// </summary>
        public bool SaveMessages()
        {
            io.Save(AppMessages);

            return io.FullySaved;
        }

        /// <summary>
        /// Implements <see cref="IMessageRepository.SaveMessages(string)" />
        /// </summary>
        public bool SaveMessages(string path)
        {
            bool exported = true;

            try
            {
                AllIO.ExportSingle(path, FileTypes.MESSAGE);
            }
            catch (Exception)
            {
                exported = false;
            }

            return exported;
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
                    AppMessage message = AppMessages.SingleOrDefault(x => x.Id == toUpdate.Id);

                    if (message != null)
                    {
                        message.Title = toUpdate.Title;
                        message.Quote = toUpdate.Quote;
                        message.Author = toUpdate.Author;
                        message.Source = toUpdate.Source;
                        message.Show = toUpdate.Show;
                        message.LastDisplayedDate = toUpdate.LastDisplayedDate;

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