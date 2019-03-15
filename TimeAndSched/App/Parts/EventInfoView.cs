using Backend.BusinessLogic.Model;
using Backend.OutputLogic.Utility;
using System;
using System.Windows.Forms;
using FrontEnd.Globals;
using FrontEnd.View.Controller;

namespace FrontEnd.App.Index.Frameworks
{
    public partial class EventInfoView : UserControl
    {
        public ControlAccess _controls;
        private CrudPurpose _purpose;
        private bool _error;
        
        public bool Error { get; set; }
        public DialogResult DialogResult { get; private set; }
        public EventDetail Results { get; private set; }
        
        public EventInfoView()
        {
            InitializeComponent();
        }

        public void SetControls(ControlAccess controls)
        {
            _controls = controls;
        }

        public void SetPurpose(CrudPurpose purpose)
        {
            Results = new EventDetail();
            _error = false;
            _purpose = purpose;
            SetTitle();
        }

        private void SetTitle()
        {
            switch (_purpose)
            {
                case CrudPurpose.None:
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

                case CrudPurpose.Create:
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

                case CrudPurpose.Edit:
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
                case CrudPurpose.Error:
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

            if (TitleTB.Text == "")
            {
                Title.Control.Text = (Title.Control.Text.Contains("*") ? Title.Control.Text : string.Format("{0}*", Title.Control.Text));
                error = true;
            }
            else
            {
                Title.Control.Text = (Title.Control.Text.Contains("*") ? Title.Control.Text.Remove(Title.Control.Text.Length - 1) : Title.Control.Text);
            }

            if (!CheckStartAndEndDate)
            {
                Start.Control.Text = (Start.Control.Text.Contains("*") ? Start.Control.Text : string.Format("{0}*", Start.Control.Text));
                End.Control.Text = (End.Control.Text.Contains("*") ? End.Control.Text : string.Format("{0}*", End.Control.Text));
                error = true;
            }
            else if (!CheckMinDate)
            {
                Start.Control.Text = (Start.Control.Text.Contains("*") ? Start.Control.Text : string.Format("{0}*", Start.Control.Text));
                error = true;
            }
            else
            {
                Start.Control.Text = (Start.Control.Text.Contains("*") ? Start.Control.Text.Remove(Start.Control.Text.Length - 1) : Start.Control.Text);
                End.Control.Text = (End.Control.Text.Contains("*") ? End.Control.Text.Remove(End.Control.Text.Length - 1) : End.Control.Text);
            }

            if (error)
            {
                DialogResult = DialogResult.None;
                _error = true;
            }
            else
            {
                DialogResult = DialogResult.OK;
                Results = new EventDetail()
                {
                    Title = TitleTB.Text,
                    Comment = CommentTB.Text,
                    ActivationDate = TimeAndDateUtility.ConvertStringDate(StartPicker.Date),
                    ActivationTime = TimeAndDateUtility.ConvertStringTime(StartPicker.Time),
                    DeactivationDate = TimeAndDateUtility.ConvertStringDate(EndPicker.Date),
                    DeactivationTime = TimeAndDateUtility.ConvertStringTime(StartPicker.Time)
                };

                _error = false;
            }
        }

        private bool CheckStartAndEndDate
        {
            get
            {
                return (StartPicker.Control.Value == EndPicker.Control.Value
                  && StartPicker.Control.Value.ToUniversalTime() < EndPicker.Control.Value.ToUniversalTime())
                  || (StartPicker.Control.Value < EndPicker.Control.Value);
            }
        }

        private bool CheckMinDate
        {
            get { return StartPicker.Control.MinDate < StartPicker.Control.Value; }
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
            _controls.Remove(ControlType.Label, Title.Id);
            _controls.Remove(ControlType.Label, Comment.Id);
            _controls.Remove(ControlType.Label, Start.Id);
            _controls.Remove(ControlType.Label, End.Id);

            _controls.Remove(ControlType.TextArea, TitleTB.Id);
            _controls.Remove(ControlType.RichTextArea, CommentTB.Id);

            _controls.Remove(ControlType.DatePicker, StartPicker.Id);
            _controls.Remove(ControlType.DatePicker, EndPicker.Id);
        }

        #endregion

        #region Controllers [Only use once view is initialized]

        #region [ TextBoxes ]

        private TextBoxController TitleTB
        {
            get { return (TextBoxController)_controls.Get(ControlType.TextArea, string.Format("{0}", BMTitleTB.Tag)); }
        }

        private RichTBController CommentTB
        {
            get { return (RichTBController)_controls.Get(ControlType.RichTextArea, string.Format("{0}", BMCommentTB.Tag)); }
        }

        #endregion

        #region [ Date ]

        private DatePickerController StartPicker
        {
            get { return (DatePickerController)_controls.Get(ControlType.DatePicker, string.Format("{0}", BMStartPicker.Tag)); }
        }

        private DatePickerController EndPicker
        {
            get { return (DatePickerController)_controls.Get(ControlType.DatePicker, string.Format("{0}", BMEndPicker.Tag)); }
        }

        #endregion

        #region [ Labels ]

        private LabelController Title
        {
            get { return (LabelController)_controls.Get(ControlType.Label, string.Format("{0}", BMTitle.Tag)); }
        }

        private LabelController Comment
        {
            get { return (LabelController)_controls.Get(ControlType.Label, string.Format("{0}", BMComment.Tag)); }
        }

        private LabelController Start
        {
            get { return (LabelController)_controls.Get(ControlType.Label, string.Format("{0}", BMStart.Tag)); }
        }

        private LabelController End
        {
            get { return (LabelController)_controls.Get(ControlType.Label, string.Format("{0}", BMEnd.Tag)); }
        }


        #endregion

        #endregion

    }
}
