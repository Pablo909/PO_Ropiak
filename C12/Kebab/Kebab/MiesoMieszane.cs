﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kebab
{
    class MiesoMieszane:KebabDekorator
    {
        public MiesoMieszane(Kebab kebab) : base(kebab)
        {

        }

        public override double Koszt()
        {
            return kebab.Koszt() + 1.0;
        }

        public override string GetOpis()
        {
            return kebab.GetOpis() + ", mieso mieszane";
        }
    }
}
