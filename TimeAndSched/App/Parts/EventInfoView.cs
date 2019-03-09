using System.Windows.Forms;
using TimeAndSched.FrontEnd.Globals;
using TimeAndSched.View.Controller;

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
