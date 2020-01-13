using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C12
{
    class Cukier : NapojDekorator
    {
        public Cukier(Napoj _napoj):base(_napoj)
        {

        }

        public override double Koszt()
        {
            return 0.7 + napoj.Koszt();
        }

        public override string GetOpis()
        {
            return napoj.GetOpis() + ", z cukrem";
        }
    }
}
