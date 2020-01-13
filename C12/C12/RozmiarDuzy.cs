using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C12
{
    class RozmiarDuzy : NapojDekorator
    {
        public RozmiarDuzy(Napoj _napoj) : base(_napoj)
        {
        }

        // zmieniamy sposób obliczania kosztu
        public override double Koszt()
        {
            return 1.50 + napoj.Koszt();
        }

        // oraz opis
        public override string GetOpis()
        {
            return napoj.GetOpis() + ", rozmiar duzy";
        }
    }
}
