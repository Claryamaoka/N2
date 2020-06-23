using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace N2___Animais.ESTRUTURA_DADOS
{
    class Lista
    {
        NodoLista primeiro = null; // ponteiro para o primeiro elemento da lista
        int qtde = 0;
        int tamanho = 0;

        public int Tamanho()
        {
            return qtde;
        }

        private void InserirNaPosicao(Nodo anterior, Animal valor)
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

        public Animal[] Listar
        {

        }
    }
}
