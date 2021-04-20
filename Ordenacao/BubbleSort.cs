using System;
using System.Collections.Generic;
using System.Text;

namespace Ordenacao
{
    class BubbleSort : Retorno
    {
        public void Ordenar(int[] vetor)
        {
            DateTime inicio = DateTime.Now;

            int n = vetor.Length;
            
            for (int i = 0; i < n-1; i++)
            {
                for (int j = 0; j < n - i - 1; j++)
                {
                    if (vetor[j] > vetor[j + 1])
                    {
                        int temp = vetor[j];
                        vetor[j] = vetor[j + 1];
                        vetor[j + 1] = temp;
                    }
                }
            }

            DateTime fim = DateTime.Now;

            this.Tempo = fim - inicio;
            this.Vetor = vetor;
        }
    }
}
