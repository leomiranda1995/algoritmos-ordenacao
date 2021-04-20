using System;
using System.Collections.Generic;
using System.Text;

namespace Ordenacao
{
    using System;
    class MergeSort : Retorno
    {
        public void Ordenar(int[] vetor)
        {
            DateTime inicio = DateTime.Now;

            int tamanhoVetor = vetor.Length - 1;

            Sort(vetor, 0, tamanhoVetor);

            DateTime fim = DateTime.Now;

            this.Tempo = fim - inicio;
            this.Vetor = vetor;
        }

        public void Sort(int[]vetor, int left, int right)
        {
            if (left < right)
            {
                int middle = (left + right) / 2;

                Sort(vetor, left, middle);
                Sort(vetor, middle + 1, right);

                Intercala(vetor, left, middle, right);
            }
        }

        public void Intercala(int[] vetor, int left, int middle, int right)
        {
            int[] vetorB = new int[vetor.Length];

            for(int i = left; i <= middle; i++)
            {
                vetorB[i] = vetor[i];
            }

            for(int j = middle+1; j <= right; j++)
            {
                vetorB[right + middle + 1 - j] = vetor[j];
            }

            int auxi = left;
            int auxj = right;

            for(int k = left; k <= right; k++)
            {
                if(vetorB[auxi] <= vetorB[auxj])
                {
                    vetor[k] = vetorB[auxi];
                    auxi++;
                }
                else
                {
                    vetor[k] = vetorB[auxj];
                    auxj--;
                }
            }
        }
    }
}
