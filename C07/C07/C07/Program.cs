using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;

namespace C07
{
    class Program
    {
        public static void Licz()
        {
            for (int i = 1; i <= 1000; i++)
            {
                Console.WriteLine("watek1: " + i);
            }
        }
        static void Main(string[] args)
        {
            int a = 5, b = 0, c = 3;
            try
            {
                c = a / b;
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
                
            }
            finally
            {
                Console.WriteLine(c);
            }
            try
            {
                Wyjatki.Metoda23();
            }
            catch (NotImplementedException notImp)
            {
                Console.WriteLine(notImp.Message);
            }

            //StackOverflowException - Wyjątek, który jest generowany w przypadku przepełnienia stosu wykonywania, ponieważ zawiera zbyt wiele wywołań metod zagnieżdżonych.
            //NullReferenceException - Wyjątek, który jest generowany, gdy istnieje próba odwołująca się do odwołania do obiektu o wartości null.
            //FileNotFoundException - Wyjątek, który jest zgłaszany, gdy nie powiedzie się próba uzyskania dostępu do pliku, który nie istnieje na dysku.
            //AccessViolationException - Wyjątek, który jest zgłaszany, gdy istnieje podjęto próbę odczytu lub zapisu chronione pamięci.
            //IndexOutOfRangeException - Wyjątek, który jest generowany, gdy zostanie podjęta próba uzyskania dostępu do elementu tablicy lub kolekcji z indeksem, który znajduje się poza granicami.

            Console.ReadKey();

            Thread thr = new Thread(Licz);
            thr.Start();
            for (int i = 1; i <= 1000; i++)
            {
                Console.WriteLine("program1: " + i);
            }


            Console.ReadKey();
        }
    }
}
