using Backend.Model;
using Frontend.App.Prompts;
using Frontend.Controller.Business;
using Frontend.View.Controller;
using Shared.Global;
using System;
using System.Linq;
using System.Windows.Forms;

namespace Frontend.Controller.Prompts
{
    /// <summary>
    /// Controller for Message View
    /// </summary>
    public class MessageViewController
    {
        private readonly MessageController _messageController;
        private readonly ControlsAccess _controls;

        /// <summary>
        /// Constructor for Message View Controller
        /// </summary>
        /// <param name="controls">The controls to manage</param>
        public MessageViewController(ControlsAccess controls)
        {
            _messageController = new MessageController();
            _controls = controls;
        }

        public AppMessage GetMessage(string id)
        {
            return _messageController.GetMessage(id);
        }

        public object[] GetAll()
        {
            return _messageController.GetMessages().Select(x => (object)x).Distinct().ToArray();
        }

        public object[] GetAll(string searchTerm)
        {
            return _messageController.GetMessages(searchTerm).Select(x => (object)x).Distinct().ToArray();
        }

        public bool UpdateLastShown(string id)
        {
            bool updated = false;
            AppMessage message = _messageController.GetMessage(id);

            if (message != null)
            {
                message.LastDateDisplayed = TimeAndDateUtility.GetCurrentDate();
                message.LastTimeDisplayed = TimeAndDateUtility.GetCurrentTime();

                updated = _messageController.EditMessage(message);
            }

            return updated;
        }

        public bool Add()
        {
            bool added = false;

            try
            {
                MessageCrudView form = new MessageCrudView(_controls);
                form.CreateView(CrudPurposes.Create);

                form.ShowDialog();
                AppMessage result = form.Data.Results;
                DialogResult dialogResult = form.Data.DialogResult;

                if (dialogResult != DialogResult.Cancel && result != null)
                {
                    added = _messageController.CreateMessage(result);
                }

                form.Dispose();
            }
            catch (Exception)
            {
                MessageBox.Show("Unable to add item.", "Please try again.", MessageBoxButtons.OK);
                added = false;
            }

            return added;
        }

        public bool Remove(string id)
        {
            bool removed = false;

            try
            {
                string title = _messageController.GetMessage(id)?.Title;

                if (!string.IsNullOrEmpty(title))
                {
                    DialogResult result =
                        MessageBox.Show($"Are you sure you want to remove message \"{title}\"?", $"Remove \"{title}\"", MessageBoxButtons.YesNo);

                    if (result == DialogResult.Yes)
                    {
                        removed = _messageController.RemoveMessage(id);
                    }
                }
            }
            catch (Exception)
            {
                MessageBox.Show("Unable to remove item.", "Please try again.", MessageBoxButtons.OK);
                removed = false;
            }

            return removed;
        }

        public bool Update(string id)
        {
            bool updated = false;

            try
            {
                AppMessage message = _messageController.GetMessage(id);

                if (message != null)
                {
                    MessageCrudView form = new MessageCrudView(_controls);
                    form.CreateView(CrudPurposes.Edit, message);

                    form.ShowDialog();
                    AppMessage result = form.Data.Results;
                    DialogResult dialogResult = form.Data.DialogResult;

                    if (dialogResult != DialogResult.Cancel && result != null)
                    {
                        result.Id = message.Id;
                        updated = _messageController.EditMessage(result);
                    }

                    form.Dispose();
                }
            }
            catch (Exception)
            {
                MessageBox.Show("Unable to update item.", "Please try again.", MessageBoxButtons.OK);
                updated = false;
            }

            return updated;
        }

        public bool ToggleShow(string id)
        {
            bool updated = false;

            try
            {
                if (!string.IsNullOrEmpty(id))
                {
                    updated = _messageController.ToggleShow(id);
                }
            }
            catch (Exception)
            {
                MessageBox.Show("Unable to toggle item.", "Please try again.", MessageBoxButtons.OK);
                updated = false;
            }

            return updated;
        }

        public bool SaveMessages()
        {
            return _messageController.SaveMessages();
        }

        public bool SaveMessages(string path)
        {
            return _messageController.SaveMessages(path);
        }

        public bool LoadMessages(bool overwrite = false)
        {
            return _messageController.LoadMessages(overwrite);
        }

        public bool LoadMessages(string path, bool overwrite = false)
        {
            return _messageController.LoadMessages(path, overwrite);
        }
    }
}
