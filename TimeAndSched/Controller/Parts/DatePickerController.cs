using Shared.Global;
using Shared.Abstract;
using System;
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
        /// Sets the date for the control
        /// </summary>
        /// <param name="date">The date to display</param>
        public void SetDates(DateTime min, DateTime date, DateTime max)
        {
            if (min < max)
            {
                GetControl().MinDate = min;
                GetControl().Value = date;
                GetControl().MaxDate = max;
            }
            else if (min > max)
            {
                GetControl().MinDate = max;
                GetControl().Value = date;
                GetControl().MaxDate = min;
            }
            else
            {
                GetControl().MinDate = DateTime.MinValue;
                GetControl().Value = date;
                GetControl().MaxDate = DateTime.MaxValue;
            }
        }

        /// <summary>
        /// Enables the control
        /// </summary>
        /// <param name="enable">Whether to enable the control</param>
        public void Enable(bool enable) => GetControl().Enabled = enable;

        /// <summary>
        /// The formatted date
        /// </summary>
        public string Date => TimeAndDateUtility.ConvertDate_String(GetControl().Value);

        /// <summary>
        /// The formatted time
        /// </summary>
        public string Time => TimeAndDateUtility.ConvertTime_String(GetControl().Value);
    }
}
