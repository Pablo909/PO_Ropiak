using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Obiektowe_C05
{
    class Test:ICloneable
    {
        public int liczba;
        public Test2 poleTestowe = new Test2();
        public Object Clone()
        {
            return MemberwiseClone();
        }

        public Test GlebokaKopia()
        {
            Test tempTest = new Test();
            tempTest.liczba = this.liczba;
            tempTest.poleTestowe.slowo = this.poleTestowe.slowo;
            return tempTest;
        }

    }
}
