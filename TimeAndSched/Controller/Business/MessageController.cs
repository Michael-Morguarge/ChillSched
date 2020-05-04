using Backend.Implementations;
using Backend.Inferfaces;
using BackEnd.Model;
using Shared.Global;
using System.Collections.Generic;

namespace FrontEnd.Controller.Business
{
    /// <summary>
    /// Controller for Message
    /// </summary>
    public class MessageController
    {
        private readonly IMessageRepository _messageRepo;

        /// <summary>
        /// Consructor for the MessageController
        /// </summary>
        public MessageController()
        {
            _messageRepo = new MessageRepository();
        }

        /// <summary>
        /// Gets the message based on the id
        /// </summary>
        /// <param name="id">The message id</param>
        /// <returns>The message</returns>
        public Message GetMessage(string id)
        {
            return _messageRepo.GetMessage(id);
        }

        /// <summary>
        /// Gets the messages based on the search term
        /// </summary>
        /// <param name="searchTerm">The term to filter with</param>
        /// <returns>Filtered list of messages</returns>
        public IEnumerable<Message> GetMessages(string searchTerm)
        {
            return _messageRepo.GetMessages(searchTerm);
        }

        /// <summary>
        /// Gets the all the messages
        /// </summary>
        /// <returns>The list of messages</returns>
        public IEnumerable<Message> GetMessages()
        {
            return _messageRepo.GetMessages();
        }

        /// <summary>
        /// Creates a messaage
        /// </summary>
        /// <param name="message">The message to create</param>
        /// <returns>Whether the message was created</returns>
        public bool CreateMessage(Message message)
        {
            message.DateCreated = TimeAndDateUtility.GetCurrentDate();
            message.TimeCreated = TimeAndDateUtility.GetCurrentTime();

            return _messageRepo.AddMessage(message);
        }

        /// <summary>
        /// Update an event
        /// </summary>
        /// <param name="message">The message to update</param>
        /// <returns>Whether the message was updated</returns>
        public bool EditMessage(Message message)
        {
            return _messageRepo.UpdateMessage(message);
        }

        /// <summary>
        /// Deletes a message
        /// </summary>
        /// <param name="id">The id of the message to delete</param>
        /// <returns>Whether the message was deleted</returns>
        public bool RemoveMessage(string id)
        {
            return _messageRepo.DeleteMessage(id);
        }

        /// <summary>
        /// Toggles the display for a message
        /// </summary>
        /// <param name="id">The message to toggle</param>
        /// <returns>Whether the message was updated</returns>
        public bool ToggleShow(string id)
        {
            Message message = GetMessage(id);

            if (message == null)
                return false;

            if (message.Show)
                message.Show = false;
            else
                message.Show = true;

            return _messageRepo.UpdateMessage(message);
        }
    }
}
