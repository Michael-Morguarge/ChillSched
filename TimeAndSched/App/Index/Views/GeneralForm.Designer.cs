namespace FrontEnd.App.Index.Views
{
    partial class GeneralForm
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
            this.Error = new System.Windows.Forms.Label();
            this.EIV = new FrontEnd.App.Index.Frameworks.EventInfoView();
            this.SuspendLayout();
            // 
            // Error
            // 
            this.Error.AutoSize = true;
            this.Error.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.Error.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Error.Font = new System.Drawing.Font("Calibri", 25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Error.Location = new System.Drawing.Point(69, 138);
            this.Error.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.Error.Name = "Error";
            this.Error.Size = new System.Drawing.Size(208, 41);
            this.Error.TabIndex = 1;
            this.Error.Text = "Invalid Access";
            this.Error.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.Error.Visible = false;
            // 
            // EIV
            // 
            this.EIV.Error = false;
            this.EIV.Location = new System.Drawing.Point(8, 6);
            this.EIV.Margin = new System.Windows.Forms.Padding(2);
            this.EIV.Name = "EIV";
            this.EIV.Size = new System.Drawing.Size(331, 320);
            this.EIV.TabIndex = 2;
            // 
            // GeneralForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BackColor = System.Drawing.SystemColors.ControlLight;
            this.ClientSize = new System.Drawing.Size(347, 332);
            this.ControlBox = false;
            this.Controls.Add(this.EIV);
            this.Controls.Add(this.Error);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "GeneralForm";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "GeneralForm";
            this.TopMost = true;
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.GeneralForm_FormClosing);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label Error;
        private Frameworks.EventInfoView EIV;
    }
}