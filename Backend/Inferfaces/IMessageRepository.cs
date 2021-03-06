﻿using Backend.Model;
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
        /// <param name="overwrite">Whether to overwrite the current data</param>
        /// <returns>Whether the messages were loaded</returns>
        bool LoadMessages(bool overwrite = false);

        /// <summary>
        /// Loads the messages from an external source
        /// </summary>
        /// <param name="path">The file path to load from</param>
        /// <param name="overwrite">Whether to overwrite the current data</param>
        /// <returns>Whether the messages were loaded</returns>
        bool LoadMessages(string path, bool overwrite = false);

        /// <summary>
        /// Saves the messages
        /// </summary>
        /// <returns>Whether the messages were fully saved</returns>
        bool SaveMessages();

        /// <summary>
        /// Saves the messages to a an external source
        /// </summary>
        /// <param name="path">The file path to save to</param>
        /// <returns>Whether the messages were fully saved</returns>
        bool SaveMessages(string path);
    }
}
