namespace FrontEnd.App.Parts
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
            this.BookmarkMaker = new System.Windows.Forms.GroupBox();
            this.Confirm = new System.Windows.Forms.Button();
            this.Cancel = new System.Windows.Forms.Button();
            this.BMEndPicker = new System.Windows.Forms.DateTimePicker();
            this.BMCommentTB = new System.Windows.Forms.RichTextBox();
            this.BMTitleTB = new System.Windows.Forms.TextBox();
            this.BMEnd = new System.Windows.Forms.Label();
            this.BMComment = new System.Windows.Forms.Label();
            this.BMStart = new System.Windows.Forms.Label();
            this.BMStartPicker = new System.Windows.Forms.DateTimePicker();
            this.BMTitle = new System.Windows.Forms.Label();
            this.BookmarkMaker.SuspendLayout();
            this.SuspendLayout();
            // 
            // BookmarkMaker
            // 
            this.BookmarkMaker.BackColor = System.Drawing.SystemColors.ControlLight;
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
            this.BookmarkMaker.ForeColor = System.Drawing.SystemColors.ControlText;
            this.BookmarkMaker.Location = new System.Drawing.Point(2, 2);
            this.BookmarkMaker.Margin = new System.Windows.Forms.Padding(2);
            this.BookmarkMaker.Name = "BookmarkMaker";
            this.BookmarkMaker.Padding = new System.Windows.Forms.Padding(2);
            this.BookmarkMaker.Size = new System.Drawing.Size(327, 315);
            this.BookmarkMaker.TabIndex = 1;
            this.BookmarkMaker.TabStop = false;
            this.BookmarkMaker.Text = "{0} Bookmark";
            // 
            // Confirm
            // 
            this.Confirm.BackColor = System.Drawing.SystemColors.ControlLight;
            this.Confirm.Font = new System.Drawing.Font("Calibri", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Confirm.ForeColor = System.Drawing.SystemColors.Desktop;
            this.Confirm.Location = new System.Drawing.Point(52, 283);
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
            this.Cancel.ForeColor = System.Drawing.SystemColors.Desktop;
            this.Cancel.Location = new System.Drawing.Point(169, 283);
            this.Cancel.Margin = new System.Windows.Forms.Padding(2);
            this.Cancel.Name = "Cancel";
            this.Cancel.Size = new System.Drawing.Size(100, 23);
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
            this.BMEndPicker.Location = new System.Drawing.Point(14, 246);
            this.BMEndPicker.Margin = new System.Windows.Forms.Padding(2);
            this.BMEndPicker.MinDate = new System.DateTime(2019, 3, 12, 13, 11, 26, 48);
            this.BMEndPicker.Name = "BMEndPicker";
            this.BMEndPicker.Size = new System.Drawing.Size(301, 24);
            this.BMEndPicker.TabIndex = 4;
            this.BMEndPicker.Value = new System.DateTime(2019, 3, 12, 13, 11, 26, 48);
            // 
            // BMCommentTB
            // 
            this.BMCommentTB.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.BMCommentTB.Font = new System.Drawing.Font("Calibri", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BMCommentTB.Location = new System.Drawing.Point(14, 88);
            this.BMCommentTB.Margin = new System.Windows.Forms.Padding(2);
            this.BMCommentTB.Name = "BMCommentTB";
            this.BMCommentTB.Size = new System.Drawing.Size(300, 85);
            this.BMCommentTB.TabIndex = 2;
            this.BMCommentTB.Text = "";
            // 
            // BMTitleTB
            // 
            this.BMTitleTB.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.BMTitleTB.Font = new System.Drawing.Font("Calibri", 10F);
            this.BMTitleTB.Location = new System.Drawing.Point(14, 49);
            this.BMTitleTB.Margin = new System.Windows.Forms.Padding(2);
            this.BMTitleTB.MaxLength = 100;
            this.BMTitleTB.Name = "BMTitleTB";
            this.BMTitleTB.Size = new System.Drawing.Size(300, 17);
            this.BMTitleTB.TabIndex = 1;
            // 
            // BMEnd
            // 
            this.BMEnd.AutoSize = true;
            this.BMEnd.BackColor = System.Drawing.Color.Transparent;
            this.BMEnd.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BMEnd.ForeColor = System.Drawing.SystemColors.ControlText;
            this.BMEnd.Location = new System.Drawing.Point(7, 225);
            this.BMEnd.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.BMEnd.Name = "BMEnd";
            this.BMEnd.Size = new System.Drawing.Size(142, 19);
            this.BMEnd.TabIndex = 0;
            this.BMEnd.Text = "End Date and Time:";
            // 
            // BMComment
            // 
            this.BMComment.AutoSize = true;
            this.BMComment.BackColor = System.Drawing.Color.Transparent;
            this.BMComment.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BMComment.ForeColor = System.Drawing.SystemColors.ControlText;
            this.BMComment.Location = new System.Drawing.Point(7, 67);
            this.BMComment.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.BMComment.Name = "BMComment";
            this.BMComment.Size = new System.Drawing.Size(79, 19);
            this.BMComment.TabIndex = 0;
            this.BMComment.Text = "Comment:";
            // 
            // BMStart
            // 
            this.BMStart.AutoSize = true;
            this.BMStart.BackColor = System.Drawing.Color.Transparent;
            this.BMStart.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BMStart.ForeColor = System.Drawing.SystemColors.ControlText;
            this.BMStart.Location = new System.Drawing.Point(7, 177);
            this.BMStart.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.BMStart.Name = "BMStart";
            this.BMStart.Size = new System.Drawing.Size(150, 19);
            this.BMStart.TabIndex = 0;
            this.BMStart.Text = "Start Date and Time:";
            // 
            // BMStartPicker
            // 
            this.BMStartPicker.CalendarMonthBackground = System.Drawing.SystemColors.InfoText;
            this.BMStartPicker.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BMStartPicker.CustomFormat = "";
            this.BMStartPicker.Font = new System.Drawing.Font("Calibri", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BMStartPicker.Format = System.Windows.Forms.DateTimePickerFormat.Time;
            this.BMStartPicker.Location = new System.Drawing.Point(14, 198);
            this.BMStartPicker.Margin = new System.Windows.Forms.Padding(2);
            this.BMStartPicker.MinDate = new System.DateTime(2019, 3, 12, 13, 11, 26, 34);
            this.BMStartPicker.Name = "BMStartPicker";
            this.BMStartPicker.Size = new System.Drawing.Size(301, 24);
            this.BMStartPicker.TabIndex = 3;
            this.BMStartPicker.Value = new System.DateTime(2019, 3, 12, 13, 11, 26, 34);
            // 
            // BMTitle
            // 
            this.BMTitle.AutoSize = true;
            this.BMTitle.BackColor = System.Drawing.Color.Transparent;
            this.BMTitle.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BMTitle.ForeColor = System.Drawing.SystemColors.ControlText;
            this.BMTitle.Location = new System.Drawing.Point(7, 28);
            this.BMTitle.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.BMTitle.Name = "BMTitle";
            this.BMTitle.Size = new System.Drawing.Size(43, 19);
            this.BMTitle.TabIndex = 0;
            this.BMTitle.Text = "Title:";
            // 
            // EventInfoView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.BookmarkMaker);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "EventInfoView";
            this.Size = new System.Drawing.Size(331, 320);
            this.BookmarkMaker.ResumeLayout(false);
            this.BookmarkMaker.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox BookmarkMaker;
        private System.Windows.Forms.Button Confirm;
        private System.Windows.Forms.Button Cancel;
        private System.Windows.Forms.DateTimePicker BMEndPicker;
        private System.Windows.Forms.RichTextBox BMCommentTB;
        private System.Windows.Forms.TextBox BMTitleTB;
        private System.Windows.Forms.Label BMEnd;
        private System.Windows.Forms.Label BMComment;
        private System.Windows.Forms.Label BMStart;
        private System.Windows.Forms.DateTimePicker BMStartPicker;
        private System.Windows.Forms.Label BMTitle;
    }
}
