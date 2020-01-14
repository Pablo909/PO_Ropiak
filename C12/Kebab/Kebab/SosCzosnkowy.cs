using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kebab
{
    class SosCzosnkowy:KebabDekorator
    {
        public SosCzosnkowy(Kebab kebab) : base(kebab)
        {

        }

        public override double Koszt()
        {
            return kebab.Koszt() + 2.0;
        }

        public override string GetOpis()
        {
            return kebab.GetOpis() + ", sos czosnkowy";
        }
    }
}
