using System.Collections.Generic;
using Backend.OutputLogic.Global;

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

    public abstract class ASetupCRUDController<T>
    {
        public ASetupCRUDController(List<T> controllers)
        {
            Controllers = controllers;
            Id = Ids.CreateId().ToString();
        }

        public List<T> Controllers { get; set; }
        public string Id { get; private set; }
    }

    public abstract class ASetupCRUDController<S,T>
    {
        public ASetupCRUDController(S form, List<T> items)
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
