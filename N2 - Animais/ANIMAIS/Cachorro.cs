using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace N2___Animais.ANIMAIS
{
    class Cachorro: Mamifero
    {
        public Cachorro(bool carne, bool peconhento)
        {
            Carnivoro = carne;
            Peconhento = peconhento;
        }
    }
}
