using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace N2___Animais
{
    class Gato : Mamifero
    {
        public Gato(bool carne, bool peconhento)
        {
            Carnivoro = carne;
            Peconhento = peconhento;
        }
    }
}
