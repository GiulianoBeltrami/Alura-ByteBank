using BibliotecaByteBank;
using System;
/*
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
*/
namespace ByteBank.SistemaAgencia
{
    public class ListaDeContaCorrente
    {
        private ContaCorrente[] _itens;
        private int _proximaPosicao;
        

        public ListaDeContaCorrente(int capacidadeInicial = 5)
        {
            _itens = new ContaCorrente[capacidadeInicial];
            _proximaPosicao = 0;
        }

        public void adicionar(ContaCorrente item)
        {
            VerificaCapacidade(_proximaPosicao + 1);
            _itens[_proximaPosicao] = item;
            _proximaPosicao++;
        }
        private void VerificaCapacidade(int tamanhoNecessario)
        {
            if (_itens.Length == tamanhoNecessario)
            {
                return;
            }
            int novoTamanho = _itens.Length * 2;
            if (novoTamanho < tamanhoNecessario)
            {
                novoTamanho = tamanhoNecessario;
            }
            ContaCorrente[] novoArray = new ContaCorrente[novoTamanho];
            Array.Copy(
                  sourceArray: _itens,
                  destinationArray: novoArray,
                  length:_itens.Length
                      );
            _itens = novoArray;
        }
        public void Remover (ContaCorrente item)
        {
            int indiceItem = -1;
            //identificar qual o item ->
            for (int i=0; i < _proximaPosicao-1; i++)
            {
                if (_itens.Equals(item))
                {
                    //achei o índice a ser removido
                    indiceItem = i;
                    break;
                }
            }
            for (int i = indiceItem; i < _proximaPosicao; i++)
            {
                _itens[i] = _itens[i + 1];
            }
            _proximaPosicao--;
            _itens[_proximaPosicao] = null;
        }


    }

}
