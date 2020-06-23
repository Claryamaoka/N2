using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace N2___Animais.ANIMAIS
{
    class Gaviao : Ave, IOviparo, IVoar,IPredador
    {
        public Gaviao(bool deRapina, bool carne, bool peconhento)
        {
            Rapina = deRapina;
            Carnivoro = carne;
            Peconhento = peconhento;
        }
        public int AlturaMaximaM()
        {
            throw new NotImplementedException();
        }

        public void Ataque()
        {
            throw new NotImplementedException();
        }

        public void Botar()
        {
            throw new NotImplementedException();
        }

        public void Chocar()
        {
            throw new NotImplementedException();
        }

        public double VelocidadeVoo()
        {
            throw new NotImplementedException();
        }

        public void Voar()
        {
            throw new NotImplementedException();
        }
    }
}
