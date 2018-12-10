namespace TimeAndSched.View
{
    partial class Main
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
            this.TimeTicker = new System.Windows.Forms.Timer(this.components);
            this.DateTicker = new System.Windows.Forms.Timer(this.components);
            this.CalendarTab = new System.Windows.Forms.TabPage();
            this.YourEvents = new System.Windows.Forms.GroupBox();
            this.CRUDButtonPanel = new System.Windows.Forms.FlowLayoutPanel();
            this.AddEvent = new System.Windows.Forms.Button();
            this.EditEvent = new System.Windows.Forms.Button();
            this.RemoveButton = new System.Windows.Forms.Button();
            this.TodaysEvents = new System.Windows.Forms.ListBox();
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.ExpStartDate = new System.Windows.Forms.Label();
            this.ExpStartTime = new System.Windows.Forms.Label();
            this.ExpEndDate = new System.Windows.Forms.Label();
            this.ExpEndTime = new System.Windows.Forms.Label();
            this.Title = new System.Windows.Forms.Label();
            this.Comment = new System.Windows.Forms.RichTextBox();
            this.Calendar = new System.Windows.Forms.MonthCalendar();
            this.TimeTab = new System.Windows.Forms.TabPage();
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
            this.CalendarTab.BackColor = System.Drawing.Color.Black;
            this.CalendarTab.Controls.Add(this.YourEvents);
            this.CalendarTab.Controls.Add(this.Calendar);
            this.CalendarTab.Location = new System.Drawing.Point(4, 22);
            this.CalendarTab.Name = "CalendarTab";
            this.CalendarTab.Padding = new System.Windows.Forms.Padding(3);
            this.CalendarTab.Size = new System.Drawing.Size(628, 323);
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
            this.YourEvents.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.YourEvents.Location = new System.Drawing.Point(254, 3);
            this.YourEvents.Name = "YourEvents";
            this.YourEvents.Size = new System.Drawing.Size(371, 317);
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
            this.CRUDButtonPanel.Location = new System.Drawing.Point(7, 276);
            this.CRUDButtonPanel.Name = "CRUDButtonPanel";
            this.CRUDButtonPanel.Size = new System.Drawing.Size(358, 35);
            this.CRUDButtonPanel.TabIndex = 0;
            // 
            // AddEvent
            // 
            this.AddEvent.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.AddEvent.FlatAppearance.CheckedBackColor = System.Drawing.Color.Black;
            this.AddEvent.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Gray;
            this.AddEvent.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Silver;
            this.AddEvent.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.AddEvent.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AddEvent.Location = new System.Drawing.Point(3, 3);
            this.AddEvent.Name = "AddEvent";
            this.AddEvent.Size = new System.Drawing.Size(75, 31);
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
            this.EditEvent.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.EditEvent.Location = new System.Drawing.Point(84, 3);
            this.EditEvent.Name = "EditEvent";
            this.EditEvent.Size = new System.Drawing.Size(75, 31);
            this.EditEvent.TabIndex = 3;
            this.EditEvent.Text = "Edit";
            this.EditEvent.UseVisualStyleBackColor = false;
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
            this.RemoveButton.Location = new System.Drawing.Point(165, 3);
            this.RemoveButton.Name = "RemoveButton";
            this.RemoveButton.Size = new System.Drawing.Size(92, 31);
            this.RemoveButton.TabIndex = 4;
            this.RemoveButton.Text = "Remove";
            this.RemoveButton.UseVisualStyleBackColor = false;
            // 
            // TodaysEvents
            // 
            this.TodaysEvents.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TodaysEvents.FormattingEnabled = true;
            this.TodaysEvents.ItemHeight = 16;
            this.TodaysEvents.Location = new System.Drawing.Point(7, 26);
            this.TodaysEvents.Name = "TodaysEvents";
            this.TodaysEvents.Size = new System.Drawing.Size(125, 244);
            this.TodaysEvents.Sorted = true;
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
            this.flowLayoutPanel1.Location = new System.Drawing.Point(138, 13);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(230, 266);
            this.flowLayoutPanel1.TabIndex = 1;
            // 
            // ExpStartDate
            // 
            this.ExpStartDate.Cursor = System.Windows.Forms.Cursors.Default;
            this.ExpStartDate.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ExpStartDate.Location = new System.Drawing.Point(3, 0);
            this.ExpStartDate.Name = "ExpStartDate";
            this.ExpStartDate.Padding = new System.Windows.Forms.Padding(0, 5, 0, 5);
            this.ExpStartDate.Size = new System.Drawing.Size(109, 28);
            this.ExpStartDate.TabIndex = 0;
            this.ExpStartDate.Text = "N/A";
            this.ExpStartDate.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // ExpStartTime
            // 
            this.ExpStartTime.Cursor = System.Windows.Forms.Cursors.Default;
            this.ExpStartTime.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ExpStartTime.Location = new System.Drawing.Point(118, 0);
            this.ExpStartTime.Name = "ExpStartTime";
            this.ExpStartTime.Padding = new System.Windows.Forms.Padding(0, 5, 0, 5);
            this.ExpStartTime.Size = new System.Drawing.Size(109, 28);
            this.ExpStartTime.TabIndex = 0;
            this.ExpStartTime.Text = "N/A";
            this.ExpStartTime.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // ExpEndDate
            // 
            this.ExpEndDate.Cursor = System.Windows.Forms.Cursors.Default;
            this.ExpEndDate.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ExpEndDate.ForeColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.ExpEndDate.Location = new System.Drawing.Point(3, 28);
            this.ExpEndDate.Name = "ExpEndDate";
            this.ExpEndDate.Padding = new System.Windows.Forms.Padding(0, 5, 0, 5);
            this.ExpEndDate.Size = new System.Drawing.Size(109, 28);
            this.ExpEndDate.TabIndex = 0;
            this.ExpEndDate.Text = "N/A";
            this.ExpEndDate.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // ExpEndTime
            // 
            this.ExpEndTime.Cursor = System.Windows.Forms.Cursors.Default;
            this.ExpEndTime.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ExpEndTime.ForeColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.ExpEndTime.Location = new System.Drawing.Point(118, 28);
            this.ExpEndTime.Name = "ExpEndTime";
            this.ExpEndTime.Padding = new System.Windows.Forms.Padding(0, 5, 0, 5);
            this.ExpEndTime.Size = new System.Drawing.Size(109, 28);
            this.ExpEndTime.TabIndex = 0;
            this.ExpEndTime.Text = "N/A";
            this.ExpEndTime.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Title
            // 
            this.Title.BackColor = System.Drawing.Color.Black;
            this.Title.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.Title.Cursor = System.Windows.Forms.Cursors.Default;
            this.Title.Dock = System.Windows.Forms.DockStyle.Top;
            this.flowLayoutPanel1.SetFlowBreak(this.Title, true);
            this.Title.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Title.Location = new System.Drawing.Point(3, 56);
            this.Title.Name = "Title";
            this.Title.Size = new System.Drawing.Size(227, 27);
            this.Title.TabIndex = 0;
            this.Title.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Comment
            // 
            this.Comment.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Comment.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.flowLayoutPanel1.SetFlowBreak(this.Comment, true);
            this.Comment.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Comment.Location = new System.Drawing.Point(3, 86);
            this.Comment.Name = "Comment";
            this.Comment.ReadOnly = true;
            this.Comment.Size = new System.Drawing.Size(224, 171);
            this.Comment.TabIndex = 3;
            this.Comment.Tag = "Comment";
            this.Comment.Text = "No comment";
            // 
            // Calendar
            // 
            this.Calendar.BackColor = System.Drawing.SystemColors.HotTrack;
            this.Calendar.CalendarDimensions = new System.Drawing.Size(1, 2);
            this.Calendar.FirstDayOfWeek = System.Windows.Forms.Day.Sunday;
            this.Calendar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Calendar.ForeColor = System.Drawing.SystemColors.ControlLight;
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
            this.TimeTab.BackColor = System.Drawing.Color.Black;
            this.TimeTab.Controls.Add(this.LatestEvent);
            this.TimeTab.Controls.Add(this.ViewEvent);
            this.TimeTab.Controls.Add(this.Date);
            this.TimeTab.Controls.Add(this.Time);
            this.TimeTab.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TimeTab.Location = new System.Drawing.Point(4, 22);
            this.TimeTab.Name = "TimeTab";
            this.TimeTab.Padding = new System.Windows.Forms.Padding(3);
            this.TimeTab.Size = new System.Drawing.Size(628, 323);
            this.TimeTab.TabIndex = 0;
            this.TimeTab.Text = "Welcome";
            // 
            // LatestEvent
            // 
            this.LatestEvent.BackColor = System.Drawing.Color.Transparent;
            this.LatestEvent.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.LatestEvent.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LatestEvent.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.LatestEvent.Location = new System.Drawing.Point(6, 172);
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
            this.Date.ForeColor = System.Drawing.SystemColors.HotTrack;
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
            this.Time.ForeColor = System.Drawing.SystemColors.HotTrack;
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
            this.TimeAndCalendarTabular.Size = new System.Drawing.Size(636, 349);
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
            // Main
            // 
            this.AccessibleDescription = "The main window";
            this.AccessibleName = "Main";
            this.AccessibleRole = System.Windows.Forms.AccessibleRole.Window;
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Inherit;
            this.AutoSize = true;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.BackgroundImage = global::TimeAndSched.Properties.Resources.icon_widgets_48;
            this.ClientSize = new System.Drawing.Size(655, 366);
            this.Controls.Add(this.TimeAndCalendarTabular);
            this.Cursor = System.Windows.Forms.Cursors.Default;
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "Main";
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
    }
}

