using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zwierzaki
{
    class Orzel:Zwierze
    {
        public Orzel(string imie, double waga, Rozmiar rozmiar) : base(imie, waga, rozmiar)
        {
        }
        public override void JakSiePoruszam()
        {
            Console.WriteLine("Latam");
        }
        public override void CoJem()
        {
            Console.WriteLine("Jem myszy");
        }
    }
}
