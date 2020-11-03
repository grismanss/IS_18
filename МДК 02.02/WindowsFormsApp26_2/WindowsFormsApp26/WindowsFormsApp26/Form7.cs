using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp26
{
    public partial class Form7 : Form
    {
        public int next = 0;
        public int countDish = 0;
        public int[] mass_id = new int[9];
        public Form7()
        {
            InitializeComponent();
        }

        private void Button2_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < 9; i++)
            {
                mass_id[i] = 0;
            }
            next = next + 9;
            if (next > countDish)
            {
                next= next - 9;
                button2.Enabled = false;
            }
            Load_dish(next);
            if (next >= 9)
            {
                
                button1.Enabled = true;
            }
        }

        private void Form7_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "restoranDataSet8.Categories". При необходимости она может быть перемещена или удалена.
            this.categoriesTableAdapter1.Fill(this.restoranDataSet8.Categories);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "restoranDataSet3.Categories". При необходимости она может быть перемещена или удалена.
           
            comboBox1.SelectedIndex = 0;
        }

        private void Button3_Click(object sender, EventArgs e)
        {
            Form1 f = new Form1();
            f.Show();
            this.Close();
        }
        public void Clear_Dish()
        {
            pictureBox4.Image = null;
            label4.Text = "";
            label3.Text = "";
            pictureBox2.Image = null;
            label2.Text = "";
            label1.Text = "";
            pictureBox3.Image = null;
            label5.Text = "";
            label6.Text = "";
            pictureBox1.Image = null;
            label7.Text = "";
            label8.Text = "";
            pictureBox12.Image = null;
            label10.Text = "";
            label9.Text = "";       
            pictureBox10.Image = null;
            label11.Text = "";
            label12.Text = "";
            pictureBox11.Image = null;
            label13.Text = "";
            label18.Text = "";
            pictureBox5.Image = null;
            label14.Text = "";
            label17.Text = "";
            pictureBox6.Image = null;
            label15.Text = "";
            label16.Text = "";
            //далее дописать!
        }
            public void Load_dish(int b)
            {
            Clear_Dish();
            if (comboBox1.SelectedValue != null)
            {
                string kateg = comboBox1.SelectedValue.ToString();
                string s = "select * from Dish where CategoriesID=" + kateg;
                Program.connect.Open();
                SqlCommand sql = new SqlCommand(s, Program.connect);
                SqlDataReader reader = sql.ExecuteReader();
                int k = 0;
                int n = 0;
                if (reader.HasRows)
                {
                    while (reader.Read())
                    {
                        n++;
                        if (n > b)
                        {
                            k++;
                            if (k == 1)
                            {
                                pictureBox4.Image = Image.FromFile(
                                    reader.GetValue(7).ToString());
                                label4.Text = reader.GetValue(1).ToString();
                                label3.Text = reader.GetValue(2).ToString();
                                mass_id[0] = Convert.ToInt32(reader.GetValue(0));
                            }
                            else if (k == 2)
                            {
                                pictureBox2.Image = Image.FromFile(
                                   reader.GetValue(7).ToString());
                                label2.Text = reader.GetValue(1).ToString();
                                label1.Text = reader.GetValue(2).ToString();
                                mass_id[1] = Convert.ToInt32(reader.GetValue(0));
                            }
                            else if (k == 3)
                            {
                                pictureBox3.Image = Image.FromFile(
                                   reader.GetValue(7).ToString());
                                label5.Text = reader.GetValue(1).ToString();
                                label6.Text = reader.GetValue(2).ToString();
                                mass_id[2] = Convert.ToInt32(reader.GetValue(0));
                            }
                            else if (k == 4)
                            {
                                pictureBox1.Image = Image.FromFile(
                                   reader.GetValue(7).ToString());
                                label7.Text = reader.GetValue(1).ToString();
                                label8.Text = reader.GetValue(2).ToString();
                                mass_id[3] = Convert.ToInt32(reader.GetValue(0));
                            }
                            else if (k == 5)
                            {
                                pictureBox12.Image = Image.FromFile(
                                    reader.GetValue(7).ToString());
                                label10.Text = reader.GetValue(1).ToString();
                                label9.Text = reader.GetValue(2).ToString();
                                mass_id[4] = Convert.ToInt32(reader.GetValue(0));
                            }
                            else if (k == 6)
                            {
                                pictureBox10.Image = Image.FromFile(
                                   reader.GetValue(7).ToString());
                                label11.Text = reader.GetValue(1).ToString();
                                label12.Text = reader.GetValue(2).ToString();
                                mass_id[5] = Convert.ToInt32(reader.GetValue(0));
                            }
                            else if (k == 7)
                            {
                                pictureBox11.Image = Image.FromFile(
                                   reader.GetValue(7).ToString());
                                label13.Text = reader.GetValue(1).ToString();
                                label18.Text = reader.GetValue(2).ToString();
                                mass_id[6] = Convert.ToInt32(reader.GetValue(0));
                            }
                            else if (k == 8)
                            {
                                pictureBox5.Image = Image.FromFile(
                                   reader.GetValue(7).ToString());
                                label14.Text = reader.GetValue(1).ToString();
                                label17.Text = reader.GetValue(2).ToString();
                                mass_id[7] = Convert.ToInt32(reader.GetValue(0));
                            }

                            else if (k == 9)
                            {
                                pictureBox6.Image = Image.FromFile(
                                   reader.GetValue(7).ToString());
                                label15.Text = reader.GetValue(1).ToString();
                                label16.Text = reader.GetValue(2).ToString();
                                mass_id[8] = Convert.ToInt32(reader.GetValue(0));
                            }
                        }
                        /*ДОПИСАТЬ ДО 9ти*/
                        if (b == 0)
                        {
                            countDish = n;
                        }
                    }
                }
                Program.connect.Close();
            }
        }

        private void Form7_Shown(object sender, EventArgs e)
        {
            Load_dish(0);
        }

        private void ComboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            Load_dish(0);
        }

        private void Form7_FormClosing(object sender, FormClosingEventArgs e)
        {

        }

        private void Button1_Click(object sender, EventArgs e)
        {
            for (int i=0; i<9; i++)
            {
                mass_id[i] = 0;
            }
            next = next - 9;
            if (next <= 0)
            {
                next = 0;
                button1.Enabled = false;
            }
            if (next < countDish)
            {

                button2.Enabled = true;
            }

            Load_dish(next);

        }

        private void pictureBox4_Click(object sender, EventArgs e)
        {
            Form8 f = new Form8();
            string s = "select * from Dish where id=" + mass_id[0];
            Program.connect.Open();
            SqlCommand sql = new SqlCommand(s, Program.connect);
            SqlDataReader reader = sql.ExecuteReader();
            reader.Read();
            f.pictureBox1.Image= Image.FromFile(reader.GetValue(7).ToString());
            f.label2.Text = reader.GetValue(1).ToString();
            f.Text= reader.GetValue(1).ToString();
            f.label3.Text = reader.GetValue(2).ToString();
            f.label5.Text = reader.GetValue(3).ToString();
            f.textBox1.Text= reader.GetValue(4).ToString();
            f.label7.Text = reader.GetValue(5).ToString();
            string id_kat= reader.GetValue(6).ToString();
            Program.connect.Close();

            string s1 = "select * from Categories where id=" + id_kat;
            Program.connect.Open();
            SqlCommand sql1 = new SqlCommand(s1, Program.connect);
            SqlDataReader reader1 = sql1.ExecuteReader();
            reader1.Read();
            f.label10.Text = reader1.GetValue(1).ToString();
            Program.connect.Close();
            f.Show();
        }
    }
}
