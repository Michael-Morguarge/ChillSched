using Shared.Abstract;
using System.Drawing;
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
        public void SetText(string text) => GetControl().Text = text;

        /// <summary>
        /// Sets the background color
        /// </summary>
        /// <param name="color">The background color</param>
        public void SetBackColor(Color color) => GetControl().BackColor = color;

        /// <summary>
        /// Sets the fore color
        /// </summary>
        /// <param name="color">The fore color</param>
        public void SetForeColor(Color color) => GetControl().ForeColor = color;
    }
}
