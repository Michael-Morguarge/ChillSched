using System;

namespace Shared.Global
{
    /// <summary>
    /// The id
    /// </summary>
    public class Generate
    {
        /// <summary>
        /// Creates an Id
        /// </summary>
        /// <returns>A guid</returns>
        public static Guid Id()
        {
            return Guid.NewGuid();
        }
    }
}
