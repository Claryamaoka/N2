using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace N2___Animais
{
    class Mamifero:Animal
    {
        #region ...PROPRIEDADES...
        public int QtdeMamas
        { get; set; }

        public bool Pelos
        { get; set; }

        public string CorPelo
        { get; set; }
        #endregion

        /// <summary>
        /// Método referente a ação de amamentar do mamífero
        /// </summary>
        public void Amamentar()
        { }
    }
}
