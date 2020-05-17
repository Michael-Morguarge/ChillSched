using Backend.Inferfaces;
using Backend.Model;
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
        private readonly List<AppMessage> Messages;
        private readonly MessageIO io;

        /// <summary>
        /// Constructor for the Message Repository
        /// </summary>
        public MessageRepository()
        {
            Messages = new List<AppMessage>();
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
        /// Implements <see cref="IMessageRepository.LoadMessages(bool)" />
        /// </summary>
        public bool LoadMessages(bool overwrite = false)
        {
            if (overwrite)
            {
                Messages.Clear();
                Messages.AddRange(io.Load());
            }
            else
            {
                List<AppMessage> messages = io.Load();
                List<AppMessage> filtered = messages.Where(x => !Messages.Any(y => y.Id == x.Id)).ToList();
                Messages.AddRange(filtered);
            }

            return true;
        }

        /// <summary>
        /// Implements <see cref="IMessageRepository.LoadMessages(string, bool)" />
        /// </summary>
        public bool LoadMessages(string path, bool overwrite = false)
        {
            if (overwrite)
            {
                Messages.Clear();
                Messages.AddRange(io.Load(path));
            }
            else
            {
                List<AppMessage> messages = io.Load(path);
                List<AppMessage> filtered = messages.Where(x => !Messages.Any(y => y.Id == x.Id)).ToList();
                Messages.AddRange(filtered);
            }

            return io.FullyLoaded;
        }

        /// <summary>
        /// Implements <see cref="IMessageRepository.SaveMessages()" />
        /// </summary>
        public bool SaveMessages()
        {
            io.Save(Messages);

            return io.FullySaved;
        }

        /// <summary>
        /// Implements <see cref="IMessageRepository.SaveMessages(string)" />
        /// </summary>
        public bool SaveMessages(string path)
        {
            io.Save(Messages, path);

            return io.FullySaved;
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