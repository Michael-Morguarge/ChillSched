using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;
using Shared.Interface;
using FrontEnd.Controller.Parts;

namespace FrontEnd.View.Controller
{
    /// <summary>
    /// Controls storage and accessor class
    /// </summary>
    public class ControlsAccess
    {
        /*Form ID => Control ID, Control*/
        private readonly Dictionary<string, Dictionary<string, IControl>> Controls;

        /// <summary>
        /// Constructor for ControlsAccess class
        /// </summary>
        public ControlsAccess()
        {
            Controls = new Dictionary<string, Dictionary<string, IControl>>();
        }

        /// <summary>
        /// Adds a form to the ControlAccess
        /// </summary>
        /// <param name="aForm">The form to manage</param>
        /// <returns>The ID of the form</returns>
        public string AddForm(Form aForm)
        {
            FormController form = new FormController(aForm);
            Controls.Add(form.GetId(), new Dictionary<string, IControl>());

            return form.GetId();
        }

        public string Add(string formId, IControl aControl)
        {
            Dictionary<string, IControl> form = Controls.Single(x => x.Key == formId).Value;
            form.Add(aControl.GetId(), aControl);

            return aControl.GetId();
        }

        public void Remove(string formId, string controlId)
        {
            Dictionary<string, IControl> form = Controls.Single(x => x.Key == formId).Value;
            form.Remove(controlId);
        }

        public IControl Get(string formId, string controlId)
        {
            Dictionary<string, IControl> form = Controls.Single(x => x.Key == formId).Value;
            form.TryGetValue(controlId, out IControl control);

            return control;
        }
    }
}
