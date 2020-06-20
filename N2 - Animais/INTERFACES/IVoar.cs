using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace N2___Animais
{
    interface IVoar
    {
        //não é um método
        int AlturaMaximaM();

        //não é um método
        double VelocidadeVoo();
        
        void Voar();
    }
}
