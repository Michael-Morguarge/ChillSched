using Frontend.Properties;
using System;
using System.Drawing;
using System.Windows.Forms;
using Frontend.View.Controller;
using Shared.Global;
using Frontend.Controller.Prompts;
using Frontend.Controller.Parts;
using Shared.Model;
using System.IO;
using FileOperations.Constants;
using FileOperations.Implementations;
using Shared.Implementation;

namespace Frontend.App.Views
{
    /// <summary>
    /// Partial View Controller
    /// </summary>
    public partial class MainApp : Form
    {
        private ControlsAccess _controls;
        private EventViewController _events;
        private MessageViewController _messages;
        private OnDelay _delay;
        private bool _error;

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

            if (!_events.LoadEvents())
            {
                MessageBox.Show("Unable to save some or all events.", "Error Occurred.", MessageBoxButtons.OK, MessageBoxIcon.Error);
                _error = true;
            }

            EIV.UpdateEvents(DateTime.Today);
            SEIV.UpdateEvents();
            UpdateEventList();

            if (!_messages.LoadMessages())
            {
                MessageBox.Show("Unable to save some or all messages.", "Error Occurred.", MessageBoxButtons.OK, MessageBoxIcon.Error);
                _error = true;
            }

            MMV.UpdateMessagesView();
        }

