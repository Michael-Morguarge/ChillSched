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
            System.Windows.Forms.ListViewGroup listViewGroup5 = new System.Windows.Forms.ListViewGroup("Complete", System.Windows.Forms.HorizontalAlignment.Center);
            System.Windows.Forms.ListViewGroup listViewGroup6 = new System.Windows.Forms.ListViewGroup("Upcoming", System.Windows.Forms.HorizontalAlignment.Center);
            System.Windows.Forms.ListViewGroup listViewGroup7 = new System.Windows.Forms.ListViewGroup("Happening Now", System.Windows.Forms.HorizontalAlignment.Center);
            System.Windows.Forms.ListViewGroup listViewGroup8 = new System.Windows.Forms.ListViewGroup("Overdue", System.Windows.Forms.HorizontalAlignment.Center);
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
            this.CalendarTab.SuspendLayout();
            this.YourEvents.SuspendLayout();
            this.CRUDButtonPanel.SuspendLayout();
            this.flowLayoutPanel1.SuspendLayout();
            this.flowLayoutPanel2.SuspendLayout();
            this.TimeTab.SuspendLayout();
            this.TimeAndCalendarTabular.SuspendLayout();
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
            this.CalendarTab.Location = new System.Drawing.Point(4, 22);
            this.CalendarTab.Name = "CalendarTab";
            this.CalendarTab.Padding = new System.Windows.Forms.Padding(3);
            this.CalendarTab.Size = new System.Drawing.Size(1060, 391);
            this.CalendarTab.TabIndex = 0;
            this.CalendarTab.Text = "CalendarTab";
            // 
            // YourEvents
            // 
            this.YourEvents.Controls.Add(this.CRUDButtonPanel);
            this.YourEvents.Controls.Add(this.TodaysEvents);
            this.YourEvents.Controls.Add(this.flowLayoutPanel1);
            this.YourEvents.Dock = System.Windows.Forms.DockStyle.Right;
            this.YourEvents.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.YourEvents.ForeColor = System.Drawing.SystemColors.ControlText;
            this.YourEvents.Location = new System.Drawing.Point(251, 3);
            this.YourEvents.Name = "YourEvents";
            this.YourEvents.Size = new System.Drawing.Size(806, 385);
            this.YourEvents.TabIndex = 0;
            this.YourEvents.TabStop = false;
            this.YourEvents.Text = "Events for day";
            // 
            // CRUDButtonPanel
            // 
            this.CRUDButtonPanel.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.CRUDButtonPanel.Controls.Add(this.AddEvent);
            this.CRUDButtonPanel.Controls.Add(this.EditEvent);
            this.CRUDButtonPanel.Controls.Add(this.RemoveButton);
            this.CRUDButtonPanel.Controls.Add(this.splitter1);
            this.CRUDButtonPanel.Controls.Add(this.ToggleStatus);
            this.CRUDButtonPanel.Location = new System.Drawing.Point(7, 339);
            this.CRUDButtonPanel.Name = "CRUDButtonPanel";
            this.CRUDButtonPanel.Size = new System.Drawing.Size(793, 40);
            this.CRUDButtonPanel.TabIndex = 0;
            // 
            // AddEvent
            // 
            this.AddEvent.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
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
            this.TodaysEvents.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TodaysEvents.FormattingEnabled = true;
            this.TodaysEvents.ItemHeight = 16;
            this.TodaysEvents.Items.AddRange(new object[] {
            "Test"});
            this.TodaysEvents.Location = new System.Drawing.Point(7, 26);
            this.TodaysEvents.MultiColumn = true;
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
            this.TimeTab.Location = new System.Drawing.Point(4, 22);
            this.TimeTab.Name = "TimeTab";
            this.TimeTab.Padding = new System.Windows.Forms.Padding(3);
            this.TimeTab.Size = new System.Drawing.Size(1060, 391);
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
            this.EventListView.Alignment = System.Windows.Forms.ListViewAlignment.SnapToGrid;
            this.EventListView.AutoArrange = false;
            this.EventListView.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.EventTitle,
            this.TimeTilEvent});
            this.EventListView.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.EventListView.FullRowSelect = true;
            this.EventListView.GridLines = true;
            listViewGroup5.Header = "Complete";
            listViewGroup5.HeaderAlignment = System.Windows.Forms.HorizontalAlignment.Center;
            listViewGroup5.Name = "Complete";
            listViewGroup6.Header = "Upcoming";
            listViewGroup6.HeaderAlignment = System.Windows.Forms.HorizontalAlignment.Center;
            listViewGroup6.Name = "Upcoming";
            listViewGroup7.Header = "Happening Now";
            listViewGroup7.HeaderAlignment = System.Windows.Forms.HorizontalAlignment.Center;
            listViewGroup7.Name = "HappeningNow";
            listViewGroup8.Header = "Overdue";
            listViewGroup8.HeaderAlignment = System.Windows.Forms.HorizontalAlignment.Center;
            listViewGroup8.Name = "Overdue";
            this.EventListView.Groups.AddRange(new System.Windows.Forms.ListViewGroup[] {
            listViewGroup5,
            listViewGroup6,
            listViewGroup7,
            listViewGroup8});
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
            this.TimeTilEvent.Text = "Time Until Event";
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
            this.TimeAndCalendarTabular.Cursor = System.Windows.Forms.Cursors.Hand;
            this.TimeAndCalendarTabular.Location = new System.Drawing.Point(11, 12);
            this.TimeAndCalendarTabular.Name = "TimeAndCalendarTabular";
            this.TimeAndCalendarTabular.SelectedIndex = 0;
            this.TimeAndCalendarTabular.Size = new System.Drawing.Size(1068, 417);
            this.TimeAndCalendarTabular.TabIndex = 0;
            // 
            // GeneralToolTip
            // 
            this.GeneralToolTip.IsBalloon = true;
            this.GeneralToolTip.Tag = "";
            // 
            // DateTimeIcon
            // 
            this.DateTimeIcon.Text = "Open";
            this.DateTimeIcon.Visible = true;
            this.DateTimeIcon.DoubleClick += new System.EventHandler(this.DateTimeIcon_DoubleClick);
            // 
            // MainApp
            // 
            this.AccessibleDescription = "The main window";
            this.AccessibleName = "Main";
            this.AccessibleRole = System.Windows.Forms.AccessibleRole.Window;
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Inherit;
            this.AutoSize = true;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.ClientSize = new System.Drawing.Size(1092, 441);
            this.Controls.Add(this.TimeAndCalendarTabular);
            this.Cursor = System.Windows.Forms.Cursors.Default;
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "MainApp";
            this.Opacity = 0.9D;
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Main";
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
    }
}

