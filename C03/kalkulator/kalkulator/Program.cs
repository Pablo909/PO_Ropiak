using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace kalkulator
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(" 1.Dodawanie\n 2.Odejmowanie\n 3.Mnozenie\n 4.Dzielenie\n 5.Potęgowanie\n 6.Pierwiastkowanie\n 7.Wyjdź");
            int x = 0, d;
            double a, b, c;
            do
            {
                try
                {
                    x = int.Parse(Console.ReadLine());

                    if (x == 1)
                    {
                        Console.WriteLine("Podaj a");
                        a = int.Parse(Console.ReadLine());
                        Console.WriteLine("Podaj b");
                        b = int.Parse(Console.ReadLine());
                        c = Obliczenia.Dodawanie(a, b);
                        Console.WriteLine(a + " + " + b + " = " + c);
                    }
                    if (x == 2)
                    {
                        Console.WriteLine("Podaj a");
                        a = int.Parse(Console.ReadLine());
                        Console.WriteLine("Podaj b");
                        b = int.Parse(Console.ReadLine());
                        c = Obliczenia.Odejmowanie(a, b);
                        Console.WriteLine(a + " - " + b + " = " + c);
                    }
                    if (x == 3)
                    {
                        Console.WriteLine("Podaj a");
                        a = int.Parse(Console.ReadLine());
                        Console.WriteLine("Podaj b");
                        b = int.Parse(Console.ReadLine());
                        c = Obliczenia.Mnozenie(a, b);
                        Console.WriteLine(a + " * " + b + " = " + c);
                    }
                    if (x == 4)
                    {
                        Console.WriteLine("Podaj a");
                        a = int.Parse(Console.ReadLine());
                        Console.WriteLine("Podaj b");
                        b = int.Parse(Console.ReadLine());
                        c = Obliczenia.Dzielenie(a, b);
                        Console.WriteLine(a + " / " + b + " = " + c);
                    }
                    if (x == 5)
                    {
                        Console.WriteLine("Podaj a");
                        a = int.Parse(Console.ReadLine());
                        Console.WriteLine("Podaj d");
                        d = int.Parse(Console.ReadLine());
                        c = Obliczenia.Potegowanie(a, d - 1);
                        Console.WriteLine(a + " ^ " + d + " = " + c);
                    }
                    if (x == 6)
                    {
                        Console.WriteLine("Podaj a");
                        a = int.Parse(Console.ReadLine());
                        c = Obliczenia.Pierwiastkowanie(a);
                        Console.WriteLine("Pierwiastek z " + a + " wynosi " + c);
                    }
                    if (x <= 0 || x >= 8)
                        Console.WriteLine("Podaj liczbe miedzy 1 a 7");
                }
                catch(Exception e)
                {
                    Console.WriteLine("Zly input");
                }
            }
            while (x != 7);
        }
    }
}
