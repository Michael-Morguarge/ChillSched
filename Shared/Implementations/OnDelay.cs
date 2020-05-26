using Shared.Global;
using Shared.Interface;
using Shared.Model;
using System;

namespace Shared.Implementation
{
    /// <summary>
    /// Delays class based on date comparisons
    /// </summary>
    public class OnDelay : IDelay
    {
        /// <summary>
        /// The date the delayed occurred
        /// </summary>
        public DateAndTime DateDelayed { get; private set; }

        /// <summary>
        /// The date to continue regular flow
        /// </summary>
        public DateAndTime DateContinued { get; private set; }

        /// <summary>
        /// The lock
        /// </summary>
        public bool Lock { get; private set; }

        /// <summary>
        /// Set the delay and date to start the delay
        /// </summary>
        /// <param name="delay">The amount of seconds to delay</param>
        /// <param name="date">The date to start the delay</param>
        public void SetDelay(int delay, DateAndTime date)
        {
            int delayTime = delay > 0 ? delay : 30;
            DateDelayed = date;
            DateTime continued = TimeAndDateUtility.ConvertDateAndTime_DateTime(date).AddSeconds(delayTime);
            DateContinued = TimeAndDateUtility.ConvertDateTime_DateAndTime(continued);
            Lock = true;
        }

        /// <summary>
        /// Unlocks delay if the current date is greater than continued date
        /// </summary>
        /// <param name="currDate">The current date</param>
        public void Unlock(DateAndTime currDate)
        {
            if (DateDelayed != null && DateContinued != null)
            {
                DateCompare compare = TimeAndDateUtility.ComputeDiff(DateDelayed, currDate, DateContinued).Comparison;
                Lock = compare != DateCompare.None;

                if (!Lock)
                {
                    DateDelayed = null;
                    DateContinued = null;
                }
            }
        }
    }
}
