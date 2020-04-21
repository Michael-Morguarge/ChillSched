using Backend.Model;
using System;
using System.Windows.Forms;
using FrontEnd.View.Controller;
using Shared.Global;
using FrontEnd.Controller.Parts;

namespace FrontEnd.App.Parts
{
    /// <summary>
    /// Partial View Controller
    /// </summary>
    public partial class EventInfoView : UserControl
    {
        private CrudPurposes _purpose;
        private bool _error;
        private string _parentId;
        private ControlsAccess _controls;

        /// <summary>
        /// Whether an error occurred
        /// </summary>
        public bool Error { get; set; }

        /// <summary>
        /// The dialog result
        /// </summary>
        public DialogResult DialogResult { get; private set; }

        /// <summary>
        /// The created/edited event data
        /// </summary>
        public SavedEvent Results { get; private set; }
        
        /// <summary>
        /// Constructor for the Partial Veiw Controllers
        /// </summary>
        public EventInfoView()
        {
            InitializeComponent();
        }

        public void SetControls(string parentId, ControlsAccess controls)
        {
            _controls = controls;
            _parentId = parentId;
            Setup();
        }

        public void SetPurpose(CrudPurposes purpose)
        {
            Results = new SavedEvent();
            _error = false;
            _purpose = purpose;
            SetTitle();
        }

        private void SetTitle()
        {
            switch (_purpose)
            {
                case CrudPurposes.None:
                    {
                        Error = false;
                        BookmarkMaker.Enabled = true;
                        Confirm.Enabled = false;
                        Confirm.Visible = false;
                        BookmarkMaker.Text = "View Bookmark";
                        Confirm.Text = "...";
                        Cancel.Text = "Ok";
                        return;
                    }

                case CrudPurposes.Create:
                    {
                        Error = false;
                        BookmarkMaker.Enabled = true;
                        Confirm.Enabled = true;
                        Confirm.Visible = true;
                        BookmarkMaker.Text = "Create Bookmark";
                        Confirm.Text = "Create";
                        Cancel.Text = "Cancel";
                        return;
                    }

                case CrudPurposes.Edit:
                    {
                        Error = false;
                        BookmarkMaker.Enabled = true;
                        Confirm.Enabled = true;
                        Confirm.Visible = true;
                        BookmarkMaker.Text = "Edit Bookmark";
                        Confirm.Text = "Update";
                        Cancel.Text = "Cancel";
                        return;
                    }
                case CrudPurposes.Error:
                    {
                        Error = true;
                        Confirm.Enabled = false;
                        Confirm.Visible = false;
                        BookmarkMaker.Enabled = false;
                        BookmarkMaker.Visible = false;
                        BookmarkMaker.Text = "...";
                        Confirm.Text = "...";
                        Cancel.Text = "...";
                        return;
                    }

                default:
                    {
                        Error = true;
                        Confirm.Enabled = false;
                        Confirm.Visible = false;
                        BookmarkMaker.Enabled = false;
                        BookmarkMaker.Visible = false;
                        BookmarkMaker.Text = "...";
                        Confirm.Text = "...";
                        Cancel.Text = "...";
                        return;
                    }
            }
        }

        internal void SetValues(SavedEvent anEvent)
        {
            //throw new NotImplementedException();
        }

        private void Setup()
        {
            BMTitle.Tag = _controls.Add(_parentId, new LabelController(BMTitle));
            BMComment.Tag = _controls.Add(_parentId, new LabelController(BMComment));
            BMStart.Tag = _controls.Add(_parentId, new LabelController(BMStart));
            BMEnd.Tag = _controls.Add(_parentId, new LabelController(BMEnd));

            BMTitleTB.Tag = _controls.Add(_parentId, new TextBoxController(BMTitleTB));
            BMCommentTB.Tag = _controls.Add(_parentId, new TextBoxController(BMCommentTB));

            BMStartPicker.Tag = _controls.Add(_parentId, new DatePickerController(BMStartPicker));
            BMStartPicker.MinDate = DateTime.Now;
            BMEndPicker.Tag = _controls.Add(_parentId, new DatePickerController(BMEndPicker));
            BMEndPicker.MinDate = DateTime.Now;
        }

        private void Cancel_Click(object sender, EventArgs e)
        {
            var result = MessageBox.Show("Do you want to discard this bookmark?", "All progress lost if not submitted", MessageBoxButtons.YesNo);

            if (result == DialogResult.Yes)
            {
                DialogResult = DialogResult.Cancel;
            }
            else if (result == DialogResult.No || result == DialogResult.None)
            {
                DialogResult = DialogResult.None;
            }
        }

