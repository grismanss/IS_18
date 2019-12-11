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
    class Blocks: GameObject
    {
      
        public void add(Point a)
        {
            // blocks.Insert(blocks.Count, a);
            body.Add(a);
            a_color = Color.Purple;
        }
    }
}
