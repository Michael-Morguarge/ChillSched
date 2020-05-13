using System;

namespace Shared.Global
{
    /// <summary>
    /// The id
    /// </summary>
    public class Generate
    {
        public static Guid Id()
        {
            return Guid.NewGuid();
        }
    }
}
