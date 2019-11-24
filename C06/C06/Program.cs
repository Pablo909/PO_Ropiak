using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C06
{
    class Program
    {
        static void Main(string[] args)
        {
            Pracownik p = new Programista();
            p.Pracuj();
            Console.ReadKey();

            Trojkat trojkat = new Trojkat(5, 5);
            Kwadrat kwadrat = new Kwadrat(5);
            Console.WriteLine(trojkat.Pole());
            Console.WriteLine(kwadrat.Pole());
            Console.ReadKey();

        }
    }
}
