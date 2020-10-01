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

        private void Form5_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "restoranDataSet1.Dish". При необходимости она может быть перемещена или удалена.
            this.dishTableAdapter.Fill(this.restoranDataSet1.Dish);

        }

        private void Button2_Click(object sender, EventArgs e)
        {
            int n = dataGridView1.CurrentRow.Index;
            Program.connect.Open();
            string s2 = "delete from Dish where id= "
                +dataGridView1[0,n].Value.ToString();

            SqlCommand sql2 = new SqlCommand(s2, Program.connect);
            sql2.ExecuteNonQuery();
            MessageBox.Show("Запись удалена");
            Program.connect.Close();
            

        }
    }
}
