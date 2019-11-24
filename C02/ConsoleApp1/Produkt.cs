using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp1
{
    class Produkt
    {
        public string nazwa;
        public double cena;
        public Produkt(string nazwa, double cena)
        {
            this.nazwa = nazwa;
            this.cena = cena;
        }

        public void WypiszInfo()
        {
            Console.WriteLine("Nazwa: {0}, cena: {1}", this.nazwa, this.cena);
        }
    }
    class Koszyk
    {
        List<Produkt> listaTowarów;

        public Koszyk()
        {
            this.listaTowarów = new List<Produkt>();
        }
        public void DodajProdukt(Produkt produkt)
        {
            this.listaTowarów.Add(produkt);
        }

        public void ZawartoscKoszyka()
        {
            double suma = 0;
            int ilosc = 0;
            foreach (Produkt p in listaTowarów)
            {
                suma += p.cena;
                ilosc++;
                p.WypiszInfo();
            }
            Console.WriteLine("Ilosc produktów: {0}. Suma: {1}", ilosc, suma);
        }

    }
}
