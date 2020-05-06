namespace FrontEnd.App.Views
{
    partial class MainApp
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.ListViewGroup listViewGroup1 = new System.Windows.Forms.ListViewGroup("Complete", System.Windows.Forms.HorizontalAlignment.Center);
            System.Windows.Forms.ListViewGroup listViewGroup2 = new System.Windows.Forms.ListViewGroup("Upcoming", System.Windows.Forms.HorizontalAlignment.Center);
            System.Windows.Forms.ListViewGroup listViewGroup3 = new System.Windows.Forms.ListViewGroup("Happening Now", System.Windows.Forms.HorizontalAlignment.Center);
            System.Windows.Forms.ListViewGroup listViewGroup4 = new System.Windows.Forms.ListViewGroup("Overdue", System.Windows.Forms.HorizontalAlignment.Center);
            this.TimeTicker = new System.Windows.Forms.Timer(this.components);
            this.DateTicker = new System.Windows.Forms.Timer(this.components);
            this.CalendarTab = new System.Windows.Forms.TabPage();
            this.YourEvents = new System.Windows.Forms.GroupBox();
            this.CRUDButtonPanel = new System.Windows.Forms.FlowLayoutPanel();
            this.AddEvent = new System.Windows.Forms.Button();
            this.EditEvent = new System.Windows.Forms.Button();
            this.RemoveButton = new System.Windows.Forms.Button();
            this.splitter1 = new System.Windows.Forms.Splitter();
            this.ToggleStatus = new System.Windows.Forms.Button();
            this.TodaysEvents = new System.Windows.Forms.ListBox();
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.ExpStartDate = new System.Windows.Forms.Label();
            this.ExpStartTime = new System.Windows.Forms.Label();
            this.ExpEndDate = new System.Windows.Forms.Label();
            this.ExpEndTime = new System.Windows.Forms.Label();
            this.Title = new System.Windows.Forms.Label();
            this.Comment = new System.Windows.Forms.RichTextBox();
            this.flowLayoutPanel2 = new System.Windows.Forms.FlowLayoutPanel();
            this.EventStatus = new System.Windows.Forms.Label();
            this.CompletedDate = new System.Windows.Forms.Label();
            this.CreateDate = new System.Windows.Forms.Label();
            this.Calendar = new System.Windows.Forms.MonthCalendar();
            this.TimeTab = new System.Windows.Forms.TabPage();
            this.NextUpdateIn = new System.Windows.Forms.Label();
            this.NextUpdateProgress = new System.Windows.Forms.ProgressBar();
            this.LastUpdated = new System.Windows.Forms.Label();
            this.CurrMonthsEvents = new System.Windows.Forms.Label();
            this.EventListView = new System.Windows.Forms.ListView();
            this.EventTitle = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.TimeTilEvent = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.LatestEvent = new System.Windows.Forms.Label();
            this.ViewEvent = new System.Windows.Forms.Button();
            this.Date = new System.Windows.Forms.Label();
            this.Time = new System.Windows.Forms.Label();
            this.TimeAndCalendarTabular = new System.Windows.Forms.TabControl();
            this.GeneralToolTip = new System.Windows.Forms.ToolTip(this.components);
            this.DateTimeIcon = new System.Windows.Forms.NotifyIcon(this.components);
            this.DateTimeIconMenuStrip = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.OpenStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.CloseStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.ChillSchedMenuStrip = new System.Windows.Forms.MenuStrip();
            this.EventsStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.CreateEventStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.EventStatsStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.MessagesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.manageMessagesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.SearchTab = new System.Windows.Forms.TabPage();
            this.BottomToolStripPanel = new System.Windows.Forms.ToolStripPanel();
            this.TopToolStripPanel = new System.Windows.Forms.ToolStripPanel();
            this.RightToolStripPanel = new System.Windows.Forms.ToolStripPanel();
            this.LeftToolStripPanel = new System.Windows.Forms.ToolStripPanel();
            this.ContentPanel = new System.Windows.Forms.ToolStripContentPanel();
            this.SearchViews = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.WelcomeToChillSchedToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.AboutStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.CloseStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.EIV = new FrontEnd.App.Parts.EventsInfoView();
            this.CalendarTab.SuspendLayout();
            this.YourEvents.SuspendLayout();
            this.CRUDButtonPanel.SuspendLayout();
            this.flowLayoutPanel1.SuspendLayout();
            this.flowLayoutPanel2.SuspendLayout();
            this.TimeTab.SuspendLayout();
            this.TimeAndCalendarTabular.SuspendLayout();
            this.DateTimeIconMenuStrip.SuspendLayout();
            this.ChillSchedMenuStrip.SuspendLayout();
            this.SearchTab.SuspendLayout();
            this.SearchViews.SuspendLayout();
            this.SuspendLayout();
            // 
            // TimeTicker
            // 
            this.TimeTicker.Enabled = true;
            this.TimeTicker.Interval = 1;
            this.TimeTicker.Tick += new System.EventHandler(this.TimeTicker_Tick);
            // 
            // DateTicker
            // 
            this.DateTicker.Enabled = true;
            this.DateTicker.Interval = 60000;
            this.DateTicker.Tick += new System.EventHandler(this.DateTicker_Tick);
            // 
            // CalendarTab
            // 
            this.CalendarTab.BackColor = System.Drawing.SystemColors.ControlLight;
            this.CalendarTab.Controls.Add(this.YourEvents);
            this.CalendarTab.Controls.Add(this.Calendar);
            this.CalendarTab.Location = new System.Drawing.Point(4, 29);
            this.CalendarTab.Name = "CalendarTab";
            this.CalendarTab.Padding = new System.Windows.Forms.Padding(3);
            this.CalendarTab.Size = new System.Drawing.Size(1060, 393);
            this.CalendarTab.TabIndex = 0;
            this.CalendarTab.Text = "Calendar";
            // 
            // YourEvents
            // 
            this.YourEvents.Controls.Add(this.EIV);
            this.YourEvents.Controls.Add(this.CRUDButtonPanel);
            this.YourEvents.Controls.Add(this.TodaysEvents);
            this.YourEvents.Controls.Add(this.flowLayoutPanel1);
            this.YourEvents.Dock = System.Windows.Forms.DockStyle.Right;
            this.YourEvents.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.YourEvents.ForeColor = System.Drawing.SystemColors.ControlText;
            this.YourEvents.Location = new System.Drawing.Point(251, 3);
            this.YourEvents.Name = "YourEvents";
            this.YourEvents.Size = new System.Drawing.Size(806, 387);
            this.YourEvents.TabIndex = 0;
            this.YourEvents.TabStop = false;
            this.YourEvents.Text = "Events for day";
            // 
            // CRUDButtonPanel
            // 
            this.CRUDButtonPanel.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.CRUDButtonPanel.Controls.Add(this.AddEvent);
            this.CRUDButtonPanel.Controls.Add(this.EditEvent);
            this.CRUDButtonPanel.Controls.Add(this.RemoveButton);
            this.CRUDButtonPanel.Controls.Add(this.splitter1);
            this.CRUDButtonPanel.Controls.Add(this.ToggleStatus);
            this.CRUDButtonPanel.Location = new System.Drawing.Point(7, 339);
            this.CRUDButtonPanel.Name = "CRUDButtonPanel";
            this.CRUDButtonPanel.Size = new System.Drawing.Size(793, 42);
            this.CRUDButtonPanel.TabIndex = 0;
            // 
            // AddEvent
            // 
            this.AddEvent.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.AddEvent.Cursor = System.Windows.Forms.Cursors.Hand;
            this.AddEvent.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.AddEvent.FlatAppearance.CheckedBackColor = System.Drawing.Color.Black;
            this.AddEvent.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Gray;
            this.AddEvent.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Silver;
            this.AddEvent.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.AddEvent.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AddEvent.Location = new System.Drawing.Point(3, 3);
            this.AddEvent.Name = "AddEvent";
            this.AddEvent.Size = new System.Drawing.Size(85, 31);
            this.AddEvent.TabIndex = 2;
            this.AddEvent.Text = "Create";
            this.AddEvent.UseVisualStyleBackColor = true;
            this.AddEvent.Click += new System.EventHandler(this.CreateEvent_Click);
            // 
            // EditEvent
            // 
            this.EditEvent.BackColor = System.Drawing.Color.Transparent;
            this.EditEvent.Cursor = System.Windows.Forms.Cursors.Hand;
            this.EditEvent.Enabled = false;
            this.EditEvent.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.EditEvent.FlatAppearance.CheckedBackColor = System.Drawing.Color.Black;
            this.EditEvent.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Gray;
            this.EditEvent.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Silver;
            this.EditEvent.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.EditEvent.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.EditEvent.ForeColor = System.Drawing.SystemColors.ControlText;
            this.EditEvent.Location = new System.Drawing.Point(94, 3);
            this.EditEvent.Name = "EditEvent";
            this.EditEvent.Size = new System.Drawing.Size(85, 31);
            this.EditEvent.TabIndex = 3;
            this.EditEvent.Text = "Edit";
            this.EditEvent.UseVisualStyleBackColor = false;
            this.EditEvent.Click += new System.EventHandler(this.EditEvent_Click);
            // 
            // RemoveButton
            // 
            this.RemoveButton.BackColor = System.Drawing.Color.Transparent;
            this.RemoveButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.RemoveButton.Enabled = false;
            this.RemoveButton.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.RemoveButton.FlatAppearance.CheckedBackColor = System.Drawing.Color.Black;
            this.RemoveButton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Gray;
            this.RemoveButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Silver;
            this.RemoveButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.RemoveButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.RemoveButton.Location = new System.Drawing.Point(185, 3);
            this.RemoveButton.Name = "RemoveButton";
            this.RemoveButton.Size = new System.Drawing.Size(85, 31);
            this.RemoveButton.TabIndex = 4;
            this.RemoveButton.Text = "Remove";
            this.RemoveButton.UseVisualStyleBackColor = false;
            this.RemoveButton.Click += new System.EventHandler(this.RemoveButton_Click);
            // 
            // splitter1
            // 
            this.splitter1.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.splitter1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.splitter1.Cursor = System.Windows.Forms.Cursors.Default;
            this.splitter1.Location = new System.Drawing.Point(276, 3);
            this.splitter1.Name = "splitter1";
            this.splitter1.Size = new System.Drawing.Size(5, 31);
            this.splitter1.TabIndex = 0;
            this.splitter1.TabStop = false;
            // 
            // ToggleStatus
            // 
            this.ToggleStatus.BackColor = System.Drawing.Color.Transparent;
            this.ToggleStatus.Cursor = System.Windows.Forms.Cursors.Hand;
            this.ToggleStatus.Enabled = false;
            this.ToggleStatus.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ToggleStatus.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ToggleStatus.Location = new System.Drawing.Point(287, 3);
            this.ToggleStatus.Name = "ToggleStatus";
            this.ToggleStatus.Size = new System.Drawing.Size(159, 31);
            this.ToggleStatus.TabIndex = 1;
            this.ToggleStatus.Text = "Toggle Status";
            this.ToggleStatus.UseVisualStyleBackColor = false;
            this.ToggleStatus.Click += new System.EventHandler(this.ToggleStatus_Click);
            // 
            // TodaysEvents
            // 
            this.TodaysEvents.Cursor = System.Windows.Forms.Cursors.Hand;
            this.TodaysEvents.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TodaysEvents.FormattingEnabled = true;
            this.TodaysEvents.ItemHeight = 16;
            this.TodaysEvents.Items.AddRange(new object[] {
            "Test"});
            this.TodaysEvents.Location = new System.Drawing.Point(7, 26);
            this.TodaysEvents.Name = "TodaysEvents";
            this.TodaysEvents.Size = new System.Drawing.Size(257, 292);
            this.TodaysEvents.TabIndex = 1;
            this.TodaysEvents.SelectedIndexChanged += new System.EventHandler(this.TodaysEvents_SelectedIndexChanged);
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.Controls.Add(this.ExpStartDate);
            this.flowLayoutPanel1.Controls.Add(this.ExpStartTime);
            this.flowLayoutPanel1.Controls.Add(this.ExpEndDate);
            this.flowLayoutPanel1.Controls.Add(this.ExpEndTime);
            this.flowLayoutPanel1.Controls.Add(this.Title);
            this.flowLayoutPanel1.Controls.Add(this.Comment);
            this.flowLayoutPanel1.Controls.Add(this.flowLayoutPanel2);
            this.flowLayoutPanel1.Location = new System.Drawing.Point(273, 13);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(527, 305);
            this.flowLayoutPanel1.TabIndex = 1;
            // 
            // ExpStartDate
            // 
            this.ExpStartDate.Cursor = System.Windows.Forms.Cursors.Default;
            this.ExpStartDate.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ExpStartDate.Location = new System.Drawing.Point(3, 0);
            this.ExpStartDate.Name = "ExpStartDate";
            this.ExpStartDate.Padding = new System.Windows.Forms.Padding(0, 5, 0, 5);
            this.ExpStartDate.Size = new System.Drawing.Size(257, 28);
            this.ExpStartDate.TabIndex = 0;
            this.ExpStartDate.Text = "-";
            this.ExpStartDate.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // ExpStartTime
            // 
            this.ExpStartTime.Cursor = System.Windows.Forms.Cursors.Default;
            this.ExpStartTime.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ExpStartTime.Location = new System.Drawing.Point(266, 0);
            this.ExpStartTime.Name = "ExpStartTime";
            this.ExpStartTime.Padding = new System.Windows.Forms.Padding(0, 5, 0, 5);
            this.ExpStartTime.Size = new System.Drawing.Size(257, 28);
            this.ExpStartTime.TabIndex = 0;
            this.ExpStartTime.Text = "-";
            this.ExpStartTime.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // ExpEndDate
            // 
            this.ExpEndDate.Cursor = System.Windows.Forms.Cursors.Default;
            this.ExpEndDate.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ExpEndDate.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.ExpEndDate.Location = new System.Drawing.Point(3, 28);
            this.ExpEndDate.Name = "ExpEndDate";
            this.ExpEndDate.Padding = new System.Windows.Forms.Padding(0, 5, 0, 5);
            this.ExpEndDate.Size = new System.Drawing.Size(257, 28);
            this.ExpEndDate.TabIndex = 0;
            this.ExpEndDate.Text = "-";
            this.ExpEndDate.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // ExpEndTime
            // 
            this.ExpEndTime.Cursor = System.Windows.Forms.Cursors.Default;
            this.ExpEndTime.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ExpEndTime.ForeColor = System.Drawing.SystemColors.GrayText;
            this.ExpEndTime.Location = new System.Drawing.Point(266, 28);
            this.ExpEndTime.Name = "ExpEndTime";
            this.ExpEndTime.Padding = new System.Windows.Forms.Padding(0, 5, 0, 5);
            this.ExpEndTime.Size = new System.Drawing.Size(257, 28);
            this.ExpEndTime.TabIndex = 0;
            this.ExpEndTime.Text = "-";
            this.ExpEndTime.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Title
            // 
            this.Title.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.Title.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.Title.Cursor = System.Windows.Forms.Cursors.Default;
            this.Title.Dock = System.Windows.Forms.DockStyle.Top;
            this.flowLayoutPanel1.SetFlowBreak(this.Title, true);
            this.Title.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Title.Location = new System.Drawing.Point(3, 56);
            this.Title.Name = "Title";
            this.Title.Size = new System.Drawing.Size(521, 32);
            this.Title.TabIndex = 0;
            this.Title.Text = "-";
            this.Title.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Comment
            // 
            this.Comment.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Comment.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.flowLayoutPanel1.SetFlowBreak(this.Comment, true);
            this.Comment.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Comment.Location = new System.Drawing.Point(3, 91);
            this.Comment.Name = "Comment";
            this.Comment.ReadOnly = true;
            this.Comment.Size = new System.Drawing.Size(520, 148);
            this.Comment.TabIndex = 3;
            this.Comment.Tag = "Comment";
            this.Comment.Text = "No comment";
            // 
            // flowLayoutPanel2
            // 
            this.flowLayoutPanel2.Controls.Add(this.EventStatus);
            this.flowLayoutPanel2.Controls.Add(this.CompletedDate);
            this.flowLayoutPanel2.Controls.Add(this.CreateDate);
            this.flowLayoutPanel2.Location = new System.Drawing.Point(3, 245);
            this.flowLayoutPanel2.Name = "flowLayoutPanel2";
            this.flowLayoutPanel2.Size = new System.Drawing.Size(521, 55);
            this.flowLayoutPanel2.TabIndex = 4;
            // 
            // EventStatus
            // 
            this.EventStatus.BackColor = System.Drawing.SystemColors.ControlDark;
            this.EventStatus.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.EventStatus.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.EventStatus.Location = new System.Drawing.Point(3, 0);
            this.EventStatus.Name = "EventStatus";
            this.EventStatus.Size = new System.Drawing.Size(514, 26);
            this.EventStatus.TabIndex = 0;
            this.EventStatus.Text = "-";
            this.EventStatus.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // CompletedDate
            // 
            this.CompletedDate.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CompletedDate.Location = new System.Drawing.Point(3, 26);
            this.CompletedDate.Name = "CompletedDate";
            this.CompletedDate.Size = new System.Drawing.Size(254, 26);
            this.CompletedDate.TabIndex = 2;
            this.CompletedDate.Text = "-";
            this.CompletedDate.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // CreateDate
            // 
            this.CreateDate.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CreateDate.Location = new System.Drawing.Point(263, 26);
            this.CreateDate.Name = "CreateDate";
            this.CreateDate.Size = new System.Drawing.Size(254, 26);
            this.CreateDate.TabIndex = 3;
            this.CreateDate.Text = "-";
            this.CreateDate.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Calendar
            // 
            this.Calendar.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.Calendar.CalendarDimensions = new System.Drawing.Size(1, 2);
            this.Calendar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Calendar.FirstDayOfWeek = System.Windows.Forms.Day.Sunday;
            this.Calendar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Calendar.ForeColor = System.Drawing.SystemColors.ControlDark;
            this.Calendar.Location = new System.Drawing.Point(12, 12);
            this.Calendar.MaxSelectionCount = 1;
            this.Calendar.Name = "Calendar";
            this.Calendar.TabIndex = 0;
            this.Calendar.TabStop = false;
            this.Calendar.TitleBackColor = System.Drawing.SystemColors.HotTrack;
            this.Calendar.TrailingForeColor = System.Drawing.SystemColors.ControlText;
            this.Calendar.DateChanged += new System.Windows.Forms.DateRangeEventHandler(this.Calendar_DateChanged);
            // 
            // TimeTab
            // 
            this.TimeTab.BackColor = System.Drawing.SystemColors.ControlLight;
            this.TimeTab.Controls.Add(this.NextUpdateIn);
            this.TimeTab.Controls.Add(this.NextUpdateProgress);
            this.TimeTab.Controls.Add(this.LastUpdated);
            this.TimeTab.Controls.Add(this.CurrMonthsEvents);
            this.TimeTab.Controls.Add(this.EventListView);
            this.TimeTab.Controls.Add(this.LatestEvent);
            this.TimeTab.Controls.Add(this.ViewEvent);
            this.TimeTab.Controls.Add(this.Date);
            this.TimeTab.Controls.Add(this.Time);
            this.TimeTab.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TimeTab.Location = new System.Drawing.Point(4, 29);
            this.TimeTab.Name = "TimeTab";
            this.TimeTab.Padding = new System.Windows.Forms.Padding(3);
            this.TimeTab.Size = new System.Drawing.Size(1060, 393);
            this.TimeTab.TabIndex = 0;
            this.TimeTab.Text = "Welcome";
            // 
            // NextUpdateIn
            // 
            this.NextUpdateIn.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.NextUpdateIn.Location = new System.Drawing.Point(638, 325);
            this.NextUpdateIn.Name = "NextUpdateIn";
            this.NextUpdateIn.Size = new System.Drawing.Size(208, 26);
            this.NextUpdateIn.TabIndex = 3;
            this.NextUpdateIn.Text = "Next Update In:";
            this.NextUpdateIn.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // NextUpdateProgress
            // 
            this.NextUpdateProgress.BackColor = System.Drawing.SystemColors.ControlDark;
            this.NextUpdateProgress.Cursor = System.Windows.Forms.Cursors.Default;
            this.NextUpdateProgress.Location = new System.Drawing.Point(846, 325);
            this.NextUpdateProgress.MarqueeAnimationSpeed = 200;
            this.NextUpdateProgress.Maximum = 15;
            this.NextUpdateProgress.Name = "NextUpdateProgress";
            this.NextUpdateProgress.Size = new System.Drawing.Size(208, 26);
            this.NextUpdateProgress.Step = 1;
            this.NextUpdateProgress.Style = System.Windows.Forms.ProgressBarStyle.Continuous;
            this.NextUpdateProgress.TabIndex = 0;
            // 
            // LastUpdated
            // 
            this.LastUpdated.BackColor = System.Drawing.Color.Transparent;
            this.LastUpdated.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LastUpdated.Location = new System.Drawing.Point(638, 360);
            this.LastUpdated.Name = "LastUpdated";
            this.LastUpdated.Size = new System.Drawing.Size(416, 26);
            this.LastUpdated.TabIndex = 2;
            this.LastUpdated.Text = "-";
            this.LastUpdated.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // CurrMonthsEvents
            // 
            this.CurrMonthsEvents.BackColor = System.Drawing.Color.Transparent;
            this.CurrMonthsEvents.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CurrMonthsEvents.Location = new System.Drawing.Point(638, 0);
            this.CurrMonthsEvents.Name = "CurrMonthsEvents";
            this.CurrMonthsEvents.Size = new System.Drawing.Size(416, 26);
            this.CurrMonthsEvents.TabIndex = 0;
            this.CurrMonthsEvents.Text = "Month at a Glance";
            this.CurrMonthsEvents.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // EventListView
            // 
            this.EventListView.Activation = System.Windows.Forms.ItemActivation.TwoClick;
            this.EventListView.Alignment = System.Windows.Forms.ListViewAlignment.SnapToGrid;
            this.EventListView.AutoArrange = false;
            this.EventListView.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.EventTitle,
            this.TimeTilEvent});
            this.EventListView.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.EventListView.FullRowSelect = true;
            this.EventListView.GridLines = true;
            listViewGroup1.Header = "Complete";
            listViewGroup1.HeaderAlignment = System.Windows.Forms.HorizontalAlignment.Center;
            listViewGroup1.Name = "Complete";
            listViewGroup2.Header = "Upcoming";
            listViewGroup2.HeaderAlignment = System.Windows.Forms.HorizontalAlignment.Center;
            listViewGroup2.Name = "Upcoming";
            listViewGroup3.Header = "Happening Now";
            listViewGroup3.HeaderAlignment = System.Windows.Forms.HorizontalAlignment.Center;
            listViewGroup3.Name = "HappeningNow";
            listViewGroup4.Header = "Overdue";
            listViewGroup4.HeaderAlignment = System.Windows.Forms.HorizontalAlignment.Center;
            listViewGroup4.Name = "Overdue";
            this.EventListView.Groups.AddRange(new System.Windows.Forms.ListViewGroup[] {
            listViewGroup1,
            listViewGroup2,
            listViewGroup3,
            listViewGroup4});
            this.EventListView.HeaderStyle = System.Windows.Forms.ColumnHeaderStyle.Nonclickable;
            this.EventListView.HideSelection = false;
            this.EventListView.Location = new System.Drawing.Point(638, 29);
            this.EventListView.MultiSelect = false;
            this.EventListView.Name = "EventListView";
            this.EventListView.Size = new System.Drawing.Size(416, 293);
            this.EventListView.Sorting = System.Windows.Forms.SortOrder.Ascending;
            this.EventListView.TabIndex = 1;
            this.EventListView.UseCompatibleStateImageBehavior = false;
            this.EventListView.View = System.Windows.Forms.View.Details;
            // 
            // EventTitle
            // 
            this.EventTitle.Text = "Title";
            this.EventTitle.Width = 188;
            // 
            // TimeTilEvent
            // 
            this.TimeTilEvent.Text = "Time Span";
            this.TimeTilEvent.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.TimeTilEvent.Width = 219;
            // 
            // LatestEvent
            // 
            this.LatestEvent.BackColor = System.Drawing.Color.Transparent;
            this.LatestEvent.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.LatestEvent.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LatestEvent.ForeColor = System.Drawing.SystemColors.Desktop;
            this.LatestEvent.Location = new System.Drawing.Point(7, 172);
            this.LatestEvent.Name = "LatestEvent";
            this.LatestEvent.Size = new System.Drawing.Size(535, 127);
            this.LatestEvent.TabIndex = 0;
            this.LatestEvent.Text = "...";
            this.LatestEvent.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // ViewEvent
            // 
            this.ViewEvent.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ViewEvent.Location = new System.Drawing.Point(547, 211);
            this.ViewEvent.Name = "ViewEvent";
            this.ViewEvent.Size = new System.Drawing.Size(75, 48);
            this.ViewEvent.TabIndex = 0;
            this.ViewEvent.Text = "VIEW";
            this.ViewEvent.UseVisualStyleBackColor = true;
            // 
            // Date
            // 
            this.Date.BackColor = System.Drawing.Color.Transparent;
            this.Date.Cursor = System.Windows.Forms.Cursors.Cross;
            this.Date.Font = new System.Drawing.Font("Microsoft Sans Serif", 25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Date.ForeColor = System.Drawing.SystemColors.ControlText;
            this.Date.Location = new System.Drawing.Point(6, 107);
            this.Date.Name = "Date";
            this.Date.Size = new System.Drawing.Size(616, 42);
            this.Date.TabIndex = 0;
            this.Date.Text = "...";
            this.Date.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Time
            // 
            this.Time.BackColor = System.Drawing.Color.White;
            this.Time.Cursor = System.Windows.Forms.Cursors.Cross;
            this.Time.Font = new System.Drawing.Font("Microsoft Sans Serif", 35F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Time.ForeColor = System.Drawing.SystemColors.ControlText;
            this.Time.Location = new System.Drawing.Point(144, 29);
            this.Time.Name = "Time";
            this.Time.Size = new System.Drawing.Size(340, 60);
            this.Time.TabIndex = 0;
            this.Time.Text = "...";
            this.Time.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // TimeAndCalendarTabular
            // 
            this.TimeAndCalendarTabular.Controls.Add(this.TimeTab);
            this.TimeAndCalendarTabular.Controls.Add(this.CalendarTab);
            this.TimeAndCalendarTabular.Controls.Add(this.SearchTab);
            this.TimeAndCalendarTabular.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.TimeAndCalendarTabular.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TimeAndCalendarTabular.Location = new System.Drawing.Point(13, 36);
            this.TimeAndCalendarTabular.Multiline = true;
            this.TimeAndCalendarTabular.Name = "TimeAndCalendarTabular";
            this.TimeAndCalendarTabular.SelectedIndex = 0;
            this.TimeAndCalendarTabular.Size = new System.Drawing.Size(1068, 426);
            this.TimeAndCalendarTabular.TabIndex = 0;
            // 
            // GeneralToolTip
            // 
            this.GeneralToolTip.IsBalloon = true;
            this.GeneralToolTip.Tag = "";
            // 
            // DateTimeIcon
            // 
            this.DateTimeIcon.BalloonTipIcon = System.Windows.Forms.ToolTipIcon.Info;
            this.DateTimeIcon.BalloonTipText = "ChillSched is hidden";
            this.DateTimeIcon.BalloonTipTitle = "ChillSched";
            this.DateTimeIcon.ContextMenuStrip = this.DateTimeIconMenuStrip;
            this.DateTimeIcon.Text = "Open";
            this.DateTimeIcon.Visible = true;
            this.DateTimeIcon.DoubleClick += new System.EventHandler(this.DateTimeIcon_DoubleClick);
            // 
            // DateTimeIconMenuStrip
            // 
            this.DateTimeIconMenuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.OpenStripMenuItem,
            this.CloseStripMenuItem1});
            this.DateTimeIconMenuStrip.Name = "DateTimeIconMenuStrip";
            this.DateTimeIconMenuStrip.RightToLeft = System.Windows.Forms.RightToLeft.Inherit;
            this.DateTimeIconMenuStrip.Size = new System.Drawing.Size(111, 52);
            // 
            // OpenStripMenuItem
            // 
            this.OpenStripMenuItem.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.OpenStripMenuItem.Name = "OpenStripMenuItem";
            this.OpenStripMenuItem.Size = new System.Drawing.Size(110, 24);
            this.OpenStripMenuItem.Text = "Open";
            this.OpenStripMenuItem.Click += new System.EventHandler(this.DateTimeIcon_DoubleClick);
            // 
            // CloseStripMenuItem1
            // 
            this.CloseStripMenuItem1.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.CloseStripMenuItem1.Name = "CloseStripMenuItem1";
            this.CloseStripMenuItem1.Size = new System.Drawing.Size(110, 24);
            this.CloseStripMenuItem1.Text = "Close";
            this.CloseStripMenuItem1.Click += new System.EventHandler(this.CloseStripMenuItem_Click);
            // 
            // ChillSchedMenuStrip
            // 
            this.ChillSchedMenuStrip.AutoSize = false;
            this.ChillSchedMenuStrip.BackColor = System.Drawing.SystemColors.ControlLight;
            this.ChillSchedMenuStrip.Dock = System.Windows.Forms.DockStyle.None;
            this.ChillSchedMenuStrip.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.ChillSchedMenuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.WelcomeToChillSchedToolStripMenuItem,
            this.EventsStripMenuItem,
            this.MessagesToolStripMenuItem});
            this.ChillSchedMenuStrip.Location = new System.Drawing.Point(0, 0);
            this.ChillSchedMenuStrip.Name = "ChillSchedMenuStrip";
            this.ChillSchedMenuStrip.RenderMode = System.Windows.Forms.ToolStripRenderMode.System;
            this.ChillSchedMenuStrip.Size = new System.Drawing.Size(1092, 32);
            this.ChillSchedMenuStrip.TabIndex = 1;
            this.ChillSchedMenuStrip.Text = "ChillSchedMenuStrip";
            // 
            // EventsStripMenuItem
            // 
            this.EventsStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.CreateEventStripMenuItem,
            this.EventStatsStripMenuItem});
            this.EventsStripMenuItem.Name = "EventsStripMenuItem";
            this.EventsStripMenuItem.ShortcutKeyDisplayString = "";
            this.EventsStripMenuItem.Size = new System.Drawing.Size(61, 28);
            this.EventsStripMenuItem.Text = "Events";
            // 
            // CreateEventStripMenuItem
            // 
            this.CreateEventStripMenuItem.Name = "CreateEventStripMenuItem";
            this.CreateEventStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)(((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.Shift) 
            | System.Windows.Forms.Keys.A)));
            this.CreateEventStripMenuItem.Size = new System.Drawing.Size(243, 24);
            this.CreateEventStripMenuItem.Text = "Create Event";
            this.CreateEventStripMenuItem.ToolTipText = "Create an event";
            this.CreateEventStripMenuItem.Click += new System.EventHandler(this.CreateEvent_Click);
            // 
            // EventStatsStripMenuItem
            // 
            this.EventStatsStripMenuItem.Name = "EventStatsStripMenuItem";
            this.EventStatsStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)(((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.Shift) 
            | System.Windows.Forms.Keys.B)));
            this.EventStatsStripMenuItem.Size = new System.Drawing.Size(243, 24);
            this.EventStatsStripMenuItem.Text = "Event Search";
            this.EventStatsStripMenuItem.Click += new System.EventHandler(this.EventBackupStripMenuItem_Click);
            // 
            // MessagesToolStripMenuItem
            // 
            this.MessagesToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.manageMessagesToolStripMenuItem});
            this.MessagesToolStripMenuItem.Name = "MessagesToolStripMenuItem";
            this.MessagesToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)(((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.Shift) 
            | System.Windows.Forms.Keys.M)));
            this.MessagesToolStripMenuItem.Size = new System.Drawing.Size(81, 28);
            this.MessagesToolStripMenuItem.Text = "Messages";
            // 
            // manageMessagesToolStripMenuItem
            // 
            this.manageMessagesToolStripMenuItem.Name = "manageMessagesToolStripMenuItem";
            this.manageMessagesToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)(((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.Shift) 
            | System.Windows.Forms.Keys.C)));
            this.manageMessagesToolStripMenuItem.Size = new System.Drawing.Size(279, 24);
            this.manageMessagesToolStripMenuItem.Text = "Manage Messages";
            this.manageMessagesToolStripMenuItem.Click += new System.EventHandler(this.ManageMessagesToolStripMenuItem_Click);
            // 
            // SearchTab
            // 
            this.SearchTab.BackColor = System.Drawing.SystemColors.ControlLight;
            this.SearchTab.Controls.Add(this.SearchViews);
            this.SearchTab.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.SearchTab.Location = new System.Drawing.Point(4, 29);
            this.SearchTab.Name = "SearchTab";
            this.SearchTab.Padding = new System.Windows.Forms.Padding(3);
            this.SearchTab.Size = new System.Drawing.Size(1060, 393);
            this.SearchTab.TabIndex = 1;
            this.SearchTab.Text = "Search";
            // 
            // BottomToolStripPanel
            // 
            this.BottomToolStripPanel.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.BottomToolStripPanel.Location = new System.Drawing.Point(0, 175);
            this.BottomToolStripPanel.Name = "BottomToolStripPanel";
            this.BottomToolStripPanel.Orientation = System.Windows.Forms.Orientation.Horizontal;
            this.BottomToolStripPanel.RowMargin = new System.Windows.Forms.Padding(3, 0, 0, 0);
            this.BottomToolStripPanel.Size = new System.Drawing.Size(150, 0);
            // 
            // TopToolStripPanel
            // 
            this.TopToolStripPanel.Dock = System.Windows.Forms.DockStyle.Top;
            this.TopToolStripPanel.Location = new System.Drawing.Point(0, 0);
            this.TopToolStripPanel.Name = "TopToolStripPanel";
            this.TopToolStripPanel.Orientation = System.Windows.Forms.Orientation.Horizontal;
            this.TopToolStripPanel.RowMargin = new System.Windows.Forms.Padding(3, 0, 0, 0);
            this.TopToolStripPanel.Size = new System.Drawing.Size(150, 25);
            // 
            // RightToolStripPanel
            // 
            this.RightToolStripPanel.Dock = System.Windows.Forms.DockStyle.Right;
            this.RightToolStripPanel.Location = new System.Drawing.Point(1092, 0);
            this.RightToolStripPanel.Name = "RightToolStripPanel";
            this.RightToolStripPanel.Orientation = System.Windows.Forms.Orientation.Vertical;
            this.RightToolStripPanel.RowMargin = new System.Windows.Forms.Padding(0, 3, 0, 0);
            this.RightToolStripPanel.Size = new System.Drawing.Size(0, 462);
            // 
            // LeftToolStripPanel
            // 
            this.LeftToolStripPanel.Dock = System.Windows.Forms.DockStyle.Left;
            this.LeftToolStripPanel.Location = new System.Drawing.Point(0, 0);
            this.LeftToolStripPanel.Name = "LeftToolStripPanel";
            this.LeftToolStripPanel.Orientation = System.Windows.Forms.Orientation.Vertical;
            this.LeftToolStripPanel.RowMargin = new System.Windows.Forms.Padding(0, 3, 0, 0);
            this.LeftToolStripPanel.Size = new System.Drawing.Size(0, 462);
            // 
            // ContentPanel
            // 
            this.ContentPanel.AutoScroll = true;
            this.ContentPanel.Size = new System.Drawing.Size(1092, 462);
            // 
            // SearchViews
            // 
            this.SearchViews.Appearance = System.Windows.Forms.TabAppearance.Buttons;
            this.SearchViews.Controls.Add(this.tabPage1);
            this.SearchViews.Controls.Add(this.tabPage2);
            this.SearchViews.Location = new System.Drawing.Point(6, 6);
            this.SearchViews.Multiline = true;
            this.SearchViews.Name = "SearchViews";
            this.SearchViews.SelectedIndex = 0;
            this.SearchViews.Size = new System.Drawing.Size(1048, 381);
            this.SearchViews.TabIndex = 2;
            // 
            // tabPage1
            // 
            this.tabPage1.Location = new System.Drawing.Point(4, 28);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(1040, 349);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "tabPage1";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // tabPage2
            // 
            this.tabPage2.Location = new System.Drawing.Point(4, 25);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(1040, 352);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "tabPage2";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // WelcomeToChillSchedToolStripMenuItem
            // 
            this.WelcomeToChillSchedToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.AboutStripMenuItem,
            this.CloseStripMenuItem});
            this.WelcomeToChillSchedToolStripMenuItem.Image = global::FrontEnd.Properties.Resources.ChillSched;
            this.WelcomeToChillSchedToolStripMenuItem.Name = "WelcomeToChillSchedToolStripMenuItem";
            this.WelcomeToChillSchedToolStripMenuItem.RightToLeftAutoMirrorImage = true;
            this.WelcomeToChillSchedToolStripMenuItem.ShowShortcutKeys = false;
            this.WelcomeToChillSchedToolStripMenuItem.Size = new System.Drawing.Size(175, 28);
            this.WelcomeToChillSchedToolStripMenuItem.Text = "Welcome to ChillSched";
            // 
            // AboutStripMenuItem
            // 
            this.AboutStripMenuItem.Name = "AboutStripMenuItem";
            this.AboutStripMenuItem.Size = new System.Drawing.Size(116, 24);
            this.AboutStripMenuItem.Text = "About";
            this.AboutStripMenuItem.Click += new System.EventHandler(this.AboutStripMenuItem_Click);
            // 
            // CloseStripMenuItem
            // 
            this.CloseStripMenuItem.Name = "CloseStripMenuItem";
            this.CloseStripMenuItem.Size = new System.Drawing.Size(116, 24);
            this.CloseStripMenuItem.Text = "Close";
            this.CloseStripMenuItem.Click += new System.EventHandler(this.CloseStripMenuItem_Click);
            // 
            // EIV
            // 
            this.EIV.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.EIV.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.EIV.Location = new System.Drawing.Point(0, 0);
            this.EIV.Name = "EIV";
            this.EIV.Size = new System.Drawing.Size(806, 387);
            this.EIV.TabIndex = 2;
            // 
            // MainApp
            // 
            this.AccessibleDescription = "The main window";
            this.AccessibleName = "Main";
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Inherit;
            this.AutoSize = true;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.ClientSize = new System.Drawing.Size(1092, 466);
            this.Controls.Add(this.ChillSchedMenuStrip);
            this.Controls.Add(this.TimeAndCalendarTabular);
            this.Cursor = System.Windows.Forms.Cursors.Default;
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MainMenuStrip = this.ChillSchedMenuStrip;
            this.MaximizeBox = false;
            this.Name = "MainApp";
            this.Opacity = 0.95D;
            this.ShowIcon = false;
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ChillSched";
            this.TransparencyKey = System.Drawing.Color.DarkGoldenrod;
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Main_FormClosing);
            this.Resize += new System.EventHandler(this.Main_Resize);
            this.CalendarTab.ResumeLayout(false);
            this.YourEvents.ResumeLayout(false);
            this.CRUDButtonPanel.ResumeLayout(false);
            this.flowLayoutPanel1.ResumeLayout(false);
            this.flowLayoutPanel2.ResumeLayout(false);
            this.TimeTab.ResumeLayout(false);
            this.TimeAndCalendarTabular.ResumeLayout(false);
            this.DateTimeIconMenuStrip.ResumeLayout(false);
            this.ChillSchedMenuStrip.ResumeLayout(false);
            this.ChillSchedMenuStrip.PerformLayout();
            this.SearchTab.ResumeLayout(false);
            this.SearchViews.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Timer TimeTicker;
        private System.Windows.Forms.Timer DateTicker;
        private System.Windows.Forms.TabPage CalendarTab;
        private System.Windows.Forms.GroupBox YourEvents;
        private System.Windows.Forms.MonthCalendar Calendar;
        private System.Windows.Forms.TabPage TimeTab;
        private System.Windows.Forms.Label Date;
        private System.Windows.Forms.Label Time;
        private System.Windows.Forms.TabControl TimeAndCalendarTabular;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private System.Windows.Forms.Label Title;
        private System.Windows.Forms.Label ExpStartDate;
        private System.Windows.Forms.Label ExpStartTime;
        private System.Windows.Forms.RichTextBox Comment;
        private System.Windows.Forms.ToolTip GeneralToolTip;
        private System.Windows.Forms.ListBox TodaysEvents;
        private System.Windows.Forms.Label LatestEvent;
        private System.Windows.Forms.Button ViewEvent;
        private System.Windows.Forms.NotifyIcon DateTimeIcon;
        private System.Windows.Forms.Button EditEvent;
        private System.Windows.Forms.Button AddEvent;
        private System.Windows.Forms.FlowLayoutPanel CRUDButtonPanel;
        private System.Windows.Forms.Button RemoveButton;
        private System.Windows.Forms.Label ExpEndDate;
        private System.Windows.Forms.Label ExpEndTime;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel2;
        private System.Windows.Forms.Label EventStatus;
        private System.Windows.Forms.Label CompletedDate;
        private System.Windows.Forms.Label CreateDate;
        private System.Windows.Forms.Button ToggleStatus;
        private System.Windows.Forms.Splitter splitter1;
        private System.Windows.Forms.ListView EventListView;
        private System.Windows.Forms.ColumnHeader EventTitle;
        private System.Windows.Forms.ColumnHeader TimeTilEvent;
        private System.Windows.Forms.Label CurrMonthsEvents;
        private System.Windows.Forms.ProgressBar NextUpdateProgress;
        private System.Windows.Forms.Label LastUpdated;
        private System.Windows.Forms.Label NextUpdateIn;
        private System.Windows.Forms.MenuStrip ChillSchedMenuStrip;
        private System.Windows.Forms.ToolStripMenuItem WelcomeToChillSchedToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem MessagesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem EventsStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem CreateEventStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem EventStatsStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem AboutStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem CloseStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem manageMessagesToolStripMenuItem;
        private System.Windows.Forms.ContextMenuStrip DateTimeIconMenuStrip;
        private System.Windows.Forms.ToolStripMenuItem OpenStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem CloseStripMenuItem1;
        private System.Windows.Forms.TabPage SearchTab;
        private System.Windows.Forms.ToolStripPanel BottomToolStripPanel;
        private System.Windows.Forms.ToolStripPanel TopToolStripPanel;
        private System.Windows.Forms.ToolStripPanel RightToolStripPanel;
        private System.Windows.Forms.ToolStripPanel LeftToolStripPanel;
        private System.Windows.Forms.ToolStripContentPanel ContentPanel;
        private System.Windows.Forms.TabControl SearchViews;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private Parts.EventsInfoView EIV;
    }
}

