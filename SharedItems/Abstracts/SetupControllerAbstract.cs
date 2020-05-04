using Shared.Interface;
using Shared.Global;

namespace SharedItems.Abstracts
{
    /// <summary>
    /// The setup for controls
    /// </summary>
    /// <typeparam name="T">The type</typeparam>
    public abstract class ASetupController<T> : ISetupController<T>, IControl
    {
        private T _control;
        private readonly string _id;

        /// <summary>
        /// Sets up a controller object
        /// </summary>
        /// <param name="control">The control to layer</param>
        public ASetupController(T control)
        {
            _control = control;
            _id = Generate.Id().ToString().Replace("-", "");
        }

        /// <summary>
        /// <see cref="ISetupController{T}.GetControl()"/>
        /// </summary>
        public T GetControl()
        {
            return _control;
        }

        /// <summary>
        /// <see cref="IControl.GetId()"/>
        /// </summary>
        public string GetId()
        {
            return _id;
        }
    }
}