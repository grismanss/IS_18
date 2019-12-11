using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Windows.Forms;

namespace SnakeWinForm
{
    class Eat : GameObject
    {
       //public List<Point> eat = new List<Point>(2);
     // public  Color eat_color = Color.Red;
        public Eat(Point a, Point b)
        {
            body.Insert(0, a);
            body.Insert(1, b);
            a_color = Color.Red;

        }
        public Point addeat(int i, int sizeX, int sizeY)
        {
            
            body.RemoveAt(i);
            Random random = new Random();
            Point eatPoint = new Point(random.Next(0, sizeX), random.Next(0, sizeY));
            body.Add(eatPoint);
            return eatPoint;
        }
    }
}
