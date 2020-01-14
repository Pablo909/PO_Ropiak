using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kebab
{
    class KebabRollo : Kebab
    {
        public override double Koszt()
        {
            return 12.0;
        }

        public override string GetOpis()
        {
            return "Kebab Rollo";
        }
    }
}
