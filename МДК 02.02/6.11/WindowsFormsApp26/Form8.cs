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

        private void button1_Click(object sender, EventArgs e)
        {
            
            int id = Convert.ToInt32(label13.Text);
            int count = Convert.ToInt32(numericUpDown1.Value);
            string name = label2.Text.Trim();
            int price = Convert.ToInt32(label3.Text.Trim());
            Program.korzina[Program.korzina.Length - 1].id = id;
            Program.korzina[Program.korzina.Length - 1].count = count;
            Program.korzina[Program.korzina.Length - 1].name = name;
            Program.korzina[Program.korzina.Length - 1].price = price;
            Array.Resize(ref Program.korzina, Program.korzina.Length + 1);
            MessageBox.Show("Добавление в корзину произведено");
            this.Close();
        }

        private void Form8_Load(object sender, EventArgs e)
        {

        }
    }
}
