using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace N2___Animais
{
    class Ave:Animal
    {
        #region ... PROPRIEDADES ...

        public bool Rapina
        { get; set; }

        public string CorPena
        { get; set; }

        #endregion

        /// <summary>
        /// Método referente a ação de ciscar da ave
        /// </summary>
        public void Ciscar()
        { }
    }
}
