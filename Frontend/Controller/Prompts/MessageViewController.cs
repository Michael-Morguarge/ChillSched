using Backend.Model;
using Frontend.App.Prompts;
using Frontend.Controller.Business;
using Frontend.View.Controller;
using Shared.Global;
using Shared.Model;
using System;
using System.Collections.Generic;
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
        private readonly Random _rand;
        private readonly List<string> _lastSeen;
        private string _lastShown;

        /// <summary>
        /// Constructor for Message View Controller
        /// </summary>
        /// <param name="controls">The controls to manage</param>
        public MessageViewController(ControlsAccess controls)
        {
            _messageController = new MessageController();
            _controls = controls;
            _rand = new Random();
            _lastSeen = new List<string>();
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
                message.LastDisplayedDate = new DateAndTime(TimeAndDateUtility.GetCurrentDate(), TimeAndDateUtility.GetCurrentTime());

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

            if (removed)
            {
                int index = _lastSeen.IndexOf(id);

                if (index > -1 && index < _lastSeen.Count)
                    _lastSeen.RemoveAt(index);
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

        public string GetRandomMessage()
        {
            List<AppMessage> messages = _messageController.GetMessages().Where(x => x.Show).ToList();

            AppMessage message = null;
            string display = string.Empty;
            bool isNotShown = false;

            while (!isNotShown && messages.Count > 0)
            {
                if (_lastSeen.Count == messages.Count)
                {
                    _lastSeen.Clear();
                }

                message = messages.ElementAtOrDefault(_rand.Next(0, messages.Count));

                if (message != null && !_lastSeen.Any(x => x == message.Id) && _lastShown != message.Id)
                {
                    string author = string.IsNullOrEmpty(message.Author) ? "No author(s)" : message.Author;
                    string source = string.IsNullOrEmpty(message.Source) ? "No source(s)" : message.Source;

                    display = $"\"{message.Quote}\"\r\n\r\n    - {author}\r\n\r\nSources:\r\n    {source}";
                    isNotShown = true;
                    _lastShown = message.Id;

                    _lastSeen.Add(message.Id);

                    message.LastDisplayedDate = new DateAndTime(TimeAndDateUtility.GetCurrentDate(), TimeAndDateUtility.GetCurrentTime());

                    _messageController.EditMessage(message);
                }
            }

            return display;
        }
    }
}
