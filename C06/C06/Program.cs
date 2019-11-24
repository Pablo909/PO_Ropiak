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

            Pracownik ksiegowy = new Ksiegowy();
            Pracownik programista = new Programista();
            Pracownik pracownik = new Pracownik();
            Pracownik projektant = new Projektant();

            List<Pracownik> listaPracownikow = new List<Pracownik>();

            listaPracownikow.Add(ksiegowy);
            listaPracownikow.Add(programista);
            listaPracownikow.Add(pracownik);
            listaPracownikow.Add(projektant);
            foreach(Pracownik x in listaPracownikow)
            {
                x.Pracuj2();
            }

            Console.ReadKey();

        }
    }
}
