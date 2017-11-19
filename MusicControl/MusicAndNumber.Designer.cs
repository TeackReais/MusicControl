namespace MusicControl
{
    partial class MusicAndNumber
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MusicAndNumber));
            this.MAN = new System.Windows.Forms.Label();
            this.MusicAndNumberBox = new System.Windows.Forms.ListBox();
            this.SuspendLayout();
            // 
            // MAN
            // 
            this.MAN.AutoSize = true;
            this.MAN.Location = new System.Drawing.Point(225, 38);
            this.MAN.Name = "MAN";
            this.MAN.Size = new System.Drawing.Size(89, 12);
            this.MAN.TabIndex = 0;
            this.MAN.Text = "MusicAndNumber";
            // 
            // MusicAndNumberBox
            // 
            this.MusicAndNumberBox.FormattingEnabled = true;
            this.MusicAndNumberBox.ItemHeight = 12;
            this.MusicAndNumberBox.Location = new System.Drawing.Point(80, 75);
            this.MusicAndNumberBox.Name = "MusicAndNumberBox";
            this.MusicAndNumberBox.Size = new System.Drawing.Size(440, 436);
            this.MusicAndNumberBox.TabIndex = 1;
            // 
            // MusicAndNumber
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(584, 561);
            this.Controls.Add(this.MusicAndNumberBox);
            this.Controls.Add(this.MAN);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "MusicAndNumber";
            this.Text = "MusicAndNumber";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label MAN;
        private System.Windows.Forms.ListBox MusicAndNumberBox;
    }
}