using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C08
{
    class Osoba
    {
        string imie;
        int wiek;
        public Osoba()
        {
            imie = "Maciek";
            wiek = 13;
        }
        public Osoba(string imie, int wiek)
        {
            this.imie = imie;
            this.wiek = wiek;
        }
        public void ZmienImie(string noweImie)
        {
            this.imie = noweImie;
        }

        public void ZmienWiek(int nowyWiek)
        {
            this.wiek = nowyWiek;
        }

        public new void ToString()
        {
            Console.WriteLine("Imie: {0}, wiek: {1}", imie, wiek);
        }
    }
}
