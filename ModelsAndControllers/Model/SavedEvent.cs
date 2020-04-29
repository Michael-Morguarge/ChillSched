using Shared.Model;
using System;

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
            Id = Guid.NewGuid().ToString();
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

        /// <summary>
        /// The date the event was completed
        /// </summary>
        public Date DateCompleted { get; set; }

        /// <summary>
        /// The time the event was completed
        /// </summary>
        public Time TimeCompleted { get; set; }

        /// <summary>
        /// The time the event was created
        /// </summary>
        public Time TimeCreated { get; set; }
        
        /// <summary>
        /// The date the event was created
        /// </summary>
        public Date DateCreated { get; set; }

        /// <summary>
        /// The time the event is set to start
        /// </summary>
        public Time ActivationTime { get; set; }
        
        /// <summary>
        /// The time the event is set to end
        /// </summary>
        public Time DeactivationTime { get; set; }

        /// <summary>
        /// The date the event is set to start
        /// </summary>
        public Date ActivationDate { get; set; }

        /// <summary>
        /// The date the event is set to end
        /// </summary>
        public Date DeactivationDate { get; set; }
    }
}
