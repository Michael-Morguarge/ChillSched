namespace FrontEnd.App.Prompts
{
    partial class MessageCrudView
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
            this.MV = new FrontEnd.App.Parts.MessageView();
            this.Error = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // MV
            // 
            this.MV.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.MV.BackColor = System.Drawing.SystemColors.ControlLight;
            this.MV.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.MV.Location = new System.Drawing.Point(1, 1);
            this.MV.Margin = new System.Windows.Forms.Padding(6);
            this.MV.Name = "MV";
            this.MV.Size = new System.Drawing.Size(348, 400);
            this.MV.TabIndex = 0;
            // 
            // Error
            // 
            this.Error.AutoSize = true;
            this.Error.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.Error.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Error.Font = new System.Drawing.Font("Calibri", 25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Error.Location = new System.Drawing.Point(71, 180);
            this.Error.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.Error.Name = "Error";
            this.Error.Size = new System.Drawing.Size(208, 41);
            this.Error.TabIndex = 2;
            this.Error.Text = "Invalid Access";
            this.Error.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.Error.Visible = false;
            // 
            // MessageCrudView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ClientSize = new System.Drawing.Size(350, 400);
            this.Controls.Add(this.MV);
            this.Controls.Add(this.Error);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "MessageCrudView";
            this.ShowIcon = false;
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide;
            this.Text = "MessageCrudView";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.MessageCrudView_FormClosing);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Parts.MessageView MV;
        private System.Windows.Forms.Label Error;
    }
}