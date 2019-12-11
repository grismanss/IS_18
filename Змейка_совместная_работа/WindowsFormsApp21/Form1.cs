using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp21
{
    public partial class Form1 : Form
    {
        Game test;
        public Form1()
        {
            InitializeComponent();
            pictureBox1.Image = new Bitmap(pictureBox1.Width, 
                pictureBox1.Height);
        }

        private void PictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void Button5_Click(object sender, EventArgs e)
        {
            test = new Game(pictureBox1);
            test.Show();

        }

        private void Button1_Click(object sender, EventArgs e)
        {
            if (test.Move(1) == false)
            {
                MessageBox.Show("Конец игры!");
            }
            label1.Text = test.count.ToString();
        }

        private void Button2_Click(object sender, EventArgs e)
        {
            if (test.Move(2) == false)
            {
                MessageBox.Show("Конец игры!");
            }
            label1.Text = test.count.ToString();

        }

        private void Button3_Click(object sender, EventArgs e)
        {
            if (test.Move(3) == false)
            {
                MessageBox.Show("Конец игры!");
            }
            label1.Text = test.count.ToString();
        }

        private void Button4_Click(object sender, EventArgs e)
        {
            if (test.Move(4) == false)
            {
                MessageBox.Show("Конец игры!");
            }
            label1.Text = test.count.ToString();
        }
    }
}
