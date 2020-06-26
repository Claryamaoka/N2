using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace N2___Animais.ANIMAIS
{
    class Pinguim : Ave, IOviparo
    {
        /// <summary>
        /// Construtor Personalizado
        /// </summary>
        /// <param name="carne"></param>
        /// <param name="peconhento"></param>
        /// <param name="rapina"></param>
        public Pinguim(bool carne, bool peconhento, bool rapina)
        {
            Carnivoro = carne;
            Peconhento = peconhento;
            Rapina = rapina;
        }

        #region MÉTODOS
        public void Botar()
        {
            throw new NotImplementedException();
        }

        public void Chocar()
        {
            throw new NotImplementedException();
        }
        #endregion

        public override string ToString()
        {
            return "PINGUIM" + Environment.NewLine + base.ToString();
        }
    }
}
