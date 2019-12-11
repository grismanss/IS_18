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

namespace SnakeWinForm
{
    public partial class Form1 : Form
    {
        Place test;
        public Form1()
        {
            InitializeComponent();
            //pictureBox1.Image = new Bitmap(pictureBox1.Width, pictureBox1.Height);
            //this.KeyDown += new KeyEventHandler(SnakeMove);
           
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            pictureBox1.Image = new Bitmap(pictureBox1.Width, pictureBox1.Height);
             test = new Place(pictureBox1);
            test.Show();
            
        }

        private void button3_Click(object sender, EventArgs e)
        {
            test.Move(1);
        }

        private void button4_Click(object sender, EventArgs e)
        {
            test.Move(3);
        }

        private void button5_Click(object sender, EventArgs e)
        {
            test.Move(4);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            test.Move(2);
        }

        private void button1_KeyDown(object sender, KeyEventArgs e)
        {
            bool a = true;
            if (e.KeyCode == Keys.A)
            {
                a = test.Move(3);
            }
            else if(e.KeyCode == Keys.D)
            {
                a = test.Move(4);
            }
            else if(e.KeyCode == Keys.W)
            {
                a = test.Move(1);
            }
            else if (e.KeyCode == Keys.S)
            {
               a = test.Move(2);
            }
            if (a == false)
            {
                MessageBox.Show("Game Over");
                test = null;
                test = new Place(pictureBox1);
                test.Show();
            }
            label1.Text = test.Schet.ToString(); 
        }

        private void PictureBox1_Click(object sender, EventArgs e)
        {

        }
        /*public void SnakeMove(object sender, KeyEventArgs e)
{

MessageBox.Show(e.KeyCode.ToString());
}*/
    }
}
