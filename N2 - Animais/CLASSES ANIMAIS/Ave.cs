using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace N2___Animais
{
    class Ave:Animal
    {
        string corpena;
        #region ... PROPRIEDADES ...

        public bool Rapina
        { get; set; }

        public string CorPena
        {
            get
            {
                return corpena;
            }

            set
            {
                if (value == "")
                    throw new Exception("Informe a cor de pena!");
                else
                    corpena = value;
            }
        }

        #endregion

        /// <summary>
        /// Método referente a ação de ciscar da ave
        /// </summary>
        public void Ciscar()
        { }

        public override string ToString()
        {
            if(Rapina)
               return base.ToString() + "COR DA PENA: " + CorPena + 
                    Environment.NewLine + "AVE DE RAPINA" + Environment.NewLine;
            else
                return base.ToString() + "COR DA PENA: " + CorPena + Environment.NewLine;
        }
    }
}
