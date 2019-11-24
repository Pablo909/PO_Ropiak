using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C03_2
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] table = new int[2];
            int liczba1 = 30, liczba2 = 0, liczba3;

            try
            {
                throw new IndexOutOfRangeException();

            }
            catch
            {
                Console.WriteLine("catch");
            }
            finally
            {
                Console.WriteLine("FINALLY");
            }
            Console.ReadKey();
            try
            {
                table[21] = 2;

            }
            catch (IndexOutOfRangeException e)
            {
                Console.WriteLine(e.Message);
            }
            catch
            {
                Console.WriteLine("drugi catch");
            }
            finally
            {
                Console.WriteLine("FINALLY");
            }
            Console.ReadKey();

            try
            {
                liczba3 = liczba1 / liczba2;

            }
            catch 
            {
                Console.WriteLine("Nie lubię dzielić przez zero");
            }
            finally
            {
                Console.WriteLine("FINALLY");
            }
            Console.ReadKey();
            try
            {
                liczba3 = liczba1 / liczba2;

            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }
            finally
            {
                Console.WriteLine("FINALLY");
            }

            Console.ReadKey();
        }
    }
}
