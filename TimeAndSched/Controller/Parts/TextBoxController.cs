using Shared.Abstract;
using System.Windows.Forms;

namespace FrontEnd.Controller.Parts
{
    /// <summary>
    /// Controller for Text Boxes and Rich Text Boxes
    /// </summary>
    public class TextBoxController : ASetupController<TextBoxBase>
    {
        /// <summary>
        /// Constructor for text box controller
        /// </summary>
        /// <param name="control">The textbox controller to manage</param>
        public TextBoxController(TextBoxBase control) : base(control)
        {
            //Control is set in base class.
        }

        /// <summary>
        /// Sets the textbox text
        /// </summary>
        /// <param name="text">Text to set</param>
        public void SetText(string text) => GetControl().Text = text;

        /// <summary>
        /// The text entered from the form
        /// </summary>
        public string Text => GetControl().Text;
    }
}
