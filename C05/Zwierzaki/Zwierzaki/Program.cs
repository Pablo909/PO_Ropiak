using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zwierzaki
{
    class Program
    {
        static void Main(string[] args)
        {
            Pies pies1 = new Pies("Azor", 6, Rozmiar.średni);
            Pies pies2 = new Pies("Stefan", 26, Rozmiar.duży);
            pies2 = pies1;
            Console.WriteLine(pies2.imie);
            Console.ReadKey();
        }
    }
}
