﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kebab
{
    class MiesoWolowe:KebabDekorator
    {
        public MiesoWolowe(Kebab kebab) : base(kebab)
        {

        }

        public override double Koszt()
        {
            return kebab.Koszt() + 2.0;
        }

        public override string GetOpis()
        {
            return kebab.GetOpis() + ", mieso wolowe";
        }
    }
}
