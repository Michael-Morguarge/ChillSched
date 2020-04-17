using Shared.Interface;
using Shared.Utility;
using System.Collections.Generic;

namespace SharedItems.Abstracts
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
            _id = Ids.CreateId().ToString();
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
    
    /// <summary>
    /// The setup for crud controls
    /// </summary>
    /// <typeparam name="S">The form type</typeparam>
    /// <typeparam name="T">The items type</typeparam>
    public abstract class SetupCRUDControllerAbstract<S, T> : ISetupController<S>, IControl
    {
        private S _form;
        private List<T> _items;
        private readonly string _id;

        /// <summary>
        /// Sets up the controller object
        /// </summary>
        /// <param name="form">The form</param>
        /// <param name="items">The items</param>
        public SetupCRUDControllerAbstract(S form, List<T> items)
        {
            _items = items;
            _form = form;
            _id = Ids.CreateId().ToString();
        }

        /// <summary>
        /// See <see cref="ISetupController{S}.GetControl()"/>
        /// </summary>
        public S GetControl()
        {
            return _form;
        }

        /// <summary>
        /// The items
        /// </summary>
        /// <returns>The list of controls</returns>
        public List<T> GetItems()
        {
            return _items;
        }

        /// <summary>
        /// See <see cref="IControl.GetId()"/>
        /// </summary>
        public string GetId()
        {
            return _id;
        }

        /// <summary>
        /// The form
        /// </summary>
        public S Form { get; private set; }

        /// <summary>
        /// The items
        /// </summary>
        public List<T> Items { get; private set; }

        /// <summary>
        /// The id
        /// </summary>
        public string Id { get; private set; }
    }
}
