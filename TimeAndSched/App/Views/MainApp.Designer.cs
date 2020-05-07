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
            System.Windows.Forms.ListViewGroup listViewGroup9 = new System.Windows.Forms.ListViewGroup("Complete", System.Windows.Forms.HorizontalAlignment.Center);
            System.Windows.Forms.ListViewGroup listViewGroup10 = new System.Windows.Forms.ListViewGroup("Upcoming", System.Windows.Forms.HorizontalAlignment.Center);
            System.Windows.Forms.ListViewGroup listViewGroup11 = new System.Windows.Forms.ListViewGroup("Happening Now", System.Windows.Forms.HorizontalAlignment.Center);
            System.Windows.Forms.ListViewGroup listViewGroup12 = new System.Windows.Forms.ListViewGroup("Overdue", System.Windows.Forms.HorizontalAlignment.Center);
            this.TimeTicker = new System.Windows.Forms.Timer(this.components);
            this.DateTicker = new System.Windows.Forms.Timer(this.components);
            this.CalendarTab = new System.Windows.Forms.TabPage();
            this.Calendar = new System.Windows.Forms.MonthCalendar();
            this.EIV = new FrontEnd.App.Parts.EventsInfoView();
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
            this.TextLbl = new System.Windows.Forms.Label();
            this.StartDateLbl = new System.Windows.Forms.Label();
            this.EndDateLbl = new System.Windows.Forms.Label();
            this.SEIV = new FrontEnd.App.Parts.EventsInfoView();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.MMV = new FrontEnd.App.Parts.ManageMessageView();
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
            this.tirggerBackupToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.BottomToolStripPanel = new System.Windows.Forms.ToolStripPanel();
            this.TopToolStripPanel = new System.Windows.Forms.ToolStripPanel();
            this.RightToolStripPanel = new System.Windows.Forms.ToolStripPanel();
            this.LeftToolStripPanel = new System.Windows.Forms.ToolStripPanel();
            this.ContentPanel = new System.Windows.Forms.ToolStripContentPanel();
            this.TextTB = new System.Windows.Forms.TextBox();
            this.SearchStartDate = new System.Windows.Forms.DateTimePicker();
            this.SearchEndDate = new System.Windows.Forms.DateTimePicker();
            this.SearchBTN = new System.Windows.Forms.Button();
            this.UseStartDate = new System.Windows.Forms.CheckBox();
            this.UseEndDate = new System.Windows.Forms.CheckBox();
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
            this.CalendarTab.Controls.Add(this.Calendar);
            this.CalendarTab.Controls.Add(this.EIV);
            this.CalendarTab.Location = new System.Drawing.Point(4, 29);
            this.CalendarTab.Name = "CalendarTab";
            this.CalendarTab.Padding = new System.Windows.Forms.Padding(3);
            this.CalendarTab.Size = new System.Drawing.Size(1060, 393);
            this.CalendarTab.TabIndex = 0;
            this.CalendarTab.Text = "Calendar";
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
            // EIV
            // 
            this.EIV.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.EIV.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.EIV.Location = new System.Drawing.Point(246, 3);
            this.EIV.Name = "EIV";
            this.EIV.Size = new System.Drawing.Size(814, 387);
            this.EIV.TabIndex = 2;
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
            listViewGroup9.Header = "Complete";
            listViewGroup9.HeaderAlignment = System.Windows.Forms.HorizontalAlignment.Center;
            listViewGroup9.Name = "Complete";
            listViewGroup10.Header = "Upcoming";
            listViewGroup10.HeaderAlignment = System.Windows.Forms.HorizontalAlignment.Center;
            listViewGroup10.Name = "Upcoming";
            listViewGroup11.Header = "Happening Now";
            listViewGroup11.HeaderAlignment = System.Windows.Forms.HorizontalAlignment.Center;
            listViewGroup11.Name = "HappeningNow";
            listViewGroup12.Header = "Overdue";
            listViewGroup12.HeaderAlignment = System.Windows.Forms.HorizontalAlignment.Center;
            listViewGroup12.Name = "Overdue";
            this.EventListView.Groups.AddRange(new System.Windows.Forms.ListViewGroup[] {
            listViewGroup9,
            listViewGroup10,
            listViewGroup11,
            listViewGroup12});
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
            this.tableLayoutPanel1.Controls.Add(this.TextTB, 0, 2);
            this.tableLayoutPanel1.Controls.Add(this.TextLbl, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.SearchBTN, 0, 12);
            this.tableLayoutPanel1.Controls.Add(this.SearchEndDate, 0, 10);
            this.tableLayoutPanel1.Controls.Add(this.EndDateLbl, 0, 9);
            this.tableLayoutPanel1.Controls.Add(this.UseEndDate, 0, 8);
            this.tableLayoutPanel1.Controls.Add(this.SearchStartDate, 0, 6);
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
            // SEIV
            // 
            this.SEIV.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.SEIV.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SEIV.Location = new System.Drawing.Point(218, 6);
            this.SEIV.Name = "SEIV";
            this.SEIV.Size = new System.Drawing.Size(814, 337);
            this.SEIV.TabIndex = 0;
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
            // MMV
            // 
            this.MMV.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.MMV.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.MMV.Location = new System.Drawing.Point(0, 2);
            this.MMV.Name = "MMV";
            this.MMV.Size = new System.Drawing.Size(377, 340);
            this.MMV.TabIndex = 0;
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
            this.EventsStripMenuItem});
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
            // EventsStripMenuItem
            // 
            this.EventsStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.CreateEventStripMenuItem,
            this.tirggerBackupToolStripMenuItem});
            this.EventsStripMenuItem.Name = "EventsStripMenuItem";
            this.EventsStripMenuItem.ShortcutKeyDisplayString = "";
            this.EventsStripMenuItem.Size = new System.Drawing.Size(61, 28);
            this.EventsStripMenuItem.Text = "Events";
            // 
            // CreateEventStripMenuItem
            // 
            this.CreateEventStripMenuItem.Name = "CreateEventStripMenuItem";
            this.CreateEventStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)(((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.Shift) 
            | System.Windows.Forms.Keys.C)));
            this.CreateEventStripMenuItem.Size = new System.Drawing.Size(254, 24);
            this.CreateEventStripMenuItem.Text = "Create Event";
            this.CreateEventStripMenuItem.ToolTipText = "Create an event";
            this.CreateEventStripMenuItem.Click += new System.EventHandler(this.CreateEvent_Click);
            // 
            // tirggerBackupToolStripMenuItem
            // 
            this.tirggerBackupToolStripMenuItem.Name = "tirggerBackupToolStripMenuItem";
            this.tirggerBackupToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)(((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.Shift) 
            | System.Windows.Forms.Keys.B)));
            this.tirggerBackupToolStripMenuItem.Size = new System.Drawing.Size(254, 24);
            this.tirggerBackupToolStripMenuItem.Text = "Trigger Backup";
            this.tirggerBackupToolStripMenuItem.Click += new System.EventHandler(this.EventBackupStripMenuItem_Click);
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
            // TextTB
            // 
            this.TextTB.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.TextTB.Location = new System.Drawing.Point(3, 34);
            this.TextTB.Name = "TextTB";
            this.TextTB.Size = new System.Drawing.Size(200, 23);
            this.TextTB.TabIndex = 3;
            this.TextTB.KeyUp += new System.Windows.Forms.KeyEventHandler(this.TextTB_KeyUp);
            // 
            // SearchStartDate
            // 
            this.SearchStartDate.CalendarFont = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SearchStartDate.CustomFormat = "MM/dd/yyyy";
            this.SearchStartDate.Enabled = false;
            this.SearchStartDate.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold);
            this.SearchStartDate.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.SearchStartDate.Location = new System.Drawing.Point(3, 134);
            this.SearchStartDate.Name = "SearchStartDate";
            this.SearchStartDate.Size = new System.Drawing.Size(200, 23);
            this.SearchStartDate.TabIndex = 4;
            this.SearchStartDate.KeyUp += new System.Windows.Forms.KeyEventHandler(this.TextTB_KeyUp);
            // 
            // SearchEndDate
            // 
            this.SearchEndDate.CustomFormat = "MM/dd/yyyy";
            this.SearchEndDate.Enabled = false;
            this.SearchEndDate.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.SearchEndDate.Location = new System.Drawing.Point(3, 232);
            this.SearchEndDate.Name = "SearchEndDate";
            this.SearchEndDate.Size = new System.Drawing.Size(200, 23);
            this.SearchEndDate.TabIndex = 5;
            this.SearchEndDate.KeyUp += new System.Windows.Forms.KeyEventHandler(this.TextTB_KeyUp);
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
        private System.Windows.Forms.MonthCalendar Calendar;
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
        private System.Windows.Forms.ToolStripMenuItem tirggerBackupToolStripMenuItem;
        private Parts.EventsInfoView SEIV;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Label TextLbl;
        private System.Windows.Forms.Label StartDateLbl;
        private System.Windows.Forms.Label EndDateLbl;
        private Parts.ManageMessageView MMV;
        private System.Windows.Forms.TextBox TextTB;
        private System.Windows.Forms.DateTimePicker SearchStartDate;
        private System.Windows.Forms.DateTimePicker SearchEndDate;
        private System.Windows.Forms.Button SearchBTN;
        private System.Windows.Forms.CheckBox UseStartDate;
        private System.Windows.Forms.CheckBox UseEndDate;
    }
}

