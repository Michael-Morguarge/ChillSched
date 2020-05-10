using Backend.Model;
using FrontEnd.App.Prompts;
using FrontEnd.Controller.Business;
using FrontEnd.View.Controller;
using Shared.Global;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FrontEnd.Controller.Prompts
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
            AppMessage message = _messageController.GetMessage(id);

            return message;
        }

        public object[] GetAll()
        {
            object[] messages = 
                _messageController.GetMessages().Select(x => (object)x).Distinct().ToArray();

            return messages;
        }

        public object[] GetAll(string searchTerm)
        {
            object[] messages =
                _messageController.GetMessages(searchTerm).Select(x => (object)x).Distinct().ToArray();

            return messages;
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
                added = false;
            }

            return added;
        }

        public bool Remove(string id)
        {
            //bool removed = _messageController.RemoveMessage(id);

            return true;
        }

        public bool Update(AppMessage message)
        {
            //bool updated = _messageController.EditMessage();

            return true;
        }

        public bool ToggleShow(string id)
        {
            //bool update = _messageController.EditMessage();

            return true;
        }
    }
}
