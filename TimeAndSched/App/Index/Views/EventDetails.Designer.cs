using System;

namespace TimeAndSched.App.Index.Views
{
    partial class EventDetails
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
            this.BMStartPicker = new System.Windows.Forms.DateTimePicker();
            this.BookmarkMaker = new System.Windows.Forms.GroupBox();
            this.Confirm = new System.Windows.Forms.Button();
            this.Cancel = new System.Windows.Forms.Button();
            this.BMEndPicker = new System.Windows.Forms.DateTimePicker();
            this.BMCommentTB = new System.Windows.Forms.RichTextBox();
            this.BMTitleTB = new System.Windows.Forms.TextBox();
            this.BMEnd = new System.Windows.Forms.Label();
            this.BMComment = new System.Windows.Forms.Label();
            this.BMStart = new System.Windows.Forms.Label();
            this.BMTitle = new System.Windows.Forms.Label();
            this.Error = new System.Windows.Forms.Label();
            this.BookmarkMaker.SuspendLayout();
            this.SuspendLayout();
            // 
            // BMStartPicker
            // 
            this.BMStartPicker.CalendarMonthBackground = System.Drawing.SystemColors.InfoText;
            this.BMStartPicker.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BMStartPicker.CustomFormat = "";
            this.BMStartPicker.Font = new System.Drawing.Font("Calibri", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BMStartPicker.Format = System.Windows.Forms.DateTimePickerFormat.Time;
            this.BMStartPicker.Location = new System.Drawing.Point(29, 240);
            this.BMStartPicker.MinDate = new System.DateTime(2018, 12, 10, 0, 0, 0, 0);
            this.BMStartPicker.Name = "BMStartPicker";
            this.BMStartPicker.Size = new System.Drawing.Size(274, 24);
            this.BMStartPicker.TabIndex = 3;
            this.BMStartPicker.MinDate = DateTime.Now;
            // 
            // BookmarkMaker
            // 
            this.BookmarkMaker.Controls.Add(this.Confirm);
            this.BookmarkMaker.Controls.Add(this.Cancel);
            this.BookmarkMaker.Controls.Add(this.BMEndPicker);
            this.BookmarkMaker.Controls.Add(this.BMCommentTB);
            this.BookmarkMaker.Controls.Add(this.BMTitleTB);
            this.BookmarkMaker.Controls.Add(this.BMEnd);
            this.BookmarkMaker.Controls.Add(this.BMComment);
            this.BookmarkMaker.Controls.Add(this.BMStart);
            this.BookmarkMaker.Controls.Add(this.BMStartPicker);
            this.BookmarkMaker.Controls.Add(this.BMTitle);
            this.BookmarkMaker.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BookmarkMaker.Font = new System.Drawing.Font("Calibri", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BookmarkMaker.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.BookmarkMaker.Location = new System.Drawing.Point(13, 13);
            this.BookmarkMaker.Name = "BookmarkMaker";
            this.BookmarkMaker.Size = new System.Drawing.Size(320, 382);
            this.BookmarkMaker.TabIndex = 0;
            this.BookmarkMaker.TabStop = false;
            this.BookmarkMaker.Text = "{0} Bookmark";
            // 
            // Confirm
            // 
            this.Confirm.Font = new System.Drawing.Font("Calibri", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Confirm.Location = new System.Drawing.Point(149, 342);
            this.Confirm.Name = "Confirm";
            this.Confirm.Size = new System.Drawing.Size(75, 24);
            this.Confirm.TabIndex = 5;
            this.Confirm.Text = "...";
            this.Confirm.UseVisualStyleBackColor = true;
            this.Confirm.Click += new System.EventHandler(this.Confirm_Click);
            // 
            // Cancel
            // 
            this.Cancel.CausesValidation = false;
            this.Cancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.Cancel.Font = new System.Drawing.Font("Calibri", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Cancel.Location = new System.Drawing.Point(238, 342);
            this.Cancel.Name = "Cancel";
            this.Cancel.Size = new System.Drawing.Size(75, 24);
            this.Cancel.TabIndex = 6;
            this.Cancel.Text = "Cancel";
            this.Cancel.UseVisualStyleBackColor = true;
            this.Cancel.Click += new System.EventHandler(this.Cancel_Click);
            // 
            // BMEndPicker
            // 
            this.BMEndPicker.CalendarMonthBackground = System.Drawing.SystemColors.InfoText;
            this.BMEndPicker.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BMEndPicker.CustomFormat = "";
            this.BMEndPicker.Font = new System.Drawing.Font("Calibri", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BMEndPicker.Format = System.Windows.Forms.DateTimePickerFormat.Time;
            this.BMEndPicker.Location = new System.Drawing.Point(29, 301);
            this.BMEndPicker.MinDate = new System.DateTime(2018, 12, 10, 0, 0, 0, 0);
            this.BMEndPicker.Name = "BMEndPicker";
            this.BMEndPicker.Size = new System.Drawing.Size(274, 24);
            this.BMEndPicker.TabIndex = 4;
            this.BMEndPicker.MinDate = DateTime.Now;
            // 
            // BMCommentTB
            // 
            this.BMCommentTB.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.BMCommentTB.Font = new System.Drawing.Font("Calibri", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BMCommentTB.Location = new System.Drawing.Point(95, 70);
            this.BMCommentTB.Name = "BMCommentTB";
            this.BMCommentTB.Size = new System.Drawing.Size(208, 131);
            this.BMCommentTB.TabIndex = 2;
            this.BMCommentTB.Text = "";
            // 
            // BMTitleTB
            // 
            this.BMTitleTB.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.BMTitleTB.Font = new System.Drawing.Font("Calibri", 10F);
            this.BMTitleTB.Location = new System.Drawing.Point(95, 41);
            this.BMTitleTB.MaxLength = 100;
            this.BMTitleTB.Name = "BMTitleTB";
            this.BMTitleTB.Size = new System.Drawing.Size(208, 17);
            this.BMTitleTB.TabIndex = 1;
            // 
            // BMEnd
            // 
            this.BMEnd.AutoSize = true;
            this.BMEnd.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BMEnd.Location = new System.Drawing.Point(10, 272);
            this.BMEnd.Name = "BMEnd";
            this.BMEnd.Size = new System.Drawing.Size(142, 19);
            this.BMEnd.TabIndex = 0;
            this.BMEnd.Text = "End Date and Time:";
            // 
            // BMComment
            // 
            this.BMComment.AutoSize = true;
            this.BMComment.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BMComment.Location = new System.Drawing.Point(10, 72);
            this.BMComment.Name = "BMComment";
            this.BMComment.Size = new System.Drawing.Size(79, 19);
            this.BMComment.TabIndex = 0;
            this.BMComment.Text = "Comment:";
            // 
            // BMStart
            // 
            this.BMStart.AutoSize = true;
            this.BMStart.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BMStart.Location = new System.Drawing.Point(10, 211);
            this.BMStart.Name = "BMStart";
            this.BMStart.Size = new System.Drawing.Size(150, 19);
            this.BMStart.TabIndex = 0;
            this.BMStart.Text = "Start Date and Time:";
            // 
            // BMTitle
            // 
            this.BMTitle.AutoSize = true;
            this.BMTitle.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BMTitle.Location = new System.Drawing.Point(46, 41);
            this.BMTitle.Name = "BMTitle";
            this.BMTitle.Size = new System.Drawing.Size(43, 19);
            this.BMTitle.TabIndex = 0;
            this.BMTitle.Text = "Title:";
            // 
            // Error
            // 
            this.Error.AutoSize = true;
            this.Error.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.Error.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Error.Font = new System.Drawing.Font("Calibri", 25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Error.Location = new System.Drawing.Point(65, 171);
            this.Error.Name = "Error";
            this.Error.Size = new System.Drawing.Size(208, 41);
            this.Error.TabIndex = 0;
            this.Error.Text = "Invalid Access";
            this.Error.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.Error.Visible = false;
            // 
            // EventDetails
            // 
            this.AcceptButton = this.Confirm;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.CancelButton = this.Cancel;
            this.ClientSize = new System.Drawing.Size(345, 408);
            this.Controls.Add(this.BookmarkMaker);
            this.Controls.Add(this.Error);
            this.Font = new System.Drawing.Font("Calibri", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "EventDetails";
            this.Text = "Event Details";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.EventDetails_FormClosing);
            this.BookmarkMaker.ResumeLayout(false);
            this.BookmarkMaker.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DateTimePicker BMStartPicker;
        private System.Windows.Forms.GroupBox BookmarkMaker;
        private System.Windows.Forms.RichTextBox BMCommentTB;
        private System.Windows.Forms.TextBox BMTitleTB;
        private System.Windows.Forms.Label BMTitle;
        private System.Windows.Forms.Label BMComment;
        private System.Windows.Forms.Label BMStart;
        private System.Windows.Forms.DateTimePicker BMEndPicker;
        private System.Windows.Forms.Label BMEnd;
        private System.Windows.Forms.Button Confirm;
        private System.Windows.Forms.Button Cancel;
        private System.Windows.Forms.Label Error;
    }
}