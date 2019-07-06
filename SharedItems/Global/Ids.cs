using System;

namespace Shared.Utility
{
    public class Ids
    {
        public static Guid CreateId()
        {
            return Guid.NewGuid();
        }
    }
}
