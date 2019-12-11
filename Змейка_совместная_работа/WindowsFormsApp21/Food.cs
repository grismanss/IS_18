using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;

namespace WindowsFormsApp21
{
    class Food:GameObject
    {
        public Food()
        {
            my_color = Color.Red;
        }
        public void Add(Point a)
        {
            body.Add(a);
        }

        public Point RandomFood(int sizeX, int sizeY)
        {
            Random r = new Random();
            Point a = new Point(r.Next(0, sizeX), r.Next(0, sizeY));
           /* for ( int i=0; i<body.Count; i++)
            {
                if (a.x==body[i].x && a.y == body[i].y)
                {
                    return RandomFood(sizeX, sizeY);
                }
            }*/
            return a;
        }
    }
}
