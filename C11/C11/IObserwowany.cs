using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C11
{
    interface IObserwowany
    {
        void dodajObserwatora(IObserwator obserwator);
        void usunObserwator(IObserwator obserwator);
        void powiadomObserwatorow();
    }
}