        private void Setup()
        {
            Tag = _controls.AddForm(this);
            string tag = Tag as string;

            Time.Tag = _controls.Add(tag, new LabelController(Time));
            Date.Tag = _controls.Add(tag, new LabelController(Date));
            LastUpdated.Tag = _controls.Add(tag, new LabelController(LastUpdated));
            StartDateLbl.Tag = _controls.Add(tag, new LabelController(StartDateLbl));
            EndDateLbl.Tag = _controls.Add(tag, new LabelController(EndDateLbl));
            EventCalendar.Tag = _controls.Add(tag, new CalendarController(EventCalendar));
            EventListView.Tag = _controls.Add(tag, new ListViewController(EventListView));
            SearchTextTB.Tag = _controls.Add(tag, new TextBoxController(SearchTextTB));
            MessageDisplay.Tag = _controls.Add(tag, new TextBoxController(MessageDisplay));
            EventSearchStartDP.Tag = _controls.Add(tag, new DatePickerController(EventSearchStartDP));
            EventSearchEndDP.Tag = _controls.Add(tag, new DatePickerController(EventSearchEndDP));

            EIV.SetControls(tag, _controls, _events, EventCal.GetId());
            EIV.SetTitle("Events for Day");
            EIV.UseCrudButtons(true);

            SEIV.SetControls(tag, _controls, _events, EventCal.GetId());
            SEIV.SetTitle("Events");
            SEIV.UseCrudButtons(false);

            MMV.SetControls(tag, _controls, _messages);
            MMV.SetTitle("Messages");

            User_Time.SetText(TimeAndDateUtility.GetCurrentTimeString());
            User_Date.SetText(TimeAndDateUtility.GetCurrentDateString());

            Icon = Resources.icon;
            DateTimeIcon.Icon = Resources.icon;

            _delay = new OnDelay();
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

        private void MessageTicker_Tick(object sender, EventArgs e)
        {
            Time time = TimeAndDateUtility.GetCurrentTime();

            if (_delay.DateDelayed != null && _delay.DateContinued != null)
                _delay.Unlock(new DateAndTime(TimeAndDateUtility.GetCurrentDate(), TimeAndDateUtility.GetCurrentTime()));

            if (!_delay.Lock && time.Seconds % 30 == 0)
            {
                TriggerDelayedRefresh();
            }
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
            MessageBox.Show("ChillSched - 2020", "About", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void Main_FormClosing(object sender, FormClosingEventArgs e)
        {
            DialogResult result = MessageBox.Show("Are you sure you want to exit?", "Exit ChillSched", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (result == DialogResult.Yes)
            {
                if (!_error)
                {
                    BackupIOConsts.ArchiveOldAll();
                    bool savedEvents = _events.SaveEvents();
                    bool savedMessages = _messages.SaveMessages();


                    if (!savedEvents || !savedMessages)
                        MessageBox.Show("Unable to save some or all events and messages.", "Error Occurred.", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
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
            EIV.UpdateEvents(EventCal.GetControl().SelectionRange.Start);
            EIV.ToggleButtons();
        }

        private void CreateEvent_Click(object sender, EventArgs e)
        {
            if (_events.Add())
            {
                if (!_events.SaveEvents())
                    MessageBox.Show("Unable to save some or all events.", "Error Occurred.", MessageBoxButtons.OK, MessageBoxIcon.Error);

                EIV.ClearEventInfo();
                EIV.UpdateEvents(EventCal.GetControl().SelectionRange.Start);
                EIV.ToggleButtons();

                RefreshEventSearch();
            }
        }

        private void EventBackupStripMenuItem_Click(object sender, EventArgs e)
        {
            BackupIOConsts.ArchiveOldAll();
            if (!_events.SaveEvents())
                MessageBox.Show("Unable to save some or all events.", "Error Occurred.", MessageBoxButtons.OK, MessageBoxIcon.Error);
            else
                MessageBox.Show("Successully saved events.\nEvents save on application close, adds, updates and deletes of an event.", "Events saved", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void CreateMessageToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (_messages.Add())
            {
                if (!_messages.SaveMessages())
                    MessageBox.Show("Unable to save some or all messages.", "Error Occurred.", MessageBoxButtons.OK, MessageBoxIcon.Error);

                MMV.ClearMessageInfo();
                MMV.UpdateMessagesView();

                TriggerDelayedRefresh();
            }
        }

        private void TriggerMessagesBackupToolStripMenuItem_Click(object sender, EventArgs e)
        {
            BackupIOConsts.ArchiveOldAll();
            if (_messages.SaveMessages())
                MessageBox.Show("Unable to save some or all messages.", "Error Occurred.", MessageBoxButtons.OK, MessageBoxIcon.Error);
            else
                MessageBox.Show("Successully saved messages.\nMessages save on application close, adds, updates and deletes of a message.", "Messages saved", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void TriggerAllBackupToolStripMenuItem_Click(object sender, EventArgs e)
        {
            BackupIOConsts.ArchiveOldAll();
            if (!_events.SaveEvents() || !_messages.SaveMessages())
                MessageBox.Show("Unable to save some or all events and messages.", "Error Occurred.", MessageBoxButtons.OK, MessageBoxIcon.Error);
            else
                MessageBox.Show("Successully saved Events and Messages.\nEvents and Messages save on application close, adds, updates and deletes.", "All saved", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void ImportAllDataToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DialogResult fileDialogResult = OpenFileDialog.ShowDialog();

            if (fileDialogResult == DialogResult.OK)
            {
                DialogResult overwriteResult = MessageBox.Show("Overwrite current data?\r\nThis will wipe all local data.", "Overwrite data", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);

                BackupIOConsts.ArchiveOldAll();
                if (!_messages.LoadMessages(OpenFileDialog.FileName, overwriteResult == DialogResult.Yes)
                    || !_events.LoadEvents(OpenFileDialog.FileName, overwriteResult == DialogResult.Yes))
                    MessageBox.Show("Unable to import some or all events and/or messages.", "Error Occurred.", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void ExportAllDataToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DialogResult folderSelectResult = FolderBrowserDialog.ShowDialog();

            if (folderSelectResult == DialogResult.OK && !string.IsNullOrEmpty(FolderBrowserDialog.SelectedPath))
            {
                DirectoryInfo info = new DirectoryInfo(FolderBrowserDialog.SelectedPath);
                BackupIOConsts.ArchiveOldAll();

                if (info.Exists)
                {
                    try
                    {
                        AllIO.ExportAll(info.FullName);

                        MessageBox.Show("Successully exported Events and Messages in requested location.", "All saved", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    catch (Exception)
                    {
                        MessageBox.Show("Unable to export some or all events and messages.", "Error Occurred.", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                else
                    MessageBox.Show("Unable to export some or all events and messages.", "Error Occurred.", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                DialogResult cancelExportResult = MessageBox.Show("You are cancelling export. Are you sure?", "Cancelling Export", MessageBoxButtons.YesNo);

                if (cancelExportResult == DialogResult.No)
                {
                    ExportAllDataToolStripMenuItem.PerformClick();
                }
            }
        }

        private void ImportMessagesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DialogResult fileDialogResult = OpenFileDialog.ShowDialog();

            if (fileDialogResult == DialogResult.OK)
            {
                DialogResult overwriteResult = MessageBox.Show("Overwrite messages current data?\r\nThis will wipe all local messages data.", "Overwrite messages data", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);

                BackupIOConsts.ArchiveOldAll();
                if (!_messages.LoadMessages(OpenFileDialog.FileName, overwriteResult == DialogResult.Yes))
                    MessageBox.Show("Unable to import some or all messages.", "Error Occurred.", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void ExportMessagesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DialogResult folderSelectResult = FolderBrowserDialog.ShowDialog();

            if (folderSelectResult == DialogResult.OK && !string.IsNullOrEmpty(FolderBrowserDialog.SelectedPath))
            {
                DirectoryInfo info = new DirectoryInfo(FolderBrowserDialog.SelectedPath);
                BackupIOConsts.ArchiveOldAll();

                if (info.Exists)
                {
                    try
                    {
                        AllIO.ExportSingle(info.FullName, FileTypes.MESSAGE);

                        MessageBox.Show("Successully exported messages in requested location.", "All messages saved", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    catch (Exception)
                    {
                        MessageBox.Show("Unable to export some or all messages.", "Error Occurred.", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                else
                    MessageBox.Show("Unable to export some or all messages.", "Error Occurred.", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                DialogResult cancelExportResult = MessageBox.Show("You are cancelling export. Are you sure?", "Cancelling Export", MessageBoxButtons.YesNo);

                if (cancelExportResult == DialogResult.No)
                {
                    ExportAllDataToolStripMenuItem.PerformClick();
                }
            }
        }

        private void ImportEventsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DialogResult fileDialogResult = OpenFileDialog.ShowDialog();

            if (fileDialogResult == DialogResult.OK)
            {
                DialogResult overwriteResult = MessageBox.Show("Overwrite current events data?\r\nThis will wipe all local events data.", "Overwrite events data", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);

                BackupIOConsts.ArchiveOldAll();
                if (!_events.LoadEvents(OpenFileDialog.FileName, overwriteResult == DialogResult.Yes))
                    MessageBox.Show("Unable to import some or all events.", "Error Occurred.", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void ExportEventsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DialogResult folderSelectResult = FolderBrowserDialog.ShowDialog();

            if (folderSelectResult == DialogResult.OK && !string.IsNullOrEmpty(FolderBrowserDialog.SelectedPath))
            {
                DirectoryInfo info = new DirectoryInfo(FolderBrowserDialog.SelectedPath);
                BackupIOConsts.ArchiveOldAll();

                if (info.Exists)
                {
                    try
                    {
                        AllIO.ExportSingle(info.FullName, FileTypes.EVENT);

                        MessageBox.Show("Successully exported events in requested location.", "All events saved", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    catch (Exception)
                    {
                        MessageBox.Show("Unable to export some or all events.", "Error Occurred.", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                else
                    MessageBox.Show("Unable to export some or all events.", "Error Occurred.", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                DialogResult cancelExportResult = MessageBox.Show("You are cancelling export. Are you sure?", "Cancelling Export", MessageBoxButtons.YesNo);

                if (cancelExportResult == DialogResult.No)
                {
                    ExportAllDataToolStripMenuItem.PerformClick();
                }
            }
        }

        private void UseStartDate_CheckedChanged(object sender, EventArgs e)
        {
            if (UseStartDate.Checked)
            {
                Start_Date.SetForeColor(Color.Black);
                SearchStartDP.Enable(true);
            }
            else
            {
                Start_Date.SetForeColor(Color.DimGray);
                SearchStartDP.Enable(false);
            }
        }

        private void UseEndDate_CheckedChanged(object sender, EventArgs e)
        {
            if (UseEndDate.Checked)
            {
                End_Date.SetForeColor(Color.Black);
                SearchEndDP.Enable(true);
            }
            else
            {
                End_Date.SetForeColor(Color.DimGray);
                SearchEndDP.Enable(false);
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
            RefreshEventSearch();
        }

        private void Highlight_MouseLeave(object sender, EventArgs e)
        {
            Label label = (Label)sender;
            label.BackColor = SystemColors.ControlLight;
            label.ForeColor = Color.Black;
        }

        private void Highlight_MouseHover(object sender, EventArgs e)
        {
            Label label = (Label)sender;
            label.BackColor = SystemColors.ControlDark;
            label.ForeColor = Color.WhiteSmoke;
        }

        private void CopyMessage_Click(object sender, EventArgs e)
        {
            MessageTicker.Stop();
            RefreshMessage.Enabled = false;
            CopyMessage.Enabled = false;

            Clipboard.SetText(MessageDisplay.Text);
            PromptUser.Visible = true;
            PromptUser.Text = "Copied\r\n💾";

            Timer timer = new Timer
            {
                Interval = 1500
            };

            timer.Tick += (s, ee) =>
            {
                PromptUser.Visible = false;
                PromptUser.Text = string.Empty;
                timer.Stop();
                MessageTicker.Start();
                RefreshMessage.Enabled = true;
                CopyMessage.Enabled = true;
            };

            timer.Start();
        }

        private void RefreshMessage_Click(object sender, EventArgs e)
        {
            TriggerDelayedRefresh();
        }

        private void ExportAsImage_Click(object sender, EventArgs e)
        {
            string text = MDisplayTB.Text;
            Font font = MDisplayTB.GetControl().Font;

            //Graphics g = new Graphics();
        }

        #region Helpers

        internal void TriggerDelayedRefresh()
        {
            MessageTicker.Stop();
            RefreshMessage.Enabled = false;
            CopyMessage.Enabled = false;
            PromptUser.Visible = true;
            int i = 0;
            string loading = "Loading\r\n";
            Timer timer = new Timer
            {
                Interval = 375
            };

            timer.Tick += (s, ee) =>
            {
                if (i % 2 == 0)
                    PromptUser.Text = $"{loading}⏳";
                else
                    PromptUser.Text = $"{loading}⌛";

                if (i == 7)
                {
                    PromptUser.Visible = false;
                    PromptUser.Text = string.Empty;
                    RefreshMessageDisplay();
                    timer.Stop();
                    MessageTicker.Start();
                    RefreshMessage.Enabled = true;
                    CopyMessage.Enabled = true;
                }

                i++;
            };

            _delay.SetDelay(30, new DateAndTime(TimeAndDateUtility.GetCurrentDate(), TimeAndDateUtility.GetCurrentTime()));
            timer.Start();
        }

        private void RefreshMessageDisplay()
        {
            string randomMessage = _messages.GetRandomMessage();
            ExportAsImage.Enabled = !string.IsNullOrEmpty(randomMessage);
            MDisplayTB.SetText(!ExportAsImage.Enabled ?
                "Add messages in the message tab of search."
                : _messages.GetRandomMessage());
        }

        internal void RefreshEventSearch()
        {
            SEIV.ClearEventInfo();

            string searchTerm = SearchTB.Text;
            DateTime start = UseStartDate.Checked ? DateTime.Parse(SearchStartDP.Date).Date : DateTime.MaxValue;
            DateTime end = UseEndDate.Checked ?
                DateTime.Parse(SearchEndDP.Date).Date.AddHours(23).AddMinutes(59).AddSeconds(59)
                : DateTime.MinValue;

            SEIV.UpdateEvents(start, end, searchTerm);
        }

        internal void UpdateCalendar()
        {
            DateTime[] dates = _events.GetAllEventDates();
            EventCal.SetBoldedDates(dates);
        }

        internal void UpdateEventList()
        {
            ListViewItem[] events = _events.GetAll(EventListView.Groups);

            Time time = TimeAndDateUtility.GetCurrentTime();
            string timeString = TimeAndDateUtility.ConvertTime_String(time);
            string dateString = TimeAndDateUtility.GetCurrentDateString(true);
            EventLV.Update(events);
            Last_Updated.SetText($"Last Updated: {dateString} {timeString}");
        }

        #endregion Helpers

        #region Controllers [Only use once view is initialized]

        #region [ ListBoxes ]

        private ListViewController EventLV => (ListViewController)_controls.Get(Tag as string, EventListView.Tag as string);

        #endregion

        #region [ Date ]

        private CalendarController EventCal => (CalendarController)_controls.Get(Tag as string, EventCalendar.Tag as string);

        private DatePickerController SearchStartDP => (DatePickerController)_controls.Get(Tag as string, EventSearchStartDP.Tag as string);

        private DatePickerController SearchEndDP => (DatePickerController)_controls.Get(Tag as string, EventSearchEndDP.Tag as string);

        #endregion

        #region [ Labels ]

        private LabelController User_Time => (LabelController)_controls.Get(Tag as string, Time.Tag as string);

        private LabelController User_Date => (LabelController)_controls.Get(Tag as string, Date.Tag as string);

        private LabelController Last_Updated => (LabelController)_controls.Get(Tag as string, LastUpdated.Tag as string);

        private LabelController Start_Date => (LabelController)_controls.Get(Tag as string, StartDateLbl.Tag as string);

        private LabelController End_Date => (LabelController)_controls.Get(Tag as string, EndDateLbl.Tag as string);

        #endregion

        #region [ TextBoxes ]

        private TextBoxController SearchTB => (TextBoxController)_controls.Get(Tag as string, SearchTextTB.Tag as string);

        private TextBoxController MDisplayTB => (TextBoxController)_controls.Get(Tag as string, MessageDisplay.Tag as string);

        #endregion

        #endregion
    }
}
