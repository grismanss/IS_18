using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;
using System.IO;
using System.Windows.Forms;

namespace WindowsFormsApp21
{
    class Game //класс, обьединяющий все элементы игры
    {
        Snake my_snake = new Snake();
        Blok my_blok = new Blok();
        Food my_food = new Food();


        public int count = 0;//счет игры
        int sizeX = 50;//переменные, хранящиеколичество клеток на экране отрисовки
        int sizeY = 50;
        Color game_color = Color.Wheat;//цвет поля
        PictureBox myPB;//область отрисовывания игры

        public Game(PictureBox pb)
        {
            myPB = pb;//соединяем в конструкторе визуальный и виртуальный пикчебокс
            Load_level(1);
        }

        public void  Proverka_food()
        {
            bool f = false;
            Point p;
            do
            {
                f = false;
                p = my_food.RandomFood(sizeX, sizeY);
                for (int i=0; i<my_snake.body.Count; i++)
                {
                    if (p.x== my_snake.body[i].x && p.y == my_snake.body[i].y)
                    {
                        f = true;
                    }

                }
                for (int i = 0; i < my_blok.body.Count; i++)
                {
                    if (p.x == my_blok.body[i].x && p.y == my_blok.body[i].y)
                    {
                        f = true;
                    }

                }
                for (int i = 0; i < my_food.body.Count; i++)
                {
                    if (p.x == my_food.body[i].x && p.y == my_food.body[i].y)
                    {
                        f = true;
                    }

                }
            } while (f);
            my_food.Add(p);
        }
        //функция для хагрузки уровня игры
        public void Load_level(int level)
        {
            /*my_food.Add(my_food.RandomFood(sizeX, sizeY));
            System.Threading.Thread.Sleep(10);
            my_food.Add(my_food.RandomFood(sizeX, sizeY));*/
            
            //Открываем поток для чтения файла
            StreamReader sr = new StreamReader(level.ToString() + ".txt");
            int strY = 0;//переменная считает строки файла
            while (!sr.EndOfStream)
            {
                string s = sr.ReadLine();//получаем текущую чтроку из файла
                //далее перебираем строку посимвольно
                for (int i=0; i<s.Length; i++)
                {
                    if (s[i] == '$')
                    {
                        my_snake.Add(new Point(i, strY));
                    }
                    if (s[i] == '*')
                    {
                        my_blok.Add(new Point(i, strY));
                    }
                }
                strY++;
            }
            Proverka_food();
            System.Threading.Thread.Sleep(100);
            Proverka_food();
            sr.Close();

        }
        //метод рисования обьктов
        public void Show()
        {
            int k = myPB.Width / sizeX;

            Graphics g = Graphics.FromImage(myPB.Image);
            SolidBrush fon = new SolidBrush(game_color);//берем кисть с фоновым цветом
            g.FillRectangle(fon, 0, 0, myPB.Width, myPB.Height);

            SolidBrush head = new SolidBrush(Color.Black);
            g.FillRectangle(head, my_snake.body[0].x * k,
                    my_snake.body[0].y * k, k, k);

            for (int i=1; i<my_snake.body.Count; i++)
            {
                SolidBrush snake_color = new SolidBrush(my_snake.my_color);
                g.FillRectangle(snake_color, my_snake.body[i].x * k,
                    my_snake.body[i].y * k, k, k);
            }

            for (int i = 0; i < my_blok.body.Count; i++)
            {
                SolidBrush blok_color = new SolidBrush(my_blok.my_color);
                g.FillRectangle(blok_color, my_blok.body[i].x * k,
                    my_blok.body[i].y * k, k, k);
            }
            for (int i = 0; i < my_food.body.Count; i++)
            {
                SolidBrush food_color = new SolidBrush(my_food.my_color);
                g.FillRectangle(food_color, my_food.body[i].x * k,
                    my_food.body[i].y * k, k, k);
            }
            myPB.Refresh();
        }


    }
}
