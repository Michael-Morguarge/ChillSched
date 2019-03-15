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
            this.SuspendLayout();
            // 
            // Error
            // 
            this.Error.AutoSize = true;
            this.Error.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.Error.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Error.Font = new System.Drawing.Font("Calibri", 25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Error.Location = new System.Drawing.Point(103, 213);
            this.Error.Name = "Error";
            this.Error.Size = new System.Drawing.Size(306, 61);
            this.Error.TabIndex = 1;
            this.Error.Text = "Invalid Access";
            this.Error.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.Error.Visible = false;
            // 
            // GeneralForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.ClientSize = new System.Drawing.Size(520, 511);
            this.Controls.Add(this.Error);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "GeneralForm";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.WindowsDefaultBounds;
            this.Text = "GeneralForm";
            this.TopMost = true;
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label Error;
    }
}