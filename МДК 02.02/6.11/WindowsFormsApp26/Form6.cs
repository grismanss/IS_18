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

namespace WindowsFormsApp26
{
    public partial class Form6 : Form
    {
        public Form6()
        {
            InitializeComponent();
        }

        private void Form6_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "restoranDataSet7.Categories". При необходимости она может быть перемещена или удалена.
            //this.categoriesTableAdapter.Fill(this.restoranDataSet7.Categories);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "restoranDataSet6.Categories". При необходимости она может быть перемещена или удалена.
              this.categoriesTableAdapter1.Fill(this.restoranDataSet6.Categories);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "restoranDataSet2.Categories". При необходимости она может быть перемещена или удалена.
            /*this.categoriesTableAdapter.Fill
                (this.restoranDataSet2.Categories);

            comboBox1.SelectedIndex = 0;*/
        }

        private void Button2_Click(object sender, EventArgs e)
        {

        }

        private void Button1_Click(object sender, EventArgs e)
        {
            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                //получаем полный путь до файла, который выбрали
                string path = openFileDialog1.FileName;
                //помещаем данный файл в FIleINFO
                FileInfo fileInf = new FileInfo(path);
                //получаем имя файла с форматом
                string file_name = fileInf.Name;
                //формируем новый путь до файла вместе с наименованием
                string newPath = Environment.CurrentDirectory+"/" +file_name;
                //копируем файл
                fileInf.CopyTo(newPath, true);
                pictureBox1.Image =
                    Image.FromFile(newPath);
              

                label8.Text = file_name;
            }
        }

        private void ComboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void Label8_Click(object sender, EventArgs e)
        {

        }

        private void Button3_Click(object sender, EventArgs e)
        {

        }

        private void Label7_Click(object sender, EventArgs e)
        {

        }

        private void PictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void Label6_Click(object sender, EventArgs e)
        {

        }

        private void NumericUpDown3_ValueChanged(object sender, EventArgs e)
        {

        }

        private void Label4_Click(object sender, EventArgs e)
        {

        }

        private void Label5_Click(object sender, EventArgs e)
        {

        }

        private void TextBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void NumericUpDown2_ValueChanged(object sender, EventArgs e)
        {

        }

        private void Label3_Click(object sender, EventArgs e)
        {

        }

        private void NumericUpDown1_ValueChanged(object sender, EventArgs e)
        {

        }

        private void Label2_Click(object sender, EventArgs e)
        {

        }

        private void Label1_Click(object sender, EventArgs e)
        {

        }

        private void TextBox1_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
