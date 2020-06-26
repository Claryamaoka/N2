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
            get
            {
                return alturaMaxima;
            }

            set
            {
                if (value > 0 || value < 12000)
                    alturaMaxima = value;
                else
                    throw new Exception("A altura máxima em que um pássaro pode voar deve variar de 1m a 12000m!");
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
                    throw new Exception("A velocidade máxima em que um pássaro pode voar deve variar de 1km/h a 350km/h!");
            }
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

        public override string ToString()
        {
            return "CORUJA" +Environment.NewLine+ base.ToString() + "ALTURA MÁXIMA DE VOO EM METROS: " + AlturaMaximaM + Environment.NewLine +
                "VELOCIDADE DE VOO: " + VelocidadeVoo + Environment.NewLine + "PREDADOR" + Environment.NewLine;
        }
    }
}
