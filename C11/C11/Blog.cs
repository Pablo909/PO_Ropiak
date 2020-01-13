using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C11
{
    class Blog : IObserwowany
    {
        //lista obiektów, które będą obserwować obiekty tej klasy 
        private List<IObserwator> listaObserwatorow = new List<IObserwator>();
        //lista, która przechowuje artykuły
        public List<Artykul> artykulyBlog = new List<Artykul>();

        public Blog()
        {

        }

        public void DodajArtykul(Artykul artykul)
        {
            artykulyBlog.Add(artykul);
        }

        public void UsunArtykul(Artykul artykul)
        {
            artykulyBlog.Remove(artykul);
        }

        public List<Artykul> PobierzArtykuly()
        {
            return this.artykulyBlog;
        }
        public void dodajObserwatora(IObserwator obserwator)
        {
            listaObserwatorow.Add(obserwator);
        }

        public void usunObserwator(IObserwator obserwator)
        {
            listaObserwatorow.Remove(obserwator);
        }

        public void powiadomObserwatorow()
        {
            foreach (var item in listaObserwatorow)
            {
                item.aktualizacjaDanych();
            }
        }
    }

    
    class Artykul
    {
        public string tytul;
        public string tresc;
        public Artykul(string tytul, string tresc)
        {
            this.tytul = tytul;
            this.tresc = tresc;
        }
    }
}
