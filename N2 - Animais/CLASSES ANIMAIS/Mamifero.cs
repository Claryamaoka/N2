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
        {
            get
            {
                return QtdeMamas;
            }

            set
            {
                if (QtdeMamas < 0)
                    throw new Exception("A quantidade de mamas deve ser maior ou igual a 0!");
                else
                    QtdeMamas = value;
            }
        }

        public bool Pelos
        { get; set; }

        public string CorPelo
        {
            get
            {
                return CorPelo;
            }

            set
            {
                if (CorPelo == "")
                    throw new Exception("Informe a cor de pelo!");
                else
                    CorPelo = value;
            }
        }

        #endregion

        /// <summary>
        /// Método referente a ação de amamentar do mamífero
        /// </summary>
        public void Amamentar()
        { }
    }
}
