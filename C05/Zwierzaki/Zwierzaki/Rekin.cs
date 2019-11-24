using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zwierzaki
{
    class Rekin:Zwierze
    {
        public Rekin(string imie, double waga, Rozmiar rozmiar) : base(imie, waga, rozmiar)
        {
        }
        public override void JakSiePoruszam()
        {
            Console.WriteLine("Plywam");
        }
        public override void CoJem()
        {
            Console.WriteLine("Jem ryby");
        }
    }
}
