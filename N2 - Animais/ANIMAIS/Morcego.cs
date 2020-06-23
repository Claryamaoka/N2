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
            get
            {
                return alturaMaxima;
            }

            set
            {
                if (value > 0 || value < 12000)
                    alturaMaxima = value;
                else
                    throw new Exception("A altura máxima em que uma ave pode voar deve variar de 1m a 12000m!");
            }
        }
        public double VelocidadeVoo
        {
            get
            {
                return velocidadeVoo;
            }

            set
            {
                if (value > 0 || value < 350)
                    velocidadeVoo = value;
                else
                    throw new Exception("A velocidade máxima em que uma ave pode voar deve variar de 1km/h a 350km/h!");
            }
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
