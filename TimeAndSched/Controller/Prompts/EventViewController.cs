using Backend.Model;
using FrontEnd.App.Views;
using FrontEnd.View.Controller;
using Shared.Global;
using Shared.Model;
using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace FrontEnd.Controller.Prompts
{
    /// <summary>
    /// Controller for Events View
    /// </summary>
    public class EventViewController
    {
        private EventController _eventController;
        private ControlsAccess _controls;

        /// <summary>
        /// Constructor for Event View
        /// </summary>
        /// <param name="controls">The controls to manage</param>
        public EventViewController(ControlsAccess controls)
        {
            _eventController = new EventController();
            _controls = controls;
        }

        public IEnumerable<SavedEvent> GetAll(Date date)
        {
            return _eventController.GetEvents(date);
        }

        public SavedEvent GetEvent(string id)
        {
            return _eventController.GetEvent(id);
        }

        public bool Add()
        {
            var added = false;
            var form = new GeneralForm(_controls); //move to constructor
            form.CreateView(CrudPurposes.Create);

            form.ShowDialog();
            var result = form.Results;
            var dialogResult = form.PromptResult;

            if (dialogResult != DialogResult.Cancel && result != null)
            {
                added = _eventController.CreateEvent(result);
            }

            form.Dispose();

            return added;
        }

        public bool Update(string id)
        {
            var updated = false;

            var form = new GeneralForm(_controls);
            form.CreateView(CrudPurposes.Edit);

            form.ShowDialog();
            var result = form.Results;
            var dialogResult = form.PromptResult;

            if (dialogResult != DialogResult.Cancel && result != null)
            {
                updated = _eventController.EditEvent(result);
            }

            form.Dispose();

            return updated;
        }

        public void Remove(string id)
        {
            //MessageBox.()
        }

        public void Dispose()
        {
            GC.SuppressFinalize(this);
        }
    }
}
