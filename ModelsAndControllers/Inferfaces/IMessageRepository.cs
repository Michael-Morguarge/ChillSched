using BackEnd.Model;
using System.Collections.Generic;

namespace Backend.Inferfaces
{
    /// <summary>
    /// Interface for MessageRepository
    /// </summary>
    public interface IMessageRepository
    {
        /// <summary>
        /// Adds the message
        /// </summary>
        /// <param name="toAdd">The message to add</param>
        /// <returns>Whether the message was added</returns>
        bool AddMessage(AppMessage toAdd);

        /// <summary>
        /// Updates the message
        /// </summary>
        /// <param name="toUpdate">The message to update</param>
        /// <returns>Whether the message was updated</returns>
        bool UpdateMessage(AppMessage toUpdate);

        /// <summary>
        /// Deletes the message
        /// </summary>
        /// <param name="id">The id of the message</param>
        /// <returns>Whether to message was deleted</returns>
        bool DeleteMessage(string id);

        /// <summary>
        /// Gets the message
        /// </summary>
        /// <param name="id">The id of the message</param>
        /// <returns>The message</returns>
        AppMessage GetMessage(string id);

        /// <summary>
        /// Gets all messages
        /// </summary>
        /// <returns>All messages</returns>
        IEnumerable<AppMessage> GetMessages();

        /// <summary>
        /// Gets all the messages based on the search term
        /// </summary>
        /// <param name="searchTerm">The term to search with</param>
        /// <returns>All messages filtered by search term</returns>
        IEnumerable<AppMessage> GetMessages(string searchTerm);

        /// <summary>
        /// Loads the messages
        /// </summary>
        /// <returns>Whether the messages were loaded</returns>
        bool LoadMessages();

        /// <summary>
        /// Saves the messages
        /// </summary>
        void SaveMessages();
    }
}
