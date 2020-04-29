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
        /// Deletes an event
        /// </summary>
        /// <param name="id">The id of the event to delete</param>
        /// <returns>Whether the event was deleted</returns>
        bool DeleteEvent(string id);

        /// <summary>
        /// Gets an event
        /// </summary>
        /// <param name="id">The Id of the event</param>
        /// <returns>The event</returns>
        SavedEvent GetEvent(string id);

        /// <summary>
        /// Gets all events
        /// </summary>
        /// <returns>A list of saved events</returns>
        IEnumerable<SavedEvent> GetEvents();

        /// <summary>
        /// Gets all events
        /// </summary>
        /// <param name="date">The current date</param>
        /// <returns>A list of saved events</returns>
        IEnumerable<SavedEvent> GetEvents(Date date);

        /// <summary>
        /// Gets all events
        /// </summary>
        /// <param name="start">The start date</param>
        /// <param name="end">The end date</param>
        /// <returns>A list of saved events</returns>
        IEnumerable<SavedEvent> GetEvents(Date start, Date end);

        /// <summary>
        /// Loads the events from the save file
        /// </summary>
        /// <returns>Whether the events are loaded</returns>
        bool LoadEvents();

        /// <summary>
        /// Saves to the events to a save file
        /// </summary>
        void SaveEvents();
    }
}
