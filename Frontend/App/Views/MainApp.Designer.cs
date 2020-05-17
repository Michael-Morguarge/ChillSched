namespace Frontend.App.Views
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
            this.EventCalendar = new System.Windows.Forms.MonthCalendar();
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
            this.SearchTab = new System.Windows.Forms.TabPage();
            this.SearchViews = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.SearchTextTB = new System.Windows.Forms.TextBox();
            this.TextLbl = new System.Windows.Forms.Label();
            this.SearchBTN = new System.Windows.Forms.Button();
            this.EventSearchEndDP = new System.Windows.Forms.DateTimePicker();
            this.EndDateLbl = new System.Windows.Forms.Label();
            this.UseEndDate = new System.Windows.Forms.CheckBox();
            this.EventSearchStartDP = new System.Windows.Forms.DateTimePicker();
            this.StartDateLbl = new System.Windows.Forms.Label();
            this.UseStartDate = new System.Windows.Forms.CheckBox();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.GeneralToolTip = new System.Windows.Forms.ToolTip(this.components);
            this.DateTimeIcon = new System.Windows.Forms.NotifyIcon(this.components);
            this.DateTimeIconMenuStrip = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.OpenStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.CloseStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.ChillSchedMenuStrip = new System.Windows.Forms.MenuStrip();
            this.WelcomeToChillSchedToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.AboutStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.CloseStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.EventsStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.CreateEventStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.EventDataToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.TriggerEventBackupToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ImportEventsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ExportEventsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.MessagesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.CreateMessageToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.MessageDataManagementToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.TriggerMessagesBackupToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ImportMessagesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exportMessagesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.MiscToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.DataManagementToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.TriggerAllBackupToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ImportAllDataToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ExportAllDataToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ShareToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.BottomToolStripPanel = new System.Windows.Forms.ToolStripPanel();
            this.TopToolStripPanel = new System.Windows.Forms.ToolStripPanel();
            this.RightToolStripPanel = new System.Windows.Forms.ToolStripPanel();
            this.LeftToolStripPanel = new System.Windows.Forms.ToolStripPanel();
            this.ContentPanel = new System.Windows.Forms.ToolStripContentPanel();
            this.OpenFileDialog = new System.Windows.Forms.OpenFileDialog();
            this.EIV = new Frontend.App.Parts.EventsInfoView();
            this.SEIV = new Frontend.App.Parts.EventsInfoView();
            this.MMV = new Frontend.App.Parts.MessagesView();
            this.FolderBrowserDialog = new System.Windows.Forms.FolderBrowserDialog();
            this.CalendarTab.SuspendLayout();
            this.TimeTab.SuspendLayout();
            this.TimeAndCalendarTabular.SuspendLayout();
            this.SearchTab.SuspendLayout();
            this.SearchViews.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.DateTimeIconMenuStrip.SuspendLayout();
            this.ChillSchedMenuStrip.SuspendLayout();
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
            this.CalendarTab.Controls.Add(this.EventCalendar);
            this.CalendarTab.Controls.Add(this.EIV);
            this.CalendarTab.Location = new System.Drawing.Point(4, 29);
            this.CalendarTab.Name = "CalendarTab";
            this.CalendarTab.Padding = new System.Windows.Forms.Padding(3);
            this.CalendarTab.Size = new System.Drawing.Size(1060, 393);
            this.CalendarTab.TabIndex = 0;
            this.CalendarTab.Text = "Calendar";
            // 
            // EventCalendar
            // 
            this.EventCalendar.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.EventCalendar.CalendarDimensions = new System.Drawing.Size(1, 2);
            this.EventCalendar.FirstDayOfWeek = System.Windows.Forms.Day.Sunday;
            this.EventCalendar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.EventCalendar.ForeColor = System.Drawing.SystemColors.ControlDark;
            this.EventCalendar.Location = new System.Drawing.Point(12, 12);
            this.EventCalendar.MaxSelectionCount = 1;
            this.EventCalendar.Name = "EventCalendar";
            this.EventCalendar.TabIndex = 0;
            this.EventCalendar.TabStop = false;
            this.EventCalendar.TitleBackColor = System.Drawing.SystemColors.HotTrack;
            this.EventCalendar.TrailingForeColor = System.Drawing.SystemColors.ControlText;
            this.EventCalendar.DateChanged += new System.Windows.Forms.DateRangeEventHandler(this.Calendar_DateChanged);
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
            // SearchViews
            // 
            this.SearchViews.Appearance = System.Windows.Forms.TabAppearance.FlatButtons;
            this.SearchViews.Controls.Add(this.tabPage1);
            this.SearchViews.Controls.Add(this.tabPage2);
            this.SearchViews.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SearchViews.ItemSize = new System.Drawing.Size(80, 25);
            this.SearchViews.Location = new System.Drawing.Point(6, 6);
            this.SearchViews.Name = "SearchViews";
            this.SearchViews.SelectedIndex = 0;
            this.SearchViews.Size = new System.Drawing.Size(1048, 381);
            this.SearchViews.TabIndex = 2;
            // 
            // tabPage1
            // 
            this.tabPage1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.tabPage1.Controls.Add(this.tableLayoutPanel1);
            this.tabPage1.Controls.Add(this.SEIV);
            this.tabPage1.Location = new System.Drawing.Point(4, 29);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(1040, 348);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Events";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.tableLayoutPanel1.ColumnCount = 1;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tableLayoutPanel1.Controls.Add(this.SearchTextTB, 0, 2);
            this.tableLayoutPanel1.Controls.Add(this.TextLbl, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.SearchBTN, 0, 12);
            this.tableLayoutPanel1.Controls.Add(this.EventSearchEndDP, 0, 10);
            this.tableLayoutPanel1.Controls.Add(this.EndDateLbl, 0, 9);
            this.tableLayoutPanel1.Controls.Add(this.UseEndDate, 0, 8);
            this.tableLayoutPanel1.Controls.Add(this.EventSearchStartDP, 0, 6);
            this.tableLayoutPanel1.Controls.Add(this.StartDateLbl, 0, 5);
            this.tableLayoutPanel1.Controls.Add(this.UseStartDate, 0, 4);
            this.tableLayoutPanel1.Location = new System.Drawing.Point(6, 6);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 14;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 8F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 23F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 29F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 27F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 24F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 30F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 19F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 27F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 22F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 31F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 21F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 73F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(206, 337);
            this.tableLayoutPanel1.TabIndex = 2;
            // 
            // SearchTextTB
            // 
            this.SearchTextTB.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.SearchTextTB.Location = new System.Drawing.Point(3, 34);
            this.SearchTextTB.Name = "SearchTextTB";
            this.SearchTextTB.Size = new System.Drawing.Size(200, 23);
            this.SearchTextTB.TabIndex = 3;
            this.SearchTextTB.KeyUp += new System.Windows.Forms.KeyEventHandler(this.TextTB_KeyUp);
            // 
            // TextLbl
            // 
            this.TextLbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold);
            this.TextLbl.Location = new System.Drawing.Point(3, 8);
            this.TextLbl.Name = "TextLbl";
            this.TextLbl.Size = new System.Drawing.Size(194, 23);
            this.TextLbl.TabIndex = 0;
            this.TextLbl.Text = "Text:";
            this.TextLbl.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // SearchBTN
            // 
            this.SearchBTN.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.SearchBTN.Location = new System.Drawing.Point(3, 284);
            this.SearchBTN.Name = "SearchBTN";
            this.SearchBTN.Size = new System.Drawing.Size(200, 27);
            this.SearchBTN.TabIndex = 6;
            this.SearchBTN.Text = "Search";
            this.SearchBTN.UseVisualStyleBackColor = true;
            this.SearchBTN.Click += new System.EventHandler(this.SearchBTN_Click);
            // 
            // EventSearchEndDP
            // 
            this.EventSearchEndDP.CustomFormat = "MM/dd/yyyy";
            this.EventSearchEndDP.Enabled = false;
            this.EventSearchEndDP.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.EventSearchEndDP.Location = new System.Drawing.Point(3, 232);
            this.EventSearchEndDP.Name = "EventSearchEndDP";
            this.EventSearchEndDP.Size = new System.Drawing.Size(200, 23);
            this.EventSearchEndDP.TabIndex = 5;
            this.EventSearchEndDP.KeyUp += new System.Windows.Forms.KeyEventHandler(this.TextTB_KeyUp);
            // 
            // EndDateLbl
            // 
            this.EndDateLbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold);
            this.EndDateLbl.ForeColor = System.Drawing.Color.DimGray;
            this.EndDateLbl.Location = new System.Drawing.Point(3, 207);
            this.EndDateLbl.Name = "EndDateLbl";
            this.EndDateLbl.Size = new System.Drawing.Size(194, 20);
            this.EndDateLbl.TabIndex = 2;
            this.EndDateLbl.Text = "End Date:";
            this.EndDateLbl.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // UseEndDate
            // 
            this.UseEndDate.AutoSize = true;
            this.UseEndDate.Location = new System.Drawing.Point(3, 183);
            this.UseEndDate.Name = "UseEndDate";
            this.UseEndDate.Size = new System.Drawing.Size(183, 21);
            this.UseEndDate.TabIndex = 8;
            this.UseEndDate.Text = "Search with End Date";
            this.UseEndDate.UseVisualStyleBackColor = true;
            this.UseEndDate.CheckedChanged += new System.EventHandler(this.UseEndDate_CheckedChanged);
            // 
            // EventSearchStartDP
            // 
            this.EventSearchStartDP.CalendarFont = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.EventSearchStartDP.CustomFormat = "MM/dd/yyyy";
            this.EventSearchStartDP.Enabled = false;
            this.EventSearchStartDP.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold);
            this.EventSearchStartDP.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.EventSearchStartDP.Location = new System.Drawing.Point(3, 134);
            this.EventSearchStartDP.Name = "EventSearchStartDP";
            this.EventSearchStartDP.Size = new System.Drawing.Size(200, 23);
            this.EventSearchStartDP.TabIndex = 4;
            this.EventSearchStartDP.KeyUp += new System.Windows.Forms.KeyEventHandler(this.TextTB_KeyUp);
            // 
            // StartDateLbl
            // 
            this.StartDateLbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold);
            this.StartDateLbl.ForeColor = System.Drawing.Color.DimGray;
            this.StartDateLbl.Location = new System.Drawing.Point(3, 107);
            this.StartDateLbl.Name = "StartDateLbl";
            this.StartDateLbl.Size = new System.Drawing.Size(194, 24);
            this.StartDateLbl.TabIndex = 0;
            this.StartDateLbl.Text = "Start Date:";
            this.StartDateLbl.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // UseStartDate
            // 
            this.UseStartDate.AutoSize = true;
            this.UseStartDate.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.UseStartDate.Location = new System.Drawing.Point(3, 83);
            this.UseStartDate.Name = "UseStartDate";
            this.UseStartDate.Size = new System.Drawing.Size(196, 21);
            this.UseStartDate.TabIndex = 7;
            this.UseStartDate.Text = "Search with Start Date";
            this.UseStartDate.UseVisualStyleBackColor = true;
            this.UseStartDate.CheckedChanged += new System.EventHandler(this.UseStartDate_CheckedChanged);
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.MMV);
            this.tabPage2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tabPage2.Location = new System.Drawing.Point(4, 29);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(1040, 348);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Mesages";
            this.tabPage2.UseVisualStyleBackColor = true;
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
            this.MessagesToolStripMenuItem,
            this.MiscToolStripMenuItem});
            this.ChillSchedMenuStrip.Location = new System.Drawing.Point(0, 0);
            this.ChillSchedMenuStrip.Name = "ChillSchedMenuStrip";
            this.ChillSchedMenuStrip.RenderMode = System.Windows.Forms.ToolStripRenderMode.System;
            this.ChillSchedMenuStrip.Size = new System.Drawing.Size(1092, 32);
            this.ChillSchedMenuStrip.TabIndex = 1;
            this.ChillSchedMenuStrip.Text = "ChillSchedMenuStrip";
            // 
            // WelcomeToChillSchedToolStripMenuItem
            // 
            this.WelcomeToChillSchedToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.AboutStripMenuItem,
            this.CloseStripMenuItem});
            this.WelcomeToChillSchedToolStripMenuItem.Image = global::Frontend.Properties.Resources.ChillSched;
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
            // EventsStripMenuItem
            // 
            this.EventsStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.CreateEventStripMenuItem,
            this.EventDataToolStripMenuItem});
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
            this.CreateEventStripMenuItem.ToolTipText = "Create an event.";
            this.CreateEventStripMenuItem.Click += new System.EventHandler(this.CreateEvent_Click);
            // 
            // EventDataToolStripMenuItem
            // 
            this.EventDataToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.TriggerEventBackupToolStripMenuItem,
            this.ImportEventsToolStripMenuItem,
            this.ExportEventsToolStripMenuItem});
            this.EventDataToolStripMenuItem.Name = "EventDataToolStripMenuItem";
            this.EventDataToolStripMenuItem.ShowShortcutKeys = false;
            this.EventDataToolStripMenuItem.Size = new System.Drawing.Size(243, 24);
            this.EventDataToolStripMenuItem.Text = "Event Data Management";
            // 
            // TriggerEventBackupToolStripMenuItem
            // 
            this.TriggerEventBackupToolStripMenuItem.Name = "TriggerEventBackupToolStripMenuItem";
            this.TriggerEventBackupToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)(((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.Shift) 
            | System.Windows.Forms.Keys.B)));
            this.TriggerEventBackupToolStripMenuItem.Size = new System.Drawing.Size(298, 24);
            this.TriggerEventBackupToolStripMenuItem.Text = "Trigger Events Backup";
            this.TriggerEventBackupToolStripMenuItem.ToolTipText = "Triggers a backup of current events. All events are backed up on application clos" +
    "e, adds, updates and deletes.";
            this.TriggerEventBackupToolStripMenuItem.Click += new System.EventHandler(this.EventBackupStripMenuItem_Click);
            // 
            // ImportEventsToolStripMenuItem
            // 
            this.ImportEventsToolStripMenuItem.Name = "ImportEventsToolStripMenuItem";
            this.ImportEventsToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)(((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.Shift) 
            | System.Windows.Forms.Keys.C)));
            this.ImportEventsToolStripMenuItem.Size = new System.Drawing.Size(298, 24);
            this.ImportEventsToolStripMenuItem.Text = "Import Events";
            this.ImportEventsToolStripMenuItem.ToolTipText = "Imports events from file.";
            // 
            // ExportEventsToolStripMenuItem
            // 
            this.ExportEventsToolStripMenuItem.Name = "ExportEventsToolStripMenuItem";
            this.ExportEventsToolStripMenuItem.ShortcutKeyDisplayString = "";
            this.ExportEventsToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)(((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.Shift) 
            | System.Windows.Forms.Keys.D)));
            this.ExportEventsToolStripMenuItem.Size = new System.Drawing.Size(298, 24);
            this.ExportEventsToolStripMenuItem.Text = "Export Events";
            this.ExportEventsToolStripMenuItem.ToolTipText = "Export events to a custom location.";
            // 
            // MessagesToolStripMenuItem
            // 
            this.MessagesToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.CreateMessageToolStripMenuItem,
            this.MessageDataManagementToolStripMenuItem});
            this.MessagesToolStripMenuItem.Name = "MessagesToolStripMenuItem";
            this.MessagesToolStripMenuItem.Size = new System.Drawing.Size(81, 28);
            this.MessagesToolStripMenuItem.Text = "Messages";
            // 
            // CreateMessageToolStripMenuItem
            // 
            this.CreateMessageToolStripMenuItem.Name = "CreateMessageToolStripMenuItem";
            this.CreateMessageToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)(((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.Shift) 
            | System.Windows.Forms.Keys.E)));
            this.CreateMessageToolStripMenuItem.Size = new System.Drawing.Size(261, 24);
            this.CreateMessageToolStripMenuItem.Text = "Create Message";
            this.CreateMessageToolStripMenuItem.ToolTipText = "Creates a message.";
            this.CreateMessageToolStripMenuItem.Click += new System.EventHandler(this.CreateMessageToolStripMenuItem_Click);
            // 
            // MessageDataManagementToolStripMenuItem
            // 
            this.MessageDataManagementToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.TriggerMessagesBackupToolStripMenuItem,
            this.ImportMessagesToolStripMenuItem,
            this.exportMessagesToolStripMenuItem});
            this.MessageDataManagementToolStripMenuItem.Name = "MessageDataManagementToolStripMenuItem";
            this.MessageDataManagementToolStripMenuItem.Size = new System.Drawing.Size(261, 24);
            this.MessageDataManagementToolStripMenuItem.Text = "Message Data Management";
            // 
            // TriggerMessagesBackupToolStripMenuItem
            // 
            this.TriggerMessagesBackupToolStripMenuItem.Name = "TriggerMessagesBackupToolStripMenuItem";
            this.TriggerMessagesBackupToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)(((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.Shift) 
            | System.Windows.Forms.Keys.F)));
            this.TriggerMessagesBackupToolStripMenuItem.Size = new System.Drawing.Size(317, 24);
            this.TriggerMessagesBackupToolStripMenuItem.Text = "Trigger Messages Backup";
            this.TriggerMessagesBackupToolStripMenuItem.ToolTipText = "Triggers a backup of current messages. All messages are backed up application clo" +
    "se, adds, updates and deletes.";
            this.TriggerMessagesBackupToolStripMenuItem.Click += new System.EventHandler(this.TriggerMessagesBackupToolStripMenuItem_Click);
            // 
            // ImportMessagesToolStripMenuItem
            // 
            this.ImportMessagesToolStripMenuItem.Name = "ImportMessagesToolStripMenuItem";
            this.ImportMessagesToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)(((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.Shift) 
            | System.Windows.Forms.Keys.G)));
            this.ImportMessagesToolStripMenuItem.Size = new System.Drawing.Size(317, 24);
            this.ImportMessagesToolStripMenuItem.Text = "Import Messages";
            this.ImportMessagesToolStripMenuItem.ToolTipText = "Imports messages from file.";
            // 
            // exportMessagesToolStripMenuItem
            // 
            this.exportMessagesToolStripMenuItem.Name = "exportMessagesToolStripMenuItem";
            this.exportMessagesToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)(((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.Shift) 
            | System.Windows.Forms.Keys.H)));
            this.exportMessagesToolStripMenuItem.Size = new System.Drawing.Size(317, 24);
            this.exportMessagesToolStripMenuItem.Text = "Export Messages";
            // 
            // MiscToolStripMenuItem
            // 
            this.MiscToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.DataManagementToolStripMenuItem,
            this.ShareToolStripMenuItem});
            this.MiscToolStripMenuItem.Name = "MiscToolStripMenuItem";
            this.MiscToolStripMenuItem.Size = new System.Drawing.Size(49, 28);
            this.MiscToolStripMenuItem.Text = "Misc";
            // 
            // DataManagementToolStripMenuItem
            // 
            this.DataManagementToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.TriggerAllBackupToolStripMenuItem,
            this.ImportAllDataToolStripMenuItem,
            this.ExportAllDataToolStripMenuItem});
            this.DataManagementToolStripMenuItem.Name = "DataManagementToolStripMenuItem";
            this.DataManagementToolStripMenuItem.Size = new System.Drawing.Size(193, 24);
            this.DataManagementToolStripMenuItem.Text = "Data Management";
            // 
            // TriggerAllBackupToolStripMenuItem
            // 
            this.TriggerAllBackupToolStripMenuItem.Name = "TriggerAllBackupToolStripMenuItem";
            this.TriggerAllBackupToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)(((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.Shift) 
            | System.Windows.Forms.Keys.I)));
            this.TriggerAllBackupToolStripMenuItem.Size = new System.Drawing.Size(255, 24);
            this.TriggerAllBackupToolStripMenuItem.Text = "Trigger Backup";
            this.TriggerAllBackupToolStripMenuItem.ToolTipText = "Triggers a backup of current events and messages. All events and messages are bac" +
    "ked up application close, adds, updates,and deletes.";
            this.TriggerAllBackupToolStripMenuItem.Click += new System.EventHandler(this.TriggerAllBackupToolStripMenuItem_Click);
            // 
            // ImportAllDataToolStripMenuItem
            // 
            this.ImportAllDataToolStripMenuItem.Name = "ImportAllDataToolStripMenuItem";
            this.ImportAllDataToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)(((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.Shift) 
            | System.Windows.Forms.Keys.J)));
            this.ImportAllDataToolStripMenuItem.Size = new System.Drawing.Size(255, 24);
            this.ImportAllDataToolStripMenuItem.Text = "Import All Data";
            this.ImportAllDataToolStripMenuItem.ToolTipText = "Imports all data from files.";
            this.ImportAllDataToolStripMenuItem.Click += new System.EventHandler(this.ImportAllDataToolStripMenuItem_Click);
            // 
            // ExportAllDataToolStripMenuItem
            // 
            this.ExportAllDataToolStripMenuItem.Name = "ExportAllDataToolStripMenuItem";
            this.ExportAllDataToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)(((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.Shift) 
            | System.Windows.Forms.Keys.K)));
            this.ExportAllDataToolStripMenuItem.Size = new System.Drawing.Size(255, 24);
            this.ExportAllDataToolStripMenuItem.Text = "Export All Data";
            this.ExportAllDataToolStripMenuItem.ToolTipText = "Exports all data to a custom location.";
            this.ExportAllDataToolStripMenuItem.Click += new System.EventHandler(this.ExportAllDataToolStripMenuItem_Click);
            // 
            // ShareToolStripMenuItem
            // 
            this.ShareToolStripMenuItem.Name = "ShareToolStripMenuItem";
            this.ShareToolStripMenuItem.Size = new System.Drawing.Size(193, 24);
            this.ShareToolStripMenuItem.Text = "Share";
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
            // OpenFileDialog
            // 
            this.OpenFileDialog.DefaultExt = "saved";
            this.OpenFileDialog.FileName = "OpenFileDialog";
            this.OpenFileDialog.Filter = "ChillSched Save|*.saved";
            this.OpenFileDialog.Multiselect = true;
            this.OpenFileDialog.ReadOnlyChecked = true;
            this.OpenFileDialog.SupportMultiDottedExtensions = true;
            this.OpenFileDialog.Title = "Import All Data";
            // 
            // EIV
            // 
            this.EIV.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.EIV.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.EIV.Location = new System.Drawing.Point(246, 3);
            this.EIV.Name = "EIV";
            this.EIV.Size = new System.Drawing.Size(814, 387);
            this.EIV.TabIndex = 2;
            // 
            // SEIV
            // 
            this.SEIV.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.SEIV.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SEIV.Location = new System.Drawing.Point(218, 6);
            this.SEIV.Name = "SEIV";
            this.SEIV.Size = new System.Drawing.Size(814, 337);
            this.SEIV.TabIndex = 0;
            // 
            // MMV
            // 
            this.MMV.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.MMV.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.MMV.Location = new System.Drawing.Point(8, 3);
            this.MMV.Name = "MMV";
            this.MMV.Size = new System.Drawing.Size(1023, 340);
            this.MMV.TabIndex = 0;
            // 
            // FolderBrowserDialog
            // 
            this.FolderBrowserDialog.Description = "Select a folder to save the application data.";
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
            this.TimeTab.ResumeLayout(false);
            this.TimeAndCalendarTabular.ResumeLayout(false);
            this.SearchTab.ResumeLayout(false);
            this.SearchViews.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.tabPage2.ResumeLayout(false);
            this.DateTimeIconMenuStrip.ResumeLayout(false);
            this.ChillSchedMenuStrip.ResumeLayout(false);
            this.ChillSchedMenuStrip.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Timer TimeTicker;
        private System.Windows.Forms.Timer DateTicker;
        private System.Windows.Forms.TabPage CalendarTab;
        private System.Windows.Forms.MonthCalendar EventCalendar;
        private System.Windows.Forms.TabPage TimeTab;
        private System.Windows.Forms.Label Date;
        private System.Windows.Forms.Label Time;
        private System.Windows.Forms.TabControl TimeAndCalendarTabular;
        private System.Windows.Forms.ToolTip GeneralToolTip;
        private System.Windows.Forms.Label LatestEvent;
        private System.Windows.Forms.Button ViewEvent;
        private System.Windows.Forms.NotifyIcon DateTimeIcon;
        private System.Windows.Forms.ListView EventListView;
        private System.Windows.Forms.ColumnHeader EventTitle;
        private System.Windows.Forms.ColumnHeader TimeTilEvent;
        private System.Windows.Forms.Label CurrMonthsEvents;
        private System.Windows.Forms.ProgressBar NextUpdateProgress;
        private System.Windows.Forms.Label LastUpdated;
        private System.Windows.Forms.Label NextUpdateIn;
        private System.Windows.Forms.MenuStrip ChillSchedMenuStrip;
        private System.Windows.Forms.ToolStripMenuItem WelcomeToChillSchedToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem EventsStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem CreateEventStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem AboutStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem CloseStripMenuItem;
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
        private System.Windows.Forms.ToolStripMenuItem TriggerEventBackupToolStripMenuItem;
        private Parts.EventsInfoView SEIV;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Label TextLbl;
        private System.Windows.Forms.Label StartDateLbl;
        private System.Windows.Forms.Label EndDateLbl;
        private Parts.MessagesView MMV;
        private System.Windows.Forms.TextBox SearchTextTB;
        private System.Windows.Forms.DateTimePicker EventSearchStartDP;
        private System.Windows.Forms.DateTimePicker EventSearchEndDP;
        private System.Windows.Forms.Button SearchBTN;
        private System.Windows.Forms.CheckBox UseStartDate;
        private System.Windows.Forms.CheckBox UseEndDate;
        private System.Windows.Forms.ToolStripMenuItem ExportEventsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ImportEventsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem MessagesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem EventDataToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem CreateMessageToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem MessageDataManagementToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem TriggerMessagesBackupToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ImportMessagesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem MiscToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem DataManagementToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ShareToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem TriggerAllBackupToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ImportAllDataToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ExportAllDataToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem exportMessagesToolStripMenuItem;
        private System.Windows.Forms.OpenFileDialog OpenFileDialog;
        private System.Windows.Forms.FolderBrowserDialog FolderBrowserDialog;
    }
}

