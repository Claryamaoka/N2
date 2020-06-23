using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace N2___Animais.ANIMAIS
{
    class Elefante:Mamifero
    {
        public Elefante(bool carne, bool peconhento)
        {
            Carnivoro = carne;
            Peconhento = peconhento;
        }
    }
}
