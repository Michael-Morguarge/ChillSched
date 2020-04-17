using FrontEnd.Properties;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;
using FrontEnd.View.Controller;
using Shared.Utility;
using Shared.Interface;

namespace FrontEnd.View
{
    /// <summary>
    /// Partial View Controller
    /// </summary>
    public partial class MainApp : Form
    {
        private EventViewController _bm;
        private ControlsAccess _controls;

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
            Comment.Tag = _controls.Add(tag, new RichTBController(Comment));
            Calendar.Tag = _controls.Add(tag, new CalendarController(Calendar));
            TodaysEvents.Tag = _controls.Add(tag, new ListBoxController(TodaysEvents));

            _bm = new EventViewController(_controls, new List<IControl> { User_Calendar, Todays_Events });

            Time.Text = TimeAndDateUtility.GetCurrentTimeString();
            Date.Text = TimeAndDateUtility.GetCurrentDateString();

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

        private void TodaysEvents_SelectedIndexChanged(object sender, EventArgs e)
        {
            var nextMonthLastWeek = DateTime.Today.AddMonths(1).AddDays(-7);
            var nextMonth = DateTime.Today.AddMonths(1);
            User_Calendar.GetControl().BoldedDates = new[] { nextMonth };
            User_Calendar.GetControl().SetDate(nextMonth);
            User_Comment.GetControl().Text = "Test comment is a test comment that test the comment section that holds the test text that is inside the text column";
            User_Title.GetControl().Text = "Test Title";
            Exp_Start_Date.GetControl().Text = string.Format("{0}/{1}/{2}", nextMonth.Month, nextMonth.Day, nextMonth.Year);
            Exp_Start_Time.GetControl().Text = TimeAndDateUtility.GetCurrentTimeString();
            Exp_End_Date.GetControl().Text = string.Format("{0}/{1}/{2}", nextMonthLastWeek.Month, nextMonthLastWeek.Day, nextMonthLastWeek.Year);
            Exp_End_Time.GetControl().Text = TimeAndDateUtility.GetCurrentTimeString();
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
            MessageBox.Show(User_Calendar.GetId());
        }

        private void CreateEvent_Click(object sender, EventArgs e)
        {
            _bm.Add();
        }

        #region Controllers [Only use once view is initialized]

        #region [ ListBoxes ]

        private ListBoxController Todays_Events
        {
            get { return ((ListBoxController)_controls.Get(Tag as string, TodaysEvents.Tag as string)); }
        }

        #endregion

        #region [ TextBoxes ]

        private RichTBController User_Comment
        {
            get { return ((RichTBController)_controls.Get(Tag as string, Comment.Tag as string)); }
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
