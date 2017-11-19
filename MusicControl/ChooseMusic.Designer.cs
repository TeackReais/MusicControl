namespace MusicControl
{
    partial class ChooseMusic
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ChooseMusic));
            this.MusicNumber = new System.Windows.Forms.NumericUpDown();
            this.Title = new System.Windows.Forms.Label();
            this.MK = new System.Windows.Forms.Label();
            this.More = new System.Windows.Forms.Button();
            this.Back = new System.Windows.Forms.Button();
            this.Confirm = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.MusicNumber)).BeginInit();
            this.SuspendLayout();
            // 
            // MusicNumber
            // 
            this.MusicNumber.Location = new System.Drawing.Point(156, 61);
            this.MusicNumber.Maximum = new decimal(new int[] {
            53,
            0,
            0,
            0});
            this.MusicNumber.Name = "MusicNumber";
            this.MusicNumber.Size = new System.Drawing.Size(178, 21);
            this.MusicNumber.TabIndex = 0;
            // 
            // Title
            // 
            this.Title.AutoSize = true;
            this.Title.Location = new System.Drawing.Point(57, 25);
            this.Title.Name = "Title";
            this.Title.Size = new System.Drawing.Size(287, 12);
            this.Title.TabIndex = 14;
            this.Title.Text = "Welcome Xukai Please Choose The Music You Like.";
            // 
            // MK
            // 
            this.MK.AutoSize = true;
            this.MK.Location = new System.Drawing.Point(57, 63);
            this.MK.Name = "MK";
            this.MK.Size = new System.Drawing.Size(35, 12);
            this.MK.TabIndex = 15;
            this.MK.Text = "Music";
            // 
            // More
            // 
            this.More.Location = new System.Drawing.Point(159, 97);
            this.More.Name = "More";
            this.More.Size = new System.Drawing.Size(75, 23);
            this.More.TabIndex = 16;
            this.More.Text = "More";
            this.More.UseVisualStyleBackColor = true;
            this.More.Click += new System.EventHandler(this.More_Click);
            // 
            // Back
            // 
            this.Back.Location = new System.Drawing.Point(259, 97);
            this.Back.Name = "Back";
            this.Back.Size = new System.Drawing.Size(75, 23);
            this.Back.TabIndex = 17;
            this.Back.Text = "Back";
            this.Back.UseVisualStyleBackColor = true;
            this.Back.Click += new System.EventHandler(this.Close_Click);
            // 
            // Confirm
            // 
            this.Confirm.Location = new System.Drawing.Point(59, 97);
            this.Confirm.Name = "Confirm";
            this.Confirm.Size = new System.Drawing.Size(75, 23);
            this.Confirm.TabIndex = 18;
            this.Confirm.Text = "Confirm";
            this.Confirm.UseVisualStyleBackColor = true;
            this.Confirm.Click += new System.EventHandler(this.Confirm_Click);
            // 
            // ChooseMusic
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(370, 145);
            this.Controls.Add(this.Confirm);
            this.Controls.Add(this.Back);
            this.Controls.Add(this.More);
            this.Controls.Add(this.MK);
            this.Controls.Add(this.Title);
            this.Controls.Add(this.MusicNumber);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "ChooseMusic";
            this.Text = "ChooseMusic";
            ((System.ComponentModel.ISupportInitialize)(this.MusicNumber)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.NumericUpDown MusicNumber;
        private System.Windows.Forms.Label Title;
        private System.Windows.Forms.Label MK;
        private System.Windows.Forms.Button More;
#pragma warning disable CS0108 // 成员隐藏继承的成员；缺少关键字 new
        private System.Windows.Forms.Button Back;
#pragma warning restore CS0108 // 成员隐藏继承的成员；缺少关键字 new
        private System.Windows.Forms.Button Confirm;
    }
}