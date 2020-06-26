using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace N2___Animais.ESTRUTURA_DADOS
{
    public class Lista
    {
        NodoLista primeiro = null; // ponteiro para o primeiro elemento da lista
        int qtde = 0;
        int tamanho = 0;

        public int Tamanho()
        {
            return qtde;
        }
        #region MÉTODOS DE INSERÇÃO
        private void InserirNaPosicao(NodoLista anterior, Animal valor)
        {
            NodoLista novo = new NodoLista();
            novo.Dado = valor;

            if (anterior == null)
            {
                if (qtde == 0)
                    primeiro = novo;
                else
                {
                    novo.Proximo = primeiro;
                    primeiro = novo;
                }
            }
            else
            {
                novo.Proximo = anterior.Proximo;
                anterior.Proximo = novo;
            }
            qtde++;
        }

        public void InserirNoInicio(Animal valor)
        {
            InserirNaPosicao(null, valor);
        }

        public void InserirNoFim(Animal valor) 
        {
            if (qtde == 0)
                InserirNoInicio(valor);
            else
            {
                NodoLista aux = primeiro;

                while (aux.Proximo != null)
                    aux = aux.Proximo;
                InserirNaPosicao(aux, valor);
            }


        }

        public void InserirNaPosicao(Animal valor, int posicao)
        {
            if (posicao > qtde || posicao < 0)
                throw new Exception("Não é possível inserir.");

            if (posicao == 0)
                InserirNoInicio(valor);
            else
            {                 //descobre qual é o nodo anterior ao que será incluído 
                NodoLista aux = primeiro;
                for (int i = 1; i < posicao; i++)
                    aux = aux.Proximo;

               InserirNaPosicao(aux, valor);
            }
        }

        #endregion

        public void RemoverDaPosicao(int posicao)
        {
            if (posicao >= qtde || posicao < 0 || qtde == 0)
                throw new Exception("Não é possível remover.");

            if (posicao == 0)
                primeiro = primeiro.Proximo;
            else
            {                 //descobre qual é o nodo anterior que será excluido     
                NodoLista aux = primeiro;
                for (int i = 1; i < posicao; i++)
                    aux = aux.Proximo;

                aux.Proximo = aux.Proximo.Proximo;
            }
            qtde--;
        }

        #region MÉTODOS DE LISTAGEM

        /// <summary>
        /// Lista todos os animais cadastrados
        /// </summary>
        /// <returns></returns>
        public string ListarGeral()
        {
            string r = string.Empty;
            NodoLista aux = primeiro;
            while (aux != null)
            {
                r += aux.Dado.ToString() + Environment.NewLine;
                aux = aux.Proximo;
            }
            return r;
        }

        /// <summary>
        /// Lista apenas mamíferos
        /// </summary>
        /// <returns></returns>
        public string ListarMamifero()
        {
            string r = string.Empty;
            NodoLista aux = primeiro;
            while (aux != null)
            {
                if(aux.Dado is Mamifero)
                    r += r.ToString() + Environment.NewLine;
                aux = aux.Proximo;
            }
            if (r == string.Empty)
                r = "NÃO HÁ MAMÍFEROS CADASTRADOS!!";
            return r;
        }

        /// <summary>
        /// Lista apenas oviparos
        /// </summary>
        /// <returns></returns>
        public string ListarOviparo()
        {
            string r = string.Empty;
            NodoLista aux = primeiro;
            while (aux != null)
            {
                if (aux.Dado is IOviparo)
                    r += r.ToString() + Environment.NewLine;
                aux = aux.Proximo;
            }
            if (r == string.Empty)
                r = "NÃO HÁ OVÍPAROS CADASTRADOS!!";
            return r;
            
        }

        /// <summary>
        /// Lista apenas animais aquáticos
        /// </summary>
        /// <returns></returns>
        public string ListarAquaticos()
        {
            string r = string.Empty;
            NodoLista aux = primeiro;
            while (aux != null)
            {
                if (aux.Dado is IAquatico)
                    r += r.ToString() + Environment.NewLine;
                aux = aux.Proximo;
            }
            if (r == string.Empty)
                r = "NÃO HÁ ANIMAIS AQUÁTICOS CADASTRADOS!!";
            return r;

        }

        /// <summary>
        /// Lista apenas animais que voam 
        /// </summary>
        /// <returns></returns>
        public string ListarAnimaisVoam()
        {
            string r = string.Empty;
            NodoLista aux = primeiro;
            while (aux != null)
            {
                if (aux.Dado is IVoar)
                    r += r.ToString() + Environment.NewLine;
                aux = aux.Proximo;
            }
            if (r == string.Empty)
                r = "NÃO HÁ ANIMAIS QUE VOAM CADASTRADOS!!";
            return r;

        }

        public string ListarPredadores()
        {
            string r = string.Empty;
            NodoLista aux = primeiro;
            while (aux != null)
            {
                if (aux.Dado is IPredador)
                    r += r.ToString() + Environment.NewLine;
                aux = aux.Proximo;
            }
            if (r == string.Empty)
                r = "NÃO HÁ PREDADORES CADASTRADOS!!";
            return r;

        }

        public void Listar(NodoLista e)
        {
            if (e != null)
                Console.WriteLine(e.Dado);
            if (e.Proximo != null)
                Listar(e.Proximo);
        }

        #endregion
    }
}
