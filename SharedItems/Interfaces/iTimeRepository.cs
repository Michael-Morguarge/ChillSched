
using Shared.Model;
using Shared.Utility;

namespace Shared.Interface
{
    /// <summary>
    /// The time interface
    /// </summary>
    public interface ITimeRepository
    {
        /// <summary>
        /// Builds a custom time
        /// </summary>
        /// <param name="hours">The hours</param>
        /// <param name="minutes">The minutes</param>
        /// <param name="seconds">The seconds</param>
        /// <param name="timeOfDay">The time of day</param>
        /// <returns>A time object</returns>
        Time GetCustomTime(int hours, int minutes, int seconds, TimeOfDay timeOfDay);

        /// <summary>
        /// The return for a time error
        /// </summary>
        /// <returns>A time object</returns>
        Time GetErrorTime();
    }
}
