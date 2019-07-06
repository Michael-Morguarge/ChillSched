using FrontEnd.Properties;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;
using FrontEnd.View.Controller;
using Shared.Utility;

namespace FrontEnd.View
{
    public partial class MainApp : Form
    {
        private BookmarkViewController _bm;
        private ControlsAccess _controls;

        public MainApp()
        {
            InitializeComponent();
            SetupControls();
        }

        private void SetupControls()
        {
            _controls = new ControlsAccess();

            Tag = _controls.Add((int)ControlsType.Forms, this);

            Time.Tag = _controls.Add((int)ControlsType.Label, Time);
            Date.Tag = _controls.Add((int)ControlsType.Label, Date);
            LatestEvent.Tag = _controls.Add((int)ControlsType.Label, LatestEvent);
            ExpStartDate.Tag = _controls.Add((int)ControlsType.Label, ExpStartDate);
            ExpStartTime.Tag = _controls.Add((int)ControlsType.Label, ExpStartTime);
            ExpEndDate.Tag = _controls.Add((int)ControlsType.Label, ExpEndDate);
            ExpEndTime.Tag = _controls.Add((int)ControlsType.Label, ExpEndTime);
            Title.Tag = _controls.Add((int)ControlsType.Label, Title);

            Comment.Tag = _controls.Add((int)ControlsType.RichTextArea, Comment);

            Calendar.Tag = _controls.Add((int)ControlsType.Calendar, Calendar);

            TodaysEvents.Tag = _controls.Add((int)ControlsType.ListBox, TodaysEvents);

            _bm = new BookmarkViewController(_controls, new List<object> { User_Calendar.Id, Todays_events.Id });

            Time.Text = TimeAndDateUtility.GetCurrentStringTime();
            Date.Text = TimeAndDateUtility.GetCurrentStringDate();

            Bitmap bit = Resources.ChillSched;
            IntPtr pIcon = bit.GetHicon();
            Icon = Icon.FromHandle(pIcon);
            DateTimeIcon.Icon = Icon;
        }

        private void TimeTicker_Tick(object sender, EventArgs e)
        {
            User_Time.Control.Text = TimeAndDateUtility.GetCurrentStringTime();
        }

        private void DateTicker_Tick(object sender, EventArgs e)
        {
            User_Date.Control.Text = TimeAndDateUtility.GetCurrentStringDate();
        }

        private void TodaysEvents_SelectedIndexChanged(object sender, EventArgs e)
        {
            var nextMonthLastWeek = DateTime.Today.AddMonths(1).AddDays(-7);
            var nextMonth = DateTime.Today.AddMonths(1);
            User_Calendar.Control.BoldedDates = new[] { nextMonth };
            User_Calendar.Control.SetDate(nextMonth);
            User_Comment.Control.Text = "Test comment is a test comment that test the comment section that holds the test text that is inside the text column";
            User_Title.Control.Text = "Test Title";
            Exp_Start_Date.Control.Text = string.Format("{0}/{1}/{2}", nextMonth.Month, nextMonth.Day, nextMonth.Year);
            Exp_Start_Time.Control.Text = TimeAndDateUtility.GetCurrentStringTime();
            Exp_End_Date.Control.Text = string.Format("{0}/{1}/{2}", nextMonthLastWeek.Month, nextMonthLastWeek.Day, nextMonthLastWeek.Year);
            Exp_End_Time.Control.Text = TimeAndDateUtility.GetCurrentStringTime();
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

        private void Calendar_DateChanged(object sender, DateRangeEventArgs e)
        {
            MessageBox.Show((string)User_Calendar.Control.Tag);
        }

        private void CreateEvent_Click(object sender, EventArgs e)
        {
            _bm.Add();
        }

        #region Controllers [Only use once view is initialized]

        #region [ ListBoxes ]

        private ListBoxController Todays_events
        {
            get { return ((ListBoxController)_controls.Get((int)ControlsType.ListBox, string.Format("{0}", TodaysEvents.Tag))); }
        }

        #endregion

        #region [ TextBoxes ]

        private RichTBController User_Comment
        {
            get { return ((RichTBController)_controls.Get((int)ControlsType.RichTextArea, string.Format("{0}", Comment.Tag))); }
        }

        #endregion

        #region [ Date ]

        private CalendarController User_Calendar
        {
            get { return ((CalendarController)_controls.Get((int)ControlsType.Calendar, string.Format("{0}", Calendar.Tag))); }
        }

        #endregion

        #region [ Labels ]

        private LabelController User_Time
        {
            get { return ((LabelController)_controls.Get((int)ControlsType.Label, string.Format("{0}", Time.Tag))); }
        }

        private LabelController User_Date
        {
            get { return ((LabelController)_controls.Get((int)ControlsType.Label, string.Format("{0}", Date.Tag))); }
        }

        private LabelController Latest_Event
        {
            get { return ((LabelController)_controls.Get((int)ControlsType.Label, string.Format("{0}", LatestEvent.Tag))); }
        }

        private LabelController Exp_Start_Date
        {
            get { return ((LabelController)_controls.Get((int)ControlsType.Label, string.Format("{0}", ExpStartDate.Tag))); }
        }

        private LabelController Exp_Start_Time
        {
            get { return ((LabelController)_controls.Get((int)ControlsType.Label, string.Format("{0}", ExpStartTime.Tag))); }
        }

        private LabelController Exp_End_Date
        {
            get { return ((LabelController)_controls.Get((int)ControlsType.Label, string.Format("{0}", ExpEndDate.Tag))); }
        }

        private LabelController Exp_End_Time
        {
            get { return ((LabelController)_controls.Get((int)ControlsType.Label, string.Format("{0}", ExpEndTime.Tag))); }
        }

        private LabelController User_Title
        {
            get { return ((LabelController)_controls.Get((int)ControlsType.Label, string.Format("{0}", Title.Tag))); }
        }

        #endregion

        #endregion
    }
}
