using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;

namespace Kalkulator
{
    class Dzialania
    {
        public static string Dodawanie(double x, double y)
        {
            
            double wynik = x + y;
            return wynik.ToString();
        }
        public static string Odejmowanie(double x, double y)
        {

            double wynik = x - y;
            return wynik.ToString();
        }
        public static string Mnozenie(double x, double y)
        {

            double wynik = x * y;
            return wynik.ToString();
        }
        public static string Dzielenie(double x, double y)
        {
            double wynik = 0;
            try
            {
                wynik = x / y;
            }
            catch
            {
                return "Nie dziel przez 0";
            }
            return wynik.ToString();
        }
    }
}
