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
    public partial class Form12 : Form
    {
        public Form12()
        {
            InitializeComponent();
        }

        private void Form12_Load(object sender, EventArgs e)
        {
            
            string s1 = "select id, Name, LastName, SurName  from Users where Phone='" + Program.login_user + "'";
            Program.connect.Open();
            SqlCommand sql1 = new SqlCommand(s1, Program.connect);
            SqlDataReader reader1 = sql1.ExecuteReader();
            reader1.Read();
            string user_id = reader1.GetValue(0).ToString();

            string n = reader1.GetValue(1).ToString().Trim();
            string s = reader1.GetValue(2).ToString().Trim();
            string l = reader1.GetValue(3).ToString().Trim();

            this.Text = n + " " + s + " " + l;

            Program.connect.Close();

            string s2 = "select * from AllOrders where UserID=" + user_id;
            Program.connect.Open();
            SqlCommand sql2 = new SqlCommand(s2, Program.connect);
            SqlDataReader reader2 = sql2.ExecuteReader();
            while(reader2.Read()){
                string[] str = new string[4];
                str[0] = reader2.GetValue(0).ToString().Trim();
                str[1] = reader2.GetValue(1).ToString().Trim();
                str[2] = reader2.GetValue(3).ToString().Trim();
                if (Convert.ToBoolean(reader2.GetValue(4).ToString().Trim())==true)
                    str[3] ="C Собой";
                else
                {
                    str[3] = "В зале";
                }
                dataGridView1.Rows.Add(str);
            }
            Program.connect.Close();
            LoadData();
        }

        void LoadData()
        {
            dataGridView2.RowCount = 0;
            if (dataGridView1.CurrentRow != null)
            {
                int k = dataGridView1.CurrentRow.Index;
                string id_zakaz = "";
                if (dataGridView1[0, k].Value != null)
                {
                    id_zakaz = dataGridView1[0, k].Value.ToString();
                }
                if (id_zakaz.Trim() != "")
                {
                    string s = "select * from Orders inner join Dish on Orders.DishID = Dish.id " +
                        "where Orders.AllOrdersID = " + id_zakaz;
                    Program.connect.Open();
                    SqlCommand sql = new SqlCommand(s, Program.connect);
                    SqlDataReader reader = sql.ExecuteReader();
                    
                    while (reader.Read())
                    {
                        string[] str = new string[5];
                        str[0] = reader.GetValue(5).ToString().Trim();
                        str[1] = reader.GetValue(2).ToString().Trim();
                        str[2] = reader.GetValue(6).ToString().Trim();
                        str[3] = reader.GetValue(7).ToString().Trim();
                        str[4] = reader.GetValue(9).ToString().Trim();
                        dataGridView2.Rows.Add(str);
                    }
                    Program.connect.Close();
                }
            }
        }
        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            LoadData();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void dataGridView2_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
