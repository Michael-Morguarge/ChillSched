using Backend.Model;
using System;
using System.Windows.Forms;
using Frontend.View.Controller;
using Shared.Global;
using Frontend.Controller.Parts;
using Frontend.Controller.Models;

namespace Frontend.App.Parts
{
    /// <summary>
    /// Partial View Controller
    /// </summary>
    public partial class EventInfoView : UserControl
    {
        private CrudPurposes _purpose;
        private string _parentId;
        private ControlsAccess _controls;

        /// <summary>
        /// The data of the prompt
        /// </summary>
        public DialogResultData<SavedEvent> Data { get; private set; }
        
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
            Data = new DialogResultData<SavedEvent>();
            Setup();
        }

        private void Setup()
        {
            TitleLB.Tag = _controls.Add(_parentId, new LabelController(TitleLB));
            StartLB.Tag = _controls.Add(_parentId, new LabelController(StartLB));
            EndLB.Tag = _controls.Add(_parentId, new LabelController(EndLB));

            EventTitleTB.Tag = _controls.Add(_parentId, new TextBoxController(EventTitleTB));
            EventCommentTB.Tag = _controls.Add(_parentId, new TextBoxController(EventCommentTB));

            StartPickerDP.Tag = _controls.Add(_parentId, new DatePickerController(StartPickerDP));
            StartPickerDP.MinDate = DateTime.Now;
            EndPickerDP.Tag = _controls.Add(_parentId, new DatePickerController(EndPickerDP));
            EndPickerDP.MinDate = DateTime.Now;
        }

        public void SetPurpose(CrudPurposes purpose)
        {
            Data.Results = new SavedEvent();
            Data.Error = false;
            _purpose = purpose;
            SetTitle();
        }

        public void SetValues(SavedEvent @event)
        {
            TitleTB.SetText(@event.Title);
            CommentTB.SetText(@event.Comment ?? string.Empty);
            DateTime now = DateTime.Now;

            DateTime start = TimeAndDateUtility.ConvertDateAndTime_Date(@event.ActivationDate, @event.ActivationTime);
            DateTime end = TimeAndDateUtility.ConvertDateAndTime_Date(@event.DeactivationDate, @event.DeactivationTime);

            StartPicker.SetDates(now > start ? start.Date : now.Date, start, DateTime.MaxValue);
            EndPicker.SetDates(now > end ? end.Date : now.Date, end, DateTime.MaxValue);

            if (start < now)
            {
                StartPicker.GetControl().Enabled = false;
            }

            if (end < now)
            {
                EndPicker.GetControl().Enabled = false;
            }

            if (!StartPicker.GetControl().Enabled && !EndPicker.GetControl().Enabled)
            {
                TitleTB.GetControl().Enabled = false;
                CommentTB.GetControl().Enabled = false;

                _purpose = CrudPurposes.None;
                SetTitle();
            }
        }

        private void SetTitle()
        {
            switch (_purpose)
            {
                case CrudPurposes.None:
                    {
                        Data.Error = false;
                        EventModal.Enabled = true;
                        Confirm.Enabled = false;
                        Confirm.Visible = false;
                        EventModal.Text = "View Event";
                        Confirm.Text = "...";
                        Cancel.Text = "Ok";
                        break;
                    }

                case CrudPurposes.Create:
                    {
                        Data.Error = false;
                        EventModal.Enabled = true;
                        Confirm.Enabled = true;
                        Confirm.Visible = true;
                        EventModal.Text = "Create Event";
                        Confirm.Text = "Create";
                        Cancel.Text = "Cancel";
                        break;
                    }

                case CrudPurposes.Edit:
                    {
                        Data.Error = false;
                        EventModal.Enabled = true;
                        Confirm.Enabled = true;
                        Confirm.Visible = true;
                        EventModal.Text = "Edit Event";
                        Confirm.Text = "Update";
                        Cancel.Text = "Cancel";
                        break;
                    }

                case CrudPurposes.Error:
                    {
                        Data.Error = true;
                        Confirm.Enabled = false;
                        Confirm.Visible = false;
                        EventModal.Enabled = false;
                        EventModal.Visible = false;
                        EventModal.Text = "Error";
                        Confirm.Text = "...";
                        Cancel.Text = "Ok";
                        break;
                    }

                default:
                    {
                        Data.Error = true;
                        Confirm.Enabled = false;
                        Confirm.Visible = false;
                        EventModal.Enabled = false;
                        EventModal.Visible = false;
                        EventModal.Text = "...";
                        Confirm.Text = "...";
                        Cancel.Text = "Ok";
                        return;
                    }
            }
        }

