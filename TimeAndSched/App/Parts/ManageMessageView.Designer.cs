namespace FrontEnd.App.Parts
{
    partial class ManageMessageView
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
            this.SearchBox = new System.Windows.Forms.TextBox();
            this.ToggleButton = new System.Windows.Forms.Button();
            this.SearchButton = new System.Windows.Forms.Button();
            this.RemoveButton = new System.Windows.Forms.Button();
            this.EditButton = new System.Windows.Forms.Button();
            this.CreateButton = new System.Windows.Forms.Button();
            this.MessagesGB.SuspendLayout();
            this.SuspendLayout();
            // 
            // MessageListBox
            // 
            this.MessageListBox.Anchor = System.Windows.Forms.AnchorStyles.None;
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
            this.MessagesGB.Controls.Add(this.SearchBox);
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
            // SearchBox
            // 
            this.SearchBox.AcceptsReturn = true;
            this.SearchBox.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.HistoryList;
            this.SearchBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.SearchBox.Location = new System.Drawing.Point(6, 25);
            this.SearchBox.Name = "SearchBox";
            this.SearchBox.Size = new System.Drawing.Size(277, 26);
            this.SearchBox.TabIndex = 1;
            this.SearchBox.Text = "test";
            this.SearchBox.KeyUp += new System.Windows.Forms.KeyEventHandler(this.SearchBox_KeyUp);
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
            // ManageMessageView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.Controls.Add(this.MessagesGB);
            this.Name = "ManageMessageView";
            this.Size = new System.Drawing.Size(376, 338);
            this.MessagesGB.ResumeLayout(false);
            this.MessagesGB.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListBox MessageListBox;
        private System.Windows.Forms.GroupBox MessagesGB;
        private System.Windows.Forms.TextBox SearchBox;
        private System.Windows.Forms.Button SearchButton;
        private System.Windows.Forms.Button RemoveButton;
        private System.Windows.Forms.Button EditButton;
        private System.Windows.Forms.Button CreateButton;
        private System.Windows.Forms.Button ToggleButton;
    }
}
