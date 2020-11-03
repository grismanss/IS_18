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
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void Form2_Load(object sender, EventArgs e)
        {

        }

        private void Form2_FormClosed(object sender, FormClosedEventArgs e)
        {

        }

        private void Form2_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (this.DialogResult == DialogResult.OK)
            {
                int k = 0;
                try
                {
                    
                    if (textBox4.Text.Trim() == "")
                    {
                        throw new Exception
                            ("Фамилия не может быть пустой!");
                    }
                    k++;
                    if(textBox5.Text.Trim() == "")
                    {
                        throw new Exception
                           ("Имя не может быть пустым!");
                    }
                    k++;
                     if(textBox6.Text.Trim() == "")
                    {
                        throw new Exception
                           ("Отчество не может быть пустым!");
                    }
                    k++;
                     if (maskedTextBox1.Text.Trim() == "")
                    {
                        throw new Exception
                          ("Телефон не может быть пустым!");
                    }
                    k++;
                     if (textBox1.Text.Trim() == "")
                    {
                        throw new Exception
                          ("Email не может быть пустым!");
                    }
                    k++;
                     if (textBox2.Text.Trim() == "")
                    {
                        throw new Exception
                          ("Пароль не может быть пустым!");
                    }
                    k++;
                     if (textBox3.Text.Trim() == "")
                    {
                        throw new Exception
                          ("Подтвердите пароль!");
                    }

                    if (textBox2.Text.Trim() != textBox3.Text.Trim())
                    {
                        throw new Exception("Пароли не совпадают");
                    }

                    Program.connect.Open();
                    string s = "select * from Users where Phone='"
                        + maskedTextBox1.Text.Trim() + "'";
                    
                    SqlCommand sql = new SqlCommand(s, Program.connect);
                    SqlDataReader reader = sql.ExecuteReader();
                                      
                    if (reader.HasRows)
                    {
                        Program.connect.Close();
                        throw new Exception("Данный пользователь " +
                            "уже зарегистрирован");
                    }
                    Program.connect.Close();
                }
                catch(Exception E)
                {
                    if (k == 0)
                    {
                        textBox4.Focus();
                    }
                else if (k == 1)
                    {
                        textBox5.Focus();
                    }
                    else if (k == 2)
                    {
                        textBox6.Focus();
                    }
                    else if (k == 3)
                    {
                        maskedTextBox1.Focus();
                    }
                    else if (k == 4)
                    {
                        textBox1.Focus();
                    }
                    else if(k == 5)
                    {
                        textBox2.Focus();
                    }
                    else if(k == 5)
                    {
                        textBox3.Focus();
                    }
                    MessageBox.Show(E.Message, "Ошибка!");
                    e.Cancel = true;
                }
            }
        }

        private void Button1_Click(object sender, EventArgs e)
        {

        }
    }
}
