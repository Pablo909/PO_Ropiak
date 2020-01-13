using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C12
{
    class Program
    {
        static void Main(string[] args)
        {
            // teraz przykład z wykorzystaniem wzorca dekorator
            Napoj nowaKawa = new Kawa();
            Console.WriteLine(nowaKawa.GetOpis() + " kosztuje: " + $"{nowaKawa.Koszt()}");

            // dodajemy mleko
            nowaKawa = new Mleko(nowaKawa);
            Console.WriteLine(nowaKawa.GetOpis() + " kosztuje: " + $"{nowaKawa.Koszt()}");

            // i czekoladę
            nowaKawa = new Czekolada(nowaKawa);
            Console.WriteLine(nowaKawa.GetOpis() + " kosztuje: " + $"{nowaKawa.Koszt()}");

            nowaKawa = new RozmiarDuzy(nowaKawa);
            Console.WriteLine(nowaKawa.GetOpis() + " kosztuje: " + $"{nowaKawa.Koszt()}");

            Napoj herbata = new Herbata();
            Console.WriteLine(herbata.GetOpis() + " kosztuje: " + $"{herbata.Koszt()}");

            herbata = new Cukier(herbata);
            Console.WriteLine(herbata.GetOpis() + " kosztuje: " + $"{herbata.Koszt()}");

            Console.ReadKey();
        }
    }
}
