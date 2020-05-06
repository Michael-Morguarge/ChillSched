using FrontEnd.Controller.Prompts;
using FrontEnd.View.Controller;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FrontEnd.App.Prompts
{
    /// <summary>
    /// Partial view controller
    /// </summary>
    public partial class SearchView : Form
    {
        private string _id;
        private ControlsAccess _controls;
        private MessageViewController _controller;

        /// <summary>
        /// Constructor for Partial View Controller
        /// </summary>
        public SearchView(ControlsAccess controls, MessageViewController controller)
        {
            InitializeComponent();
            _controls = controls;
            _controller = controller;

            Tag = _controls.AddForm(this);
            _id = Tag as string;
            MSV.SetControls(_id, _controls, _controller);
        }

        private void MessageDisplayView_Resize(object sender, EventArgs e)
        {
            if (WindowState == FormWindowState.Minimized)
            {
                ShowInTaskbar = false;
                Hide();
            }
        }
    }
}
