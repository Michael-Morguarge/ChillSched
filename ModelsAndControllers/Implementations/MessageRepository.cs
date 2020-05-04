using Backend.Inferfaces;
using BackEnd.Model;
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
        private readonly List<Message> Messages;

        /// <summary>
        /// Constructor for the Message Repository
        /// </summary>
        public MessageRepository()
        {
            Messages = new List<Message>();
        }

        /// <summary>
        /// Implements <see cref="IMessageRepository.AddMessage(Message)" />
        /// </summary>
        public bool AddMessage(Message toAdd)
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
                    Message existingMessage = Messages.SingleOrDefault(x => x.Id == id);

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
        public Message GetMessage(string id)
        {
            Message message = null;

            if (!string.IsNullOrEmpty(id))
            {
                message = Messages.SingleOrDefault(x => x.Id == id);
            }

            return message;
        }

        /// <summary>
        /// Implements <see cref="IMessageRepository.GetMessages()" />
        /// </summary>
        public IEnumerable<Message> GetMessages()
        {
            return Messages.AsReadOnly();
        }

        /// <summary>
        /// Implements <see cref="IMessageRepository.GetMessages(string)" />
        /// </summary>
        public IEnumerable<Message> GetMessages(string searchTerm)
        {
            IEnumerable<Message> messages = new List<Message>();

            if (!string.IsNullOrEmpty(searchTerm))
            {
                messages =
                    Messages.Where(x =>
                        x.Author.Contains(searchTerm)
                        || x.Quote.Contains(searchTerm)
                        || x.Source.Contains(searchTerm)
                    );
            }

            return messages;
        }

        /// <summary>
        /// Implements <see cref="IMessageRepository.LoadMessages()" />
        /// </summary>
        public bool LoadMessages()
        {
            throw new System.NotImplementedException();
        }

        /// <summary>
        /// Implements <see cref="IMessageRepository.SaveMessages()" />
        /// </summary>
        public void SaveMessages()
        {
            throw new System.NotImplementedException();
        }

        /// <summary>
        /// Implements <see cref="IMessageRepository.UpdateMessage(Message)" />
        /// </summary>
        public bool UpdateMessage(Message toUpdate)
        {
            bool updated = false;

            try
            {
                if (toUpdate == null)
                {
                    updated = false;
                }
                else
                {
                    Message message = Messages.SingleOrDefault(x => x.Id == toUpdate.Id);

                    if (message != null)
                    {
                        message.Quote = toUpdate.Quote;
                        message.Author = toUpdate.Author;
                        message.Source = toUpdate.Source;
                        message.Show = toUpdate.Show;

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