using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp1
{
    class Zespolone
    {
        public double re;
        public double im;

        public Zespolone(double re, double im)
        {
            this.re = re;
            this.im = im;
        }
        public Zespolone suma(Zespolone z1, Zespolone z2)
        {
            Zespolone z3 = new Zespolone(0, 0);
            this.re = z1.re + z2.re;
            this.im = z1.im + z2.im;
            return z3;
        }
    }
}
