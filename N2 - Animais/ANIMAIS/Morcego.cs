using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace N2___Animais.ANIMAIS
{
    class Morcego : Mamifero, IVoar
    {
        /// <summary>
        /// Construtor Personalizado
        /// </summary>
        /// <param name="carne"></param>
        /// <param name="peconhento"></param>
        /// <param name="pelo"></param>
        public Morcego(bool carne, bool peconhento, bool pelo)
        {
            Carnivoro = carne;
            Peconhento = peconhento;
            Pelos = pelo;
        }

        #region PARÂMETROS
        private int alturaMaxima;
        private double velocidadeVoo;
        //Falta validar
        public int AlturaMaximaM
        {
            get => throw new NotImplementedException();
            set => throw new NotImplementedException();
        }
        public double VelocidadeVoo
        {
            get => throw new NotImplementedException();
            set => throw new NotImplementedException();
        }
        #endregion

        #region MÉTODOS

        public void Voar()
        {
            throw new NotImplementedException();
        }
        #endregion
    }
}
