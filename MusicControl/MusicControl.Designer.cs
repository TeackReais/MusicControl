namespace MusicControl
{
    partial class MusicControl
    {
        /// <summary>
        /// 必需的设计器变量。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清理所有正在使用的资源。
        /// </summary>
        /// <param name="disposing">如果应释放托管资源，为 true；否则为 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows 窗体设计器生成的代码

        /// <summary>
        /// 设计器支持所需的方法 - 不要修改
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MusicControl));
            this.NowMusic = new System.Windows.Forms.Label();
            this.Close = new System.Windows.Forms.Button();
            this.Choose = new System.Windows.Forms.Button();
            this.Info = new System.Windows.Forms.Button();
            this.Next = new System.Windows.Forms.Button();
            this.NowMusicShow = new System.Windows.Forms.ListBox();
            this.MusicControltitle = new System.Windows.Forms.Label();
            this.AllMusic = new System.Windows.Forms.CheckBox();
            this.MainMusic = new System.Windows.Forms.CheckBox();
            this.LeaveSchool = new System.Windows.Forms.CheckBox();
            this.SuspendLayout();
            // 
            // NowMusic
            // 
            this.NowMusic.AutoSize = true;
            this.NowMusic.Location = new System.Drawing.Point(71, 67);
            this.NowMusic.Name = "NowMusic";
            this.NowMusic.Size = new System.Drawing.Size(59, 12);
            this.NowMusic.TabIndex = 0;
            this.NowMusic.Text = "Now Music";
            // 
            // Close
            // 
            this.Close.Location = new System.Drawing.Point(256, 269);
            this.Close.Name = "Close";
            this.Close.Size = new System.Drawing.Size(75, 23);
            this.Close.TabIndex = 1;
            this.Close.Text = "Close";
            this.Close.UseVisualStyleBackColor = true;
            this.Close.Click += new System.EventHandler(this.Close_Click);
            // 
            // Choose
            // 
            this.Choose.Location = new System.Drawing.Point(256, 185);
            this.Choose.Name = "Choose";
            this.Choose.Size = new System.Drawing.Size(75, 23);
            this.Choose.TabIndex = 2;
            this.Choose.Text = "Choose";
            this.Choose.UseVisualStyleBackColor = true;
            this.Choose.Click += new System.EventHandler(this.Choose_Click);
            this.Choose.MouseHover += new System.EventHandler(this.Choose_MouseHover);
            // 
            // Info
            // 
            this.Info.Location = new System.Drawing.Point(73, 269);
            this.Info.Name = "Info";
            this.Info.Size = new System.Drawing.Size(75, 23);
            this.Info.TabIndex = 3;
            this.Info.Text = "Info";
            this.Info.UseVisualStyleBackColor = true;
            this.Info.Click += new System.EventHandler(this.Info_Click);
            // 
            // Next
            // 
            this.Next.Location = new System.Drawing.Point(73, 185);
            this.Next.Name = "Next";
            this.Next.Size = new System.Drawing.Size(75, 23);
            this.Next.TabIndex = 4;
            this.Next.Text = "Next";
            this.Next.UseVisualStyleBackColor = true;
            this.Next.Click += new System.EventHandler(this.Next_Click);
            this.Next.MouseHover += new System.EventHandler(this.Next_MouseHover);
            // 
            // NowMusicShow
            // 
            this.NowMusicShow.FormattingEnabled = true;
            this.NowMusicShow.ItemHeight = 12;
            this.NowMusicShow.Location = new System.Drawing.Point(158, 67);
            this.NowMusicShow.Name = "NowMusicShow";
            this.NowMusicShow.Size = new System.Drawing.Size(173, 16);
            this.NowMusicShow.TabIndex = 6;
            // 
            // MusicControltitle
            // 
            this.MusicControltitle.AutoSize = true;
            this.MusicControltitle.Location = new System.Drawing.Point(156, 27);
            this.MusicControltitle.Name = "MusicControltitle";
            this.MusicControltitle.Size = new System.Drawing.Size(77, 12);
            this.MusicControltitle.TabIndex = 7;
            this.MusicControltitle.Text = "MusicControl";
            // 
            // AllMusic
            // 
            this.AllMusic.AutoSize = true;
            this.AllMusic.Location = new System.Drawing.Point(70, 130);
            this.AllMusic.Name = "AllMusic";
            this.AllMusic.Size = new System.Drawing.Size(72, 16);
            this.AllMusic.TabIndex = 8;
            this.AllMusic.Text = "AllMusic";
            this.AllMusic.UseVisualStyleBackColor = true;
            this.AllMusic.CheckedChanged += new System.EventHandler(this.AllMusic_CheckedChanged);
            // 
            // MainMusic
            // 
            this.MainMusic.AutoSize = true;
            this.MainMusic.Location = new System.Drawing.Point(155, 130);
            this.MainMusic.Name = "MainMusic";
            this.MainMusic.Size = new System.Drawing.Size(78, 16);
            this.MainMusic.TabIndex = 9;
            this.MainMusic.Text = "MainMusic";
            this.MainMusic.UseVisualStyleBackColor = true;
            this.MainMusic.CheckedChanged += new System.EventHandler(this.MainMusic_CheckedChanged);
            // 
            // LeaveSchool
            // 
            this.LeaveSchool.AutoSize = true;
            this.LeaveSchool.Location = new System.Drawing.Point(253, 130);
            this.LeaveSchool.Name = "LeaveSchool";
            this.LeaveSchool.Size = new System.Drawing.Size(90, 16);
            this.LeaveSchool.TabIndex = 10;
            this.LeaveSchool.Text = "LeaveSchool";
            this.LeaveSchool.UseVisualStyleBackColor = true;
            this.LeaveSchool.CheckedChanged += new System.EventHandler(this.LeaveSchool_CheckedChanged);
            // 
            // MusicControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(434, 411);
            this.Controls.Add(this.LeaveSchool);
            this.Controls.Add(this.MainMusic);
            this.Controls.Add(this.AllMusic);
            this.Controls.Add(this.MusicControltitle);
            this.Controls.Add(this.NowMusicShow);
            this.Controls.Add(this.Next);
            this.Controls.Add(this.Info);
            this.Controls.Add(this.Choose);
            this.Controls.Add(this.Close);
            this.Controls.Add(this.NowMusic);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "MusicControl";
            this.Text = "MusicControl";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label NowMusic;
        private System.Windows.Forms.ListBox NowMusicShow;
        private System.Windows.Forms.Label MusicControltitle;
        private System.Windows.Forms.CheckBox AllMusic;
        private System.Windows.Forms.CheckBox MainMusic;
        private System.Windows.Forms.CheckBox LeaveSchool;
        public System.Windows.Forms.Button Close;
        public System.Windows.Forms.Button Choose;
        public System.Windows.Forms.Button Info;
        public System.Windows.Forms.Button Next;
    }
}

