namespace Frontend.App.Parts
{
    partial class EventInfoView
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
            this.EventModal = new System.Windows.Forms.GroupBox();
            this.Confirm = new System.Windows.Forms.Button();
            this.Cancel = new System.Windows.Forms.Button();
            this.EndPickerDP = new System.Windows.Forms.DateTimePicker();
            this.EventCommentTB = new System.Windows.Forms.RichTextBox();
            this.EventTitleTB = new System.Windows.Forms.TextBox();
            this.EndLB = new System.Windows.Forms.Label();
            this.CommentLB = new System.Windows.Forms.Label();
            this.StartLB = new System.Windows.Forms.Label();
            this.StartPickerDP = new System.Windows.Forms.DateTimePicker();
            this.TitleLB = new System.Windows.Forms.Label();
            this.EventModal.SuspendLayout();
            this.SuspendLayout();
            // 
            // EventModal
            // 
            this.EventModal.BackColor = System.Drawing.SystemColors.ControlLight;
            this.EventModal.Controls.Add(this.Confirm);
            this.EventModal.Controls.Add(this.Cancel);
            this.EventModal.Controls.Add(this.EndPickerDP);
            this.EventModal.Controls.Add(this.EventCommentTB);
            this.EventModal.Controls.Add(this.EventTitleTB);
            this.EventModal.Controls.Add(this.EndLB);
            this.EventModal.Controls.Add(this.CommentLB);
            this.EventModal.Controls.Add(this.StartLB);
            this.EventModal.Controls.Add(this.StartPickerDP);
            this.EventModal.Controls.Add(this.TitleLB);
            this.EventModal.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.EventModal.Font = new System.Drawing.Font("Calibri", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.EventModal.ForeColor = System.Drawing.SystemColors.ControlText;
            this.EventModal.Location = new System.Drawing.Point(2, 2);
            this.EventModal.Margin = new System.Windows.Forms.Padding(2);
            this.EventModal.Name = "EventModal";
            this.EventModal.Padding = new System.Windows.Forms.Padding(2);
            this.EventModal.Size = new System.Drawing.Size(327, 315);
            this.EventModal.TabIndex = 0;
            this.EventModal.TabStop = false;
            this.EventModal.Text = "{0} Bookmark";
            // 
            // Confirm
            // 
            this.Confirm.BackColor = System.Drawing.SystemColors.ControlLight;
            this.Confirm.Font = new System.Drawing.Font("Calibri", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Confirm.ForeColor = System.Drawing.SystemColors.ControlText;
            this.Confirm.Location = new System.Drawing.Point(55, 283);
            this.Confirm.Margin = new System.Windows.Forms.Padding(2);
            this.Confirm.Name = "Confirm";
            this.Confirm.Size = new System.Drawing.Size(100, 23);
            this.Confirm.TabIndex = 5;
            this.Confirm.Text = "...";
            this.Confirm.UseVisualStyleBackColor = false;
            this.Confirm.Click += new System.EventHandler(this.Confirm_Click);
            // 
            // Cancel
            // 
            this.Cancel.CausesValidation = false;
            this.Cancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.Cancel.Font = new System.Drawing.Font("Calibri", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Cancel.ForeColor = System.Drawing.SystemColors.ControlText;
            this.Cancel.Location = new System.Drawing.Point(172, 283);
            this.Cancel.Margin = new System.Windows.Forms.Padding(2);
            this.Cancel.Name = "Cancel";
            this.Cancel.Size = new System.Drawing.Size(100, 23);
            this.Cancel.TabIndex = 6;
            this.Cancel.Text = "Cancel";
            this.Cancel.UseVisualStyleBackColor = true;
            this.Cancel.Click += new System.EventHandler(this.Cancel_Click);
            // 
            // EndPickerDP
            // 
            this.EndPickerDP.CalendarMonthBackground = System.Drawing.SystemColors.InfoText;
            this.EndPickerDP.Cursor = System.Windows.Forms.Cursors.Hand;
            this.EndPickerDP.CustomFormat = "";
            this.EndPickerDP.Font = new System.Drawing.Font("Calibri", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.EndPickerDP.Format = System.Windows.Forms.DateTimePickerFormat.Time;
            this.EndPickerDP.Location = new System.Drawing.Point(14, 246);
            this.EndPickerDP.Margin = new System.Windows.Forms.Padding(2);
            this.EndPickerDP.MinDate = new System.DateTime(2019, 3, 12, 13, 11, 26, 48);
            this.EndPickerDP.Name = "EndPickerDP";
            this.EndPickerDP.Size = new System.Drawing.Size(301, 24);
            this.EndPickerDP.TabIndex = 4;
            this.EndPickerDP.Value = new System.DateTime(2019, 3, 12, 13, 11, 26, 48);
            // 
            // EventCommentTB
            // 
            this.EventCommentTB.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.EventCommentTB.Font = new System.Drawing.Font("Calibri", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.EventCommentTB.Location = new System.Drawing.Point(14, 88);
            this.EventCommentTB.Margin = new System.Windows.Forms.Padding(2);
            this.EventCommentTB.Name = "EventCommentTB";
            this.EventCommentTB.Size = new System.Drawing.Size(300, 85);
            this.EventCommentTB.TabIndex = 2;
            this.EventCommentTB.Text = "";
            // 
            // EventTitleTB
            // 
            this.EventTitleTB.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.EventTitleTB.Font = new System.Drawing.Font("Calibri", 10F);
            this.EventTitleTB.Location = new System.Drawing.Point(14, 49);
            this.EventTitleTB.Margin = new System.Windows.Forms.Padding(2);
            this.EventTitleTB.MaxLength = 100;
            this.EventTitleTB.Name = "EventTitleTB";
            this.EventTitleTB.Size = new System.Drawing.Size(300, 17);
            this.EventTitleTB.TabIndex = 1;
            // 
            // EndLB
            // 
            this.EndLB.AutoSize = true;
            this.EndLB.BackColor = System.Drawing.Color.Transparent;
            this.EndLB.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.EndLB.ForeColor = System.Drawing.SystemColors.ControlText;
            this.EndLB.Location = new System.Drawing.Point(7, 225);
            this.EndLB.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.EndLB.Name = "EndLB";
            this.EndLB.Size = new System.Drawing.Size(142, 19);
            this.EndLB.TabIndex = 0;
            this.EndLB.Text = "End Date and Time:";
            // 
            // CommentLB
            // 
            this.CommentLB.AutoSize = true;
            this.CommentLB.BackColor = System.Drawing.Color.Transparent;
            this.CommentLB.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CommentLB.ForeColor = System.Drawing.SystemColors.ControlText;
            this.CommentLB.Location = new System.Drawing.Point(7, 67);
            this.CommentLB.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.CommentLB.Name = "CommentLB";
            this.CommentLB.Size = new System.Drawing.Size(79, 19);
            this.CommentLB.TabIndex = 0;
            this.CommentLB.Text = "Comment:";
            // 
            // StartLB
            // 
            this.StartLB.AutoSize = true;
            this.StartLB.BackColor = System.Drawing.Color.Transparent;
            this.StartLB.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.StartLB.ForeColor = System.Drawing.SystemColors.ControlText;
            this.StartLB.Location = new System.Drawing.Point(7, 177);
            this.StartLB.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.StartLB.Name = "StartLB";
            this.StartLB.Size = new System.Drawing.Size(150, 19);
            this.StartLB.TabIndex = 0;
            this.StartLB.Text = "Start Date and Time:";
            // 
            // StartPickerDP
            // 
            this.StartPickerDP.CalendarMonthBackground = System.Drawing.SystemColors.InfoText;
            this.StartPickerDP.Cursor = System.Windows.Forms.Cursors.Hand;
            this.StartPickerDP.CustomFormat = "";
            this.StartPickerDP.Font = new System.Drawing.Font("Calibri", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.StartPickerDP.Format = System.Windows.Forms.DateTimePickerFormat.Time;
            this.StartPickerDP.Location = new System.Drawing.Point(14, 198);
            this.StartPickerDP.Margin = new System.Windows.Forms.Padding(2);
            this.StartPickerDP.MinDate = new System.DateTime(2019, 3, 12, 13, 11, 26, 34);
            this.StartPickerDP.Name = "StartPickerDP";
            this.StartPickerDP.Size = new System.Drawing.Size(301, 24);
            this.StartPickerDP.TabIndex = 3;
            this.StartPickerDP.Value = new System.DateTime(2019, 3, 12, 13, 11, 26, 34);
            // 
            // TitleLB
            // 
            this.TitleLB.AutoSize = true;
            this.TitleLB.BackColor = System.Drawing.Color.Transparent;
            this.TitleLB.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TitleLB.ForeColor = System.Drawing.SystemColors.ControlText;
            this.TitleLB.Location = new System.Drawing.Point(7, 28);
            this.TitleLB.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.TitleLB.Name = "TitleLB";
            this.TitleLB.Size = new System.Drawing.Size(43, 19);
            this.TitleLB.TabIndex = 0;
            this.TitleLB.Text = "Title:";
            // 
            // EventInfoView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.EventModal);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "EventInfoView";
            this.Size = new System.Drawing.Size(331, 320);
            this.EventModal.ResumeLayout(false);
            this.EventModal.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox EventModal;
        private System.Windows.Forms.Button Confirm;
        private System.Windows.Forms.Button Cancel;
        private System.Windows.Forms.DateTimePicker EndPickerDP;
        private System.Windows.Forms.RichTextBox EventCommentTB;
        private System.Windows.Forms.TextBox EventTitleTB;
        private System.Windows.Forms.Label EndLB;
        private System.Windows.Forms.Label CommentLB;
        private System.Windows.Forms.Label StartLB;
        private System.Windows.Forms.DateTimePicker StartPickerDP;
        private System.Windows.Forms.Label TitleLB;
    }
}
