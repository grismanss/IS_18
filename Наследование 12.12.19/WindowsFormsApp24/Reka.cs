using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp24
{
    public class Reka:BaseClass
    {
        public double v, w;


        public Reka(double newv, double neww, double newS) : base(newS)
        {
            v = newv;
            w = neww;
        }

        public override double Calc()
        {
            return S / (v + w);
        }

        public override string ToString()
        {
            return "Река S=" + S.ToString()
                + " v=" + v.ToString() + " w=" + w.ToString();
        }
    }
}
