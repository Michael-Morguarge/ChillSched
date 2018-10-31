using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TimeAndSched.Backend.Globals;

namespace TimeAndSched.App.Index.Implementations
{
    public abstract class ASetupController<T>
    {
        public ASetupController(T control)
        {
            Control = control;
            Id = ControlGlobals.CreateId().ToString();
        }

        public T Control { get; private set; }
        public string Id { get; private set; }
    }

    public abstract class ASetupCRUDController<T>
    {
        public ASetupCRUDController(List<T> controllers)
        {
            Controllers = controllers;
            Id = ControlGlobals.CreateId().ToString();
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
            Id = ControlGlobals.CreateId().ToString();
        }

        public S Form { get; set; }
        public List<T> Items { get; set; }
        public string Id { get; private set; }
    }
}
