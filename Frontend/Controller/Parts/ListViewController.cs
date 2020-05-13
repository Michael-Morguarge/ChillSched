using Shared.Abstract;
using System.Windows.Forms;

namespace Frontend.Controller.Parts
{
    /// <summary>
    /// Controller for List Views in view
    /// </summary>
    public class ListViewController : ASetupController<ListView>
    {
        /// <summary>
        /// Constructor for list view controller
        /// </summary>
        /// <param name="control">The control to manage</param>
        public ListViewController(ListView control) : base(control)
        {
            //Control is set in base class
        }

        /// <summary>
        /// Clears and updates the ListView
        /// </summary>
        /// <param name="items">The items to display</param>
        public void Update(ListViewItem[] items)
        {
            GetControl().Items.Clear();
            GetControl().Items.AddRange(items);
        }
    }
}
