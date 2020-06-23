using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace N2___Animais.ANIMAIS
{
    class Pombo : Ave, IOviparo, IVoar
    {
        /// <summary>
        /// Construtor Personalizado
        /// </summary>
        /// <param name="carne"></param>
        /// <param name="peconhento"></param>
        /// <param name="rapina"></param>
        public Pombo(bool carne, bool peconhento, bool rapina)
        {
            Carnivoro = carne;
            Peconhento = peconhento;
            Rapina = rapina;
        }

        #region PARÂMETRO
        private int alturaMaxima;
        private double velocidadeVoo;

        //falta validar altura e velocidade
        public int AlturaMaximaM
        {
            get => alturaMaxima;
            set => alturaMaxima = value;
        }
        public double VelocidadeVoo
        {
            get => velocidadeVoo;
            set => velocidadeVoo = value;
        }
        #endregion

        #region MÉTODOS

        public void Botar()
        {
            throw new NotImplementedException();
        }

        public void Chocar()
        {
            throw new NotImplementedException();
        }

        public void Voar()
        {
            throw new NotImplementedException();
        }
        #endregion
    }
}
