using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Wojownik:Postac
    {
        private int sila;
        public Wojownik(string imie) : base(imie)
        {
            this.profesja = Profesja.Wojownik;
            this.maxHp = 70;
            this.hp = maxHp;
            this.punktyTaktyki = 1;
            this.sila = 15;
        }
        public override int MocAtaku()
        {
            return (int)(this.sila * this.zywotnosc);
        }

        public override void PrzedstawSie()
        {
            Console.WriteLine(String.Format("Nazywam się {0}.\nMoja profesja to {1}", this.imie, this.profesja));
        }

    }
}
