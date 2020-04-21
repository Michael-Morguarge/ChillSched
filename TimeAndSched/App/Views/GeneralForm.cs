using FrontEnd.View.Controller;
using System.Windows.Forms;
using Backend.Model;
using Shared.Global;
using Backend.Implementations;

namespace FrontEnd.App.Views
{
    /// <summary>
    /// Partial class for General Form
    /// </summary>
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
        /// The forms dialog result
        /// </summary>
        public DialogResult PromptResult { get; private set; }
        
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

        /// <summary>
        /// Creates a view with the
        /// </summary>
        /// <param name="purpose">The purpose of the form</param>
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
            var dialog = EIV.DialogResult;

            if (dialog == DialogResult.OK && result != null)
            {
                Results = result;
                PromptResult = dialog;
            }
            else if (dialog == DialogResult.None)
                e.Cancel = true;
            else
            {
                e.Cancel = false;
                PromptResult = dialog;
            }
        }
    }
}
