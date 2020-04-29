using SharedItems.Abstracts;
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

        /// <summary>
        /// Clears the ListView
        /// </summary>
        public void Clear() => GetControl().Items.Clear();

        /// <summary>
        /// Sets the value (value) and display (key) members of the ListBox
        /// </summary>
        /// <param name="display">The key and the value displayed</param>
        /// <param name="value">The value sent to the code behind</param>
        public void SetMembers(string display, string value)
        {
            GetControl().ValueMember = value;
            GetControl().DisplayMember = display;
        }
        
        /// <summary>
        /// Clears then updates the ListBox
        /// </summary>
        /// <param name="items">The items to display</param>
        public void Update(object[] items)
        {
            GetControl().Items.Clear();
            GetControl().Items.AddRange(items);
        }

        /// <summary>
        /// Gets the selected item from the ListBox
        /// </summary>
        /// <returns>The selected item</returns>
        public object SelectedIndex() => GetControl().SelectedItem;
    }
}
