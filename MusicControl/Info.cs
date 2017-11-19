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
    public partial class Info : Form
    {
        public Info()
        {
            InitializeComponent();
            Cr.Text = Application.CompanyName;
            Co.Text = Application.CompanyName;
            Ve.Text = Application.ProductVersion;
        }
    }
}
