namespace FrontEnd.App.Prompts
{
    partial class SearchView
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
            this.MSV = new FrontEnd.App.Parts.ManageMessageView();
            this.SuspendLayout();
            // 
            // MSV
            // 
            this.MSV.BackColor = System.Drawing.SystemColors.Control;
            this.MSV.Location = new System.Drawing.Point(5, 4);
            this.MSV.Name = "MSV";
            this.MSV.Size = new System.Drawing.Size(758, 398);
            this.MSV.TabIndex = 1;
            // 
            // SearchView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.ClientSize = new System.Drawing.Size(768, 406);
            this.Controls.Add(this.MSV);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "SearchView";
            this.ShowIcon = false;
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide;
            this.Text = "Manage Messages";
            this.Resize += new System.EventHandler(this.MessageDisplayView_Resize);
            this.ResumeLayout(false);

        }

        #endregion

        private Parts.ManageMessageView MSV;
    }
}