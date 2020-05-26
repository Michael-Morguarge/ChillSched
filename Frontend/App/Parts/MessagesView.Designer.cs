namespace Frontend.App.Parts
{
    partial class MessagesView
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
            this.MessageListBox = new System.Windows.Forms.ListBox();
            this.MessagesGB = new System.Windows.Forms.GroupBox();
            this.MessageSearchBox = new System.Windows.Forms.TextBox();
            this.ToggleButton = new System.Windows.Forms.Button();
            this.SearchButton = new System.Windows.Forms.Button();
            this.RemoveButton = new System.Windows.Forms.Button();
            this.EditButton = new System.Windows.Forms.Button();
            this.CreateButton = new System.Windows.Forms.Button();
            this.MessageInfoGB = new System.Windows.Forms.GroupBox();
            this.InfoTab = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.MessageSourcesTB = new System.Windows.Forms.RichTextBox();
            this.MessageAuthorsTB = new System.Windows.Forms.RichTextBox();
            this.MessageTitleLB = new System.Windows.Forms.Label();
            this.MessageLastTimeDisplayedLB = new System.Windows.Forms.Label();
            this.MessageInfoTB = new System.Windows.Forms.RichTextBox();
            this.MessageLastDateDisplayedLB = new System.Windows.Forms.Label();
            this.MessageStatusLB = new System.Windows.Forms.Label();
            this.MessageTimeCreatedLB = new System.Windows.Forms.Label();
            this.MessageDateCreatedLB = new System.Windows.Forms.Label();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.MessagePreviewTB = new System.Windows.Forms.RichTextBox();
            this.MessagesGB.SuspendLayout();
            this.MessageInfoGB.SuspendLayout();
            this.InfoTab.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.SuspendLayout();
            // 
            // MessageListBox
            // 
            this.MessageListBox.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.MessageListBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MessageListBox.FormattingEnabled = true;
            this.MessageListBox.ItemHeight = 20;
            this.MessageListBox.Items.AddRange(new object[] {
            "Test items"});
            this.MessageListBox.Location = new System.Drawing.Point(6, 69);
            this.MessageListBox.Name = "MessageListBox";
            this.MessageListBox.Size = new System.Drawing.Size(277, 244);
            this.MessageListBox.Sorted = true;
            this.MessageListBox.TabIndex = 0;
            this.MessageListBox.SelectedIndexChanged += new System.EventHandler(this.MessageListBox_SelectedIndexChanged);
            // 
            // MessagesGB
            // 
            this.MessagesGB.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.MessagesGB.Controls.Add(this.MessageSearchBox);
            this.MessagesGB.Controls.Add(this.MessageListBox);
            this.MessagesGB.Controls.Add(this.ToggleButton);
            this.MessagesGB.Controls.Add(this.SearchButton);
            this.MessagesGB.Controls.Add(this.RemoveButton);
            this.MessagesGB.Controls.Add(this.EditButton);
            this.MessagesGB.Controls.Add(this.CreateButton);
            this.MessagesGB.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MessagesGB.Location = new System.Drawing.Point(3, 3);
            this.MessagesGB.Name = "MessagesGB";
            this.MessagesGB.Size = new System.Drawing.Size(368, 332);
            this.MessagesGB.TabIndex = 0;
            this.MessagesGB.TabStop = false;
            this.MessagesGB.Text = "Messages";
            // 
            // MessageSearchBox
            // 
            this.MessageSearchBox.AcceptsReturn = true;
            this.MessageSearchBox.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.HistoryList;
            this.MessageSearchBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.MessageSearchBox.Location = new System.Drawing.Point(6, 25);
            this.MessageSearchBox.Name = "MessageSearchBox";
            this.MessageSearchBox.Size = new System.Drawing.Size(277, 26);
            this.MessageSearchBox.TabIndex = 1;
            this.MessageSearchBox.Text = "test";
            this.MessageSearchBox.KeyUp += new System.Windows.Forms.KeyEventHandler(this.SearchBox_KeyUp);
            // 
            // ToggleButton
            // 
            this.ToggleButton.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ToggleButton.Enabled = false;
            this.ToggleButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ToggleButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ToggleButton.Location = new System.Drawing.Point(282, 162);
            this.ToggleButton.Name = "ToggleButton";
            this.ToggleButton.Size = new System.Drawing.Size(80, 25);
            this.ToggleButton.TabIndex = 6;
            this.ToggleButton.Text = "-";
            this.ToggleButton.UseVisualStyleBackColor = true;
            this.ToggleButton.Click += new System.EventHandler(this.ToggleButton_Click);
            // 
            // SearchButton
            // 
            this.SearchButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.SearchButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SearchButton.Location = new System.Drawing.Point(282, 25);
            this.SearchButton.Name = "SearchButton";
            this.SearchButton.Size = new System.Drawing.Size(80, 26);
            this.SearchButton.TabIndex = 2;
            this.SearchButton.Text = "Search";
            this.SearchButton.UseVisualStyleBackColor = true;
            this.SearchButton.Click += new System.EventHandler(this.SearchButton_Click);
            // 
            // RemoveButton
            // 
            this.RemoveButton.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.RemoveButton.Enabled = false;
            this.RemoveButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.RemoveButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.RemoveButton.Location = new System.Drawing.Point(282, 131);
            this.RemoveButton.Name = "RemoveButton";
            this.RemoveButton.Size = new System.Drawing.Size(80, 25);
            this.RemoveButton.TabIndex = 5;
            this.RemoveButton.Text = "Remove";
            this.RemoveButton.UseVisualStyleBackColor = true;
            this.RemoveButton.Click += new System.EventHandler(this.RemoveButton_Click);
            // 
            // EditButton
            // 
            this.EditButton.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.EditButton.Enabled = false;
            this.EditButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.EditButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.EditButton.Location = new System.Drawing.Point(282, 100);
            this.EditButton.Name = "EditButton";
            this.EditButton.Size = new System.Drawing.Size(80, 25);
            this.EditButton.TabIndex = 4;
            this.EditButton.Text = "Edit";
            this.EditButton.UseVisualStyleBackColor = true;
            this.EditButton.Click += new System.EventHandler(this.EditButton_Click);
            // 
            // CreateButton
            // 
            this.CreateButton.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.CreateButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.CreateButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CreateButton.Location = new System.Drawing.Point(282, 69);
            this.CreateButton.Name = "CreateButton";
            this.CreateButton.Size = new System.Drawing.Size(80, 25);
            this.CreateButton.TabIndex = 3;
            this.CreateButton.Text = "Create";
            this.CreateButton.UseVisualStyleBackColor = true;
            this.CreateButton.Click += new System.EventHandler(this.CreateButton_Click);
            // 
            // MessageInfoGB
            // 
            this.MessageInfoGB.Controls.Add(this.InfoTab);
            this.MessageInfoGB.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold);
            this.MessageInfoGB.Location = new System.Drawing.Point(377, 3);
            this.MessageInfoGB.Name = "MessageInfoGB";
            this.MessageInfoGB.Size = new System.Drawing.Size(640, 332);
            this.MessageInfoGB.TabIndex = 1;
            this.MessageInfoGB.TabStop = false;
            this.MessageInfoGB.Text = "Text Goes Here";
            // 
            // InfoTab
            // 
            this.InfoTab.Appearance = System.Windows.Forms.TabAppearance.Buttons;
            this.InfoTab.Controls.Add(this.tabPage1);
            this.InfoTab.Controls.Add(this.tabPage2);
            this.InfoTab.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold);
            this.InfoTab.Location = new System.Drawing.Point(7, 25);
            this.InfoTab.Name = "InfoTab";
            this.InfoTab.SelectedIndex = 0;
            this.InfoTab.Size = new System.Drawing.Size(627, 301);
            this.InfoTab.TabIndex = 7;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.MessageSourcesTB);
            this.tabPage1.Controls.Add(this.MessageAuthorsTB);
            this.tabPage1.Controls.Add(this.MessageTitleLB);
            this.tabPage1.Controls.Add(this.MessageLastTimeDisplayedLB);
            this.tabPage1.Controls.Add(this.MessageInfoTB);
            this.tabPage1.Controls.Add(this.MessageLastDateDisplayedLB);
            this.tabPage1.Controls.Add(this.MessageStatusLB);
            this.tabPage1.Controls.Add(this.MessageTimeCreatedLB);
            this.tabPage1.Controls.Add(this.MessageDateCreatedLB);
            this.tabPage1.Location = new System.Drawing.Point(4, 28);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(619, 269);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Details";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // MessageSourcesTB
            // 
            this.MessageSourcesTB.BackColor = System.Drawing.SystemColors.Control;
            this.MessageSourcesTB.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.MessageSourcesTB.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.MessageSourcesTB.DetectUrls = false;
            this.MessageSourcesTB.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.MessageSourcesTB.Location = new System.Drawing.Point(316, 109);
            this.MessageSourcesTB.Name = "MessageSourcesTB";
            this.MessageSourcesTB.ReadOnly = true;
            this.MessageSourcesTB.Size = new System.Drawing.Size(300, 68);
            this.MessageSourcesTB.TabIndex = 0;
            this.MessageSourcesTB.TabStop = false;
            this.MessageSourcesTB.Text = "No source(s)";
            // 
            // MessageAuthorsTB
            // 
            this.MessageAuthorsTB.BackColor = System.Drawing.SystemColors.Control;
            this.MessageAuthorsTB.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.MessageAuthorsTB.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.MessageAuthorsTB.DetectUrls = false;
            this.MessageAuthorsTB.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.MessageAuthorsTB.Location = new System.Drawing.Point(316, 38);
            this.MessageAuthorsTB.Name = "MessageAuthorsTB";
            this.MessageAuthorsTB.ReadOnly = true;
            this.MessageAuthorsTB.Size = new System.Drawing.Size(300, 68);
            this.MessageAuthorsTB.TabIndex = 0;
            this.MessageAuthorsTB.TabStop = false;
            this.MessageAuthorsTB.Text = "No author(s)";
            // 
            // MessageTitleLB
            // 
            this.MessageTitleLB.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.MessageTitleLB.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.MessageTitleLB.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.MessageTitleLB.Location = new System.Drawing.Point(3, 3);
            this.MessageTitleLB.Name = "MessageTitleLB";
            this.MessageTitleLB.Size = new System.Drawing.Size(613, 32);
            this.MessageTitleLB.TabIndex = 0;
            this.MessageTitleLB.Text = "-";
            this.MessageTitleLB.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // MessageLastTimeDisplayedLB
            // 
            this.MessageLastTimeDisplayedLB.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold);
            this.MessageLastTimeDisplayedLB.Location = new System.Drawing.Point(313, 241);
            this.MessageLastTimeDisplayedLB.Name = "MessageLastTimeDisplayedLB";
            this.MessageLastTimeDisplayedLB.Size = new System.Drawing.Size(303, 26);
            this.MessageLastTimeDisplayedLB.TabIndex = 4;
            this.MessageLastTimeDisplayedLB.Text = "-";
            this.MessageLastTimeDisplayedLB.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // MessageInfoTB
            // 
            this.MessageInfoTB.BackColor = System.Drawing.SystemColors.Control;
            this.MessageInfoTB.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.MessageInfoTB.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.MessageInfoTB.DetectUrls = false;
            this.MessageInfoTB.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.MessageInfoTB.Location = new System.Drawing.Point(3, 38);
            this.MessageInfoTB.Name = "MessageInfoTB";
            this.MessageInfoTB.ReadOnly = true;
            this.MessageInfoTB.ScrollBars = System.Windows.Forms.RichTextBoxScrollBars.Vertical;
            this.MessageInfoTB.Size = new System.Drawing.Size(307, 139);
            this.MessageInfoTB.TabIndex = 0;
            this.MessageInfoTB.TabStop = false;
            this.MessageInfoTB.Text = "No message";
            // 
            // MessageLastDateDisplayedLB
            // 
            this.MessageLastDateDisplayedLB.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold);
            this.MessageLastDateDisplayedLB.Location = new System.Drawing.Point(3, 241);
            this.MessageLastDateDisplayedLB.Name = "MessageLastDateDisplayedLB";
            this.MessageLastDateDisplayedLB.Size = new System.Drawing.Size(303, 26);
            this.MessageLastDateDisplayedLB.TabIndex = 3;
            this.MessageLastDateDisplayedLB.Text = "-";
            this.MessageLastDateDisplayedLB.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // MessageStatusLB
            // 
            this.MessageStatusLB.BackColor = System.Drawing.SystemColors.ControlDark;
            this.MessageStatusLB.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold);
            this.MessageStatusLB.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.MessageStatusLB.Location = new System.Drawing.Point(3, 180);
            this.MessageStatusLB.Name = "MessageStatusLB";
            this.MessageStatusLB.Size = new System.Drawing.Size(613, 26);
            this.MessageStatusLB.TabIndex = 0;
            this.MessageStatusLB.Text = "-";
            this.MessageStatusLB.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // MessageTimeCreatedLB
            // 
            this.MessageTimeCreatedLB.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold);
            this.MessageTimeCreatedLB.Location = new System.Drawing.Point(313, 209);
            this.MessageTimeCreatedLB.Name = "MessageTimeCreatedLB";
            this.MessageTimeCreatedLB.Size = new System.Drawing.Size(303, 26);
            this.MessageTimeCreatedLB.TabIndex = 2;
            this.MessageTimeCreatedLB.Text = "-";
            this.MessageTimeCreatedLB.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // MessageDateCreatedLB
            // 
            this.MessageDateCreatedLB.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold);
            this.MessageDateCreatedLB.Location = new System.Drawing.Point(3, 209);
            this.MessageDateCreatedLB.Name = "MessageDateCreatedLB";
            this.MessageDateCreatedLB.Size = new System.Drawing.Size(303, 26);
            this.MessageDateCreatedLB.TabIndex = 1;
            this.MessageDateCreatedLB.Text = "-";
            this.MessageDateCreatedLB.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // tabPage2
            // 
            this.tabPage2.AutoScroll = true;
            this.tabPage2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.tabPage2.Controls.Add(this.MessagePreviewTB);
            this.tabPage2.Location = new System.Drawing.Point(4, 28);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(619, 269);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Preview";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // MessagePreviewTB
            // 
            this.MessagePreviewTB.BackColor = System.Drawing.SystemColors.ControlLight;
            this.MessagePreviewTB.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.MessagePreviewTB.Cursor = System.Windows.Forms.Cursors.Default;
            this.MessagePreviewTB.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.MessagePreviewTB.Location = new System.Drawing.Point(7, 7);
            this.MessagePreviewTB.Name = "MessagePreviewTB";
            this.MessagePreviewTB.ReadOnly = true;
            this.MessagePreviewTB.ScrollBars = System.Windows.Forms.RichTextBoxScrollBars.Vertical;
            this.MessagePreviewTB.Size = new System.Drawing.Size(606, 256);
            this.MessagePreviewTB.TabIndex = 0;
            this.MessagePreviewTB.TabStop = false;
            this.MessagePreviewTB.Text = "No message";
            // 
            // MessagesView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.Controls.Add(this.MessageInfoGB);
            this.Controls.Add(this.MessagesGB);
            this.Name = "MessagesView";
            this.Size = new System.Drawing.Size(1020, 338);
            this.MessagesGB.ResumeLayout(false);
            this.MessagesGB.PerformLayout();
            this.MessageInfoGB.ResumeLayout(false);
            this.InfoTab.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListBox MessageListBox;
        private System.Windows.Forms.GroupBox MessagesGB;
        private System.Windows.Forms.TextBox MessageSearchBox;
        private System.Windows.Forms.Button SearchButton;
        private System.Windows.Forms.Button RemoveButton;
        private System.Windows.Forms.Button EditButton;
        private System.Windows.Forms.Button CreateButton;
        private System.Windows.Forms.Button ToggleButton;
        private System.Windows.Forms.GroupBox MessageInfoGB;
        private System.Windows.Forms.Label MessageTitleLB;
        private System.Windows.Forms.RichTextBox MessageInfoTB;
        private System.Windows.Forms.Label MessageStatusLB;
        private System.Windows.Forms.Label MessageDateCreatedLB;
        private System.Windows.Forms.Label MessageTimeCreatedLB;
        private System.Windows.Forms.Label MessageLastTimeDisplayedLB;
        private System.Windows.Forms.Label MessageLastDateDisplayedLB;
        private System.Windows.Forms.TabControl InfoTab;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.RichTextBox MessagePreviewTB;
        private System.Windows.Forms.RichTextBox MessageAuthorsTB;
        private System.Windows.Forms.RichTextBox MessageSourcesTB;
    }
}
