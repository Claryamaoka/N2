using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace N2___Animais.ANIMAIS
{
    class Coruja : Ave, IOviparo, IVoar, IPredador
    {
        /// <summary>
        /// Construtor Personalizado
        /// </summary>
        /// <param name="deRapina"></param>
        /// <param name="carne"></param>
        /// <param name="peconhento"></param>
        public Coruja(bool deRapina, bool carne, bool peconhento)
        {
            Rapina = deRapina;
            Carnivoro = carne;
            Peconhento = peconhento;
        }

        #region PARÂMETROS
        private int alturaMaxima;
        private double velocidadeVoo;

        //falta validar altura e velocidade
        public int AlturaMaximaM
        {
            get => alturaMaxima;
            set =>alturaMaxima = value;
        }
        public double VelocidadeVoo
        {
            get => velocidadeVoo;
            set => velocidadeVoo = value;
        }
        #endregion

        #region MÉTODOS
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

        public void Voar()
        {
            throw new NotImplementedException();
        }
        #endregion
    }
}
