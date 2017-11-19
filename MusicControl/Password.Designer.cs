namespace MusicControl
{
    partial class Password
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Password));
            this.Reset = new System.Windows.Forms.Button();
            this.Confirm = new System.Windows.Forms.Button();
            this.Pa = new System.Windows.Forms.Label();
            this.PasswordText = new System.Windows.Forms.TextBox();
            this.Pl = new System.Windows.Forms.Label();
            this.Passwordwrong = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // Reset
            // 
            this.Reset.Location = new System.Drawing.Point(174, 175);
            this.Reset.Name = "Reset";
            this.Reset.Size = new System.Drawing.Size(75, 23);
            this.Reset.TabIndex = 0;
            this.Reset.Text = "Reset";
            this.Reset.UseVisualStyleBackColor = true;
            this.Reset.Click += new System.EventHandler(this.Reset_Click);
            // 
            // Confirm
            // 
            this.Confirm.Location = new System.Drawing.Point(27, 175);
            this.Confirm.Name = "Confirm";
            this.Confirm.Size = new System.Drawing.Size(75, 23);
            this.Confirm.TabIndex = 1;
            this.Confirm.Text = "Confirm";
            this.Confirm.UseVisualStyleBackColor = true;
            this.Confirm.Click += new System.EventHandler(this.Confirm_Click);
            // 
            // Pa
            // 
            this.Pa.AutoSize = true;
            this.Pa.Location = new System.Drawing.Point(25, 88);
            this.Pa.Name = "Pa";
            this.Pa.Size = new System.Drawing.Size(53, 12);
            this.Pa.TabIndex = 2;
            this.Pa.Text = "Password";
            // 
            // PasswordText
            // 
            this.PasswordText.Location = new System.Drawing.Point(95, 85);
            this.PasswordText.MaxLength = 12;
            this.PasswordText.Name = "PasswordText";
            this.PasswordText.Size = new System.Drawing.Size(154, 21);
            this.PasswordText.TabIndex = 3;
            // 
            // Pl
            // 
            this.Pl.AutoSize = true;
            this.Pl.Location = new System.Drawing.Point(60, 31);
            this.Pl.Name = "Pl";
            this.Pl.Size = new System.Drawing.Size(149, 12);
            this.Pl.TabIndex = 4;
            this.Pl.Text = "Please Type The Password";
            // 
            // Passwordwrong
            // 
            this.Passwordwrong.AutoSize = true;
            this.Passwordwrong.Location = new System.Drawing.Point(25, 130);
            this.Passwordwrong.Name = "Passwordwrong";
            this.Passwordwrong.Size = new System.Drawing.Size(11, 12);
            this.Passwordwrong.TabIndex = 5;
            this.Passwordwrong.Text = "1";
            // 
            // Password
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 261);
            this.Controls.Add(this.Passwordwrong);
            this.Controls.Add(this.Pl);
            this.Controls.Add(this.PasswordText);
            this.Controls.Add(this.Pa);
            this.Controls.Add(this.Confirm);
            this.Controls.Add(this.Reset);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Password";
            this.Text = "Password";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button Reset;
        private System.Windows.Forms.Button Confirm;
        private System.Windows.Forms.Label Pa;
        private System.Windows.Forms.TextBox PasswordText;
        private System.Windows.Forms.Label Pl;
        private System.Windows.Forms.Label Passwordwrong;
    }
}