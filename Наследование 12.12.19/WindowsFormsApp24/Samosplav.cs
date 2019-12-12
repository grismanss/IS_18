using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp24
{
    public class Samosplav : BaseClass
    {
        public double w;

        public Samosplav(double neww, double news) : base(news)
        {
            w = neww;
        }

        public override double Calc()
        {
            return S / w;
        }

        public override string ToString()
        {
            return "Самосплав S=" + S.ToString() + " w=" + w.ToString();
        }
    }
}
