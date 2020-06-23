using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace N2___Animais.ANIMAIS
{
    class Baleia : Mamifero, IAquatico
    {
        public Baleia(bool terra, bool mergulho, bool agua, bool peconhento, bool carne)
        {
            //ViveEmTerra = terra;
            Peconhento = peconhento;
            Carnivoro = carne;

        }
        public bool AguaDoce()
        {
            throw new NotImplementedException();
        }

        public bool Mergulha()
        {
            throw new NotImplementedException();
        }

        public bool ViveEmTerra()
        {
            throw new NotImplementedException();
        }
    }
}
