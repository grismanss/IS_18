using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;

namespace WindowsFormsApp21
{
    public class GameObject
    {
        //тело обьекта в списке, список работает как массив,
        //но проще добавлять и удалять
        public List<Point> body = new List<Point>();
        public Color my_color;
    }
}
