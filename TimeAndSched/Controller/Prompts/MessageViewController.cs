using BackEnd.Model;
using FrontEnd.Controller.Business;
using FrontEnd.View.Controller;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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

        public bool Create()
        {
            //bool created = _messageController.CreateMessage();

            return true;
        }

        public bool Remove(string id)
        {
            //bool removed = _messageController.RemoveMessage(id);

            return true;
        }

        public bool Update(string id)
        {
            //bool updated = _messageController.EditMessage();

            return true;
        }

        public bool Toggle(string id)
        {
            //bool update = _messageController.EditMessage();

            return true;
        }
    }
}
