using Shared.Abstract;
using System.Drawing;
using System.Windows.Forms;

namespace FrontEnd.Controller.Parts
{
    /// <summary>
    /// Controller for Form view
    /// </summary>
    public class FormController : ASetupController<Form>
    {
        /// <summary>
        /// Constructor for form controller
        /// </summary>
        /// <param name="control">Form to manage</param>
        public FormController(Form control) : base(control)
        {
            //Control is set in base class.
        }

        /// <summary>
        /// Sets the form icon
        /// </summary>
        /// <param name="icon">The icon to use</param>
        public void SetIcon(Icon icon) => GetControl().Icon = icon;
    }
}
