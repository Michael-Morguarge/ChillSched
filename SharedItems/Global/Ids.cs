using System;

namespace Shared.Utility
{
    /// <summary>
    /// The id
    /// </summary>
    public class Ids
    {
        public static Guid CreateId()
        {
            return Guid.NewGuid();
        }
    }
}
