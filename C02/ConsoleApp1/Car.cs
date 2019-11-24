//using System;

namespace ConsoleApp1
{
    class Car
    {
        public string model;
        public int rokProdukcji;
        private int iloscDrzwi;
        private int pojemnoscSilnika;
        public double srednieSpalanie;
        public Car(string model, int rokProdukcji, double srednieSpalanie)
        {
            this.model = model;
            this.rokProdukcji = rokProdukcji;
            this.srednieSpalanie = srednieSpalanie;
        }
        
        private double ObliczSpalanie(double dlugoscTrasy)
        {
            return srednieSpalanie * dlugoscTrasy / 100;
        }

        public double ObliczKosztPrzejazdu(int dlugoscTrasy, double cenaPaliwa)
        {
            return this.ObliczSpalanie(dlugoscTrasy) * cenaPaliwa;
        }
        
        public static void OpiszTyp( string marka, string SrednieSpalanie)
        {
            System.Console.WriteLine("Marka {0} \n spalanie {1}", marka, SrednieSpalanie);
        }
    }
}
