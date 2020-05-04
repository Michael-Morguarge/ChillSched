using SharedItems.Abstracts;
using System.Windows.Forms;

namespace FrontEnd.Controller.Parts
{
    /// <summary>
    /// Controller for User Controls in view
    /// </summary>
    public class UserControlController : SetupCRUDControllerAbstract<UserControl>
    {
        /// <summary>
        /// Constructor for user control controller
        /// </summary>
        /// <param name="control">The user control to manage</param>
        public UserControlController(UserControl control) : base(control)
        {
            //Control is set in base class.
        }
    }
}
