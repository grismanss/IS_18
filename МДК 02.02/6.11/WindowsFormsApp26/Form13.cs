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
    public partial class Form13 : Form
    {
        public Form13()
        {
            InitializeComponent();
        }

        private void Form13_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "restoranDataSet10.Users". При необходимости она может быть перемещена или удалена.
            this.usersTableAdapter.Fill(this.restoranDataSet10.Users);

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
        void LoadData()
        {
            dataGridView2.RowCount = 0;
            if (dataGridView1.CurrentRow != null)
            {
                int k = dataGridView1.CurrentRow.Index;
                string id_user = "";
                if (dataGridView1[0, k].Value != null)
                {
                    id_user = dataGridView1[0, k].Value.ToString();
                }
                if (id_user.Trim() != "")
                {
                    string s = "select * from AllOrders where UserID=" + id_user;
                    Program.connect.Open();
                    System.Data.SqlClient.SqlCommand sql = new SqlCommand(s, Program.connect);
                    SqlDataReader reader = sql.ExecuteReader();

                    while (reader.Read())
                    {
                        string[] str = new string[4];
                        str[0] = reader.GetValue(0).ToString().Trim();
                        str[1] = reader.GetValue(1).ToString().Trim();
                        str[2] = reader.GetValue(3).ToString().Trim();
                        if (Convert.ToBoolean(reader.GetValue(4)) == true)
                        {
                            str[3] = "В зале";
                        }
                        else
                        {
                            str[3] = "С собой";
                        }
                        //str[3] = reader.GetValue(4).ToString().Trim();                       
                        dataGridView2.Rows.Add(str);
                    }
                    Program.connect.Close();
                }
            }
        }
        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            LoadData();
            LoadData2();
        }

        void LoadData2()
        {
            dataGridView3.RowCount = 0;
            if (dataGridView2.CurrentRow != null)
            {
                int k = dataGridView2.CurrentRow.Index;
                string id_order = "";
                if (dataGridView2[0, k].Value != null)
                {
                    id_order = dataGridView2[0, k].Value.ToString();
                }
                if (id_order.Trim() != "")
                {
                    string s = "select * from Orders inner join Dish on Orders.DishID = Dish.id " +
                        "where Orders.AllOrdersID =" + id_order;
                    Program.connect.Open();
                    System.Data.SqlClient.SqlCommand sql = new SqlCommand(s, Program.connect);
                    SqlDataReader reader = sql.ExecuteReader();

                    while (reader.Read())
                    {
                        string[] str = new string[5];
                        str[0] = reader.GetValue(5).ToString().Trim();
                        str[1] = reader.GetValue(2).ToString().Trim();
                        str[2] = reader.GetValue(6).ToString().Trim();
                        str[3] = reader.GetValue(7).ToString().Trim();
                        str[4] = reader.GetValue(9).ToString().Trim();
                        dataGridView3.Rows.Add(str);
                    }
                    Program.connect.Close();
                }
            }
        }

        private void dataGridView2_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            LoadData2();
        }
    }
}
