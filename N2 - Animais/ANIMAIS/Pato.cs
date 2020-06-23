using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace N2___Animais.ANIMAIS
{
    class Pato : Ave, IOviparo, IAquatico, IVoar
    {
        /// <summary>
        /// Construtor Personalizado
        /// </summary>
        /// <param name="carne"></param>
        /// <param name="peconhento"></param>
        /// <param name="rapina"></param>
        /// <param name="terra"></param>
        /// <param name="mergulho"></param>
        /// <param name="agua"></param>
        public Pato(bool carne, bool peconhento, bool rapina,
            bool terra, bool mergulho, bool agua)
        {
            Carnivoro = carne;
            Peconhento = peconhento;
            Rapina = rapina;
            ViveEmTerra = terra;
            Mergulha = mergulho;
            AguaDoce = agua;
        }

        #region PARÂMETROS

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
        private bool viveTerra, mergulha, aguaDoce;

        public bool ViveEmTerra
        {
            get => viveTerra;
            set => viveTerra = value;
        }
        public bool Mergulha
        {
            get => mergulha;
            set => mergulha = value;
        }
        public bool AguaDoce
        {
            get => aguaDoce;
            set => aguaDoce = value;
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
