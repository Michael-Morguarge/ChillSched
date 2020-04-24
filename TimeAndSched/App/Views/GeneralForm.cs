using FrontEnd.View.Controller;
using System.Windows.Forms;
using Backend.Model;
using Shared.Global;

namespace FrontEnd.App.Views
{
    /// <summary>
    /// Partial class for General Form
    /// </summary>
    public partial class GeneralForm : Form
    {
        private readonly string _id;
        private readonly ControlsAccess _controls;

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
        /// Creates a view within a popup form
        /// </summary>
        /// <param name="purpose">The purpose of the form</param>
        /// <param name="event">The event</param>
        public void CreateView(CrudPurposes purpose, SavedEvent @event = null)
        {
            if (purpose == CrudPurposes.Error)
            {
                Error.Visible = true;
                EIV.Visible = false;
            }
            else
            {
                Error.Visible = false;
                EIV.Visible = true;
                EIV.SetControls(_id, _controls);
                EIV.SetPurpose(purpose);
            }
            
            if (purpose == CrudPurposes.Edit)
            {
                EIV.SetValues(@event);
            }
        }

        private void GeneralForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            SavedEvent result = EIV.Results;
            DialogResult dialog = EIV.DialogResult;

            if (dialog == DialogResult.OK && result != null)
            {
                Results = result;
                PromptResult = dialog;
            }
            else if (dialog == DialogResult.None)
            {
                e.Cancel = true;
            }
            else
            {
                e.Cancel = false;
                PromptResult = dialog;
            }
        }
    }
}
