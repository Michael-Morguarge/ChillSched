using Shared.Utility;

namespace FrontEnd.App.Index.Implementations
{
    public abstract class ASetupController<T>
    {
        public ASetupController(T control)
        {
            Control = control;
            Id = Ids.CreateId().ToString();
        }

        public T Control { get; private set; }
        public string Id { get; private set; }
    }
}