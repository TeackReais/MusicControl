using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Diagnostics;

namespace MusicControl
{
    static class Program
    {
        /// <summary>
        /// 应用程序的主入口点。
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new MusicControl());
        }
        public static int outmusic(int number)
        {
            Random random = new Random();
            int outmusic;
            outmusic = random.Next(number);
            return outmusic;
        }
        public static void StartFile(string path)
        {
            Process.Start(path);
            return;
        }
    }
}
