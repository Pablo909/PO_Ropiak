using System;
namespace ConsoleApp1
{
    class Osoba
    {
        public string imie;
        public string nazwisko;
        public int rokUrodzenia;
        public int waga;
        public int wzrost;
        public bool okulary;
        internal plec value;

        public enum plec { K, M };

        public int ObliczWiek()
        {
            return DateTime.Now.Year - this.rokUrodzenia;
        }
        
        public void Przedrostek()
        {
            if (value == plec.M) Console.WriteLine("Dyrektorem jest Pan " + this.imie + " " + this.nazwisko);
            else Console.WriteLine("Dyrektorem jest Pani " + this.imie + " " + this.nazwisko);
        }

        public void BMI()
        {
            float bmi = (float)waga / ((float)wzrost / 100 * (float)wzrost / 100);
            if (bmi <= 18.49)
                Console.WriteLine("Niedowaga");
            else if (bmi <= 24.99)
                Console.WriteLine("Optimum");
            else if (bmi <= 29.99)
                Console.WriteLine("Nadwaga");
            else
                Console.WriteLine("Otyłość");

            Console.WriteLine(bmi);

        }
        //public void setWaga(int waga)
        //{
        //   if(waga < 0)
        //    {
        //
        //    }
        //    else this.waga = waga;
        //}
    }
}
