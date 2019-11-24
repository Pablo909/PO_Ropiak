using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zwierzaki
{
    class Wilk:Zwierze
    {
        public Wilk(string imie, double waga, Rozmiar rozmiar) : base(imie, waga, rozmiar)
        {
        }
        public override void JakSiePoruszam()
        {
            Console.WriteLine("Chodze na 4 lapach");
        }
        public override void CoJem()
        {
            Console.WriteLine("Jem owieczki");
        }
    }
}
