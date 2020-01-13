using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C12
{
    class Czekolada : NapojDekorator
    {

        public Czekolada(Napoj _napoj) : base(_napoj)
        {
        }

        // zmieniamy sposób obliczania kosztu
        public override double Koszt()
        {
            return 0.80 + napoj.Koszt();
        }

        // oraz opis
        public override string GetOpis()
        {
            return napoj.GetOpis() + ", Czekolada";
        }
    }
}
