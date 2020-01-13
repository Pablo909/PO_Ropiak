using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C11
{
    class Program
    {
        static void Main(string[] args)
        {
            Artykul artykul1 = new Artykul("TEXT1", "To jest mój artykuł numer 1.");
            Artykul artykul2 = new Artykul("TEXT2", "To jest mój artykuł numer 2.");
            Artykul artykul3 = new Artykul("TEXT3", "To jest mój artykuł numer 3.");
            Artykul artykul4 = new Artykul("TEXT4", "To jest mój artykuł numer 4.");
            Artykul artykul5 = new Artykul("TEXT5", "To jest mój artykuł numer 5.");


            Blog MyBlog = new Blog();
            MyBlog.DodajArtykul(artykul1);
            MyBlog.DodajArtykul(artykul2);
            MyBlog.DodajArtykul(artykul3);

            Czytelnik user1 = new Czytelnik(MyBlog);
            Czytelnik user2 = new Czytelnik(MyBlog);

            MyBlog.dodajObserwatora(user1);
            MyBlog.dodajObserwatora(user2);

            MyBlog.powiadomObserwatorow();
            MyBlog.DodajArtykul(artykul4);
            MyBlog.UsunArtykul(artykul3);
            MyBlog.powiadomObserwatorow();


            Console.ReadKey();
        }
    }
}
