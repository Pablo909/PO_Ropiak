using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C06
{
    class Kwadrat:Figura
    {
        public Kwadrat(int a)
        {
            this.a = a;
        }
        public override double Pole()
        {
            return a * a;
        }
    }
}
