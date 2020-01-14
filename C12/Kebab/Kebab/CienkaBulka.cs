using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kebab
{
    class CienkaBulka : KebabDekorator
    {
        public CienkaBulka(Kebab kebab) : base(kebab)
        {

        }

        public override double Koszt()
        {
            return kebab.Koszt();
        }

        public override string GetOpis()
        {
            return kebab.GetOpis() + ", cienka bułka";
        }
    }
}