        private void Confirm_Click(object sender, EventArgs e)
        {
            bool error = false;
            var title = Title.GetControl();

            if (TitleTB.Text == "")
            {
                title.Text = (title.Text.Contains("*") ? title.Text : string.Format("{0}*", title.Text));
                error = true;
            }
            else
            {
                title.Text = (title.Text.Contains("*") ? title.Text.Remove(title.Text.Length - 1) : title.Text);
            }

            var start = Start.GetControl();
            var end = End.GetControl();
            if (CheckStartAndEndDate())
            {
                start.Text = (start.Text.Contains("*") ? start.Text : string.Format("{0}*", start.Text));
                end.Text = (end.Text.Contains("*") ? end.Text : string.Format("{0}*", end.Text));
                error = true;
            }

            if (CheckMinDate())
            {
                start.Text = (start.Text.Contains("*") ? start.Text : string.Format("{0}*", start.Text));
                end.Text = (end.Text.Contains("*") ? end.Text : string.Format("{0}*", end.Text));
                error = true;
            }
            else
            {
                start.Text = (start.Text.Contains("*") ? start.Text.Remove(start.Text.Length - 1) : start.Text);
                end.Text = (end.Text.Contains("*") ? end.Text.Remove(end.Text.Length - 1) : end.Text);
            }

            if (error)
            {
                DialogResult = DialogResult.None;
                _error = true;
            }
            else
            {
                DialogResult = DialogResult.OK;
                Results = new SavedEvent()
                {
                    Title = TitleTB.Text,
                    Comment = CommentTB.Text,
                    ActivationDate = TimeAndDateUtility.ConvertString_Date(StartPicker.Date),
                    ActivationTime = TimeAndDateUtility.ConvertString_Time(StartPicker.Time),
                    DeactivationDate = TimeAndDateUtility.ConvertString_Date(EndPicker.Date),
                    DeactivationTime = TimeAndDateUtility.ConvertString_Time(EndPicker.Time)
                };

                _error = false;

                ((Form)TopLevelControl).Close();
            }
        }

        private bool CheckStartAndEndDate()
        {
            var startPicker = StartPicker.GetControl();
            var endPicker = EndPicker.GetControl();

            return (startPicker.Value == endPicker.Value) || (startPicker.Value > endPicker.Value);
        }

        private bool CheckMinDate()
        {
            var startPicker = StartPicker.GetControl();
            var endPicker = EndPicker.GetControl();

            return (startPicker.Value < startPicker.MinDate || endPicker.Value < endPicker.MinDate)
                   || (startPicker.Value < DateTime.Now || endPicker.Value < DateTime.Now); 
        }

        private void EventInfo_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (!_error)
            {
                CleanUp();
            }
        }

        #region Cleanup

        public void CleanUp()
        {
            _controls.Remove(_parentId, BMTitle.Tag as string);
            _controls.Remove(_parentId, BMComment.Tag as string);
            _controls.Remove(_parentId, BMStart.Tag as string);
            _controls.Remove(_parentId, BMEnd.Tag as string);

            _controls.Remove(_parentId, BMTitleTB.Tag as string);
            _controls.Remove(_parentId, BMCommentTB.Tag as string);

            _controls.Remove(_parentId, BMStartPicker.Tag as string);
            _controls.Remove(_parentId, BMEndPicker.Tag as string);
        }

        #endregion

        #region Controllers [Only use once view is initialized]

        #region [ TextBoxes ]

        private TextBoxController TitleTB
        {
            get { return (TextBoxController)_controls.Get(_parentId, BMTitleTB.Tag as string); }
        }

        private TextBoxController CommentTB
        {
            get { return (TextBoxController)_controls.Get(_parentId, BMCommentTB.Tag as string); }
        }

        #endregion

        #region [ Date ]

        private DatePickerController StartPicker
        {
            get { return (DatePickerController)_controls.Get(_parentId, BMStartPicker.Tag as string); }
        }

        private DatePickerController EndPicker
        {
            get { return (DatePickerController)_controls.Get(_parentId, BMEndPicker.Tag as string); }
        }

        #endregion

        #region [ Labels ]

        private LabelController Title
        {
            get { return (LabelController)_controls.Get(_parentId, BMTitle.Tag as string); }
        }                                               
                                                        
        private LabelController Comment                 
        {                                               
            get { return (LabelController)_controls.Get(_parentId, BMComment.Tag as string); }
        }                                               
                                                        
        private LabelController Start                   
        {                                               
            get { return (LabelController)_controls.Get(_parentId, BMStart.Tag as string); }
        }                                               
                                                        
        private LabelController End                     
        {                                               
            get { return (LabelController)_controls.Get(_parentId, BMEnd.Tag as string); }
        }

        #endregion

        #endregion
    }
}
