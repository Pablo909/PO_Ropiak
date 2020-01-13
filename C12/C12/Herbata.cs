using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C12
{
    class Herbata : Napoj
    {
        public override double Koszt()
        {
            return 1.50;
        }

        public override string GetOpis()
        {
            return "Herbata";
        }
    }
}
