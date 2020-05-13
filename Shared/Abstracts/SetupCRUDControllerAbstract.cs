using Shared.Interface;
using Shared.Global;

namespace Shared.Abstract
{
    /// <summary>
    /// The setup for crud controls
    /// </summary>
    /// <typeparam name="T">The type</typeparam>
    public abstract class SetupCRUDControllerAbstract<T> : ISetupController<T>, IControl
    {
        private T _control;
        private string _id;

        /// <summary>
        /// Sets up the controller object
        /// </summary>
        /// <param name="controller">The control to layer</param>
        public SetupCRUDControllerAbstract(T controller)
        {
            _control = controller;
            _id = Generate.Id().ToString();
        }

        /// <summary>
        /// <see cref="ISetupController{T}.GetControl()"/>
        /// </summary>
        public T GetControl()
        {
            return _control;
        }

        /// <summary>
        /// <see cref="IControl.GetId()"></see>
        /// </summary>
        public string GetId()
        {
            return _id;
        }
    }
}
