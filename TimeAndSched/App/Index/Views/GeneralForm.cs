using FrontEnd.View.Controller;
using System.Windows.Forms;
using Backend.Model;
using Shared.Utility;
using Backend.Implementations;

namespace FrontEnd.App.Index.Views
{
    public partial class GeneralForm : Form
    {
        private readonly string _id;
        private ControlsAccess _controls;
        private EventRepository _repo;

        /// <summary>
        /// The data returned from the prompt
        /// </summary>
        public SavedEvent Results { get; private set; }
        

        /// <summary>
        /// The constructor for General Forms
        /// </summary>
        /// <param name="controls">The library of existing controls</param>
        public GeneralForm(ControlsAccess controls)
        {
            InitializeComponent();
            _controls = controls;
            
            Tag = _controls.AddForm(this);
            _id = Tag as string;
        }

        public void CreateView(CrudPurposes purpose)
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
                _repo = new EventRepository();
                var anEvent = _repo.GetEvent("");
                EIV.SetControls(_id, _controls);
                EIV.SetPurpose(purpose);
                EIV.SetValues(anEvent);
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
