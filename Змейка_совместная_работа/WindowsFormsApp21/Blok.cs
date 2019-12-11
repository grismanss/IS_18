using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;
namespace WindowsFormsApp21
{
    class Blok:GameObject
    {
        public Blok()
        {
            my_color = Color.Purple;
        }

        public void Add(Point a)
        {
            body.Add(a);
        }
    }
}
