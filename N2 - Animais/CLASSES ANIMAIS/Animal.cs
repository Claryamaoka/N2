using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace N2___Animais
{
    class Animal
    {
        #region ...PROPRIEDADES...
        public string Nome
        { get; set; }

        public DateTime DataNascimento
        { get; set; }

        public char Sexo
        { get; set; }

        public int Idade
        { get; set; }

        public bool Carnivoro
        { get; set; }

        public bool Peconhento
        { get; set; }
        #endregion

        #region ...MÉTODOS...
        /// <summary>
        /// Método referente a ação de movimentar do animal
        /// </summary>
        public void Movimentar()
        { }

        /// <summary>
        /// Método referente a ação de comunicar do animal
        /// </summary>
        public void Comunicar()
        { }

        /// <summary>
        /// Método referente a ação de alimentar do animal
        /// </summary>
        public void Alimentar()
        { }
        #endregion
    }
}
