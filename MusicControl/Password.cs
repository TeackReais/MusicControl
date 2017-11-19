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
    public partial class Password : Form
    {
        public Password()
        {
            InitializeComponent();
            PasswordText.PasswordChar = '*';
            Passwordwrong.Text = "";
        }
        private void Reset_Click(object sender, EventArgs e)
        {
            PasswordText.Clear();
            return;
        }

        private void Confirm_Click(object sender, EventArgs e)
        {
            string Password = PasswordText.Text;
            string RightPassword = "yinyueadmin";
            if (Password == RightPassword)
            {
                PasswordText.Clear();
                new ChooseMusic().Show();
                this.Close();
            }
            else
            {
                PasswordText.Clear();
                Passwordwrong.Text = "Your Password is " + Password + ".It is Wrong!";
            }
        }
    }
}
