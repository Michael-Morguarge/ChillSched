using FrontEnd.Properties;
using System;
using System.Drawing;
using System.Windows.Forms;
using FrontEnd.View.Controller;
using Shared.Global;
using FrontEnd.Controller.Prompts;
using FrontEnd.Controller.Parts;
using System.Linq;
using Backend.Model;

namespace FrontEnd.App.Views
{
    /// <summary>
    /// Partial View Controller
    /// </summary>
    public partial class MainApp : Form
    {
        private ControlsAccess _controls;
        private EventViewController _events;

        /// <summary>
        /// Constructor for Partial View Controller
        /// </summary>
        public MainApp()
        {
            InitializeComponent();
            SetupControls();
        }

        private void SetupControls()
        {
            _controls = new ControlsAccess();
            _events = new EventViewController(_controls);

            Tag = _controls.AddForm(this);
            var tag = Tag as string;

            Time.Tag = _controls.Add(tag, new LabelController(Time));
            Date.Tag = _controls.Add(tag, new LabelController(Date));
            LatestEvent.Tag = _controls.Add(tag, new LabelController(LatestEvent));
            ExpStartDate.Tag = _controls.Add(tag, new LabelController(ExpStartDate));
            ExpStartTime.Tag = _controls.Add(tag, new LabelController(ExpStartTime));
            ExpEndDate.Tag = _controls.Add(tag, new LabelController(ExpEndDate));
            ExpEndTime.Tag = _controls.Add(tag, new LabelController(ExpEndTime));
            Title.Tag = _controls.Add(tag, new LabelController(Title));
            Comment.Tag = _controls.Add(tag, new TextBoxController(Comment));
            Calendar.Tag = _controls.Add(tag, new CalendarController(Calendar));
            TodaysEvents.Tag = _controls.Add(tag, new ListBoxController(TodaysEvents));

            Todays_Events.SetMembers("Title", "Id");
            Time.Text = TimeAndDateUtility.GetCurrentTimeString();
            Date.Text = TimeAndDateUtility.GetCurrentDateString();

            UpdateTodaysEvents();

            Bitmap bit = Resources.ChillSched;
            IntPtr pIcon = bit.GetHicon();
            Icon = Icon.FromHandle(pIcon);
            DateTimeIcon.Icon = Icon;
        }

        private void TimeTicker_Tick(object sender, EventArgs e)
        {
            User_Time.GetControl().Text = TimeAndDateUtility.GetCurrentTimeString();
        }

        private void DateTicker_Tick(object sender, EventArgs e)
        {
            User_Date.GetControl().Text = TimeAndDateUtility.GetCurrentDateString();
        }

        private void Main_Resize(object sender, EventArgs e)
        {
            if (WindowState == FormWindowState.Minimized)
            {
                Hide();
            }
        }

        private void DateTimeIcon_DoubleClick(object sender, EventArgs e)
        {
            Show();
            WindowState = FormWindowState.Normal;
        }

        private void Main_FormClosing(object sender, FormClosingEventArgs e)
        {
            WindowState = FormWindowState.Minimized;
            if (WindowState == FormWindowState.Minimized)
            {
                Hide();
            }
            e.Cancel = true;
        }

        private void TodaysEvents_SelectedIndexChanged(object sender, EventArgs e)
        {
            //Get events to show in listbox
            //Highlight events past date and time

            var id = ((SavedEvent)Todays_Events.SelectedIndex()).Id;
            var @event = _events.GetEvent(id);
            SetEventDetails(@event);
        }

        private void Calendar_DateChanged(object sender, DateRangeEventArgs e)
        {
            User_Calendar.GetControl().BoldedDates = new[] { User_Calendar.GetControl().SelectionStart };
            ClearEventDetails();
            UpdateTodaysEvents();
        }

        private void CreateEvent_Click(object sender, EventArgs e)
        {
            if (_events.Add())
            {
                ClearEventDetails();
                UpdateTodaysEvents();
            }
        }

