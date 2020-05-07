using FrontEnd.View.Controller;
using System.Windows.Forms;
using Backend.Model;
using Shared.Global;
using FrontEnd.Controller.Models;

namespace FrontEnd.App.Prompts
{
    /// <summary>
    /// Partial class for General Form
    /// </summary>
    public partial class EventCrudView : Form
    {
        private readonly string _id;
        private readonly ControlsAccess _controls;

        /// <summary>
        /// The data for the prompt
        /// </summary>
        public DialogResultData<SavedEvent> Data { get; private set; }
        
        /// <summary>
        /// The constructor for General Forms
        /// </summary>
        /// <param name="controls">The library of existing controls</param>
        public EventCrudView(ControlsAccess controls)
        {
            InitializeComponent();
            _controls = controls;
            
            Tag = _controls.AddForm(this);
            _id = Tag as string;
            Data = new DialogResultData<SavedEvent>();
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
            DialogResultData<SavedEvent> data = EIV.Data;
            SavedEvent result = data.Results;
            DialogResult dialog = data.DialogResult;

            if (dialog == DialogResult.OK && result != null)
            {
                Data.Results = result;
                Data.DialogResult = dialog;
                EIV.CleanUp();
            }
            else if (dialog == DialogResult.None)
            {
                e.Cancel = true;
            }
            else
            {
                e.Cancel = false;
                Data.DialogResult = dialog;
                EIV.CleanUp();
            }
        }
    }
}
