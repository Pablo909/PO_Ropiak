using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace kalkulator
{
    class Obliczenia
    {
        public static double Dodawanie(double a, double b)
        {
            return a + b;
        }

        public static double Odejmowanie(double a, double b)
        {
            return a - b;
        }

        public static double Mnozenie(double a, double b)
        {
            return a * b;
        }

        public static double Dzielenie(double a, double b)
        {
            return a / b;
        }

        public static double Potegowanie(double a, int b)
        {
            double c = a;
            for (int i = 0; i < b; i++)
                c *= a;
            return c;
        }

        public static double Pierwiastkowanie(double a)
        {
            double epsilon = 0.00000000001, x = 1, y = a;
            while (Bezwzgledna(x - y) >= epsilon)
            {
                x = (x + y) / 2;
                y = a / x;
            }
            return y;
        }

        public static double Bezwzgledna(double a)
        {
            if (a < 0)
                a = -a;
            return a;
        }
    }
}
