using System;
using System.Collections.Generic;
using System.Text;

namespace Ordenacao
{
    class InsertionSort : Retorno
    {
        public void Ordenar(int[] vetor)
        {
            DateTime inicio = DateTime.Now;

            for (int j = 1; j < vetor.Length; j++)
            {
                int chave = vetor[j];

                int i = j - 1;

                while(i >= 0 && vetor[i] > chave)
                {
                    vetor[i+1] = vetor[i];
                    i--;
                }

                vetor[i+1] = chave;
            }

            DateTime fim = DateTime.Now;

            this.Tempo = fim - inicio;
            this.Vetor = vetor;
        }
    }
}