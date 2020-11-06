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
    public partial class Form5 : Form
    {
        public Form5()
        {
            InitializeComponent();
        }

        public void load()
        {
            this.dishTableAdapter1.Fill(this.restoranDataSet5.Dish);
            for (int i = 0; i < dataGridView1.RowCount; i++)
            {
                int k = Convert.ToInt32(dataGridView1[6, i].Value);
                string s = "select * from Categories where id=" + k;
                Program.connect.Open();
                SqlCommand sql = new SqlCommand(s, Program.connect);
                SqlDataReader reader = sql.ExecuteReader();
                reader.Read();
                string ss = reader.GetValue(1).ToString();
                dataGridView1[8, i].Value
                   = reader.GetValue(1).ToString();
                dataGridView1.Columns[8].Width = 200;

                Program.connect.Close();
            }
        }
        private void Form5_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "restoranDataSet5.Dish". При необходимости она может быть перемещена или удалена.
          //  this.dishTableAdapter1.Fill(this.restoranDataSet5.Dish);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "restoranDataSet1.Dish". При необходимости она может быть перемещена или удалена.
            /*this.dishTableAdapter.Fill(this.restoranDataSet1.Dish);
            for (int i=0; i<dataGridView1.RowCount; i++)
            {
                int k = Convert.ToInt32(dataGridView1[6, i].Value);
                string s = "select * from Categories where id="+ k;
                Program.connect.Open();
                SqlCommand sql = new SqlCommand(s, Program.connect);
                SqlDataReader reader = sql.ExecuteReader();
                reader.Read();
                string ss= reader.GetValue(1).ToString();
                dataGridView1[8, i].Value
                   = reader.GetValue(1).ToString();
                dataGridView1.Columns[8].Width = 200;

                Program.connect.Close();
            }*/
            load();
        }

        private void Button2_Click(object sender, EventArgs e)
        {
            if (dataGridView1.CurrentRow != null)
            {
                DialogResult r = MessageBox.Show("Точно удалить запись?","",
                    MessageBoxButtons.YesNo);
                if (r == DialogResult.Yes)
                {
                    int n = dataGridView1.CurrentRow.Index;
                    Program.connect.Open();
                    string s2 = "delete from Dish where id= "
                        + dataGridView1[0, n].Value.ToString();

                    SqlCommand sql2 = new SqlCommand(s2, Program.connect);
                    sql2.ExecuteNonQuery();
                    MessageBox.Show("Запись удалена");
                    Program.connect.Close();
                    load();
                }
            }
            else
            {
                MessageBox.Show("Не выбраны данные для удаления!");
            }

        }

        private void Button1_Click(object sender, EventArgs e)
        {
            Form6 f = new Form6();
            f.Text = "Добавление";

            f.categoriesTableAdapter1.Fill
               (f.restoranDataSet6.Categories);
            f.comboBox1.SelectedIndex = 0;

            if (f.ShowDialog() == DialogResult.OK)
            {
                string nam = f.textBox1.Text.Trim();
                string stoim =f.numericUpDown1.Value.ToString();
                string kkall = f.numericUpDown2.Value.ToString();
                string sosta = f.textBox2.Text.Trim();
                string ves = f.numericUpDown3.Value.ToString();
                string kateg = f.comboBox1.SelectedValue.ToString();
                string foto = f.label8.Text;

               

                

                string s = "insert into Dish(Name,Price, Calorie,Sostav," +
                    "Ves,CategoriesID, Photo) " +
                    "values('" + nam + "'," + stoim +
                    "," + kkall + ",'" +
                    sosta + "'," + ves + "," + kateg + ",'" + foto + "')";
                Program.connect.Open();
                SqlCommand sql = new SqlCommand(s, Program.connect);
                sql.ExecuteNonQuery();
                Program.connect.Close();
                load();
                MessageBox.Show("Запись добавлена!");
            }
        }

        private void Button3_Click(object sender, EventArgs e)
        {
            if (dataGridView1.CurrentRow != null)
            {
                int n = dataGridView1.CurrentRow.Index;

                string s="select * from Dish where id="+ 
                    dataGridView1[0, n].Value.ToString();
                Program.connect.Open();
                SqlCommand sql = new SqlCommand(s, Program.connect);
                SqlDataReader reader = sql.ExecuteReader();
                reader.Read();


                Form6 f = new Form6();
                f.textBox1.Text = reader.GetValue(1).ToString();
                f.numericUpDown1.Value= Convert.ToInt32(reader.GetValue(2));
                f.numericUpDown2.Value = Convert.ToInt32(reader.GetValue(3));
                f.textBox2.Text = reader.GetValue(4).ToString();
                f.numericUpDown3.Value = Convert.ToInt32(reader.GetValue(5));
                //Поправить соответсиве
                f.comboBox1.SelectedValue= Convert.ToInt32(reader.GetValue(6));
                
                f.pictureBox1.Image=  
                    Image.FromFile(reader.GetValue(7).ToString());
                f.label8.Text = reader.GetValue(7).ToString();
                f.Text = "Редактирование";

                f.categoriesTableAdapter1.Fill
                (f.restoranDataSet6.Categories);//!!!!!
               
                f.comboBox1.SelectedValue =
                    Convert.ToInt32(reader.GetValue(6));


                if (f.ShowDialog() == DialogResult.OK)
                {
                    Program.connect.Close();
                    Program.connect.Open();
                    string nam = f.textBox1.Text.Trim();
                    string stoim = f.numericUpDown1.Value.ToString();
                    string kkall = f.numericUpDown2.Value.ToString();
                    string sosta = f.textBox2.Text.Trim();
                    string ves = f.numericUpDown3.Value.ToString();
                    string kateg = f.comboBox1.SelectedValue.ToString();
                    string foto = f.label8.Text;
                    string s2 = "update Dish set Name='"+ nam + "'" +
                        " ,Price="+ stoim + ", Calorie="+ kkall +
                        " ,Sostav='"+ sosta
                        + "'," +
                        "Ves="+ ves + ",CategoriesID="+ kateg 
                        + ", Photo='"+ foto + "' where id= " 
                        + dataGridView1[0, n].Value.ToString();
                                       
                    SqlCommand sql2 = new SqlCommand(s2, Program.connect);
                    sql2.ExecuteNonQuery();
                    Program.connect.Close();
                    load();
                    MessageBox.Show("Запись отредактирована!");

                }
                Program.connect.Close();

            }
            else
            {
                MessageBox.Show("Не выбран обьект для удаления");
            }
        }
    }
}
