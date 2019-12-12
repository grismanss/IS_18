using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp24
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();

            textBox3.Visible = false;
            label3.Visible = false;

            textBox2.Visible = true;
            label2.Visible = true;
        }

        private void Label3_Click(object sender, EventArgs e)
        {

        }

        private void RadioButton1_CheckedChanged(object sender, EventArgs e)
        {
            textBox3.Visible = false;
            label3.Visible = false;

            textBox2.Visible = true;
            label2.Visible = true;
        }

        private void RadioButton2_CheckedChanged(object sender, EventArgs e)
        {
            textBox3.Visible = true;
            label3.Visible = true;

            textBox2.Visible = true;
            label2.Visible = true;
        }

        private void RadioButton3_CheckedChanged(object sender, EventArgs e)
        {
            textBox3.Visible = true;
            label3.Visible = true;

            textBox2.Visible = false;
            label2.Visible = false;
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            double s = Convert.ToDouble(textBox1.Text);
            if (radioButton1.Checked)
            {
                double v = Convert.ToDouble(textBox2.Text);
                Ozero o = new Ozero(v, s);
                listBox1.Items.Add(o);
            }
            else if (radioButton2.Checked)
            {
                double v = Convert.ToDouble(textBox2.Text);
                double w = Convert.ToDouble(textBox3.Text);
                Reka r = new Reka(v, w, s);
                listBox1.Items.Add(r);
            }
            else
            {
                double w = Convert.ToDouble(textBox3.Text);
                Samosplav ss= new Samosplav(w, s);
                listBox1.Items.Add(ss);
            }
        }

        private void ListBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (listBox1.SelectedIndex > -1)
            {
                if (listBox1.SelectedItem is Ozero)
                {
                    Ozero o = listBox1.SelectedItem as Ozero;
                    label4.Text ="T="+ o.Calc().ToString();
                }
                else if (listBox1.SelectedItem is Reka)
                {
                    Reka o = listBox1.SelectedItem as Reka;
                    label4.Text = "T=" + o.Calc().ToString();
                }
                else
                {
                    Samosplav o = listBox1.SelectedItem as Samosplav;
                    label4.Text = "T=" + o.Calc().ToString();
                }
            }
        }

        private void Button2_Click(object sender, EventArgs e)
        {
            if (listBox1.SelectedIndex > -1)
            {
                listBox1.Items.RemoveAt(listBox1.SelectedIndex);
            }
        }

    }
}
