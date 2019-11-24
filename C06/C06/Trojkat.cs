using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C06
{
    class Trojkat:Figura
    {
        public Trojkat(int a, int b)
        {
            this.a = a;
            this.b = b;
        }

        public override double Pole()
        {
            double wynik = (double)1 / 2 * a * b;
            return wynik;
        }
    }
}
