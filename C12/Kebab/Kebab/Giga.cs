using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kebab
{
    class Giga : KebabDekorator
    {
        public Giga(Kebab kebab) : base(kebab)
        {

        }

        public override double Koszt()
        {
            return kebab.Koszt() + 7.0;
        }

        public override string GetOpis()
        {
            return kebab.GetOpis() + ", giga";
        }
    }
}
