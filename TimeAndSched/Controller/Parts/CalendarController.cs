using SharedItems.Abstracts;
using System;
using System.Windows.Forms;

namespace FrontEnd.Controller.Parts
{
    /// <summary>
    /// Controller for Calendars in view
    /// </summary>
    public class CalendarController : ASetupController<MonthCalendar>
    {
        /// <summary>
        /// Constructor for calendar controller
        /// </summary>
        /// <param name="control">The calendar to manage</param>
        public CalendarController(MonthCalendar control) : base(control)
        {
            //Control is set in base class.
        }

        /// <summary>
        /// Sets dates to be bolded
        /// </summary>
        /// <param name="dates">The dates to bold on the calendar</param>
        public void SetBoldedDates(params DateTime[] dates) => GetControl().BoldedDates = dates ?? new DateTime[0];
    }
}
