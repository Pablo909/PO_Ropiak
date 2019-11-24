using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C06
{
    class Pracownik
    {
        public virtual void Pracuj()
        {
            Console.WriteLine("Logowanie");
        }
        public virtual void Pracuj2()
        {
            Console.WriteLine("pracownik pracuje");
        }
    }
}
