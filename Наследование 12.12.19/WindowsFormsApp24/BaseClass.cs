using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp24
{
    abstract public class BaseClass
    {
        public double S;
        public BaseClass(double newS)
        {
            S = newS;
        }

        abstract public double Calc();
    }
}
