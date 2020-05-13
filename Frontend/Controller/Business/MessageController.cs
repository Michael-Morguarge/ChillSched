using Backend.Implementations;
using Backend.Inferfaces;
using Backend.Model;
using Shared.Global;
using System.Collections.Generic;

namespace Frontend.Controller.Business
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
        public AppMessage GetMessage(string id)
        {
            return _messageRepo.GetMessage(id);
        }

        /// <summary>
        /// Gets the messages based on the search term
        /// </summary>
        /// <param name="searchTerm">The term to filter with</param>
        /// <returns>Filtered list of messages</returns>
        public IEnumerable<AppMessage> GetMessages(string searchTerm)
        {
            return _messageRepo.GetMessages(searchTerm);
        }

        /// <summary>
        /// Gets the all the messages
        /// </summary>
        /// <returns>The list of messages</returns>
        public IEnumerable<AppMessage> GetMessages()
        {
            return _messageRepo.GetMessages();
        }

        /// <summary>
        /// Creates a messaage
        /// </summary>
        /// <param name="message">The message to create</param>
        /// <returns>Whether the message was created</returns>
        public bool CreateMessage(AppMessage message)
        {
            if (message != null)
            {
                message.DateCreated = TimeAndDateUtility.GetCurrentDate();
                message.TimeCreated = TimeAndDateUtility.GetCurrentTime();
            }

            bool added = _messageRepo.AddMessage(message);

            return added;
        }

        /// <summary>
        /// Update an event
        /// </summary>
        /// <param name="message">The message to update</param>
        /// <returns>Whether the message was updated</returns>
        public bool EditMessage(AppMessage message)
        {
            bool updated = _messageRepo.UpdateMessage(message);

            return updated;
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
            AppMessage message = GetMessage(id);

            if (message != null)
            {
                message.Show = !message.Show;
            }

            bool updated = _messageRepo.UpdateMessage(message);

            return updated;
        }
    }
}
