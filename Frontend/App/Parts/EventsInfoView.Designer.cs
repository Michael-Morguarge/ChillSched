namespace Frontend.App.Parts
{
    partial class EventsInfoView
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.YourEvents = new System.Windows.Forms.GroupBox();
            this.TodaysEventsListBox = new System.Windows.Forms.ListBox();
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.EventStartDateLB = new System.Windows.Forms.Label();
            this.EventStartTimeLB = new System.Windows.Forms.Label();
            this.EventEndDateLB = new System.Windows.Forms.Label();
            this.EventEndTimeLB = new System.Windows.Forms.Label();
            this.EventTitleLB = new System.Windows.Forms.Label();
            this.EventCommentTB = new System.Windows.Forms.RichTextBox();
            this.flowLayoutPanel2 = new System.Windows.Forms.FlowLayoutPanel();
            this.EventStatusLB = new System.Windows.Forms.Label();
            this.CompletedDateLB = new System.Windows.Forms.Label();
            this.EventCreateDateLB = new System.Windows.Forms.Label();
            this.CRUDButtonPanel = new System.Windows.Forms.FlowLayoutPanel();
            this.AddEvent = new System.Windows.Forms.Button();
            this.EditEvent = new System.Windows.Forms.Button();
            this.RemoveButton = new System.Windows.Forms.Button();
            this.splitter1 = new System.Windows.Forms.Splitter();
            this.ToggleEventStatus = new System.Windows.Forms.Button();
            this.EventsToolTip = new System.Windows.Forms.ToolTip(this.components);
            this.YourEvents.SuspendLayout();
            this.flowLayoutPanel1.SuspendLayout();
            this.flowLayoutPanel2.SuspendLayout();
            this.CRUDButtonPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // YourEvents
            // 
            this.YourEvents.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.YourEvents.Controls.Add(this.TodaysEventsListBox);
            this.YourEvents.Controls.Add(this.flowLayoutPanel1);
            this.YourEvents.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.YourEvents.ForeColor = System.Drawing.SystemColors.ControlText;
            this.YourEvents.Location = new System.Drawing.Point(5, 5);
            this.YourEvents.Name = "YourEvents";
            this.YourEvents.Size = new System.Drawing.Size(804, 325);
            this.YourEvents.TabIndex = 1;
            this.YourEvents.TabStop = false;
            this.YourEvents.Text = "Text Goes Here";
            // 
            // TodaysEventsListBox
            // 
            this.TodaysEventsListBox.Cursor = System.Windows.Forms.Cursors.Hand;
            this.TodaysEventsListBox.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.TodaysEventsListBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TodaysEventsListBox.FormattingEnabled = true;
            this.TodaysEventsListBox.ItemHeight = 16;
            this.TodaysEventsListBox.Items.AddRange(new object[] {
            "Test"});
            this.TodaysEventsListBox.Location = new System.Drawing.Point(7, 26);
            this.TodaysEventsListBox.Name = "TodaysEventsListBox";
            this.TodaysEventsListBox.Size = new System.Drawing.Size(257, 292);
            this.TodaysEventsListBox.TabIndex = 1;
            this.TodaysEventsListBox.DrawItem += new System.Windows.Forms.DrawItemEventHandler(this.TodaysEventsListBox_DrawItem);
            this.TodaysEventsListBox.SelectedIndexChanged += new System.EventHandler(this.TodaysEvents_SelectedIndexChanged);
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.Controls.Add(this.EventStartDateLB);
            this.flowLayoutPanel1.Controls.Add(this.EventStartTimeLB);
            this.flowLayoutPanel1.Controls.Add(this.EventEndDateLB);
            this.flowLayoutPanel1.Controls.Add(this.EventEndTimeLB);
            this.flowLayoutPanel1.Controls.Add(this.EventTitleLB);
            this.flowLayoutPanel1.Controls.Add(this.EventCommentTB);
            this.flowLayoutPanel1.Controls.Add(this.flowLayoutPanel2);
            this.flowLayoutPanel1.Location = new System.Drawing.Point(273, 13);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(527, 305);
            this.flowLayoutPanel1.TabIndex = 1;
            // 
            // EventStartDateLB
            // 
            this.EventStartDateLB.Cursor = System.Windows.Forms.Cursors.Default;
            this.EventStartDateLB.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.EventStartDateLB.Location = new System.Drawing.Point(3, 0);
            this.EventStartDateLB.Name = "EventStartDateLB";
            this.EventStartDateLB.Padding = new System.Windows.Forms.Padding(0, 5, 0, 5);
            this.EventStartDateLB.Size = new System.Drawing.Size(257, 28);
            this.EventStartDateLB.TabIndex = 0;
            this.EventStartDateLB.Text = "-";
            this.EventStartDateLB.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.EventsToolTip.SetToolTip(this.EventStartDateLB, "Event Start Date");
            // 
            // EventStartTimeLB
            // 
            this.EventStartTimeLB.Cursor = System.Windows.Forms.Cursors.Default;
            this.EventStartTimeLB.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.EventStartTimeLB.Location = new System.Drawing.Point(266, 0);
            this.EventStartTimeLB.Name = "EventStartTimeLB";
            this.EventStartTimeLB.Padding = new System.Windows.Forms.Padding(0, 5, 0, 5);
            this.EventStartTimeLB.Size = new System.Drawing.Size(257, 28);
            this.EventStartTimeLB.TabIndex = 0;
            this.EventStartTimeLB.Text = "-";
            this.EventStartTimeLB.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.EventsToolTip.SetToolTip(this.EventStartTimeLB, "Event Start Time");
            // 
            // EventEndDateLB
            // 
            this.EventEndDateLB.Cursor = System.Windows.Forms.Cursors.Default;
            this.EventEndDateLB.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.EventEndDateLB.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.EventEndDateLB.Location = new System.Drawing.Point(3, 28);
            this.EventEndDateLB.Name = "EventEndDateLB";
            this.EventEndDateLB.Padding = new System.Windows.Forms.Padding(0, 5, 0, 5);
            this.EventEndDateLB.Size = new System.Drawing.Size(257, 28);
            this.EventEndDateLB.TabIndex = 0;
            this.EventEndDateLB.Text = "-";
            this.EventEndDateLB.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.EventsToolTip.SetToolTip(this.EventEndDateLB, "Event End Date");
            // 
            // EventEndTimeLB
            // 
            this.EventEndTimeLB.Cursor = System.Windows.Forms.Cursors.Default;
            this.EventEndTimeLB.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.EventEndTimeLB.ForeColor = System.Drawing.SystemColors.GrayText;
            this.EventEndTimeLB.Location = new System.Drawing.Point(266, 28);
            this.EventEndTimeLB.Name = "EventEndTimeLB";
            this.EventEndTimeLB.Padding = new System.Windows.Forms.Padding(0, 5, 0, 5);
            this.EventEndTimeLB.Size = new System.Drawing.Size(257, 28);
            this.EventEndTimeLB.TabIndex = 0;
            this.EventEndTimeLB.Text = "-";
            this.EventEndTimeLB.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.EventsToolTip.SetToolTip(this.EventEndTimeLB, "Event End Time");
            // 
            // EventTitleLB
            // 
            this.EventTitleLB.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.EventTitleLB.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.EventTitleLB.Cursor = System.Windows.Forms.Cursors.Default;
            this.EventTitleLB.Dock = System.Windows.Forms.DockStyle.Top;
            this.flowLayoutPanel1.SetFlowBreak(this.EventTitleLB, true);
            this.EventTitleLB.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.EventTitleLB.Location = new System.Drawing.Point(3, 56);
            this.EventTitleLB.Name = "EventTitleLB";
            this.EventTitleLB.Size = new System.Drawing.Size(521, 32);
            this.EventTitleLB.TabIndex = 0;
            this.EventTitleLB.Text = "-";
            this.EventTitleLB.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.EventsToolTip.SetToolTip(this.EventTitleLB, "Event Title");
            // 
            // EventCommentTB
            // 
            this.EventCommentTB.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.EventCommentTB.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.flowLayoutPanel1.SetFlowBreak(this.EventCommentTB, true);
            this.EventCommentTB.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.EventCommentTB.Location = new System.Drawing.Point(3, 91);
            this.EventCommentTB.Name = "EventCommentTB";
            this.EventCommentTB.ReadOnly = true;
            this.EventCommentTB.Size = new System.Drawing.Size(520, 148);
            this.EventCommentTB.TabIndex = 3;
            this.EventCommentTB.Tag = "Comment";
            this.EventCommentTB.Text = "No comment";
            this.EventsToolTip.SetToolTip(this.EventCommentTB, "Event Comment");
            // 
            // flowLayoutPanel2
            // 
            this.flowLayoutPanel2.Controls.Add(this.EventStatusLB);
            this.flowLayoutPanel2.Controls.Add(this.CompletedDateLB);
            this.flowLayoutPanel2.Controls.Add(this.EventCreateDateLB);
            this.flowLayoutPanel2.Location = new System.Drawing.Point(3, 245);
            this.flowLayoutPanel2.Name = "flowLayoutPanel2";
            this.flowLayoutPanel2.Size = new System.Drawing.Size(521, 55);
            this.flowLayoutPanel2.TabIndex = 4;
            // 
            // EventStatusLB
            // 
            this.EventStatusLB.BackColor = System.Drawing.SystemColors.ControlDark;
            this.EventStatusLB.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.EventStatusLB.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.EventStatusLB.Location = new System.Drawing.Point(3, 0);
            this.EventStatusLB.Name = "EventStatusLB";
            this.EventStatusLB.Size = new System.Drawing.Size(514, 26);
            this.EventStatusLB.TabIndex = 0;
            this.EventStatusLB.Text = "-";
            this.EventStatusLB.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.EventsToolTip.SetToolTip(this.EventStatusLB, "Event Status");
            // 
            // CompletedDateLB
            // 
            this.CompletedDateLB.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CompletedDateLB.Location = new System.Drawing.Point(3, 26);
            this.CompletedDateLB.Name = "CompletedDateLB";
            this.CompletedDateLB.Size = new System.Drawing.Size(254, 26);
            this.CompletedDateLB.TabIndex = 2;
            this.CompletedDateLB.Text = "-";
            this.CompletedDateLB.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.EventsToolTip.SetToolTip(this.CompletedDateLB, "Date Completed");
            // 
            // EventCreateDateLB
            // 
            this.EventCreateDateLB.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.EventCreateDateLB.Location = new System.Drawing.Point(263, 26);
            this.EventCreateDateLB.Name = "EventCreateDateLB";
            this.EventCreateDateLB.Size = new System.Drawing.Size(254, 26);
            this.EventCreateDateLB.TabIndex = 3;
            this.EventCreateDateLB.Text = "-";
            this.EventCreateDateLB.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.EventsToolTip.SetToolTip(this.EventCreateDateLB, "Date Created");
            // 
            // CRUDButtonPanel
            // 
            this.CRUDButtonPanel.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.CRUDButtonPanel.Controls.Add(this.AddEvent);
            this.CRUDButtonPanel.Controls.Add(this.EditEvent);
            this.CRUDButtonPanel.Controls.Add(this.RemoveButton);
            this.CRUDButtonPanel.Controls.Add(this.splitter1);
            this.CRUDButtonPanel.Controls.Add(this.ToggleEventStatus);
            this.CRUDButtonPanel.Enabled = false;
            this.CRUDButtonPanel.Location = new System.Drawing.Point(5, 339);
            this.CRUDButtonPanel.Name = "CRUDButtonPanel";
            this.CRUDButtonPanel.Size = new System.Drawing.Size(804, 45);
            this.CRUDButtonPanel.TabIndex = 2;
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
            this.EventsToolTip.SetToolTip(this.AddEvent, "Cretes an event.");
            this.AddEvent.UseVisualStyleBackColor = true;
            this.AddEvent.Click += new System.EventHandler(this.AddEvent_Click);
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
            this.EventsToolTip.SetToolTip(this.EditEvent, "Edit the selected event.");
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
            this.EventsToolTip.SetToolTip(this.RemoveButton, "Remove the selected event.");
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
            // ToggleEventStatus
            // 
            this.ToggleEventStatus.BackColor = System.Drawing.Color.Transparent;
            this.ToggleEventStatus.Cursor = System.Windows.Forms.Cursors.Hand;
            this.ToggleEventStatus.Enabled = false;
            this.ToggleEventStatus.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ToggleEventStatus.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ToggleEventStatus.Location = new System.Drawing.Point(287, 3);
            this.ToggleEventStatus.Name = "ToggleEventStatus";
            this.ToggleEventStatus.Size = new System.Drawing.Size(159, 31);
            this.ToggleEventStatus.TabIndex = 1;
            this.ToggleEventStatus.Text = "Toggle Status";
            this.EventsToolTip.SetToolTip(this.ToggleEventStatus, "Toggles the event\'s status.");
            this.ToggleEventStatus.UseVisualStyleBackColor = false;
            this.ToggleEventStatus.Click += new System.EventHandler(this.ToggleStatus_Click);
            // 
            // EventsToolTip
            // 
            this.EventsToolTip.IsBalloon = true;
            this.EventsToolTip.Tag = "";
            // 
            // EventsInfoView
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.Controls.Add(this.CRUDButtonPanel);
            this.Controls.Add(this.YourEvents);
            this.Name = "EventsInfoView";
            this.Size = new System.Drawing.Size(814, 387);
            this.YourEvents.ResumeLayout(false);
            this.flowLayoutPanel1.ResumeLayout(false);
            this.flowLayoutPanel2.ResumeLayout(false);
            this.CRUDButtonPanel.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox YourEvents;
        private System.Windows.Forms.ListBox TodaysEventsListBox;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private System.Windows.Forms.Label EventStartDateLB;
        private System.Windows.Forms.Label EventStartTimeLB;
        private System.Windows.Forms.Label EventEndDateLB;
        private System.Windows.Forms.Label EventEndTimeLB;
        private System.Windows.Forms.Label EventTitleLB;
        private System.Windows.Forms.RichTextBox EventCommentTB;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel2;
        private System.Windows.Forms.Label EventStatusLB;
        private System.Windows.Forms.Label CompletedDateLB;
        private System.Windows.Forms.Label EventCreateDateLB;
        private System.Windows.Forms.FlowLayoutPanel CRUDButtonPanel;
        private System.Windows.Forms.Button AddEvent;
        private System.Windows.Forms.Button EditEvent;
        private System.Windows.Forms.Button RemoveButton;
        private System.Windows.Forms.Splitter splitter1;
        private System.Windows.Forms.Button ToggleEventStatus;
        private System.Windows.Forms.ToolTip EventsToolTip;
    }
}
