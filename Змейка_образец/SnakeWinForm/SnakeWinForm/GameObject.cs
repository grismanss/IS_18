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
    public class GameObject
    {
        public List<Point> body = new List<Point>();
        public Color a_color = Color.Purple;
    }
}
