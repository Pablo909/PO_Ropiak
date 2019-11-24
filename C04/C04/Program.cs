using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C04
{
    class Program
    {
        static void Main(string[] args)
        {
            Osoba osoba1 = new Osoba("Paweł", "Dzik", 1998);
            Osoba osoba2 = new Osoba("Bartek", "Kocur", 1997);

            osoba1.WypiszInfo();

            Type type = osoba2.GetType();

           /*
            foreach (var f in type.GetFields())
            {
                Console.WriteLine(String.Format("Nazwa: {0}, Typ: {2}, Wartosc: {1}", f.Name, f.GetValue(osoba2), f.FieldType));
            }
            Console.ReadKey();
            */

            Student student1 = new Student("Mati", "Byk", 1998, 2, 1, 156313);
            Student student2 = new Student("Kamil", "Chojrak", 1998, 2, 1, 178543);

            student1.WypiszInfoStudent();
            Console.WriteLine(student1.ObliczWiek());
            student1.miejsceZamieszkania = "Barczewo";

            // student1 = osoba1; 
            osoba2 = student1;

            osoba2.WypiszInfo();
            Console.ReadKey();
        }
    }
}
