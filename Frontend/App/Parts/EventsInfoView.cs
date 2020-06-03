using System;
using System.Drawing;
using System.Windows.Forms;
using Frontend.View.Controller;
using Frontend.Controller.Prompts;
using Frontend.Controller.Parts;
using Shared.Model;
using Shared.Global;
using Backend.Model;
using Frontend.App.Views;

namespace Frontend.App.Parts
{
    /// <summary>
    /// Partial View Controller
    /// </summary>
    public partial class EventsInfoView : UserControl
    {
        private ControlsAccess _controls;
        private string _parentId;
        private EventViewController _events;
        private CalendarController _calendar;

        private const string DASH = "-";
        private const string NO_COMMENT = "No comment";

        /// <summary>
        /// Contructor for the Partial View Controllers
        /// </summary>
        public EventsInfoView()
        {
            InitializeComponent();
            SetStyle(ControlStyles.OptimizedDoubleBuffer, true);
        }

        /// <summary>
        /// Sets the controls
        /// </summary>
        /// <param name="parentId">The parent id</param>
        /// <param name="controls">The controls</param>
        /// <param name="controller">The controller to use</param>
        public void SetControls(string parentId, ControlsAccess controls, EventViewController controller, string calendarId)
        {
            _controls = controls;
            _parentId = parentId;
            _events = controller;
            _calendar = (CalendarController)_controls.Get(parentId, calendarId);

            Setup();
        }

        private void Setup()
        {
            EventStartDateLB.Tag = _controls.Add(_parentId, new LabelController(EventStartDateLB));
            EventStartTimeLB.Tag = _controls.Add(_parentId, new LabelController(EventStartTimeLB));
            EventEndDateLB.Tag = _controls.Add(_parentId, new LabelController(EventEndDateLB));
            EventEndTimeLB.Tag = _controls.Add(_parentId, new LabelController(EventEndTimeLB));
            EventTitleLB.Tag = _controls.Add(_parentId, new LabelController(EventTitleLB));
            EventStatusLB.Tag = _controls.Add(_parentId, new LabelController(EventStatusLB));
            CompletedDateLB.Tag = _controls.Add(_parentId, new LabelController(CompletedDateLB));
            EventCreateDateLB.Tag = _controls.Add(_parentId, new LabelController(EventCreateDateLB));
            EventCommentTB.Tag = _controls.Add(_parentId, new TextBoxController(EventCommentTB));
            TodaysEventsListBox.Tag = _controls.Add(_parentId, new ListBoxController(TodaysEventsListBox));

            Todays_Events.SetMembers("Title", "Id");
        }

        /// <summary>
        /// Sets the title
        /// </summary>
        /// <param name="title">The title to set</param>
        public void SetTitle(string title)
        {
            YourEvents.Text = title;
        }

        /// <summary>
        /// Whether to use the CRUD buttons
        /// </summary>
        /// <param name="enable">true or false to use the buttons</param>
        public void UseCrudButtons(bool enable)
        {
            CRUDButtonPanel.Enabled = enable;
        }

        public string GetSelectedIndex()
        {
            string id = string.Empty;
            try
            {
                id = ((SavedEvent)Todays_Events.SelectedIndex()).Id;
            }
            catch (Exception)
            {
                //Something happened
            }

            return id;
        }

        /// <summary>
        /// Toggles the CRUD buttons on the view
        /// </summary>
        /// <param name="enable">Whether to enable the CRUD buttons</param>
        public void ToggleButtons(bool enable = false)
        {
            ToggleViewButtons(enable);
        }

        /// <summary>
        /// Updates the views
        /// </summary>
        public void UpdateEvents()
        {
            UpdateTodaysEvents();
            ForceUpdate();
        }

        /// <summary>
        /// Updates the views
        /// </summary>
        /// <param name="date">The date to set</param>
        public void UpdateEvents(DateTime date)
        {
            UpdateTodaysEvents(date);
            ForceUpdate();
        }