        private void Cancel_Click(object sender, EventArgs e)
        {
            if (Cancel.Text == "Ok")
            {
                Data.DialogResult = DialogResult.Cancel;
            }
            else
            {
                DialogResult result = MessageBox.Show("Do you want to discard the changes to the Event?", "All progress lost if not submitted", MessageBoxButtons.YesNo);

                if (result == DialogResult.Yes)
                {
                    Data.DialogResult = DialogResult.Cancel;
                }
                else if (result == DialogResult.No || result == DialogResult.None)
                {
                    Data.DialogResult = DialogResult.None;
                }
            }
        }

        private void Confirm_Click(object sender, EventArgs e)
        {
            bool error = false;
            Label title = Title.GetControl();

            if (TitleTB.Text == string.Empty)
            {
                Title.SetText(title.Text.Contains("*") ? title.Text : string.Format("{0}*", title.Text));
                error = true;
            }
            else
            {
                Title.SetText(title.Text.Contains("*") ? title.Text.Remove(title.Text.Length - 1) : title.Text);
            }

            Label start = Start.GetControl();
            Label end = End.GetControl();
            if (CheckStartAndEndDate())
            {
                Start.SetText(start.Text.Contains("*") ? start.Text : string.Format("{0}*", start.Text));
                End.SetText(end.Text.Contains("*") ? end.Text : string.Format("{0}*", end.Text));
                error = true;
            }
            else if (CheckMinDate())
            {
                Start.SetText(start.Text.Contains("*") ? start.Text : string.Format("{0}*", start.Text));
                End.SetText(end.Text.Contains("*") ? end.Text : string.Format("{0}*", end.Text));
                error = true;
            }
            else
            {
                Start.SetText(start.Text.Contains("*") ? start.Text.Remove(start.Text.Length - 1) : start.Text);
                End.SetText(end.Text.Contains("*") ? end.Text.Remove(end.Text.Length - 1) : end.Text);
            }

            if (error)
            {
                Data.DialogResult = DialogResult.None;
                Data.Error = true;
            }
            else
            {
                Data.DialogResult = DialogResult.OK;
                Data.Results = new SavedEvent()
                {
                    Title = TitleTB.Text,
                    Comment = CommentTB.Text,
                    ActivationDate = TimeAndDateUtility.ConvertString_Date(StartPicker.Date),
                    ActivationTime = TimeAndDateUtility.ConvertString_Time(StartPicker.Time),
                    DeactivationDate = TimeAndDateUtility.ConvertString_Date(EndPicker.Date),
                    DeactivationTime = TimeAndDateUtility.ConvertString_Time(EndPicker.Time)
                };

                Data.Error = false;

                ((Form)TopLevelControl).Close();
            }
        }

        private bool CheckStartAndEndDate()
        {
            DateTimePicker startPicker = StartPicker.GetControl();
            DateTimePicker endPicker = EndPicker.GetControl();

            return (startPicker.Value == endPicker.Value) || (startPicker.Value > endPicker.Value);
        }

        private bool CheckMinDate()
        {
            DateTimePicker startPicker = StartPicker.GetControl();
            DateTimePicker endPicker = EndPicker.GetControl();

            return (startPicker.Enabled && (startPicker.Value < startPicker.MinDate || startPicker.Value < DateTime.Now))
                   || (endPicker.Enabled && (endPicker.Value < endPicker.MinDate || endPicker.Value < DateTime.Now));
        }

        #region Cleanup

        public void CleanUp()
        {
            _controls.Remove(_parentId, Title.GetId());
            _controls.Remove(_parentId, Start.GetId());
            _controls.Remove(_parentId, End.GetId());

            _controls.Remove(_parentId, TitleTB.GetId());
            _controls.Remove(_parentId, CommentTB.GetId());

            _controls.Remove(_parentId, StartPicker.GetId());
            _controls.Remove(_parentId, EndPicker.GetId());
        }

        #endregion

        #region Controllers [Only use once view is initialized]

        #region [ TextBoxes ]

        private TextBoxController TitleTB => (TextBoxController)_controls.Get(_parentId, EventTitleTB.Tag as string);

        private TextBoxController CommentTB => (TextBoxController)_controls.Get(_parentId, EventCommentTB.Tag as string);

        #endregion

        #region [ Date ]

        private DatePickerController StartPicker => (DatePickerController)_controls.Get(_parentId, StartPickerDP.Tag as string);

        private DatePickerController EndPicker => (DatePickerController)_controls.Get(_parentId, EndPickerDP.Tag as string);

        #endregion

        #region [ Labels ]

        private LabelController Title => (LabelController)_controls.Get(_parentId, TitleLB.Tag as string);

        private LabelController Start => (LabelController)_controls.Get(_parentId, StartLB.Tag as string);

        private LabelController End => (LabelController)_controls.Get(_parentId, EndLB.Tag as string);

        #endregion

        #endregion
    }
}
