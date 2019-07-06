using Shared.Utility;
using System.Collections.Generic;

namespace SharedItems.Abstracts
{
    public abstract class SetupCRUDControllerAbstract<T>
    {
        public SetupCRUDControllerAbstract(T controller)
        {
            Controller = controller;
            Id = Ids.CreateId().ToString();
        }

        public T Controller { get; set; }
        public string Id { get; private set; }
    }



    public abstract class SetupCRUDControllerAbstract<S, T>
    {
        public SetupCRUDControllerAbstract(S form, List<T> items)
        {
            Items = items;
            Form = form;
            Id = Ids.CreateId().ToString();
        }

        public S Form { get; set; }
        public List<T> Items { get; set; }
        public string Id { get; private set; }
    }
}
