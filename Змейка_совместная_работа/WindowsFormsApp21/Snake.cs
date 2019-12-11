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
        //сделать класс гейм
        //загрузить карту из файла
        //отразить змейку на пикчебоксе

    }
}
