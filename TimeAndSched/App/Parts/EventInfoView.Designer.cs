namespace FrontEnd.App.Index.Frameworks
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
            this.BookmarkMaker.BackColor = System.Drawing.Color.Black;
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
            this.BookmarkMaker.Location = new System.Drawing.Point(3, 3);
            this.BookmarkMaker.Name = "BookmarkMaker";
            this.BookmarkMaker.Size = new System.Drawing.Size(491, 484);
            this.BookmarkMaker.TabIndex = 1;
            this.BookmarkMaker.TabStop = false;
            this.BookmarkMaker.Text = "{0} Bookmark";
            // 
            // Confirm
            // 
            this.Confirm.Font = new System.Drawing.Font("Calibri", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Confirm.Location = new System.Drawing.Point(78, 436);
            this.Confirm.Name = "Confirm";
            this.Confirm.Size = new System.Drawing.Size(150, 35);
            this.Confirm.TabIndex = 5;
            this.Confirm.Text = "...";
            this.Confirm.UseVisualStyleBackColor = true;
            // 
            // Cancel
            // 
            this.Cancel.CausesValidation = false;
            this.Cancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.Cancel.Font = new System.Drawing.Font("Calibri", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Cancel.Location = new System.Drawing.Point(254, 436);
            this.Cancel.Name = "Cancel";
            this.Cancel.Size = new System.Drawing.Size(150, 35);
            this.Cancel.TabIndex = 6;
            this.Cancel.Text = "Cancel";
            this.Cancel.UseVisualStyleBackColor = true;
            // 
            // BMEndPicker
            // 
            this.BMEndPicker.CalendarMonthBackground = System.Drawing.SystemColors.InfoText;
            this.BMEndPicker.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BMEndPicker.CustomFormat = "";
            this.BMEndPicker.Font = new System.Drawing.Font("Calibri", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BMEndPicker.Format = System.Windows.Forms.DateTimePickerFormat.Time;
            this.BMEndPicker.Location = new System.Drawing.Point(21, 371);
            this.BMEndPicker.MinDate = new System.DateTime(2019, 3, 12, 13, 11, 26, 48);
            this.BMEndPicker.Name = "BMEndPicker";
            this.BMEndPicker.Size = new System.Drawing.Size(450, 32);
            this.BMEndPicker.TabIndex = 4;
            this.BMEndPicker.Value = new System.DateTime(2019, 3, 12, 13, 11, 26, 48);
            // 
            // BMCommentTB
            // 
            this.BMCommentTB.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.BMCommentTB.Font = new System.Drawing.Font("Calibri", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BMCommentTB.Location = new System.Drawing.Point(21, 135);
            this.BMCommentTB.Name = "BMCommentTB";
            this.BMCommentTB.Size = new System.Drawing.Size(450, 131);
            this.BMCommentTB.TabIndex = 2;
            this.BMCommentTB.Text = "";
            // 
            // BMTitleTB
            // 
            this.BMTitleTB.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.BMTitleTB.Font = new System.Drawing.Font("Calibri", 10F);
            this.BMTitleTB.Location = new System.Drawing.Point(21, 75);
            this.BMTitleTB.MaxLength = 100;
            this.BMTitleTB.Name = "BMTitleTB";
            this.BMTitleTB.Size = new System.Drawing.Size(450, 25);
            this.BMTitleTB.TabIndex = 1;
            // 
            // BMEnd
            // 
            this.BMEnd.AutoSize = true;
            this.BMEnd.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BMEnd.Location = new System.Drawing.Point(10, 339);
            this.BMEnd.Name = "BMEnd";
            this.BMEnd.Size = new System.Drawing.Size(208, 29);
            this.BMEnd.TabIndex = 0;
            this.BMEnd.Text = "End Date and Time:";
            // 
            // BMComment
            // 
            this.BMComment.AutoSize = true;
            this.BMComment.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BMComment.Location = new System.Drawing.Point(10, 103);
            this.BMComment.Name = "BMComment";
            this.BMComment.Size = new System.Drawing.Size(119, 29);
            this.BMComment.TabIndex = 0;
            this.BMComment.Text = "Comment:";
            // 
            // BMStart
            // 
            this.BMStart.AutoSize = true;
            this.BMStart.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BMStart.Location = new System.Drawing.Point(10, 272);
            this.BMStart.Name = "BMStart";
            this.BMStart.Size = new System.Drawing.Size(218, 29);
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
            this.BMStartPicker.Location = new System.Drawing.Point(21, 304);
            this.BMStartPicker.MinDate = new System.DateTime(2019, 3, 12, 13, 11, 26, 34);
            this.BMStartPicker.Name = "BMStartPicker";
            this.BMStartPicker.Size = new System.Drawing.Size(450, 32);
            this.BMStartPicker.TabIndex = 3;
            this.BMStartPicker.Value = new System.DateTime(2019, 3, 12, 13, 11, 26, 34);
            // 
            // BMTitle
            // 
            this.BMTitle.AutoSize = true;
            this.BMTitle.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BMTitle.Location = new System.Drawing.Point(10, 43);
            this.BMTitle.Name = "BMTitle";
            this.BMTitle.Size = new System.Drawing.Size(64, 29);
            this.BMTitle.TabIndex = 0;
            this.BMTitle.Text = "Title:";
            // 
            // EventInfoView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.BookmarkMaker);
            this.Name = "EventInfoView";
            this.Size = new System.Drawing.Size(497, 492);
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
