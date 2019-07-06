
using Shared.Utility;

namespace Shared.Abstract
{
    public abstract class SetupAbstract<T>
    {
        public SetupAbstract(T control)
        {
            Control = control;
            Id = Ids.CreateId().ToString();
        }

        public T Control { get; private set; }
        public string Id { get; private set; }
    }
}
