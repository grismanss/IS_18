using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp26
{
    static class Program
    {
        /// <summary>
        /// Главная точка входа для приложения.
        /// </summary>
        /// 

        public struct Korzina
        {
            public static int id;
            public static int count;
        }

       // создаем глобальную переменную для строки подключения
        public static string connect_string = @"Data Source=DESKTOP-591CTJD;Initial Catalog=restoran;Integrated Security=True";
        public static SqlConnection connect = new SqlConnection
            (Program.connect_string);

        public static bool type_user = false;
        public static string login_user = "";
        public static Korzina[] korzina;

        //  public static string connect_string2 = "Data Source=505-S-S\\SQLEXPRESS;Initial Catalog=restoran;Integrated Security=True";


        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new Form1());
        }
    }
}
