using System;
using System.Windows.Forms;
using TimeAndSched.View.Controller;
using TimeAndSched.FrontEnd.Globals;
using Backend.BusinessLogic.Repository;
using Backend.OutputLogic.Utility;
using Backend.BusinessLogic.Model;

namespace TimeAndSched.App.Index.Views
{
    public partial class EventDetails : Form
    {
        private CrudPurpose _purpose;
        private ControlAccess _controls;
        private bool _error;
        public EventDetailRepository _eventDetailRepo;

        public EventDetail Results { get; private set; }

        public EventDetails()
        {
            InitializeComponent();
            Setup();
            SetPurpose(CrudPurpose.None);
            _eventDetailRepo = new EventDetailRepository();
        }

        public EventDetails(ControlAccess controls)
        {
            _controls = controls;
            InitializeComponent();
            Setup();
            SetPurpose(CrudPurpose.None);
            _eventDetailRepo = new EventDetailRepository();
        }

        public void SetPurpose(CrudPurpose purpose)
        {
            Results = new EventDetail();
            _eventDetailRepo = new EventDetailRepository();
            _error = false;
            _purpose = purpose;
            SetTitle();
        }

        private void SetTitle()
        {
            switch(_purpose)
            {
                case CrudPurpose.None:
                    {
                        Error.Visible = false;
                        BookmarkMaker.Enabled = true;
                        Confirm.Enabled = false;
                        Confirm.Visible = false;
                        BookmarkMaker.Text = "View Bookmark";
                        Confirm.Text = "...";
                        Cancel.Text = "Ok";
                        return;
                    }

                case CrudPurpose.Create:
                    {
                        Error.Visible = false;
                        BookmarkMaker.Enabled = true;
                        Confirm.Enabled = true;
                        Confirm.Visible = true;
                        BookmarkMaker.Text = "Create Bookmark";
                        Confirm.Text = "Create";
                        Cancel.Text = "Cancel";
                        return;
                    }

                case CrudPurpose.Edit:
                    {
                        Error.Visible = false;
                        BookmarkMaker.Enabled = true;
                        Confirm.Enabled = true;
                        Confirm.Visible = true;
                        BookmarkMaker.Text = "Edit Bookmark";
                        Confirm.Text = "Update";
                        Cancel.Text = "Cancel";
                        return;
                    }
                case CrudPurpose.Error:
                    {
                        Error.Visible = true;
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
                        Error.Visible = true;
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

        private void Setup()
        {
            BMTitle.Tag = _controls.Add(ControlType.Label, BMTitle);
            BMComment.Tag = _controls.Add(ControlType.Label, BMComment);
            BMStart.Tag = _controls.Add(ControlType.Label, BMStart);
            BMEnd.Tag = _controls.Add(ControlType.Label, BMEnd);
            
            BMTitleTB.Tag = _controls.Add(ControlType.TextArea, BMTitleTB);
            BMCommentTB.Tag = _controls.Add(ControlType.RichTextArea, BMCommentTB);
            
            BMStartPicker.Tag = _controls.Add(ControlType.DatePicker, BMStartPicker);
            BMStartPicker.MinDate = DateTime.Today;
            BMEndPicker.Tag = _controls.Add(ControlType.DatePicker, BMEndPicker);
        }

        private void Cancel_Click(object sender, EventArgs e)
        {
            var result = MessageBox.Show("Do you want to discard this bookmark?", "You worked so hard on it :(", MessageBoxButtons.YesNo);
            if (result == DialogResult.No || result == DialogResult.None)
            {
                DialogResult = DialogResult.None;
            }
        }

        private void Confirm_Click(object sender, EventArgs e)
        {
            bool error = false;

            if (titleTB.Text == "")
            {
                title.Control.Text = (title.Control.Text.Contains("*") ? title.Control.Text : string.Format("{0}*", title.Control.Text));
                error = true;
            }
            else
            {
                title.Control.Text = (title.Control.Text.Contains("*") ? title.Control.Text.Remove(title.Control.Text.Length - 1) : title.Control.Text);
            }

            if (!checkStartAndEndDate)
            {
                start.Control.Text = (start.Control.Text.Contains("*") ? start.Control.Text : string.Format("{0}*", start.Control.Text));
                end.Control.Text = (end.Control.Text.Contains("*") ? end.Control.Text : string.Format("{0}*", end.Control.Text));
                error = true;
            }
            else if (!checkMinDate)
            {
                start.Control.Text = (start.Control.Text.Contains("*") ? start.Control.Text : string.Format("{0}*", start.Control.Text));
                error = true;
            }
            else
            {
                start.Control.Text = (start.Control.Text.Contains("*") ? start.Control.Text.Remove(start.Control.Text.Length - 1) : start.Control.Text);
                end.Control.Text = (end.Control.Text.Contains("*") ? end.Control.Text.Remove(end.Control.Text.Length - 1) : end.Control.Text);
            }

            if (error)
            {
                DialogResult = DialogResult.None;
                _error = true;
            }
            else
            {
                DialogResult = DialogResult.OK;
                Results = new EventDetail();
                Results = _eventDetailRepo.CreateEvent(
                    titleTB.Text,
                    commentTB.Text,
                    TimeAndDateUtility.ConvertStringDate(startPicker.Date),
                    TimeAndDateUtility.ConvertStringTime(startPicker.Time),
                    TimeAndDateUtility.ConvertStringDate(endPicker.Date),
                    TimeAndDateUtility.ConvertStringTime(endPicker.Time)
                );
                _error = false;
            }
        }

        private bool checkStartAndEndDate
        {
            get { return (startPicker.Control.Value == endPicker.Control.Value
                    && startPicker.Control.Value.ToUniversalTime() < endPicker.Control.Value.ToUniversalTime())
                    || (startPicker.Control.Value < endPicker.Control.Value); }
        }

        private bool checkMinDate
        {
            get { return startPicker.Control.MinDate < startPicker.Control.Value; }
        }

        private void EventDetails_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (!_error)
            {
                cleanUp();
            }
        }

        #region Cleanup

        private void cleanUp()
        {
            _controls.Remove(ControlType.Label, title.Id);
            _controls.Remove(ControlType.Label, comment.Id);
            _controls.Remove(ControlType.Label, start.Id);
            _controls.Remove(ControlType.Label, end.Id);

            _controls.Remove(ControlType.TextArea, titleTB.Id);
            _controls.Remove(ControlType.RichTextArea, commentTB.Id);

            _controls.Remove(ControlType.DatePicker, startPicker.Id);
            _controls.Remove(ControlType.DatePicker, endPicker.Id);
        }

        #endregion

        #region Controllers [Only use once view is initialized]

        #region [ TextBoxes ]

        private TextBoxController titleTB
        {
            get { return (TextBoxController)_controls.Get(ControlType.TextArea, string.Format("{0}", BMTitleTB.Tag)); }
        }

        private RichTBController commentTB {
            get { return (RichTBController)_controls.Get(ControlType.RichTextArea, string.Format("{0}", BMCommentTB.Tag)); }
        }

        #endregion

        #region [ Date ]

        private DatePickerController startPicker
        {
            get { return (DatePickerController)_controls.Get(ControlType.DatePicker, string.Format("{0}", BMStartPicker.Tag)); }
        }

        private DatePickerController endPicker
        {
            get { return (DatePickerController)_controls.Get(ControlType.DatePicker, string.Format("{0}", BMEndPicker.Tag)); }
        }

        #endregion

        #region [ Labels ]

        private LabelController title
        {
            get { return (LabelController)_controls.Get(ControlType.Label, string.Format("{0}", BMTitle.Tag)); }
        }

        private LabelController comment
        {
            get { return (LabelController)_controls.Get(ControlType.Label, string.Format("{0}", BMComment.Tag)); }
        }

        private LabelController start
        {
            get { return (LabelController)_controls.Get(ControlType.Label, string.Format("{0}", BMStart.Tag)); }
        }

        private LabelController end
        {
            get { return (LabelController)_controls.Get(ControlType.Label, string.Format("{0}", BMEnd.Tag)); }
        }


        #endregion

        #endregion
        
    }
}