        /// <summary>
        /// Updates the views
        /// </summary>
        /// <param name="start">The start date</param>
        /// <param name="end">The end date</param>
        /// <param name="searchTerm">The search term</param>
        public void UpdateEvents(DateTime start, DateTime end, string searchTerm = null)
        {
            DateAndTime startDate = start == DateTime.MaxValue ? null : TimeAndDateUtility.ConvertDateTime_DateAndTime(start);
            DateAndTime endDate = end == DateTime.MinValue ? null : TimeAndDateUtility.ConvertDateTime_DateAndTime(end);

            ClearEventDetails();
            UpdateTodaysEvents(startDate, endDate, searchTerm);
        }

        /// <summary>
        /// Updates the Event Details
        /// </summary>
        public void UpdateEventDetailView()
        {
            UpdateEventDetails();
        }

        /// <summary>
        /// Clears the Event Details
        /// </summary>
        public void ClearEventInfo()
        {
            ClearEventDetails();
        }

        private void TodaysEvents_SelectedIndexChanged(object sender, EventArgs e)
        {
            UpdateEventDetails();
            TodaysEventsListBox.Refresh();
        }

        private void AddEvent_Click(object sender, EventArgs e)
        {
            if (_events.Add())
            {
                if (!_events.SaveEvents())
                    MessageBox.Show("Unable to save some or all events.", "Error Occurred.", MessageBoxButtons.OK, MessageBoxIcon.Error);

                UpdateView();
            }
        }

        private void EditEvent_Click(object sender, EventArgs e)
        {
            string id = ((SavedEvent)Todays_Events.SelectedIndex()).Id;
            if (_events.Update(id))
            {
                if (!_events.SaveEvents())
                    MessageBox.Show("Unable to save some or all events.", "Error Occurred.", MessageBoxButtons.OK, MessageBoxIcon.Error);

                UpdateView();
            }
        }

        private void RemoveButton_Click(object sender, EventArgs e)
        {
            string id = ((SavedEvent)Todays_Events.SelectedIndex()).Id;
            if (_events.Remove(id))
            {
                if (!_events.SaveEvents())
                    MessageBox.Show("Unable to save some or all events.", "Error Occurred.", MessageBoxButtons.OK, MessageBoxIcon.Error);

                UpdateView();
            }
        }

        private void ToggleStatus_Click(object sender, EventArgs e)
        {
            string id = ((SavedEvent)Todays_Events.SelectedIndex()).Id;
            if (_events.ToggleStatus(id))
            {
                if (!_events.SaveEvents())
                    MessageBox.Show("Unable to save some or all events.", "Error Occurred.", MessageBoxButtons.OK, MessageBoxIcon.Error);

                UpdateView();
            }
        }

