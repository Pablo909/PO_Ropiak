using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kebab
{
    public abstract class KebabDekorator : Kebab
    {
        protected Kebab kebab;
        public KebabDekorator(Kebab kebab)
        {
            this.kebab = kebab;
        }

        public override double Koszt()
        {
            return kebab.Koszt();
        }

        public override string GetOpis()
        {
            return kebab.GetOpis();
        }

    }
}
