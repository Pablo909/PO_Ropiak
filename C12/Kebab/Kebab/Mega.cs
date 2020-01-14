using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kebab
{
    class Mega : KebabDekorator
    {
        public Mega(Kebab kebab):base(kebab)
        {

        }

        public override double Koszt()
        {
            return kebab.Koszt() + 3.0;
        }

        public override string GetOpis()
        {
            return kebab.GetOpis() + ", mega";
        }
    }
}
