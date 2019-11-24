using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Obiektowe_C05
{
    class Car:Vehicle,IRideable
    {
        public void Ride()
        {
            Console.WriteLine("Jade sobie samochodem");
        }
    }
}
