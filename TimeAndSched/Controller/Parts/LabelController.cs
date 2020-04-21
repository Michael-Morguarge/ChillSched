using SharedItems.Abstracts;
using System.Windows.Forms;

namespace FrontEnd.Controller.Parts
{
    /// <summary>
    /// Controller for Labels in view
    /// </summary>
    public class LabelController : ASetupController<Label>
    {
        /// <summary>
        /// Constructor for Label Controller
        /// </summary>
        /// <param name="control">The label to manage</param>
        public LabelController(Label control) : base(control)
        {
            //Control is set in base class.
        }

        /// <summary>
        /// Sets the label text
        /// </summary>
        /// <param name="text">Text to set</param>
        public void SetText(string text)
        {
            GetControl().Text = text;
        }
    }
}
