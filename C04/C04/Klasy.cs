using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C04
{
    class Osoba
    {
        protected string imie;
        protected string nazwisko;
        protected int rokUrodzenia;
        public string miejsceZamieszkania;

        public Osoba(string imie, string nazwisko, int rokUrodzenia)
        {
            this.imie = imie;
            this.nazwisko = nazwisko;
            this.rokUrodzenia = rokUrodzenia;
        }

        public void WypiszInfo()
        {
            Console.WriteLine(imie + " " + nazwisko + ", " + rokUrodzenia);
        }

        public int ObliczWiek()
        {
            return DateTime.Now.Year - this.rokUrodzenia;
        }
    }
   class Student:Osoba
    {
        int rok;
        int numerGrupy;
        int numerAlbumu;
        public Student(string imie, string nazwisko, int rokUrodzenia,  int rok, int numerGrupy, int numerAlbumu) : base(imie, nazwisko, rokUrodzenia)
        {
            this.rok = rok;
            this.numerGrupy = numerGrupy;
            this.numerAlbumu = numerAlbumu;
        }
        public void WypiszInfoStudent()
        {
            Console.WriteLine(imie + " " + nazwisko + ", " + rokUrodzenia + ", " + rok + " rok, " + numerGrupy + " grupa, " + numerAlbumu);
        }
    }
    class StudentPierwszegoRoku:Student
    {
        public StudentPierwszegoRoku(string imie, string nazwisko, int rokUrodzenia, int rok, int numerGrupy, int numerAlbumu) : base(imie, nazwisko, rokUrodzenia, rok, numerGrupy, numerAlbumu)
        {
            
        }
    }
}
