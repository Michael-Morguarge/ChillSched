using FrontEnd.View.Controller;
using System.Windows.Forms;
using Backend.Model;
using Shared.Utility;
using Backend.Implementations;

namespace FrontEnd.App.Index.Views
{
    public partial class GeneralForm : Form
    {
        private ControlsAccess _controls;
        private EventDetailRepository _repo;

        public EventDetail Results { get; private set; }

        public GeneralForm()
        {
            InitializeComponent();
        }

        public GeneralForm(ControlsAccess controls)
        {
            _controls = controls;
        }

        public void CreateView(CrudPurposes purpose, ControlsAccess controls)
        {
            if (purpose == CrudPurposes.Error)
            {
                Error.Visible = true;
                EIV.Visible = false;
                return;
            }
            else
            {
                Error.Visible = false;
                EIV.Visible = true;
                _repo = new EventDetailRepository();
                EIV.SetControls(controls);
                EIV.SetPurpose(purpose);
            }
        }

        private void GeneralForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            var result = EIV.Results;
            var dialogue = EIV.DialogResult;

            if (dialogue == DialogResult.OK && result != null)
                Results = result;
        }
    }
}
