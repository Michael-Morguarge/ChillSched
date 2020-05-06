namespace FrontEnd.App.Parts
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
            this.YourEvents = new System.Windows.Forms.GroupBox();
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
            this.CRUDButtonPanel = new System.Windows.Forms.FlowLayoutPanel();
            this.AddEvent = new System.Windows.Forms.Button();
            this.EditEvent = new System.Windows.Forms.Button();
            this.RemoveButton = new System.Windows.Forms.Button();
            this.splitter1 = new System.Windows.Forms.Splitter();
            this.ToggleStatus = new System.Windows.Forms.Button();
            this.YourEvents.SuspendLayout();
            this.flowLayoutPanel1.SuspendLayout();
            this.flowLayoutPanel2.SuspendLayout();
            this.CRUDButtonPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // YourEvents
            // 
            this.YourEvents.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.YourEvents.Controls.Add(this.TodaysEvents);
            this.YourEvents.Controls.Add(this.flowLayoutPanel1);
            this.YourEvents.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.YourEvents.ForeColor = System.Drawing.SystemColors.ControlText;
            this.YourEvents.Location = new System.Drawing.Point(5, 5);
            this.YourEvents.Name = "YourEvents";
            this.YourEvents.Size = new System.Drawing.Size(804, 325);
            this.YourEvents.TabIndex = 1;
            this.YourEvents.TabStop = false;
            this.YourEvents.Text = "Events for day";
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
            // CRUDButtonPanel
            // 
            this.CRUDButtonPanel.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.CRUDButtonPanel.Controls.Add(this.AddEvent);
            this.CRUDButtonPanel.Controls.Add(this.EditEvent);
            this.CRUDButtonPanel.Controls.Add(this.RemoveButton);
            this.CRUDButtonPanel.Controls.Add(this.splitter1);
            this.CRUDButtonPanel.Controls.Add(this.ToggleStatus);
            this.CRUDButtonPanel.Location = new System.Drawing.Point(278, 336);
            this.CRUDButtonPanel.Name = "CRUDButtonPanel";
            this.CRUDButtonPanel.Size = new System.Drawing.Size(531, 45);
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
            this.AddEvent.UseVisualStyleBackColor = true;
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
            // 
            // EventsInfoView
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.Controls.Add(this.CRUDButtonPanel);
            this.Controls.Add(this.YourEvents);
            this.Name = "EventsInfoView";
            this.Size = new System.Drawing.Size(806, 387);
            this.YourEvents.ResumeLayout(false);
            this.flowLayoutPanel1.ResumeLayout(false);
            this.flowLayoutPanel2.ResumeLayout(false);
            this.CRUDButtonPanel.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox YourEvents;
        private System.Windows.Forms.ListBox TodaysEvents;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private System.Windows.Forms.Label ExpStartDate;
        private System.Windows.Forms.Label ExpStartTime;
        private System.Windows.Forms.Label ExpEndDate;
        private System.Windows.Forms.Label ExpEndTime;
        private System.Windows.Forms.Label Title;
        private System.Windows.Forms.RichTextBox Comment;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel2;
        private System.Windows.Forms.Label EventStatus;
        private System.Windows.Forms.Label CompletedDate;
        private System.Windows.Forms.Label CreateDate;
        private System.Windows.Forms.FlowLayoutPanel CRUDButtonPanel;
        private System.Windows.Forms.Button AddEvent;
        private System.Windows.Forms.Button EditEvent;
        private System.Windows.Forms.Button RemoveButton;
        private System.Windows.Forms.Splitter splitter1;
        private System.Windows.Forms.Button ToggleStatus;
    }
}
