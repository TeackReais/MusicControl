using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MusicControl
{
    public partial class ChooseMusic : Form
    {
        public ChooseMusic()
        {
            InitializeComponent();
        }

        private void Close_Click(object sender, EventArgs e)
        {
            MusicControl musiccontrol = (MusicControl)this.Owner;
            musiccontrol.Show();
            this.Close();
            return;
        }

        private void More_Click(object sender, EventArgs e)
        {
            new MusicAndNumber().Show();
        }

        private void Confirm_Click(object sender, EventArgs e)
        {
            string pathbase1 = @"D:\MusicDocument\AllMusic\音乐 (";
            string pathbase2 = @").mp3";
            int num = (int)MusicNumber.Value;
            string numstr = num.ToString();
            Program.StartFile(pathbase1 + numstr + pathbase2);
            return;
        }
    }
}
