using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{

    class Lucznik : Postac
    {
        private int zrecznosc;

        public Lucznik(string imie) : base(imie)
        {
            this.profesja = Profesja.Łucznik;
            this.maxHp = 50;
            this.zrecznosc = 15;
            this.hp = maxHp;
            this.punktyTaktyki = 3;
        }

        public override int MocAtaku()
        {
            return (int)(this.zrecznosc * this.zywotnosc);
        }

        public override void PrzedstawSie()
        {
            Console.WriteLine(String.Format("Nazywam się {0}.\nMoja profesja to {1}", this.imie, this.profesja));
        }
    }
}
