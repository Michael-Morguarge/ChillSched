using Shared.Global;
using Shared.Model;

namespace BackEnd.Model
{
    /// <summary>
    /// Model for messages
    /// </summary>
    public class AppMessage
    {
        /// <summary>
        /// Sets the message id
        /// </summary>
        public AppMessage()
        {
            Id = Generate.Id().ToString();
        }

        /// <summary>
        /// The title of the message
        /// </summary>
        public string Title { get; set; }

        /// <summary>
        /// The Id of the message
        /// </summary>
        public string Id { get; set; }

        /// <summary>
        /// The quote
        /// </summary>
        public string Quote { get; set; }

        /// <summary>
        /// The author of the quote
        /// </summary>
        public string Author { get; set; }

        /// <summary>
        /// The link source of the quote
        /// </summary>
        public string Source { get; set; }

        /// <summary>
        /// Whether to show the mesage
        /// </summary>
        public bool Show { get; set; }

        /// <summary>
        /// The date created
        /// </summary>
        public Date DateCreated { get; set; }

        /// <summary>
        /// The time created
        /// </summary>
        public Time TimeCreated { get; set; }
    }
}