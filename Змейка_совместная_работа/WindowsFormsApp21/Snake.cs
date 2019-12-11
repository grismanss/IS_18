using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;

namespace WindowsFormsApp21
{
    //пронаследуем класс от базового
    class Snake:GameObject
    {
        public int speed = 1;
        
        //вызываем конструктор и назначаем цвет змейки
        public Snake()
        {
            my_color = Color.Green;
        }

        public void Add(Point a)
        {
            body.Add(a);
        }

        public void move(int dx, int dy)
        {
            for (int i = body.Count - 1; i>0; i--)
            {
                body[i].x = body[i - 1].x;
                body[i].y = body[i - 1].y;
            }
            body[0].x = body[0].x+dx;
            body[0].y = body[0].y+dy;

        }

        public void AddHvost()
        {
            int n = body.Count - 1;//номер последней ячейки змейки
            if ((body[n].x- body[n - 1].x) == 0)
            {
                body.Add(new Point(body[n].x, body[n].y + 1));
            }
            else
            {
                body.Add(new Point(body[n].x+1, body[n].y ));
            }
        }
        //сделать класс гейм
        //загрузить карту из файла
        //отразить змейку на пикчебоксе

    }
}
