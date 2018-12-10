using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TimeAndSched.App.Index.Controller;
using TimeAndSched.App.Index.Utility;
using TimeAndSched.App.Index.Views;
using TimeAndSched.Backend.Globals;
using TimeAndSched.Controller.View;

namespace TimeAndSched.View
{
    public partial class Main : Form
    {
        private BookmarkViewController _bm;
        private ControlAccess _controls;

        public Main()
        {
            InitializeComponent();
            Setup();
        }

        private void Setup()
        {
            _controls = new ControlAccess();

            Tag = _controls.Add(ControlType.Forms, this);

            Time.Tag = _controls.Add(ControlType.Label, Time);
            Date.Tag = _controls.Add(ControlType.Label, Date);
            LatestEvent.Tag = _controls.Add(ControlType.Label, LatestEvent);
            ExpStartDate.Tag = _controls.Add(ControlType.Label, ExpStartDate);
            ExpStartTime.Tag = _controls.Add(ControlType.Label, ExpStartTime);
            ExpEndDate.Tag = _controls.Add(ControlType.Label, ExpEndDate);
            ExpEndTime.Tag = _controls.Add(ControlType.Label, ExpEndTime);
            Title.Tag = _controls.Add(ControlType.Label, Title);

            Comment.Tag = _controls.Add(ControlType.RichTextArea, Comment);

            Calendar.Tag = _controls.Add(ControlType.Calendar, Calendar);

            TodaysEvents.Tag = _controls.Add(ControlType.ListBox, TodaysEvents);

            _bm = new BookmarkViewController(_controls, new List<object> { calendar.Id, todays_events.Id });

            Time.Text = TimeUtility.GetCurrentTime();
            Date.Text = TimeUtility.GetCurrentDate();

            Bitmap bit = Properties.Resources.ChillSched;
            IntPtr pIcon = bit.GetHicon();
            Icon = Icon.FromHandle(pIcon);
            DateTimeIcon.Icon = Icon;
        }

        private void TimeTicker_Tick(object sender, EventArgs e)
        {
            time.Control.Text = TimeUtility.GetCurrentTime();
        }

        private void DateTicker_Tick(object sender, EventArgs e)
        {
            date.Control.Text = TimeUtility.GetCurrentDate();
        }

        private void TodaysEvents_SelectedIndexChanged(object sender, EventArgs e)
        {
            var nextMonthLastWeek = DateTime.Today.AddMonths(1).AddDays(-7);
            var nextMonth = DateTime.Today.AddMonths(1);
            calendar.Control.BoldedDates = new[] { nextMonth };
            calendar.Control.SetDate(nextMonth);
            comment.Control.Text = "Test comment is a test comment that test the comment section that holds the test text that is inside the text column";
            title.Control.Text = "Test Title";
            exp_start_date.Control.Text = string.Format("{0}/{1}/{2}", nextMonth.Month, nextMonth.Day, nextMonth.Year);
            exp_start_time.Control.Text = TimeUtility.GetCurrentTime();
            exp_end_date.Control.Text = string.Format("{0}/{1}/{2}", nextMonthLastWeek.Month, nextMonthLastWeek.Day, nextMonthLastWeek.Year);
            exp_end_time.Control.Text = TimeUtility.GetCurrentTime();
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
            MessageBox.Show((string)calendar.Control.Tag);
        }

        private void CreateEvent_Click(object sender, EventArgs e)
        {
            _bm.Add();
        }

        #region Controllers [Only use once view is initialized]

        #region [ ListBoxes ]

        private ListBoxController todays_events
        {
            get { return ((ListBoxController)_controls.Get(ControlType.ListBox, string.Format("{0}", TodaysEvents.Tag))); }
        }

        #endregion

        #region [ TextBoxes ]

        private RichTBController comment
        {
            get { return ((RichTBController)_controls.Get(ControlType.RichTextArea, string.Format("{0}", Comment.Tag))); }
        }

        #endregion

        #region [ Date ]

        private CalendarController calendar
        {
            get { return ((CalendarController)_controls.Get(ControlType.Calendar, string.Format("{0}", Calendar.Tag))); }
        }

        #endregion

        #region [ Labels ]

        private LabelController time
        {
            get { return ((LabelController)_controls.Get(ControlType.Label, string.Format("{0}", Time.Tag))); }
        }

        private LabelController date
        {
            get { return ((LabelController)_controls.Get(ControlType.Label, string.Format("{0}", Date.Tag))); }
        }

        private LabelController latest_event
        {
            get { return ((LabelController)_controls.Get(ControlType.Label, string.Format("{0}", LatestEvent.Tag))); }
        }

        private LabelController exp_start_date
        {
            get { return ((LabelController)_controls.Get(ControlType.Label, string.Format("{0}", ExpStartDate.Tag))); }
        }

        private LabelController exp_start_time
        {
            get { return ((LabelController)_controls.Get(ControlType.Label, string.Format("{0}", ExpStartTime.Tag))); }
        }

        private LabelController exp_end_date
        {
            get { return ((LabelController)_controls.Get(ControlType.Label, string.Format("{0}", ExpEndDate.Tag))); }
        }

        private LabelController exp_end_time
        {
            get { return ((LabelController)_controls.Get(ControlType.Label, string.Format("{0}", ExpEndTime.Tag))); }
        }

        private LabelController title
        {
            get { return ((LabelController)_controls.Get(ControlType.Label, string.Format("{0}", Title.Tag))); }
        }

        #endregion

        #endregion
    }
}
