using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C11
{
    class Czytelnik : IObserwator
    {
        //prywatne pole do przechowywanie pobranej zmiennej (obserwowanej)
        private List<Artykul> mojeArtykuly = new List<Artykul>();

        //referencja do obserwowanego obiektu
        private Blog obserwowanyBlog;

        //wraz z definicja obiektu przypisywany mu jest blog
        public Czytelnik(Blog o)
        {
            this.obserwowanyBlog = o;
        }

        //metoda pobierajaca artykuły
        public void aktualizacjaDanych()
        {
            Console.Clear();
            mojeArtykuly = obserwowanyBlog.PobierzArtykuly();
            foreach (var item in mojeArtykuly)
            {
                Console.WriteLine("Tytuł: {0} \n {1}", item.tytul, item.tresc);
            }
            Console.WriteLine("\n");
        }
    }
}
