using SharedItems.Abstracts;
using System.Collections.Generic;
using System.Windows.Forms;

namespace FrontEnd.Controller.Parts
{
    /// <summary>
    /// Controller for List Boxes in view
    /// </summary>
    public class ListBoxController : ASetupController<ListBox>
    {
        /// <summary>
        /// Constructor for list box controller
        /// </summary>
        /// <param name="control">The List Box to manage</param>
        public ListBoxController(ListBox control) : base(control)
        {
            //Control is set in base class.
        }

        // Needs major modifications

        public void Clear()
        {
            GetControl().Items.Clear();
        }

        public void SetMembers(string display, string value)
        {
            GetControl().ValueMember = value;
            GetControl().DisplayMember = display;
        }

        public void Update(object[] items)
        {
            GetControl().Items.Clear();
            GetControl().Items.AddRange(items);
        }

        public object SelectedIndex()
        {
            return GetControl().SelectedItem;
        }
    }
}