        private void TodaysEventsListBox_DrawItem(object sender, DrawItemEventArgs e)
        {
            
            TodaysEventsListBox.SuspendLayout();
            
            Font font;
            Brush brush;
            Brush selectedBrush = new SolidBrush(Color.White);
            int status = -1;
            string title = string.Empty;
            Graphics g = e.Graphics;
            ListBox lb = (ListBox)sender;
            int index = e.Index;

            if (index > -1)
            {
                SavedEvent @event = null;
                try { @event = (SavedEvent)lb.Items[index]; } catch (Exception) { /*Something happened*/ }

                if (@event != null)
                {
                    DateAndTime currDate = new DateAndTime(TimeAndDateUtility.GetCurrentDate(), TimeAndDateUtility.GetCurrentTime());
                    DateAndTime eventStartDate = @event.ActivationDate;
                    DateAndTime eventEndDate = @event.DeactivationDate;

                    status = @event.Completed ?
                        4 : TimeAndDateUtility.IsBeforeRange(eventStartDate, currDate) ?
                            1 : TimeAndDateUtility.IsWithinRange(eventStartDate, currDate, eventEndDate) ?
                                2 : 3;

                    title = @event.Title;
                }
            }

            switch (status)
            {
                case 1:
                    e.DrawBackground();
                    font = new Font(FontFamily.GenericSansSerif, 10, FontStyle.Bold);
                    brush = Brushes.DarkSlateGray;
                    break;
                case 2:
                    e.DrawBackground();
                    font = new Font(FontFamily.GenericSansSerif, 10, FontStyle.Italic);
                    brush = Brushes.DarkSlateBlue;
                    break;
                case 3:
                    e.DrawBackground();
                    font = new Font(FontFamily.GenericSansSerif, 10, FontStyle.Regular);
                    brush = Brushes.DarkRed;
                    break;
                case 4:
                    e.DrawBackground();
                    font = new Font(FontFamily.GenericSansSerif, 10, FontStyle.Bold | FontStyle.Italic);
                    brush = Brushes.DarkGreen;
                    break;
                default:
                    font = e.Font;
                    brush = Brushes.Black;
                    break;
            }

            if (index > -1 && lb.SelectedIndex == index)
            {
                g.FillRectangle(Brushes.Blue, e.Bounds);
                g.DrawString(title, font, selectedBrush, e.Bounds, StringFormat.GenericDefault);
            }
            else
            {
                g.FillRectangle(Brushes.White, e.Bounds);
                g.DrawString(title, font, brush, e.Bounds, StringFormat.GenericDefault);
            }

            TodaysEventsListBox.ResumeLayout();
        }

        #region Helpers

        private void UpdateView()
        {
            ClearEventDetails();
            ForceUpdate();
            UpdateTodaysEvents(_calendar.GetControl().SelectionStart);
            ToggleButtons();
            TodaysEventsListBox.Refresh();
        }

        private void ForceUpdate()
        {
            MainApp form = (_controls.Get(_parentId, _parentId) as FormController).GetControl() as MainApp;
            form.UpdateCalendar();
            form.UpdateEventList();
            form.RefreshEventSearch();
        }

        private void SetEventDetails(SavedEvent @event)
        {
            DateAndTime currDate = new DateAndTime(TimeAndDateUtility.GetCurrentDate(), TimeAndDateUtility.GetCurrentTime());
            DateAndTime eventStartDate = @event.ActivationDate;
            DateAndTime eventEndDate = @event.DeactivationDate;

            Exp_Start_Date.SetText(TimeAndDateUtility.ConvertDate_String(@event.ActivationDate.Date, true));
            Exp_Start_Time.SetText(TimeAndDateUtility.ConvertTime_String(@event.ActivationDate.Time));
            Exp_End_Date.SetText(TimeAndDateUtility.ConvertDate_String(@event.DeactivationDate.Date, true));
            Exp_End_Time.SetText(TimeAndDateUtility.ConvertTime_String(@event.DeactivationDate.Time));
            Created_Date.SetText(
                $"{TimeAndDateUtility.ConvertDate_String(@event.CreatedDate.Date, true)} {TimeAndDateUtility.ConvertTime_String(@event.CreatedDate.Time)}");

            Completion_Date.SetText(
                @event.Completed && @event.CompletedDate != null && @event.CompletedDate.Date != null && @event.CompletedDate.Time != null ?
                    $"{TimeAndDateUtility.ConvertDate_String(@event.CompletedDate.Date, true)} {TimeAndDateUtility.ConvertTime_String(@event.CompletedDate.Time)}"
                    : DASH);

            Event_Status.SetText(
                @event.Completed ? "Complete"
                    : TimeAndDateUtility.IsBeforeRange(eventStartDate, currDate) ?
                        "Upcoming"
                        : TimeAndDateUtility.IsWithinRange(eventStartDate, currDate, eventEndDate) ?
                            "In Progress" : "Overdue");
            Event_Status.SetBackColor(
                @event.Completed ? Color.DarkGreen
                    : TimeAndDateUtility.IsBeforeRange(eventStartDate, currDate) ?
                        Color.DarkGray
                        : TimeAndDateUtility.IsWithinRange(eventStartDate, currDate, eventEndDate) ?
                            Color.DarkBlue : Color.DarkRed);

            User_Title.SetText(@event.Title);

            User_Comment.SetText(!string.IsNullOrEmpty(@event.Comment) ? @event.Comment : NO_COMMENT);
        }

