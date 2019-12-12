using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp24
{
   public class Ozero:BaseClass
    {
        public double v;

        public Ozero(double newV, double newS) : base(newS)
        {
            v = newV;
        }
        public override double Calc()//Переопределение метода родителя
            //т.е. описывем как работают вычисления для данного класса
        {
            return S / v;
        }

        //переопределяем тостринг

        public override string ToString()
        {
            return "Озеро S=" + S.ToString() + " v=" + v.ToString();
        }


    }
}
