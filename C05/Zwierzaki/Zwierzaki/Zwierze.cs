using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zwierzaki
{
    public enum Rozmiar {mały, średni, duży};
    public abstract class Zwierze:IZwierzaki
    {
        public string imie;
        double waga;
        Rozmiar rozmiar;

        protected Zwierze(string imie, double waga, Rozmiar rozmiar)
        {
            this.imie = imie;
            this.waga = waga;
            this.rozmiar = rozmiar;
        }
        public abstract void JakSiePoruszam();
        public abstract void CoJem();

    }
}
