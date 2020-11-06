using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp26
{
    public partial class Form8 : Form
    {
        public Form8()
        {
            InitializeComponent();
        }

        private void Form8_Shown(object sender, EventArgs e)
        {
            if (Program.login_user.Trim() != "")
            {
                label12.Visible = true;
                numericUpDown1.Visible = true;
                button1.Visible = true;
            }
        }
    }
}
