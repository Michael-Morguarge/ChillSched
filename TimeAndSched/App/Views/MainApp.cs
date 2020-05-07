using FrontEnd.Properties;
using System;
using System.Drawing;
using System.Windows.Forms;
using FrontEnd.View.Controller;
using Shared.Global;
using FrontEnd.Controller.Prompts;
using FrontEnd.Controller.Parts;
using Shared.Model;

namespace FrontEnd.App.Views
{
    /// <summary>
    /// Partial View Controller
    /// </summary>
    public partial class MainApp : Form
    {
        private ControlsAccess _controls;
        private EventViewController _events;
        private MessageViewController _messages;

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
            _messages = new MessageViewController(_controls);
            Setup();

            _events.LoadEvents();
            UpdateCalendar();
            EIV.UpdateEvents(DateTime.Today);
            SEIV.UpdateEvents();
            UpdateEventList();
        }

        private void Setup()
        {
            Tag = _controls.AddForm(this);
            string tag = Tag as string;

            Time.Tag = _controls.Add(tag, new LabelController(Time));
            Date.Tag = _controls.Add(tag, new LabelController(Date));
            LatestEvent.Tag = _controls.Add(tag, new LabelController(LatestEvent));
            LastUpdated.Tag = _controls.Add(tag, new LabelController(LastUpdated));
            StartDateLbl.Tag = _controls.Add(tag, new LabelController(StartDateLbl));
            EndDateLbl.Tag = _controls.Add(tag, new LabelController(EndDateLbl));
            Calendar.Tag = _controls.Add(tag, new CalendarController(Calendar));
            EventListView.Tag = _controls.Add(tag, new ListViewController(EventListView));
            TextTB.Tag = _controls.Add(tag, new TextBoxController(TextTB));
            SearchStartDate.Tag = _controls.Add(tag, new DatePickerController(SearchStartDate));
            SearchEndDate.Tag = _controls.Add(tag, new DatePickerController(SearchEndDate));

            EIV.SetControls(tag, _controls, _events, User_Calendar.GetId());
            EIV.SetTitle("Events for Day");
            EIV.UseCrudButtons(true);

            SEIV.SetControls(tag, _controls, _events, User_Calendar.GetId());
            SEIV.SetTitle("Events");
            SEIV.UseCrudButtons(false);

            MMV.SetControls(tag, _controls, _messages);
            MMV.SetTitle("Messages");

            User_Time.SetText(TimeAndDateUtility.GetCurrentTimeString());
            User_Date.SetText(TimeAndDateUtility.GetCurrentDateString());

            Bitmap bit = Resources.ChillSched;
            IntPtr pIcon = bit.GetHicon();
            Icon = Icon.FromHandle(pIcon);
            DateTimeIcon.Icon = Icon;
        }

        private void TimeTicker_Tick(object sender, EventArgs e)
        {
            Time time = TimeAndDateUtility.GetCurrentTime();
            string timeString = TimeAndDateUtility.ConvertTime_String(time);

            User_Time.SetText(timeString);
            NextUpdateProgress.Value = time.Seconds % 15;

            if (time.Seconds % 15 == 0)
            {
                UpdateEventList();
            }

            if (time.Seconds % 5 == 0)
            {
                EIV.UpdateEventDetailView();
                SEIV.UpdateEventDetailView();
            }
        }

        private void DateTicker_Tick(object sender, EventArgs e)
        {
            User_Date.SetText(TimeAndDateUtility.GetCurrentDateString());
        }

        private void Main_Resize(object sender, EventArgs e)
        {
            if (WindowState == FormWindowState.Minimized)
            {
                ShowInTaskbar = false;
                Hide();
            }
        }

        private void DateTimeIcon_DoubleClick(object sender, EventArgs e)
        {
            Show();
            WindowState = FormWindowState.Normal;
            TopMost = true;
            TopMost = false;
            ShowInTaskbar = true;
        }

