using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace MusicControl
{
    public partial class MusicControl : Form
    {
        public static MusicControl musiccontrol;
        public MusicControl()
        {
            InitializeComponent();
            NowMusicShow.Items.Add("Welcome!");      
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void Close_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void Info_Click(object sender, EventArgs e)
        {
            new Info().Show();
        }

        private void Next_Click(object sender, EventArgs e)
        {
            string[] AllMusicNameAndNumber = new string[54];
            AllMusicNameAndNumber[0] = "哀乐  罗浪编曲";
            AllMusicNameAndNumber[1] = "奥林匹克进行曲";
            AllMusicNameAndNumber[2] = "鞭炮齐鸣";
            AllMusicNameAndNumber[3] = "步步高";
            AllMusicNameAndNumber[4] = "春节序曲";
            AllMusicNameAndNumber[5] = "打靶归来";
            AllMusicNameAndNumber[6] = "分列式进行曲";
            AllMusicNameAndNumber[7] = "歌唱祖国";
            AllMusicNameAndNumber[8] = "光荣的禁卫军";
            AllMusicNameAndNumber[9] = "光荣的凯旋";
            AllMusicNameAndNumber[10] = "国歌";
            AllMusicNameAndNumber[11] = "国际歌";
            AllMusicNameAndNumber[12] = "海军进行曲";
            AllMusicNameAndNumber[13] = "欢送进行曲";
            AllMusicNameAndNumber[14] = "欢迎进行曲";
            AllMusicNameAndNumber[15] = "辉煌时刻(颁奖专用曲)";
            AllMusicNameAndNumber[16] = "瓦格纳婚礼进行曲";
            AllMusicNameAndNumber[17] = "火箭部队进行曲";
            AllMusicNameAndNumber[18] = "检阅进行曲";
            AllMusicNameAndNumber[19] = "军威进行曲";
            AllMusicNameAndNumber[20] = "卡秋莎";
            AllMusicNameAndNumber[21] = "拉德斯基进行曲";
            AllMusicNameAndNumber[22] = "没有共产党就没有新中国";
            AllMusicNameAndNumber[23] = "女兵进行曲";
            AllMusicNameAndNumber[24] = "炮兵进行曲";
            AllMusicNameAndNumber[25] = "骑兵进行曲";
            AllMusicNameAndNumber[26] = "人民海军向前进";
            AllMusicNameAndNumber[27] = "人民军队忠于党";
            AllMusicNameAndNumber[28] = "三大纪律八项注意";
            AllMusicNameAndNumber[29] = "胜利在召唤";
            AllMusicNameAndNumber[30] = "苏军进行曲";
            AllMusicNameAndNumber[31] = "团结就是力量";
            AllMusicNameAndNumber[32] = "团结友谊进行曲";
            AllMusicNameAndNumber[33] = "我们走在大路上";
            AllMusicNameAndNumber[34] = "新四军军歌";
            AllMusicNameAndNumber[35] = "学习雷锋好榜样";
            AllMusicNameAndNumber[36] = "一个斯拉夫女人的告别";
            AllMusicNameAndNumber[37] = "义勇军进行曲";
            AllMusicNameAndNumber[38] = "友谊地久天长";
            AllMusicNameAndNumber[39] = "运动员进行曲";
            AllMusicNameAndNumber[40] = "在希望的田野上";
            AllMusicNameAndNumber[41] = "葬礼进行曲  李桐树曲";
            AllMusicNameAndNumber[42] = "战车进行曲";
            AllMusicNameAndNumber[43] = "志愿军战歌";
            AllMusicNameAndNumber[44] = "中国人民解放军进行曲(铜管乐)";
            AllMusicNameAndNumber[45] = "中国人民解放军进行曲";
            AllMusicNameAndNumber[46] = "中国少年先锋队队歌";
            AllMusicNameAndNumber[47] = "中国中国鲜红的太阳永不落";
            AllMusicNameAndNumber[48] = "义勇军进行曲";
            AllMusicNameAndNumber[49] = "回家";
            AllMusicNameAndNumber[50] = "渔舟唱晚";
            AllMusicNameAndNumber[51] = "CCTV新闻联播片头";
            AllMusicNameAndNumber[52] = "欢乐斗地主背景音乐";
            AllMusicNameAndNumber[53] = "最初的梦想";
            string[] MainMusicNameAndNumber = new string[18];
            MainMusicNameAndNumber[0] = "春节序曲";
            MainMusicNameAndNumber[1] = "分列式进行曲";
            MainMusicNameAndNumber[2] = "歌唱祖国";
            MainMusicNameAndNumber[3] = "光荣的凯旋";
            MainMusicNameAndNumber[4] = "欢送进行曲";
            MainMusicNameAndNumber[5] = "欢迎进行曲";
            MainMusicNameAndNumber[6] = "检阅进行曲";
            MainMusicNameAndNumber[7] = "拉德斯基进行曲";
            MainMusicNameAndNumber[8] = "没有共产党就没有新中国";
            MainMusicNameAndNumber[9] = "学习雷锋好榜样";
            MainMusicNameAndNumber[10] = "志愿军战歌";
            MainMusicNameAndNumber[11] = "运动员进行曲";
            MainMusicNameAndNumber[12] = "中国人民解放军进行曲(铜管乐)";
            MainMusicNameAndNumber[13] = "中国少年先锋队队歌";
            MainMusicNameAndNumber[14] = "回家";
            MainMusicNameAndNumber[15] = "渔舟唱晚";
            MainMusicNameAndNumber[16] = "欢乐斗地主背景音乐";
            MainMusicNameAndNumber[17] = "最初的梦想";
            string[] LeaveSchoolNameAndNumber = new string[8];
            LeaveSchoolNameAndNumber[0] = "分列式进行曲";
            LeaveSchoolNameAndNumber[1] = "歌唱祖国";
            LeaveSchoolNameAndNumber[2] = "欢迎进行曲";
            LeaveSchoolNameAndNumber[3] = "拉德斯基进行曲";
            LeaveSchoolNameAndNumber[4] = "中国人民解放军进行曲(铜管乐)";
            LeaveSchoolNameAndNumber[5] = "回家";
            LeaveSchoolNameAndNumber[6] = "渔舟唱晚";
            LeaveSchoolNameAndNumber[7] = "最初的梦想";
            if ((AllMusic.CheckState == CheckState.Unchecked) && (MainMusic.CheckState == CheckState.Unchecked) && (LeaveSchool.CheckState == CheckState.Unchecked)) 
            {
                MessageBox.Show("You Must Choose a Mode.", "Worning");
                return;
            }
            if(AllMusic.CheckState == CheckState.Checked)
            {
                int musicnumber = Program.outmusic(54);
                NowMusicShow.Items.Clear();
                NowMusicShow.Items.Add(AllMusicNameAndNumber[musicnumber]);
                string pathbase1 = @"D:\MusicDocument\AllMusic\音乐 (";
                string pathbase2 = @").mp3";
                string numstr = musicnumber.ToString();
                Program.StartFile(pathbase1 + numstr + pathbase2);
                return;
            }
            else if (MainMusic.CheckState == CheckState.Checked)
            {
                int musicnumber = Program.outmusic(18);
                NowMusicShow.Items.Clear();
                NowMusicShow.Items.Add(MainMusicNameAndNumber[musicnumber]);
                string pathbase1 = @"D:\MusicDocument\MainMusic\音乐 (";
                string pathbase2 = @").mp3";
                string numstr = musicnumber.ToString();
                Program.StartFile(pathbase1 + numstr + pathbase2);
                return;
            }
            else
            {
                int musicnumber = Program.outmusic(8);
                NowMusicShow.Items.Clear();
                NowMusicShow.Items.Add(LeaveSchoolNameAndNumber[musicnumber]);
                string pathbase1 = @"D:\MusicDocument\LeaveSchool\音乐 (";
                string pathbase2 = @").mp3";
                string numstr = musicnumber.ToString();
                Program.StartFile(pathbase1 + numstr + pathbase2);
                return;
            }
        }

        private void Next_MouseHover(object sender, EventArgs e)
        {
            ToolTip p = new ToolTip();
            p.ShowAlways = true;
            p.SetToolTip(this.Next, "Click And Change A Music.");
        }

        private void Choose_MouseHover(object sender, EventArgs e)
        {
            ToolTip p = new ToolTip();
            p.ShowAlways = true;
            p.SetToolTip(this.Choose, "Click And Change A Designated Music.");
        }

        private void Choose_Click(object sender, EventArgs e)
        {
            new Password().Show();
        }

        private void AllMusic_CheckedChanged(object sender, EventArgs e)
        {
            if (MainMusic.CheckState == CheckState.Checked)
            {
                AllMusic.CheckState = CheckState.Unchecked;
            }
            if (LeaveSchool.CheckState == CheckState.Checked)
            {
                AllMusic.CheckState = CheckState.Unchecked;
            }
        }

        private void MainMusic_CheckedChanged(object sender, EventArgs e)
        {
            if (AllMusic.CheckState == CheckState.Checked)
            {
                MainMusic.CheckState = CheckState.Unchecked;
            }
            if (LeaveSchool.CheckState == CheckState.Checked)
            {
                MainMusic.CheckState = CheckState.Unchecked;
            }
        }

        private void LeaveSchool_CheckedChanged(object sender, EventArgs e)
        {
            if (MainMusic.CheckState == CheckState.Checked)
            {
                LeaveSchool.CheckState = CheckState.Unchecked;
            }
            if (AllMusic.CheckState == CheckState.Checked)
            {
                LeaveSchool.CheckState = CheckState.Unchecked;
            }
        }
    }
}
