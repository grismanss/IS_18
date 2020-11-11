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
    public partial class Form9 : Form
    {
        public Form9()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Form7 f = new Form7();
            f.Show();
            this.Close();
        }

        private void сменитьПарольToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form10 f = new Form10();
            if (f.ShowDialog() == DialogResult.OK)
            {
                string s = "select Password from Users where Phone='"
                    + Program.login_user + "'";
                Program.connect.Open();
                SqlCommand sql2 = new SqlCommand(s, Program.connect);
                SqlDataReader reader = sql2.ExecuteReader();
                reader.Read();
                string old_pass = reader.GetValue(0).ToString().Trim();
                Program.connect.Close();
                if (old_pass != f.textBox1.Text.Trim())
                {
                    MessageBox.Show("Старый пароль введен неверно!");
                }
                else
                {
                    if (f.textBox2.Text.Trim() != f.textBox3.Text.Trim())
                    {
                        MessageBox.Show("Пароли не совпадают!");
                    }
                    else
                    {
                        string s2 = "update Users set Password='"+ f.textBox2.Text.Trim() 
                            + "' where Phone='"+Program.login_user+"'";
                        Program.connect.Open();
                        SqlCommand sql3 = new SqlCommand(s2, Program.connect);
                        sql3.ExecuteNonQuery();
                        Program.connect.Close();
                        MessageBox.Show("Пароль изменен!");
                        Program.login_user = "";
                        this.Close();
                        Form1 f2 = new Form1();
                        f2.Show();
                    }
                }


            }
        }

        private void Form9_Load(object sender, EventArgs e)
        {
            string s1 = "select * from Users where Phone='" + Program.login_user + "'";
            Program.connect.Open();
            SqlCommand sql1 = new SqlCommand(s1, Program.connect);
            SqlDataReader reader1 = sql1.ExecuteReader();
            reader1.Read();

           //Form9 f = new Form9();
            label2.Text = reader1.GetValue(2).ToString().Trim() + " "
                + reader1.GetValue(3).ToString().Trim() + " "
                + reader1.GetValue(4).ToString().Trim();

            label3.Text = reader1.GetValue(1).ToString();

            label5.Text = reader1.GetValue(5).ToString();
            label9.Text= reader1.GetValue(0).ToString();
            // f.Show();
            Program.connect.Close();

            if (Program.korzina.Length > 1)
            {
                dataGridView1.RowCount = Program.korzina.Length - 1;
                int summ = 0;
                for (int i = 0; i < Program.korzina.Length-1; i++)
                {
                    dataGridView1[0, i].Value = Program.korzina[i].id;
                    dataGridView1[1, i].Value = Program.korzina[i].name;
                    dataGridView1[2, i].Value = Program.korzina[i].count;
                    dataGridView1[3, i].Value = Program.korzina[i].price;
                    dataGridView1[4, i].Value = Program.korzina[i].price * Program.korzina[i].count;
                    summ += Program.korzina[i].price * Program.korzina[i].count;
                }
                label8.Text = summ.ToString();
            }
        }

        private void выходToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Program.login_user = "";
            this.Close();
            Form1 f = new Form1();
            f.Show();
        }

        private void редактироватьДанныеToolStripMenuItem_Click(object sender, EventArgs e)
        {
            string s1 = "select * from Users where Phone='" + Program.login_user + "'";
            Program.connect.Open();
            SqlCommand sql1 = new SqlCommand(s1, Program.connect);
            SqlDataReader reader1 = sql1.ExecuteReader();
            reader1.Read();

            Form11 f = new Form11();
            f.textBox4.Text = reader1.GetValue(3).ToString().Trim();
            f.textBox5.Text = reader1.GetValue(2).ToString().Trim();
            f.textBox6.Text = reader1.GetValue(4).ToString().Trim();
            f.maskedTextBox1.Text= reader1.GetValue(1).ToString().Trim();
            f.textBox1.Text = reader1.GetValue(5).ToString().Trim();           
    
            Program.connect.Close();
            if (f.ShowDialog() == DialogResult.OK)
            {
                string s3 = "select * from Users where Phone='" + f.maskedTextBox1.Text.Trim() + "'";
                Program.connect.Open();
                SqlCommand sql3 = new SqlCommand(s3, Program.connect);
                SqlDataReader reader = sql3.ExecuteReader();
               
                if (reader.HasRows && f.maskedTextBox1.Text.Trim() != Program.login_user)
                {
                    MessageBox.Show("Данный номер телефона уже имеется в БД");
                    Program.connect.Close();
                }

                else
                {
                     Program.connect.Close();                  

                    string s = "update Users set Name='" + f.textBox5.Text.Trim()
                    + "', SurName='" + f.textBox4.Text.Trim()
                    + "', LastName='" + f.textBox6.Text.Trim() + "', " +
                    "Email='" + f.textBox1.Text.Trim() + "', Phone='" +
                    f.maskedTextBox1.Text.Trim() +
                    "' where Phone='" + Program.login_user + "'";
                    Program.connect.Open();
                    SqlCommand sql = new SqlCommand(s, Program.connect);
                    sql.ExecuteNonQuery();
                    Program.connect.Close();
                    MessageBox.Show("Изменения сохранены!");
                }

            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            DateTime d = DateTime.Now;
            string ds = d.ToString("yyyy-MM-dd");
            int k = 0;
            if (radioButton2.Checked)
            {
                k = 1;
            }
            string s = "insert into AllOrders (Date,UserID,Sum, Mesto) values('"+ ds 
                + "'," + label9.Text + "," + label8.Text + ","+k+");";
            Program.connect.Open();
            SqlCommand sql = new SqlCommand(s, Program.connect);
            sql.ExecuteNonQuery();
            Program.connect.Close();



            string s1 = "select id from AllOrders order by id desc";
            Program.connect.Open();
            SqlCommand sql1 = new SqlCommand(s1, Program.connect);
            SqlDataReader reader1 = sql1.ExecuteReader();
            reader1.Read();
            string id_allOrder= reader1.GetValue(0).ToString();          
            Program.connect.Close();


            for (int i=0; i<Program.korzina.Length-1; i++)
            {
                string s3 = "insert into Orders (DishID, Kol_vo,AllOrdersID)" +
                    " values("+ Program.korzina[i].id
                    + ","+
                   Program.korzina[i].count + ","+
                  id_allOrder + ")";
                Program.connect.Open();
                SqlCommand sql3 = new SqlCommand(s3, Program.connect);
                sql3.ExecuteNonQuery();
                Program.connect.Close();
            }

            Array.Clear(Program.korzina, 0, Program.korzina.Length);
            Array.Resize(ref Program.korzina, 1);
            dataGridView1.RowCount = 1;
            dataGridView1[0, 0].Value = "";
            dataGridView1[1, 0].Value = "";
            dataGridView1[2, 0].Value = "";
            dataGridView1[3, 0].Value = "";
            dataGridView1[4, 0].Value = "";

            MessageBox.Show("Заказ оформлен, номер заказа " + id_allOrder);
        }

        private void историяЗаказовToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form12 f = new Form12();
            f.Show();
        }
    }
}
