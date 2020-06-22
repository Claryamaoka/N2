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
        {
            get
            {
                return Nome;
            }

            set
            {
                if (Nome != "")
                    Nome = value;
                else
                    throw new Exception("Atribua um nome ao animal!");
            }

        }


        public DateTime DataNascimento
        {
            get
            {
                return DataNascimento;
            }

            set
            {
                if (DataNascimento < DateTime.Now)
                    DataNascimento = value;
                else
                    throw new Exception("A data de nascimento nao pode ser futura!");
            }
        }

        public char Sexo
        {
            get
            {
                return Sexo;
            }

            set
            {
                if (Sexo == 'M' || Sexo == 'F')
                    Sexo = value;
                else
                    throw new Exception("Atribua um sexo ao animal!");
            }
        }

        public int Idade
        {
            get
            {
                return Idade;
            }

            set
            {
                if (Idade >= 0)
                    Idade = value;
                else
                    throw new Exception("A idade deve ser maior ou igual a zero!");
            }
        }

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
