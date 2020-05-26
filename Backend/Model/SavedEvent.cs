using Shared.Global;
using Shared.Model;

namespace Backend.Model
{
    /// <summary>
    /// Model for events
    /// </summary>
    public class SavedEvent
    {
        /// <summary>
        /// Sets the event id
        /// </summary>
        public SavedEvent()
        {
            Id = Generate.Id().ToString();
        }

        /// <summary>
        /// The event id
        /// </summary>
        public string Id { get; set; }

        /// <summary>
        /// The title of the event
        /// </summary>
        public string Title { get; set; }

        /// <summary>
        /// The comment for the event
        /// </summary>
        public string Comment { get; set; }

        /// <summary>
        /// Whether the event is complete
        /// </summary>
        public bool Completed { get; set; }

        public DateAndTime CompletedDate { get; set; }

        public DateAndTime CreatedDate { get; set; }

        public DateAndTime ActivationDate { get; set; }

        public DateAndTime DeactivationDate { get; set; }
    }
}
