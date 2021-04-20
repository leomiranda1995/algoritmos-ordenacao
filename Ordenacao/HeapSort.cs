using System;
using System.Collections.Generic;
using System.Text;

namespace Ordenacao
{
    class HeapSort: Retorno
    {
        public void Ordenar(int[] vetor)
        {
            DateTime inicio = DateTime.Now;

            //PrintaVetor(vetor);

            int n = vetor.Length;

            for(int i = n/2-1; i >= 0; i--)
            {
                Heapify(vetor, n, i);
            }

            for(int i = n-1; i >= 0; i--)
            {
                int temp = vetor[0];
                vetor[0] = vetor[i];
                vetor[i] = temp;

                //PrintaVetor(vetor);

                Heapify(vetor, i, 0);
            }

            DateTime fim = DateTime.Now;
            this.Tempo = fim - inicio;
            this.Vetor = vetor;
        }

        public void Heapify(int[] vetor, int n, int posTopo)
        {
            int maior = posTopo;
            int esquerda = 2 * posTopo + 1;
            int direita = 2 * posTopo + 2;

            if (esquerda < n && vetor[esquerda] > vetor[maior])
            {
                maior = esquerda;
            }

            if(direita < n && vetor[direita] > vetor[maior])
            {
                maior = direita;
            }

            if(maior != posTopo)
            {
                int swap = vetor[posTopo];
                vetor[posTopo] = vetor[maior];
                vetor[maior] = swap;

                //PrintaVetor(vetor);

                Heapify(vetor, n, maior);
            }
        }

        public void PrintaVetor(int[] vetor)
        {
            Console.WriteLine();
            for (int i = 0; i <= vetor.Length - 1; i++)
            {
                Console.Write(vetor[i]);
                if (i != vetor.Length - 1)
                {
                    Console.Write(", ");
                }
            }
            Console.WriteLine();
            Console.WriteLine();
        }
    }
}
