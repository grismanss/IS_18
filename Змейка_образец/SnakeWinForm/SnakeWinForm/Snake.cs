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
    class Snake: GameObject
    {
        // Point g=new Point()
        public int speed = 1;
       

      
        public void add(Point a)
        {        
            body.Add(a);
            a_color = Color.Green;
        }
        public void move(int a, int b)
        {
            for(int i = body.Count -1; i >0; i--)
            {
                body[i].x = body[i - 1].x;
                body[i].y = body[i - 1].y;
            }
            body[0].x = body[0].x + a;
            body[0].y = body[0].y + b;
        }
        public bool colission(Point a)
        {
            bool p = false;
            if(a.x == body[0].x && a.y == body[0].y)
            {
                p = true;
                
            }
            return p;
        }
        public void scale(Point a, int x, int y)
        {
            /* body.Add(new Point(0, 0));
             for(int i = body.Count-1; i>0; i--)
             {
                 body[i].x = body[i - 1].x;
                 body[i].y = body[i - 1].y;
             }
             body[0].x = a.x;
             body[0].y = a.y;*/
            body.Insert(0, a);
            for(int i = 1; i < body.Count; i++)
            {
                body[i].x -= x;
                body[i].y -= y;
            }

        }
    }
}
