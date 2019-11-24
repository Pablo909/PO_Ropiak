using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            Lucznik lucznik = new Lucznik("Legolas");
            Wojownik wojownik = new Wojownik("Aragorn");
            List<Postac> druzyna = new List<Postac>();

            druzyna.Add(lucznik);
            druzyna.Add(wojownik);

            foreach (Postac pos in druzyna)
            {
                pos.PrzedstawSie();
                Console.WriteLine("Moc ataku: {0}", pos.MocAtaku());
            }

            lucznik.PrzyjmijCios(40);
            wojownik.PrzyjmijCios(30);

            foreach (Postac pos in druzyna)
            {
                pos.PokazHp();
                Console.WriteLine("Moc ataku: {0}", pos.MocAtaku());
            }

            lucznik.PrzyjmijCios(40);
            lucznik.PokazHp();

            Console.ReadKey();
        }
    }
}
