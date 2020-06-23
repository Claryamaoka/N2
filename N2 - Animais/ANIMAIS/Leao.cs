using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace N2___Animais.ANIMAIS
{
    class Leao : Mamifero, IPredador
    {
        /// <summary>
        /// Construtor Personalizado
        /// </summary>
        /// <param name="carn"></param>
        /// <param name="peconhento"></param>
        /// <param name="pelo"></param>
        public Leao(bool carn, bool peconhento, bool pelo)
        {
            Carnivoro = carn;
            Peconhento = peconhento;
            Pelos = pelo;
        }

        #region MÉTODOS
        public void Ataque()
        {
            throw new NotImplementedException();
        }
        #endregion
    }
}
