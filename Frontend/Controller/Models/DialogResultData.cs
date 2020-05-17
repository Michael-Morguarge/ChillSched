using System.Windows.Forms;

namespace Frontend.Controller.Models
{
    /// <summary>
    /// The class for dialog result data
    /// </summary>
    public class DialogResultData<T>
    {
        /// <summary>
        /// Whether an error occurred
        /// </summary>
        public bool Error { get; set; }

        /// <summary>
        /// The dialog result
        /// </summary>
        public DialogResult DialogResult { get; set; }

        /// <summary>
        /// The created/edtited T data
        /// </summary>
        public T Results { get; set; }
    }
}
