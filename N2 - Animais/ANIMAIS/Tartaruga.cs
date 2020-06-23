﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace N2___Animais.ANIMAIS
{
    class Tartaruga : Reptil, IAquatico, IOviparo
    {
        /// <summary>
        /// Construtor Personalizado
        /// </summary>
        /// <param name="carne"></param>
        /// <param name="peconhento"></param>
        /// <param name="escamas"></param>
        /// <param name="casco"></param>
        /// <param name="terra"></param>
        /// <param name="mergulho"></param>
        /// <param name="agua"></param>
        public Tartaruga(bool carne, bool peconhento, bool escamas, bool casco,
            bool terra, bool mergulho, bool agua)
        {
            ViveEmTerra = terra;
            Mergulha = mergulho;
            AguaDoce = agua;
            Peconhento = peconhento;
            Carnivoro = carne;
            TemCasco = casco;
            TemEscama = escamas;

        }

        #region PARÂMETROS
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
        #endregion

    }
}
