using Backend.Model;
using Shared.Model;
using System.Collections.Generic;

namespace BackEnd.Inferfaces
{
    /// <summary>
    /// Interface for IEventRepository
    /// </summary>
    public interface IEventRepository
    {
        /// <summary>
        /// Adds an event
        /// </summary>
        /// <param name="event">The event to add</param>
        /// <returns>Whether the event was added</returns>
        bool AddEvent(SavedEvent @event);

        /// <summary>
        /// Updates an event
        /// </summary>
        /// <param name="event">The event to update</param>
        /// <returns>Whether the event was updated</returns>
        bool UpdateEvent(SavedEvent @event);

        /// <summary>
        /// Gets an event
        /// </summary>
        /// <param name="id">The Id of the event</param>
        /// <returns>The event</returns>
        SavedEvent GetEvent(string id);

        /// <summary>
        /// Gets all events
        /// </summary>
        /// <param name="date">The current date</param>
        /// <returns>A list of saved events</returns>
        IEnumerable<SavedEvent> GetEvents(Date date);

        void SaveBookmarks();
    }
}
