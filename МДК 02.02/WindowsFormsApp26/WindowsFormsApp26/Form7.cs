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
        public Form7()
        {
            InitializeComponent();
        }

        private void Button2_Click(object sender, EventArgs e)
        {

        }

        private void Form7_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "restoranDataSet3.Categories". При необходимости она может быть перемещена или удалена.
            this.categoriesTableAdapter.Fill(
                this.restoranDataSet3.Categories);
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
            //далее дописать!
        }
            public void Load_dish()
        {
            Clear_Dish();
            string kateg = comboBox1.SelectedValue.ToString();
            string s = "select * from Dish where CategoriesID=" + kateg;
            Program.connect.Open();
            SqlCommand sql = new SqlCommand(s, Program.connect);
            SqlDataReader reader = sql.ExecuteReader();
            int k = 0;
            if (reader.HasRows)
            {
                reader.Read();
                k++;
                if (k == 1)
                {
                    pictureBox4.Image = Image.FromFile(
                        reader.GetValue(7).ToString());
                    label4.Text = reader.GetValue(1).ToString();
                    label3.Text = reader.GetValue(2).ToString();
                }
                else if (k == 2)
                {
                    pictureBox2.Image = Image.FromFile(
                       reader.GetValue(7).ToString());
                    label2.Text = reader.GetValue(1).ToString();
                    label1.Text = reader.GetValue(2).ToString();
                }
                else if (k == 3)
                {
                    pictureBox3.Image = Image.FromFile(
                       reader.GetValue(7).ToString());
                    label5.Text = reader.GetValue(1).ToString();
                    label6.Text = reader.GetValue(2).ToString();
                }
                /*ДОПИСАТЬ ДО 9ти*/
            }
            Program.connect.Close();
        }

        private void Form7_Shown(object sender, EventArgs e)
        {
            Load_dish();
        }

        private void ComboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            Load_dish();
        }

        private void Form7_FormClosing(object sender, FormClosingEventArgs e)
        {

        }
    }
}
