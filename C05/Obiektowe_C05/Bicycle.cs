using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Obiektowe_C05
{
    class Bicycle:Vehicle,IRideable
    {
        public void Ride()
        {
            Console.WriteLine("No i pan pawel na rowerze skacze");
        }
    }
}