        private void EditEvent_Click(object sender, EventArgs e)
        {
            var id = ((SavedEvent)Todays_Events.SelectedIndex()).Id;
            if (_events.Update(id))
            {
                ClearEventDetails();
                UpdateTodaysEvents();
            }

        }

        private void RemoveButton_Click(object sender, EventArgs e)
        {

        }

        private void TodaysEvents_SelectedValueChanged(object sender, EventArgs e)
        {

        }

        private void TodaysEvents_Leave(object sender, EventArgs e)
        {

        }

        #region Helpers

        private void SetEventDetails(SavedEvent @event)
        {
            Exp_Start_Date.SetText(TimeAndDateUtility.ConvertDate_String(@event.ActivationDate, true));
            Exp_Start_Time.SetText(TimeAndDateUtility.ConvertTime_String(@event.ActivationTime));
            Exp_End_Date.SetText(TimeAndDateUtility.ConvertDate_String(@event.DeactivationDate, true));
            Exp_End_Time.SetText(TimeAndDateUtility.ConvertTime_String(@event.DeactivationTime));

            User_Title.SetText(@event.Title);

            User_Comment.SetText(@event.Comment);
        }

        private void ClearEventDetails()
        {
            const string dash = "-";
            const string no_comment = "No comment";

            Exp_Start_Date.SetText(dash);
            Exp_Start_Time.SetText(dash);
            Exp_End_Date.SetText(dash);
            Exp_End_Time.SetText(dash);

            User_Title.SetText(dash);

            User_Comment.SetText(no_comment);
        }

        private void UpdateTodaysEvents()
        {
            var selectedDate = User_Calendar.GetControl().SelectionRange.Start;
            User_Calendar.GetControl().BoldedDates = new[] { selectedDate };
            var date = TimeAndDateUtility.ConvertDate_Date(selectedDate);
            var eventList = _events.GetAll(date).OrderBy(x => x.Title).Select(x => (object)x).Distinct().ToArray();

            Todays_Events.Update(eventList);
        }

        #endregion Helpers

        #region Controllers [Only use once view is initialized]

        #region [ ListBoxes ]

        private ListBoxController Todays_Events
        {
            get { return ((ListBoxController)_controls.Get(Tag as string, TodaysEvents.Tag as string)); }
        }

        #endregion

        #region [ TextBoxes ]

        private TextBoxController User_Comment
        {
            get { return ((TextBoxController)_controls.Get(Tag as string, Comment.Tag as string)); }
        }

        #endregion

        #region [ Date ]

        private CalendarController User_Calendar
        {
            get { return ((CalendarController)_controls.Get(Tag as string, Calendar.Tag as string)); }
        }

        #endregion

        #region [ Labels ]

        private LabelController User_Time
        {
            get { return ((LabelController)_controls.Get(Tag as string, Time.Tag as string)); }
        }

        private LabelController User_Date
        {
            get { return ((LabelController)_controls.Get(Tag as string, Date.Tag as string)); }
        }

        private LabelController Latest_Event
        {
            get { return ((LabelController)_controls.Get(Tag as string, LatestEvent.Tag as string)); }
        }

        private LabelController Exp_Start_Date
        {
            get { return ((LabelController)_controls.Get(Tag as string, ExpStartDate.Tag as string)); }
        }

        private LabelController Exp_Start_Time
        {
            get { return ((LabelController)_controls.Get(Tag as string, ExpStartTime.Tag as string)); }
        }

        private LabelController Exp_End_Date
        {
            get { return ((LabelController)_controls.Get(Tag as string, ExpEndDate.Tag as string)); }
        }

        private LabelController Exp_End_Time
        {
            get { return ((LabelController)_controls.Get(Tag as string, ExpEndTime.Tag as string)); }
        }

        private LabelController User_Title
        {
            get { return ((LabelController)_controls.Get(Tag as string, Title.Tag as string)); }
        }


        #endregion

        #endregion
    }
}
