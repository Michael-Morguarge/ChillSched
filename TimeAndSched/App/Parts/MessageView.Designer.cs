namespace FrontEnd.App.Parts
{
    partial class MessageView
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
            this.MessageModal = new System.Windows.Forms.GroupBox();
            this.Cancel = new System.Windows.Forms.Button();
            this.Confirm = new System.Windows.Forms.Button();
            this.MessageHideRB = new System.Windows.Forms.RadioButton();
            this.MessageShowRB = new System.Windows.Forms.RadioButton();
            this.ShowHideLB = new System.Windows.Forms.Label();
            this.MessageSourceTB = new System.Windows.Forms.TextBox();
            this.SourceLB = new System.Windows.Forms.Label();
            this.MessageAuthorTB = new System.Windows.Forms.TextBox();
            this.AuthorLB = new System.Windows.Forms.Label();
            this.MessageQuoteTB = new System.Windows.Forms.RichTextBox();
            this.QuoteLB = new System.Windows.Forms.Label();
            this.MessageTitleTB = new System.Windows.Forms.TextBox();
            this.TitleLB = new System.Windows.Forms.Label();
            this.MessageModal.SuspendLayout();
            this.SuspendLayout();
            // 
            // MessageModal
            // 
            this.MessageModal.Controls.Add(this.Cancel);
            this.MessageModal.Controls.Add(this.Confirm);
            this.MessageModal.Controls.Add(this.MessageHideRB);
            this.MessageModal.Controls.Add(this.MessageShowRB);
            this.MessageModal.Controls.Add(this.ShowHideLB);
            this.MessageModal.Controls.Add(this.MessageSourceTB);
            this.MessageModal.Controls.Add(this.SourceLB);
            this.MessageModal.Controls.Add(this.MessageAuthorTB);
            this.MessageModal.Controls.Add(this.AuthorLB);
            this.MessageModal.Controls.Add(this.MessageQuoteTB);
            this.MessageModal.Controls.Add(this.QuoteLB);
            this.MessageModal.Controls.Add(this.MessageTitleTB);
            this.MessageModal.Controls.Add(this.TitleLB);
            this.MessageModal.Font = new System.Drawing.Font("Calibri", 15F);
            this.MessageModal.Location = new System.Drawing.Point(0, 0);
            this.MessageModal.Margin = new System.Windows.Forms.Padding(4);
            this.MessageModal.Name = "MessageModal";
            this.MessageModal.Padding = new System.Windows.Forms.Padding(4);
            this.MessageModal.Size = new System.Drawing.Size(348, 400);
            this.MessageModal.TabIndex = 0;
            this.MessageModal.TabStop = false;
            this.MessageModal.Text = "{0} Message";
            // 
            // Cancel
            // 
            this.Cancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.Cancel.Font = new System.Drawing.Font("Calibri", 10F);
            this.Cancel.Location = new System.Drawing.Point(182, 358);
            this.Cancel.Name = "Cancel";
            this.Cancel.Size = new System.Drawing.Size(101, 23);
            this.Cancel.TabIndex = 8;
            this.Cancel.Text = "Cancel";
            this.Cancel.UseVisualStyleBackColor = true;
            this.Cancel.Click += new System.EventHandler(this.Cancel_Click);
            // 
            // Confirm
            // 
            this.Confirm.Font = new System.Drawing.Font("Calibri", 10F);
            this.Confirm.Location = new System.Drawing.Point(65, 358);
            this.Confirm.Name = "Confirm";
            this.Confirm.Size = new System.Drawing.Size(101, 23);
            this.Confirm.TabIndex = 7;
            this.Confirm.Text = "...";
            this.Confirm.UseVisualStyleBackColor = true;
            this.Confirm.Click += new System.EventHandler(this.Confirm_Click);
            // 
            // MessageHideRB
            // 
            this.MessageHideRB.Appearance = System.Windows.Forms.Appearance.Button;
            this.MessageHideRB.Font = new System.Drawing.Font("Calibri", 12F);
            this.MessageHideRB.Location = new System.Drawing.Point(173, 321);
            this.MessageHideRB.Name = "MessageHideRB";
            this.MessageHideRB.Size = new System.Drawing.Size(160, 25);
            this.MessageHideRB.TabIndex = 6;
            this.MessageHideRB.TabStop = true;
            this.MessageHideRB.Text = "No";
            this.MessageHideRB.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.MessageHideRB.UseVisualStyleBackColor = true;
            // 
            // MessageShowRB
            // 
            this.MessageShowRB.Appearance = System.Windows.Forms.Appearance.Button;
            this.MessageShowRB.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.MessageShowRB.Font = new System.Drawing.Font("Calibri", 12F);
            this.MessageShowRB.Location = new System.Drawing.Point(14, 321);
            this.MessageShowRB.Name = "MessageShowRB";
            this.MessageShowRB.Size = new System.Drawing.Size(160, 25);
            this.MessageShowRB.TabIndex = 5;
            this.MessageShowRB.Text = "Yes";
            this.MessageShowRB.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.MessageShowRB.UseVisualStyleBackColor = true;
            // 
            // ShowHideLB
            // 
            this.ShowHideLB.AutoSize = true;
            this.ShowHideLB.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold);
            this.ShowHideLB.Location = new System.Drawing.Point(8, 300);
            this.ShowHideLB.Name = "ShowHideLB";
            this.ShowHideLB.Size = new System.Drawing.Size(191, 19);
            this.ShowHideLB.TabIndex = 5;
            this.ShowHideLB.Text = "Show Message on Scroller:";
            // 
            // MessageSourceTB
            // 
            this.MessageSourceTB.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.MessageSourceTB.Font = new System.Drawing.Font("Calibri", 10F);
            this.MessageSourceTB.Location = new System.Drawing.Point(11, 272);
            this.MessageSourceTB.Name = "MessageSourceTB";
            this.MessageSourceTB.Size = new System.Drawing.Size(327, 17);
            this.MessageSourceTB.TabIndex = 4;
            // 
            // SourceLB
            // 
            this.SourceLB.AutoSize = true;
            this.SourceLB.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold);
            this.SourceLB.Location = new System.Drawing.Point(7, 250);
            this.SourceLB.Name = "SourceLB";
            this.SourceLB.Size = new System.Drawing.Size(60, 19);
            this.SourceLB.TabIndex = 0;
            this.SourceLB.Text = "Source:";
            this.SourceLB.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // MessageAuthorTB
            // 
            this.MessageAuthorTB.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.MessageAuthorTB.Font = new System.Drawing.Font("Calibri", 10F);
            this.MessageAuthorTB.Location = new System.Drawing.Point(11, 224);
            this.MessageAuthorTB.Name = "MessageAuthorTB";
            this.MessageAuthorTB.Size = new System.Drawing.Size(327, 17);
            this.MessageAuthorTB.TabIndex = 3;
            // 
            // AuthorLB
            // 
            this.AuthorLB.AutoSize = true;
            this.AuthorLB.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold);
            this.AuthorLB.Location = new System.Drawing.Point(7, 202);
            this.AuthorLB.Name = "AuthorLB";
            this.AuthorLB.Size = new System.Drawing.Size(62, 19);
            this.AuthorLB.TabIndex = 0;
            this.AuthorLB.Text = "Author:";
            this.AuthorLB.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // MessageQuoteTB
            // 
            this.MessageQuoteTB.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.MessageQuoteTB.Font = new System.Drawing.Font("Calibri", 10F);
            this.MessageQuoteTB.Location = new System.Drawing.Point(11, 98);
            this.MessageQuoteTB.Name = "MessageQuoteTB";
            this.MessageQuoteTB.Size = new System.Drawing.Size(327, 96);
            this.MessageQuoteTB.TabIndex = 2;
            this.MessageQuoteTB.Text = "";
            // 
            // QuoteLB
            // 
            this.QuoteLB.AutoSize = true;
            this.QuoteLB.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold);
            this.QuoteLB.Location = new System.Drawing.Point(7, 76);
            this.QuoteLB.Name = "QuoteLB";
            this.QuoteLB.Size = new System.Drawing.Size(56, 19);
            this.QuoteLB.TabIndex = 0;
            this.QuoteLB.Text = "Quote:";
            this.QuoteLB.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // MessageTitleTB
            // 
            this.MessageTitleTB.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.MessageTitleTB.Font = new System.Drawing.Font("Calibri", 10F);
            this.MessageTitleTB.Location = new System.Drawing.Point(11, 51);
            this.MessageTitleTB.Margin = new System.Windows.Forms.Padding(6);
            this.MessageTitleTB.Name = "MessageTitleTB";
            this.MessageTitleTB.Size = new System.Drawing.Size(327, 17);
            this.MessageTitleTB.TabIndex = 1;
            // 
            // TitleLB
            // 
            this.TitleLB.AutoSize = true;
            this.TitleLB.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold);
            this.TitleLB.Location = new System.Drawing.Point(7, 29);
            this.TitleLB.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.TitleLB.Name = "TitleLB";
            this.TitleLB.Size = new System.Drawing.Size(43, 19);
            this.TitleLB.TabIndex = 0;
            this.TitleLB.Text = "Title:";
            this.TitleLB.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // MessageView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlLight;
            this.Controls.Add(this.MessageModal);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.Margin = new System.Windows.Forms.Padding(6);
            this.Name = "MessageView";
            this.Size = new System.Drawing.Size(348, 400);
            this.MessageModal.ResumeLayout(false);
            this.MessageModal.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox MessageModal;
        private System.Windows.Forms.Label TitleLB;
        private System.Windows.Forms.TextBox MessageTitleTB;
        private System.Windows.Forms.Label QuoteLB;
        private System.Windows.Forms.Label AuthorLB;
        private System.Windows.Forms.RichTextBox MessageQuoteTB;
        private System.Windows.Forms.Label SourceLB;
        private System.Windows.Forms.TextBox MessageAuthorTB;
        private System.Windows.Forms.TextBox MessageSourceTB;
        private System.Windows.Forms.RadioButton MessageShowRB;
        private System.Windows.Forms.Label ShowHideLB;
        private System.Windows.Forms.Button Confirm;
        private System.Windows.Forms.RadioButton MessageHideRB;
        private System.Windows.Forms.Button Cancel;
    }
}
