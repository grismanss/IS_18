﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace WindowsFormsApp26
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Button2_Click(object sender, EventArgs e)
        {
            Form2 f2 = new Form2();
            if (f2.ShowDialog() == DialogResult.OK)
            {
               /* if (f2.textBox2.Text.Trim() != f2.textBox3.Text.Trim())
                {
                    MessageBox.Show("Пароли не совпадают");
                }*/
              //  else {
                   /* Program.connect.Open();
                    string s = "select * from Users where Phone='" 
                        + f2.maskedTextBox1.Text+"'";
                    //MessageBox.Show(s);
                    SqlCommand sql = new SqlCommand(s, Program.connect);
                    int d = sql.ExecuteNonQuery();
                    Program.connect.Close();
                    if (d == -1)
                    {*/
                        Program.connect.Open();
                        string s2 = "insert into Users(Phone, " +
                            "Name, LastName, SurName,"+
                           " Email, Password, TypeUser)"+
                            "values('"+f2.maskedTextBox1.Text
                            +"', '"+f2.textBox5.Text.Trim()
                            +"', '"+ f2.textBox4.Text.Trim()
                            + "', '"+ f2.textBox6.Text.Trim() 
                            + "', '"+ f2.textBox1.Text.Trim()
                            + "', '"+ f2.textBox2.Text.Trim() + "', 0)  ";

                        SqlCommand sql2 = new SqlCommand(s2, Program.connect);
                        sql2.ExecuteNonQuery();
                        MessageBox.Show("Вы успешно зарегистрированы");
                        Program.connect.Close();
                    /*}
                    else
                    {
                        MessageBox.Show("Данный пользователь зарегистрирован");
                    }*/
               // }
            }
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            string s = "select * from Users where Phone='" + maskedTextBox1.Text.Trim()
                + "' and Password='" + textBox2.Text.Trim() + "'";
            Program.connect.Open();
            SqlCommand sql2 = new SqlCommand(s, Program.connect);
            SqlDataReader reader = sql2.ExecuteReader();

            if (!reader.HasRows)
            {
                MessageBox.Show("Неверный логин или пароль");
                maskedTextBox1.Focus();
            }
            else
            {
                reader.Read();
                Program.type_user = Convert.ToBoolean(reader.GetValue(7));
                Program.login_user = (Convert.ToString(reader["Phone"])).Trim();
                Form3 f = new Form3();
                f.Show();
            }

            Program.connect.Close();

        }

        private void Button3_Click(object sender, EventArgs e)
        {
            this.Visible = false;
            Form7 f = new Form7();
            f.Show();
        }
    }
}
