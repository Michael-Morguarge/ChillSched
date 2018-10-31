using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TimeAndSched.App.Index.Controller;
using TimeAndSched.Backend.Globals;

namespace TimeAndSched.App.Index.Frameworks
{
    public partial class EventInfoView : UserControl
    {
        private ControlAccess _controls;

        public EventInfoView(ControlAccess control)
        {
            InitializeComponent();
            _controls = control;
            Setup();
        }

        public void Setup()
        {
            Tag = _controls.Add(ControlType.Forms, this);
        }
    }
}
