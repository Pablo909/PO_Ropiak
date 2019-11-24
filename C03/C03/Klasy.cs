using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace C03
{
    class Car
    {
        private double pojemnoscSilnika;
        private string marka;
        static int iloscKol;

        private Car()
        {
            this.pojemnoscSilnika = 2.5;
            this.marka = "BMW";
            Console.WriteLine("domyslny");
        }
        private Car(double pojemnoscSilnika, string marka)
        {
            this.pojemnoscSilnika = pojemnoscSilnika;
            this.marka = marka;
            Console.WriteLine("parametryczny");
        }

        static Car()
        {
            iloscKol = 4;
        }
        public static Car Create()
        {
            Car car = new Car(2.4, "BWM");
            Console.WriteLine("Car Create");
            return car;
        }

        ~Car()
        {
            MessageBox.Show("Zwalniam pamiec");
        }
    }
}
