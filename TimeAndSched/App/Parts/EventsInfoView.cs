using System;
using System.Drawing;
using System.Windows.Forms;
using FrontEnd.View.Controller;
using FrontEnd.Controller.Prompts;
using FrontEnd.Controller.Parts;
using Shared.Model;
using Shared.Global;
using Backend.Model;
using FrontEnd.App.Views;

namespace FrontEnd.App.Parts
{
    /// <summary>
    /// Partial View Controller
    /// </summary>
    public partial class EventsInfoView : UserControl
    {
        private ControlsAccess _controls;
        private string _parentId;
        private EventViewController _controller;
        private CalendarController _calendar;

        /// <summary>
        /// Contructor for the Partial View Controllers
        /// </summary>
        public EventsInfoView()
        {
            InitializeComponent();
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
            _controller = controller;
            _calendar = (CalendarController)_controls.Get(parentId, calendarId);

            Setup();
        }

        private void Setup()
        {
            ExpStartDate.Tag = _controls.Add(_parentId, new LabelController(ExpStartDate));
            ExpStartTime.Tag = _controls.Add(_parentId, new LabelController(ExpStartTime));
            ExpEndDate.Tag = _controls.Add(_parentId, new LabelController(ExpEndDate));
            ExpEndTime.Tag = _controls.Add(_parentId, new LabelController(ExpEndTime));
            Title.Tag = _controls.Add(_parentId, new LabelController(Title));
            EventStatus.Tag = _controls.Add(_parentId, new LabelController(EventStatus));
            CompletedDate.Tag = _controls.Add(_parentId, new LabelController(CompletedDate));
            CreateDate.Tag = _controls.Add(_parentId, new LabelController(CreateDate));
            Comment.Tag = _controls.Add(_parentId, new TextBoxController(Comment));
            TodaysEvents.Tag = _controls.Add(_parentId, new ListBoxController(TodaysEvents));

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

        public void ToggleButtons(bool enable = false)
        {
            ToggleViewButtons(enable);
        }

        public void UpdateEvents()
        {
            UpdateTodaysEvents();
            ForceUpdate();
        }

        public void UpdateEvents(DateTime date)
        {
            UpdateTodaysEvents(date);
            ForceUpdate();
        }

        public void UpdateEvents(DateTime start, DateTime end, string searchTerm = null)
        {
            Date startDate = start == DateTime.MaxValue ? null : TimeAndDateUtility.ConvertDate_Date(start);
            Date endDate = end == DateTime.MinValue ? null : TimeAndDateUtility.ConvertDate_Date(end);

            ClearEventDetails();
            UpdateTodaysEvents(startDate, endDate, searchTerm);
        }

        public void UpdateEventDetailView()
        {
            UpdateEventDetails();
        }

        public void ClearEventInfo()
        {
            ClearEventDetails();
        }

        private void TodaysEvents_SelectedIndexChanged(object sender, EventArgs e)
        {
            UpdateEventDetails();
        }

        private void AddEvent_Click(object sender, EventArgs e)
        {
            if (_controller.Add())
            {
                _controller.SaveEvents();
                ClearEventDetails();
                UpdateTodaysEvents(_calendar.GetControl().SelectionStart);
                ToggleButtons();
                ForceUpdate();
            }
        }

        private void EditEvent_Click(object sender, EventArgs e)
        {
            string id = ((SavedEvent)Todays_Events.SelectedIndex()).Id;
            if (_controller.Update(id))
            {
                _controller.SaveEvents();
                ClearEventDetails();
                ForceUpdate();
                UpdateTodaysEvents(_calendar.GetControl().SelectionStart);
                ToggleButtons();
            }
        }

        private void RemoveButton_Click(object sender, EventArgs e)
        {
            string id = ((SavedEvent)Todays_Events.SelectedIndex()).Id;
            if (_controller.Remove(id))
            {
                _controller.SaveEvents();
                ClearEventDetails();
                ForceUpdate();
                UpdateTodaysEvents(_calendar.GetControl().SelectionStart);
                ToggleButtons();
            }
        }

        private void ToggleStatus_Click(object sender, EventArgs e)
        {
            string id = ((SavedEvent)Todays_Events.SelectedIndex()).Id;
            if (_controller.ToggleStatus(id))
            {
                _controller.SaveEvents();
                ClearEventDetails();
                ForceUpdate();
                UpdateTodaysEvents(_calendar.GetControl().SelectionStart);
                ToggleButtons();
            }
        }

        #region Helpers

        private void ForceUpdate()
        {
            MainApp form = (_controls.Get(_parentId, _parentId) as FormController).GetControl() as MainApp;
            form.UpdateCalendar();
            form.UpdateEventList();
        }

        private void SetEventDetails(SavedEvent @event)
        {
            Date currDate = TimeAndDateUtility.GetCurrentDate();
            Time currTime = TimeAndDateUtility.GetCurrentTime();

            Date eventStartDate = @event.ActivationDate;
            Time eventStartTime = @event.ActivationTime;

            Date eventEndDate = @event.DeactivationDate;
            Time eventEndTime = @event.DeactivationTime;

            Exp_Start_Date.SetText(TimeAndDateUtility.ConvertDate_String(@event.ActivationDate, true));
            Exp_Start_Time.SetText(TimeAndDateUtility.ConvertTime_String(@event.ActivationTime));
            Exp_End_Date.SetText(TimeAndDateUtility.ConvertDate_String(@event.DeactivationDate, true));
            Exp_End_Time.SetText(TimeAndDateUtility.ConvertTime_String(@event.DeactivationTime));
            Created_Date.SetText(
                $"{TimeAndDateUtility.ConvertDate_String(@event.DateCreated, true)} {TimeAndDateUtility.ConvertTime_String(@event.TimeCreated)}");

            if (@event.Completed && @event.DateCompleted != null && @event.TimeCompleted != null)
            {
                Completion_Date.SetText(
                    $"{TimeAndDateUtility.ConvertDate_String(@event.DateCompleted, true)} {TimeAndDateUtility.ConvertTime_String(@event.TimeCompleted)}");
            }

            Event_Status.SetText(
                @event.Completed ? "Complete"
                    : TimeAndDateUtility.IsBeforeRange(eventStartDate, eventStartTime, currDate, currTime) ?
                        "Upcoming"
                        : TimeAndDateUtility.IsWithinRange(eventStartDate, eventStartTime, currDate, currTime, eventEndDate, eventEndTime) ?
                            "In Progress" : "Overdue");
            Event_Status.SetBackColor(
                @event.Completed ? Color.DarkGreen
                    : TimeAndDateUtility.IsBeforeRange(eventStartDate, eventStartTime, currDate, currTime) ?
                        Color.DarkGray
                        : TimeAndDateUtility.IsWithinRange(eventStartDate, eventStartTime, currDate, currTime, eventEndDate, eventEndTime) ?
                            Color.DarkBlue : Color.DarkRed);

            User_Title.SetText(@event.Title);

            User_Comment.SetText(@event.Comment);
        }

        private void ToggleViewButtons(bool enable, bool isBefore = false)
        {
            EditEvent.Enabled = enable;
            RemoveButton.Enabled = enable;
            ToggleStatus.Enabled = !isBefore && enable;
            ToggleStatus.BackColor = ToggleStatus.Enabled ? Color.WhiteSmoke : Color.Transparent;
        }

        private void UpdateEventDetails()
        {
            try
            {
                string id = ((SavedEvent)Todays_Events.SelectedIndex())?.Id;
                if (!string.IsNullOrEmpty(id))
                {
                    SavedEvent @event = _controller.GetEvent(id);

                    if (@event != null)
                    {
                        Date currDate = TimeAndDateUtility.GetCurrentDate();
                        Time currTime = TimeAndDateUtility.GetCurrentTime();

                        Date eventStartDate = @event.ActivationDate;
                        Time eventStartTime = @event.ActivationTime;

                        SetEventDetails(@event);
                        ToggleViewButtons(true, TimeAndDateUtility.IsBeforeRange(eventStartDate, eventStartTime, currDate, currTime));
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
            const string dash = "-";
            const string no_comment = "No comment";

            Exp_Start_Date.SetText(dash);
            Exp_Start_Time.SetText(dash);
            Exp_End_Date.SetText(dash);
            Exp_End_Time.SetText(dash);
            Created_Date.SetText(dash);
            Completion_Date.SetText(dash);
            Event_Status.SetText(dash);
            Event_Status.SetBackColor(Color.DarkGray);

            User_Title.SetText(dash);

            User_Comment.SetText(no_comment);
        }

        private void UpdateTodaysEvents()
        {
            object[] eventList = _controller.GetAll();

            Todays_Events.Update(eventList);
        }

        private void UpdateTodaysEvents(DateTime selectedDate)
        {
            Date date = TimeAndDateUtility.ConvertDate_Date(selectedDate);
            object[] eventList = _controller.GetAll(date);

            Todays_Events.Update(eventList);
        }

        private void UpdateTodaysEvents(Date start, Date end, string searchTerm = null)
        {
            object[] eventList = _controller.GetAll(start, end, searchTerm);

            Todays_Events.Update(eventList);
        }

        #endregion Helpers

        #region Controllers [Only use once view is initialized]

        #region [ ListBoxes ]

        private ListBoxController Todays_Events => (ListBoxController)_controls.Get(_parentId, TodaysEvents.Tag as string);

        #endregion

        #region [ TextBoxes ]

        private TextBoxController User_Comment => (TextBoxController)_controls.Get(_parentId, Comment.Tag as string);

        #endregion

        #region [ Labels ]

        private LabelController Exp_Start_Date => (LabelController)_controls.Get(_parentId, ExpStartDate.Tag as string);

        private LabelController Exp_Start_Time => (LabelController)_controls.Get(_parentId, ExpStartTime.Tag as string);

        private LabelController Exp_End_Date => (LabelController)_controls.Get(_parentId, ExpEndDate.Tag as string);

        private LabelController Exp_End_Time => (LabelController)_controls.Get(_parentId, ExpEndTime.Tag as string);

        private LabelController User_Title => (LabelController)_controls.Get(_parentId, Title.Tag as string);

        private LabelController Event_Status => (LabelController)_controls.Get(_parentId, EventStatus.Tag as string);

        private LabelController Completion_Date => (LabelController)_controls.Get(_parentId, CompletedDate.Tag as string);

        private LabelController Created_Date => (LabelController)_controls.Get(_parentId, CreateDate.Tag as string);

        #endregion

        #endregion
    }
}
