using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C08
{
    class Program
    {
        static void Main(string[] args)
        {
            Stack<int> stosInt = new Stack<int>();
            List<Osoba> listaOsoba = new List<Osoba>();
            Dictionary<string, string> slownikString = new Dictionary<string, string>();
            int a = 1, b = 5, c = 10;
            string wyraz1 = "abc", wyraz2 = "xyz", wyraz3 = "maciek";
            string x = "1", y = "2", z = "3";
            Osoba osoba1 = new Osoba();
            Osoba osoba2 = new Osoba("Stefan", 64);
            stosInt.Push(a);
            stosInt.Push(b);
            stosInt.Push(c);
            slownikString.Add(x,wyraz1);
            slownikString.Add(y, wyraz2);
            slownikString.Add(z, wyraz3);
            listaOsoba.Add(osoba1);
            listaOsoba.Add(osoba2);

            foreach(var p in stosInt)
            {
                Console.WriteLine(p);
            }
            foreach(var p in listaOsoba)
            {
                p.ToString();
            }
            foreach(var p in slownikString)
            {
                Console.WriteLine("{0}: {1}", p.Key, p.Value);
            }

            Console.WriteLine(stosInt.Peek());
            Console.WriteLine(stosInt.ElementAt(2));
            listaOsoba.First().ToString();
            Console.Write(slownikString.First().Value);

            //listaOsoba.Sort();

            Console.WriteLine("stosInt {0}", stosInt.Count());
            Console.WriteLine("listaOsoba {0} {1}", listaOsoba.Count(),listaOsoba.Capacity);
            Console.WriteLine("slownikString {0}", slownikString.Count());

            listaOsoba.Reverse();
           
            foreach (var p in listaOsoba)
            {
                p.ToString();
            }
            

            stosInt.Pop();
            listaOsoba.RemoveAt(1);
            slownikString.Remove("1");

            
            Console.ReadKey();
        }
    }
}
