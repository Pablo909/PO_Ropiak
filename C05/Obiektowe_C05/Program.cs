using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Obiektowe_C05
{
    class Program
    {
        static void Main(string[] args)
        {
            Car car1 = new Car();
            Bicycle bicycle1 = new Bicycle();

            car1.Ride();
            bicycle1.Ride();
            
            Console.ReadKey();

            Osoba osoba1 = new Osoba();
            ISkrzypek osoba2 = new Osoba();
            IGitarzysta osoba3 = new Osoba();
            
            osoba1.Graj();
            osoba2.Graj();
            osoba3.Graj(); 
           
            Console.ReadKey();

            Test obiekt1 = new Test();
            Test obiekt2 = new Test();
            Test obiekt3 = new Test();
            Test obiekt4 = new Test();

            obiekt1.liczba = 255;
            obiekt1.poleTestowe.slowo = "słowo";
            obiekt2 = obiekt1;
            obiekt3 = (Test)obiekt1.Clone();
            //obiekt3 = obiekt1.GlebokaKopia();
            obiekt4.liczba = obiekt1.liczba;
            obiekt1.liczba = 347;
            obiekt1.poleTestowe.slowo = "kaczka";


            Console.WriteLine(obiekt1.liczba + " " + obiekt1.poleTestowe.slowo);
            Console.WriteLine(obiekt2.liczba + " " + obiekt2.poleTestowe.slowo);
            Console.WriteLine(obiekt3.liczba + " " + obiekt3.poleTestowe.slowo);
            Console.WriteLine(obiekt4.liczba);
            Console.ReadLine();

        }
    }
}
