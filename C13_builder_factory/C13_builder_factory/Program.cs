using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C13_builder_factory
{
    class Program
    {
        public static void Main(string[] args)
        {
            ProductionCheef szefProdukcji = new ProductionCheef();
            IBuilder A4Builder = new A4Builder();

            // buduj według logiki ProductionCheef używając implementacji z A4Builder
            szefProdukcji.BuildCar(A4Builder);

            Car a4 = A4Builder.GetCar();
            Console.WriteLine(a4.Engine + " " + a4.Wheels);
            Console.ReadKey();

            Console.Read();
        }
    }
}
