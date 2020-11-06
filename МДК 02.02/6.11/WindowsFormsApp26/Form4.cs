using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp26
{
    public partial class Form4 : Form
    {
        public Form4()
        {
            InitializeComponent();
        }

        private void Form4_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "restoranDataSet4.Categories". При необходимости она может быть перемещена или удалена.
            this.categoriesTableAdapter1.Fill(this.restoranDataSet4.Categories);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "restoranDataSet.Categories". При необходимости она может быть перемещена или удалена.
          //  this.categoriesTableAdapter.Fill(this.restoranDataSet.Categories);

        }

        private void Button1_Click(object sender, EventArgs e)
        {
            this.Close();
            Form3 f = new Form3();
            f.Show();
        }

        private void ToolStripButton1_Click(object sender, EventArgs e)
        {
            this.categoriesTableAdapter1.Update
                (this.restoranDataSet4.Categories);

            this.categoriesTableAdapter1.Fill
                (this.restoranDataSet4.Categories);
        }

        private void categoriesBindingSource_CurrentChanged(object sender, EventArgs e)
        {

        }
    }
}
