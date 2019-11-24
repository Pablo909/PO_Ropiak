using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    public enum Profesja { Wojownik, Złodziej, Palladyn, Łucznik };
    public abstract class Postac
    {
        protected Profesja profesja;
        protected string imie;
        protected int hp;
        protected int maxHp;
        protected double zywotnosc = 1.0;
        protected int punktyTaktyki;
        public double mocAtaku;
        protected Postac(string _imie)
        {
            this.imie = _imie;
        }
        public abstract void PrzedstawSie();
        public abstract int MocAtaku();

        public bool CzyZyje { get; private set; } = true;

        public virtual void PrzyjmijCios(int obrazenia)
        {
            this.hp -= obrazenia;
            Console.WriteLine($"{this.profesja} {this.imie} otrzymał {obrazenia} punktów obrażeń");
            if (this.hp <= 0)
            {
                this.CzyZyje = false;
                this.zywotnosc = 0;
                Console.WriteLine($"{this.profesja} {this.imie} zginął!");
            }
            else
                this.zywotnosc = (double)this.hp / (double)this.maxHp;
        }
        public void PokazHp()
        {
            Console.WriteLine($"{imie}: {hp}/{maxHp} HP");
        }

    }

}