        private void ToggleViewButtons(bool enable, bool isBefore = false)
        {
            EditEvent.Enabled = enable;
            RemoveButton.Enabled = enable;
            ToggleEventStatus.Enabled = !isBefore && enable;
            ToggleEventStatus.BackColor = ToggleEventStatus.Enabled ? Color.WhiteSmoke : Color.Transparent;
        }

        private void UpdateEventDetails()
        {
            try
            {
                string id = ((SavedEvent)Todays_Events.SelectedIndex())?.Id;
                if (!string.IsNullOrEmpty(id))
                {
                    SavedEvent @event = _events.GetEvent(id);

                    if (@event != null)
                    {
                        DateAndTime currDate = new DateAndTime(TimeAndDateUtility.GetCurrentDate(), TimeAndDateUtility.GetCurrentTime());

                        SetEventDetails(@event);
                        ToggleViewButtons(true, TimeAndDateUtility.IsBeforeRange(@event.ActivationDate, currDate));
                    }
                }
            }
            catch (Exception)
            {
                // Log
            }
        }

        private void ClearEventDetails()
        {
            Exp_Start_Date.SetText(DASH);
            Exp_Start_Time.SetText(DASH);
            Exp_End_Date.SetText(DASH);
            Exp_End_Time.SetText(DASH);
            Created_Date.SetText(DASH);
            Completion_Date.SetText(DASH);
            User_Title.SetText(DASH);
            Event_Status.SetText(DASH);
            Event_Status.SetBackColor(Color.DarkGray);

            User_Comment.SetText(NO_COMMENT);
        }

        private void UpdateTodaysEvents()
        {
            object[] eventList = _events.GetAll();

            Todays_Events.Update(eventList);
        }

        private void UpdateTodaysEvents(DateTime selectedDate)
        {
            DateAndTime date = TimeAndDateUtility.ConvertDateTime_DateAndTime(selectedDate);
            object[] eventList = _events.GetAll(date);

            Todays_Events.Update(eventList);
        }

        private void UpdateTodaysEvents(DateAndTime start, DateAndTime end, string searchTerm = null)
        {
            object[] eventList = _events.GetAll(start, end, searchTerm);

            Todays_Events.Update(eventList);
        }

        #endregion Helpers

        #region Controllers [Only use once view is initialized]

        #region [ ListBoxes ]

        private ListBoxController Todays_Events => (ListBoxController)_controls.Get(_parentId, TodaysEventsListBox.Tag as string);

        #endregion

        #region [ TextBoxes ]

        private TextBoxController User_Comment => (TextBoxController)_controls.Get(_parentId, EventCommentTB.Tag as string);

        #endregion

        #region [ Labels ]

        private LabelController Exp_Start_Date => (LabelController)_controls.Get(_parentId, EventStartDateLB.Tag as string);

        private LabelController Exp_Start_Time => (LabelController)_controls.Get(_parentId, EventStartTimeLB.Tag as string);

        private LabelController Exp_End_Date => (LabelController)_controls.Get(_parentId, EventEndDateLB.Tag as string);

        private LabelController Exp_End_Time => (LabelController)_controls.Get(_parentId, EventEndTimeLB.Tag as string);

        private LabelController User_Title => (LabelController)_controls.Get(_parentId, EventTitleLB.Tag as string);

        private LabelController Event_Status => (LabelController)_controls.Get(_parentId, EventStatusLB.Tag as string);

        private LabelController Completion_Date => (LabelController)_controls.Get(_parentId, CompletedDateLB.Tag as string);

        private LabelController Created_Date => (LabelController)_controls.Get(_parentId, EventCreateDateLB.Tag as string);

        #endregion

        #endregion
    }
}
