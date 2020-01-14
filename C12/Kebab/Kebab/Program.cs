using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kebab
{
    class Program
    {
        static void Main(string[] args)
        {
            Kebab kebab = new KebabRollo();
            kebab = new MiesoMieszane(kebab);
            kebab = new Giga(kebab);
            kebab = new CienkaBulka(kebab);
            kebab = new Oliwki(kebab);
            Console.WriteLine(kebab.GetOpis() + ", koszt: " + kebab.Koszt());
            Console.ReadKey();
        }
    }
}
