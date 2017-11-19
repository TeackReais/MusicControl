namespace MusicControl
{
    partial class Info
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Info));
            this.Creater = new System.Windows.Forms.Label();
            this.Version = new System.Windows.Forms.Label();
            this.Company = new System.Windows.Forms.Label();
            this.Web = new System.Windows.Forms.Label();
            this.Ve = new System.Windows.Forms.Label();
            this.Co = new System.Windows.Forms.Label();
            this.We = new System.Windows.Forms.Label();
            this.Cr = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // Creater
            // 
            this.Creater.AutoSize = true;
            this.Creater.Location = new System.Drawing.Point(59, 42);
            this.Creater.Name = "Creater";
            this.Creater.Size = new System.Drawing.Size(53, 12);
            this.Creater.TabIndex = 0;
            this.Creater.Text = "Creater:";
            // 
            // Version
            // 
            this.Version.AutoSize = true;
            this.Version.Location = new System.Drawing.Point(59, 120);
            this.Version.Name = "Version";
            this.Version.Size = new System.Drawing.Size(53, 12);
            this.Version.TabIndex = 1;
            this.Version.Text = "Version:";
            // 
            // Company
            // 
            this.Company.AutoSize = true;
            this.Company.Location = new System.Drawing.Point(59, 81);
            this.Company.Name = "Company";
            this.Company.Size = new System.Drawing.Size(53, 12);
            this.Company.TabIndex = 2;
            this.Company.Text = "Company:";
            // 
            // Web
            // 
            this.Web.AutoSize = true;
            this.Web.Location = new System.Drawing.Point(59, 159);
            this.Web.Name = "Web";
            this.Web.Size = new System.Drawing.Size(29, 12);
            this.Web.TabIndex = 3;
            this.Web.Text = "Web:";
            // 
            // Ve
            // 
            this.Ve.AutoSize = true;
            this.Ve.Location = new System.Drawing.Point(118, 120);
            this.Ve.Name = "Ve";
            this.Ve.Size = new System.Drawing.Size(41, 12);
            this.Ve.TabIndex = 5;
            this.Ve.Text = "label2";
            // 
            // Co
            // 
            this.Co.AutoSize = true;
            this.Co.Location = new System.Drawing.Point(118, 81);
            this.Co.Name = "Co";
            this.Co.Size = new System.Drawing.Size(41, 12);
            this.Co.TabIndex = 6;
            this.Co.Text = "label3";
            // 
            // We
            // 
            this.We.AutoSize = true;
            this.We.Location = new System.Drawing.Point(94, 159);
            this.We.Name = "We";
            this.We.Size = new System.Drawing.Size(179, 12);
            this.We.TabIndex = 7;
            this.We.Text = "https://github.com/TeackReais";
            // 
            // Cr
            // 
            this.Cr.AutoSize = true;
            this.Cr.Location = new System.Drawing.Point(118, 42);
            this.Cr.Name = "Cr";
            this.Cr.Size = new System.Drawing.Size(41, 12);
            this.Cr.TabIndex = 4;
            this.Cr.Text = "label1";
            // 
            // Info
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 261);
            this.Controls.Add(this.We);
            this.Controls.Add(this.Co);
            this.Controls.Add(this.Ve);
            this.Controls.Add(this.Cr);
            this.Controls.Add(this.Web);
            this.Controls.Add(this.Company);
            this.Controls.Add(this.Version);
            this.Controls.Add(this.Creater);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Info";
            this.Text = "Info";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label Creater;
        private System.Windows.Forms.Label Version;
        private System.Windows.Forms.Label Company;
        private System.Windows.Forms.Label Web;
        private System.Windows.Forms.Label Ve;
        private System.Windows.Forms.Label Co;
        private System.Windows.Forms.Label We;
        private System.Windows.Forms.Label Cr;
    }
}