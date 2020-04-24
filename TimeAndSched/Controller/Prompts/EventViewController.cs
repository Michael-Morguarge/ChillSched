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
        private readonly EventController _eventController;
        private readonly ControlsAccess _controls;

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
            bool added = false;

            try
            {
                GeneralForm form = new GeneralForm(_controls);
                form.CreateView(CrudPurposes.Create);

                form.ShowDialog();
                SavedEvent result = form.Results;
                DialogResult dialogResult = form.PromptResult;

                if (dialogResult != DialogResult.Cancel && result != null)
                {
                    added = _eventController.CreateEvent(result);
                }

                form.Dispose();
            }
            catch (Exception)
            {
                added = false;
            }

            return added;
        }

        public bool ToggleStatus(string id)
        {
            bool updated;

            try
            {
                updated = _eventController.ToggleStatus(id);

            }
            catch (Exception)
            {
                updated = false;
            }

            return updated;
        }

        public bool Update(string id)
        {
            bool updated = false;

            try
            {
                GeneralForm form = new GeneralForm(_controls);
                SavedEvent @event = _eventController.GetEvent(id);
                form.CreateView(CrudPurposes.Edit, @event);

                form.ShowDialog();
                SavedEvent result = form.Results;
                DialogResult dialogResult = form.PromptResult;

                if (dialogResult != DialogResult.Cancel && result != null)
                {
                    result.Id = id;
                    updated = _eventController.EditEvent(result);
                }

                form.Dispose();
            }
            catch (Exception) {
                updated = false;
            }

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
