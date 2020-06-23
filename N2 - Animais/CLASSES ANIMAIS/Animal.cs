using System;

namespace N2___Animais
{
    class Animal
    {
        string nome;
        DateTime dataNascimento;
        char sexo;
        int idade;
        #region ...PROPRIEDADES...
        public string Nome
        {
            get
            {
                return nome;
            }

            set
            {
                if (value != "")
                    nome = value;
                else
                    throw new Exception("Atribua um nome ao animal!");
            }

        }


        public DateTime DataNascimento
        {
            get
            {
                return dataNascimento;
            }

            set
            {
                if (dataNascimento < DateTime.Now)
                    dataNascimento = value;
                else
                    throw new Exception("A data de nascimento nao pode ser futura!");
            }
        }

        public char Sexo
        {
            get
            {
                return sexo;
            }

            set
            {
                if (value == 'M' || value == 'F')
                    sexo = value;
                else
                    throw new Exception("Atribua um sexo ao animal!");
            }
        }

        public int Idade
        {
            get => idade;
            set => idade = 2020 - dataNascimento.Year;
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