        private void AboutStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("ChillSched - 2020", "About");
        }

        private void Main_FormClosing(object sender, FormClosingEventArgs e)
        {
            DialogResult result = MessageBox.Show("Are you sure you want to exit?", "Exit ChillSched", MessageBoxButtons.YesNo);
            if (result == DialogResult.Yes)
            {
                _events.SaveEvents();
            }
            else
            {
                e.Cancel = true;
            }
        }

        private void CloseStripMenuItem_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void Calendar_DateChanged(object sender, DateRangeEventArgs e)
        {
            EIV.ClearEventInfo();
            EIV.UpdateEvents(User_Calendar.GetControl().SelectionRange.Start);
            EIV.ToggleButtons();
        }

        private void CreateEvent_Click(object sender, EventArgs e)
        {
            if (_events.Add())
            {
                _events.SaveEvents();
                EIV.ClearEventInfo();
                EIV.UpdateEvents(User_Calendar.GetControl().SelectionRange.Start);
                EIV.ToggleButtons();
            }
        }

        private void EventBackupStripMenuItem_Click(object sender, EventArgs e)
        {
            _events.SaveEvents();
            MessageBox.Show("Successully saved events. Events save on every add, edit, delete.", "Events saved");
        }

        private void UseStartDate_CheckedChanged(object sender, EventArgs e)
        {
            if (UseStartDate.Checked)
            {
                Start_Date.SetForeColor(Color.Black);
                Search_Start.Enable(true);
            }
            else
            {
                Start_Date.SetForeColor(Color.DimGray);
                Search_Start.Enable(false);
            }
        }

        private void UseEndDate_CheckedChanged(object sender, EventArgs e)
        {
            if (UseEndDate.Checked)
            {
                End_Date.SetForeColor(Color.Black);
                Search_End.Enable(true);
            }
            else
            {
                End_Date.SetForeColor(Color.DimGray);
                Search_End.Enable(false);
            }
        }

        private void TextTB_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                SearchBTN.PerformClick();
            }
        }

        private void SearchBTN_Click(object sender, EventArgs e)
        {
            string searchTerm = Search_Box.Text;
            DateTime start = UseStartDate.Checked ? DateTime.Parse(Search_Start.Date).Date : DateTime.MaxValue;
            DateTime end = UseEndDate.Checked ? 
                DateTime.Parse(Search_End.Date).Date.AddHours(23).AddMinutes(59).AddSeconds(59)
                : DateTime.MinValue;

            SEIV.UpdateEvents(start, end, searchTerm);
        }

        #region Helpers

        internal void UpdateCalendar()
        {
            DateTime[] dates = _events.GetAllEventDates();
            User_Calendar.SetBoldedDates(dates);
        }

        internal void UpdateEventList()
        {
            ListViewItem[] events = _events.GetAll(EventListView.Groups);

            Time time = TimeAndDateUtility.GetCurrentTime();
            string timeString = TimeAndDateUtility.ConvertTime_String(time);
            string dateString = TimeAndDateUtility.GetCurrentDateString(true);
            Event_View.Update(events);
            Last_Updated.SetText($"Last Updated: {dateString} {timeString}");
        }

        #endregion Helpers

        #region Controllers [Only use once view is initialized]

        #region [ ListBoxes ]

        private ListViewController Event_View => (ListViewController)_controls.Get(Tag as string, EventListView.Tag as string);

        #endregion

        #region [ Date ]

        private CalendarController User_Calendar => (CalendarController)_controls.Get(Tag as string, Calendar.Tag as string);

        private DatePickerController Search_Start => (DatePickerController)_controls.Get(Tag as string, SearchStartDate.Tag as string);

        private DatePickerController Search_End => (DatePickerController)_controls.Get(Tag as string, SearchEndDate.Tag as string);

        #endregion

        #region [ Labels ]

        private LabelController User_Time => (LabelController)_controls.Get(Tag as string, Time.Tag as string);

        private LabelController User_Date => (LabelController)_controls.Get(Tag as string, Date.Tag as string);

        private LabelController Last_Updated => (LabelController)_controls.Get(Tag as string, LastUpdated.Tag as string);

        private LabelController Start_Date => (LabelController)_controls.Get(Tag as string, StartDateLbl.Tag as string);

        private LabelController End_Date => (LabelController)_controls.Get(Tag as string, EndDateLbl.Tag as string);

        #endregion

        #region [ TextBoxes ]

        private TextBoxController Search_Box => (TextBoxController)_controls.Get(Tag as string, TextTB.Tag as string);

        #endregion

        #endregion
    }
}
