using Shared.Global;
using SharedItems.Abstracts;
using System.Windows.Forms;

namespace FrontEnd.Controller.Parts
{
    /// <summary>
    /// The controller for DateTimePickers in view
    /// </summary>
    public class DatePickerController : ASetupController<DateTimePicker>
    {
        /// <summary>
        /// Controller for Date Pickers in view
        /// </summary>
        /// <param name="control">The date picker to manage</param>
        public DatePickerController(DateTimePicker control) : base(control)
        {
            //Control is set in base class.
        }

        /// <summary>
        /// The formatted date
        /// </summary>
        public string Date
        {
            get
            {
                return TimeAndDateUtility.ConvertDate_String(GetControl().Value);
            }
        }

        /// <summary>
        /// The formatted time
        /// </summary>
        public string Time
        {
            get
            {
                return TimeAndDateUtility.ConvertTime_String(GetControl().Value);
            }
        }
    }
}
